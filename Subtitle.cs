using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UtfUnknown;

namespace BatchSubtitleSync
{
    class Subtitle
    {
        public Subtitle(string header, List<Parser> body, string type)
        {
            Header = header;
            Body = body;
            Type = type;
        }

        public static Subtitle Open(string path, string encode, bool noNoFallback = false)
        {
            string text;
            if (encode == "자동")
            {
                var bytes = File.ReadAllBytes(path);
                var result = CharsetDetector.DetectFromBytes(bytes.Take(30).ToArray()); // 성능 최적화를 위해 우선 초반 30 Bytes만 검사
                Encoding encoding;
                try
                {
                    if (result.Detected == null) throw new DecoderFallbackException();
                    encoding = Encoding.GetEncoding(result.Detected.EncodingName, MainWindow.EcdFallback, MainWindow.DcdFallback);
                    text = encoding.GetString(bytes);
                }
                catch (DecoderFallbackException)
                {
                    // Debug.WriteLine("Full Bytes 검사 : " + path);
                    result = CharsetDetector.DetectFromBytes(bytes);
                    if (noNoFallback) encoding = Encoding.GetEncoding(result.Detected.EncodingName, MainWindow.EcdFallback, MainWindow.DcdFallback);
                    else encoding = result.Detected.Encoding;
                    try
                    {
                        text = encoding.GetString(bytes);
                    }
                    catch (DecoderFallbackException)
                    {
                        throw new Exception("인코딩 자동 감지 실패");
                    }
                }
            }
            else
            {
                encode = encode == "ANSI" ? "ks_c_5601-1987" : encode;
                using (var sr = new StreamReader(path, Encoding.GetEncoding(encode), true))
                {
                    text = sr.ReadToEnd();
                }
            }
            if (String.IsNullOrEmpty(text)) throw new Exception("파일 읽기 실패");

            // 성능 향상을 위해 자주 쓰일 법한 포맷부터 먼저 체크해 조건문을 빠져나갈 수 있도록 함
            if (path.EndsWith(".smi"))
            {
                return Parser.Parse(text, "SMI");
            }
            else if (path.EndsWith(".ass") || path.EndsWith(".ssa"))
            {
                return Parser.Parse(text, "ASS");
            }
            else
            {
                return Parser.Parse(text, "SRT");
            }
        }

        public void ShiftTime(float offset, int lineIndex = 0, bool strip = true)
        {
            var former = this.Body.Take(lineIndex).ToList();
            var later = this.Body.Skip(lineIndex).ToList();
            var shift = (int)(offset * 1000);
            int threshold = Math.Max(later[0].StartTime - shift, 0);

            if (strip)
            {
                for (int i = former.Count - 1; i >= 0; i--)
                {
                    former[i] = former[i].StartTime < threshold ? former[i] : null;
                }
                for (int i = later.Count - 1; i >= 0; i--)
                {
                    later[i] = later[i].StartTime < shift ? null : later[i];
                }
                former.RemoveAll(item => item == null);
                later.RemoveAll(item => item == null);
            }
            for (int i = later.Count - 1; i >= 0; i--)
            {
                later[i].StartTime = Math.Max(later[i].StartTime - shift, 0);
                if (later[i].EndTime != -1) later[i].EndTime = Math.Max(later[i].EndTime - shift, 0);
            }
            this.Body = former.Concat(later).ToList();
        }

        public void ChangeSpeed(int rate, bool strip = true)
        {
            foreach (var item in this.Body)
            {
                item.StartTime = (int)Math.Round(item.StartTime * rate / 100.0);
                if (item.EndTime != -1) item.EndTime = (int)Math.Round(item.EndTime * rate / 100.0);
            }
            if (strip)
            {
                this.Body.RemoveAll(item => item.StartTime == item.EndTime);
            }
        }

        public void SponserSwitcher(float sponserTime, string sponserText, int offset, int ignoreLine, float ignoreTime, bool strip)
        {
            var time = ignoreTime * 1000;
            var body = this.Body;
            var len = body.Count;
            int index = -1;

            if (len < ignoreLine) throw new Exception("자막 길이가 " + ignoreLine.ToString() + "줄보다 짧습니다.");

            for (int i = ignoreLine; i < len; i++)
            {
                if (time < body[i].StartTime && body[i].Content.IndexOf(sponserText) != -1)
                {
                    index = i + offset;
                    break;
                }
            }
            if (index < 0 || index >= len) throw new Exception("기준점을 찾을 수 없습니다. 검색 텍스트나 라인 오프셋이 잘못 설정되어있을 수 있습니다.");
            this.ShiftTime(sponserTime, index, strip);
        }

        public string Header { get; set; }
        public List<Parser> Body { get; set; }
        public string Type { get; }
    }
}
