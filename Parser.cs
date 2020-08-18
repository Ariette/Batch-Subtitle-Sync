using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BatchSubtitleSync
{
    class Parser
    {
        public Parser(int startTime, int endTime, string content)
        {
            StartTime = startTime;
            EndTime = endTime;
            Content = content;
        }
        public Parser(int startTime, string content)
        {
            StartTime = startTime;
            Content = content;
            EndTime = -1;
        }

        public static Subtitle Parse(string raw, string type)
        {
            var header = "";
            var body = new List<Parser>();

            // 성능 향상을 위해 자주 쓰일 법한 포맷부터 먼저 체크해 조건문을 빠져나갈 수 있도록 함
            // 나중에 지원하는 포맷이 5개 이상이 되면 Switch문으로 바꾸는 것이 바람직함
            if (type == "SMI")
            {
                var Lines = Regex.Split(raw, "<SYNC ", RegexOptions.IgnoreCase);
                header = Lines[0];
                foreach (string line in Lines)
                {
                    var find = Regex.Match(line, @"^Start=(\d+)>([\s\S]*)", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                    if (find.Success)
                    {
                        var data = new Parser(int.Parse(find.Groups[1].Value), find.Groups[2].Value);
                        body.Add(data);
                    }
                };
                if (body.Count == 0) throw new Exception("파일 읽기 실패");
                body = body.OrderBy(item => item.StartTime).ToList(); // 자막 텍스트를 시간 순으로 정렬
            }
            else if (type == "ASS")
            {
                // ASS Parsing
                var Lines = Regex.Split(raw, @"(\d+:\d\d:\d\d\.\d*,\d+:\d\d:\d\d\.\d*)");
                header = Lines[0];

                var length = Lines.Length / 2 + 1;
                var formatProvider = new System.Globalization.CultureInfo("en-US");
                for (int i = 1; i < length; i++)
                {
                    var timeStamp = Lines[2 * i - 1].Split(',');
                    var startTime = TimeSpan.Parse(timeStamp[0], formatProvider).TotalMilliseconds;
                    var endTime = TimeSpan.Parse(timeStamp[1], formatProvider).TotalMilliseconds;
                    var data = new Parser((int)startTime, (int)endTime, Lines[2 * i]);
                    body.Add(data);
                }
                if (body.Count == 0) throw new Exception("파일 읽기 실패");
                body = body.OrderBy(item => item.StartTime).ToList(); // 자막 텍스트를 시간 순으로 정렬
            }
            else
            {
                // SRT Parsing
                var Lines = Regex.Split(raw, @"(\d+:\d\d:\d\d,\d+ --> \d+:\d\d:\d\d,\d+)");
                header = Lines[0];

                var length = Lines.Length / 2 + 1;
                var formatProvider = new System.Globalization.CultureInfo("fr-FR");
                for (int i = 1; i < length; i++)
                {
                    var timeStamp = Regex.Split(Lines[2 * i - 1], " --> ");
                    var startTime = TimeSpan.Parse(timeStamp[0], formatProvider).TotalMilliseconds;
                    var endTime = TimeSpan.Parse(timeStamp[1], formatProvider).TotalMilliseconds;
                    var data = new Parser((int)startTime, (int)endTime, Lines[2 * i]);
                    body.Add(data);
                }
                if (body.Count == 0) throw new Exception("파일 읽기 실패");
                body = body.OrderBy(item => item.StartTime).ToList(); // 자막 텍스트를 시간 순으로 정렬
            }

            return new Subtitle(header, body, type);
        }

        public static string Stringify(Subtitle subtitle)
        {
            // 성능 향상을 위해 자주 쓰일 법한 포맷부터 먼저 체크해 조건문을 빠져나갈 수 있도록 함
            // 나중에 지원하는 포맷이 5개 이상이 되면 Switch문으로 바꾸는 것이 바람직함
            if (subtitle.Type == "SMI")
            {
                var data = new StringBuilder(subtitle.Header);
                foreach (var item in subtitle.Body)
                {
                    string str = "<SYNC Start=" + item.StartTime + ">" + item.Content;
                    data.Append(str);
                }
                return data.ToString();
            }
            else if (subtitle.Type == "ASS")
            {
                var data = new StringBuilder(subtitle.Header);
                foreach (var item in subtitle.Body)
                {
                    var startTime = TimeSpan.FromMilliseconds(item.StartTime);
                    var endTime = TimeSpan.FromMilliseconds(item.EndTime);
                    string str = startTime.ToString(@"h\:mm\:ss\.ff") + "," + endTime.ToString(@"h\:mm\:ss\.ff") + item.Content;
                    data.Append(str);
                }
                return data.ToString();
            }
            else
            {
                var data = new StringBuilder(subtitle.Header);
                foreach (var item in subtitle.Body)
                {
                    var startTime = TimeSpan.FromMilliseconds(item.StartTime);
                    var endTime = TimeSpan.FromMilliseconds(item.EndTime);
                    string str = startTime.ToString(@"hh\:mm\:ss\,fff") + " --> " + endTime.ToString(@"hh\:mm\:ss\,fff") + item.Content;
                    data.Append(str);
                }
                return data.ToString();
            }
        }

        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string Content { get; }
    }
}
