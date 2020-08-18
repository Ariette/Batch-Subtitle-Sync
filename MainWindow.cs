using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BatchSubtitleSync
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            DragEnter += new DragEventHandler(MainWindowDragEnter);
            DragDrop += new DragEventHandler(MainWindowDragDrop);
            Codepage = "자동";
            NoFallback = false;
            ANSI = false;
        }

        static MainWindow()
        {
            EcdFallback = new EncoderExceptionFallback();
            DcdFallback = new DecoderExceptionFallback();
        }

        private void MainWindowDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                if (File.GetAttributes(file).HasFlag(FileAttributes.Directory))
                {
                    string[] paths = Directory.GetFiles(file, "*.*", SearchOption.AllDirectories);
                    foreach (var path in paths)
                    {
                        if (!fileList.Items.ContainsKey(path) && (path.EndsWith(".smi") || path.EndsWith(".srt") || path.EndsWith(".ass") || path.EndsWith(".ssa")))
                        {
                            string name = Path.GetFileName(path);
                            string[] content = { name, path };
                            var item = new ListViewItem(content)
                            {
                                Name = path
                            };
                            fileList.Items.Add(item);
                        }
                    }
                }
                else
                {
                    if (!fileList.Items.ContainsKey(file) && (fileName.EndsWith(".smi") || fileName.EndsWith(".srt") || fileName.EndsWith(".ass") || fileName.EndsWith(".ssa")))
                    {
                        string[] content = { fileName, file };
                        var item = new ListViewItem(content)
                        {
                            Name = file
                        };
                        fileList.Items.Add(item);
                    }
                }
            }
        }
        private void MainWindowDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;

        }

        private void tab1Add_Click(object sender, EventArgs e)
        {
            string sponserText = SearchText.Text;
            float sponserTime = (float)SponserTime.Value;
            int lineOffset = (short)LineOffset.Value;
            int ignoreLine = (short)IgnoreLine.Value;
            float ignoreTime = (float)IgnoreTime.Value;
            List<dynamic> data = new List<dynamic> { 1, sponserTime, sponserText, lineOffset, ignoreLine, ignoreTime };
            string[] content = { tabPage1.Text, "스폰서 영상 시간 : " + sponserTime.ToString() + "초, 오프셋 : " + lineOffset.ToString() + "줄, 시작부터 " + ignoreLine.ToString() + "번째 줄, " + ignoreTime.ToString() + "초 무시 - 검색어 : " + sponserText };
            var item = new ListViewItem(content)
            {
                Tag = data
            };

            queList.Items.Add(item);

        }

        private void tab2Add_Click(object sender, EventArgs e)
        {
            float syncTime = (float)SyncTime.Value;
            bool syncDirection = OffsetFast.Checked;
            string directionText = syncDirection ? "빠르게" : "느리게";
            List<dynamic> data = new List<dynamic> { 2, syncTime, syncDirection };
            string[] content = { tabPage2.Text, "자막 싱크 " + syncTime.ToString() + "초 " + directionText };
            var item = new ListViewItem(content)
            {
                Tag = data
            };

            queList.Items.Add(item);
        }

        private void tab3Add_Click(object sender, EventArgs e)
        {
            int syncSpeed = (int)SyncSpeed.Value;
            List<dynamic> data = new List<dynamic> { 3, syncSpeed };
            string[] content = { tabPage3.Text, "자막 싱크 " + syncSpeed.ToString() + "%" };
            var item = new ListViewItem(content)
            {
                Tag = data
            };

            queList.Items.Add(item);
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Title = "자막 파일 선택", Filter = "지원하는 자막 포맷 (*.smi, *.srt, *.ass, *.ssa)|*.smi;*.srt;*.ass;*.ssa", Multiselect = true })
            {
                var dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var len = ofd.FileNames.Length;
                    for (int i = 0; i < len; i++)
                    {
                        var path = ofd.FileNames[i];
                        var name = ofd.SafeFileNames[i];

                        if (!fileList.Items.ContainsKey(path) && name.EndsWith(".smi"))
                        {
                            string[] content = { name, path };
                            var item = new ListViewItem(content)
                            {
                                Name = path
                            };
                            fileList.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void DirOpen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var dr = fbd.ShowDialog();
                if (dr == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] paths = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories);
                    foreach (var path in paths)
                    {
                        if (!fileList.Items.ContainsKey(path) && (path.EndsWith(".smi") || path.EndsWith(".srt") || path.EndsWith(".ass") || path.EndsWith(".ssa")))
                        {
                            string name = Path.GetFileName(path);
                            string[] content = { name, path };
                            var item = new ListViewItem(content)
                            {
                                Name = path
                            };
                            fileList.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            using (var ipd = new encodeDialog(this.Codepage, this.NoFallback, this.ANSI))
            {
                var dr = ipd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    this.NoFallback = ipd.NoFallback;
                    this.ANSI = ipd.ANSI;
                    if (!string.IsNullOrWhiteSpace(ipd.Value)) this.Codepage = ipd.Value;
                }
            }
        }
        private void SaveDirOpen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var dr = fbd.ShowDialog();
                if (dr == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    SaveDir.Text = fbd.SelectedPath;
                }
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Apply.Enabled = false;
            // Do something

            var bypass = !BypassSync.Checked;
            var ques = queList.Items;
            var queLength = ques.Count;
            var files = fileList.Items;
            var fileLength = files.Count;
            var log = new List<string>();

            for (int i = 0; i < fileLength; i++)
            {
                try
                {
                    // 변환 작업 수행
                    var path = files[i].SubItems[1].Text;
                    var subtitle = Subtitle.Open(path, this.Codepage, this.NoFallback);
                    for (int j = 0; j < queLength; j++)
                    {
                        var data = (List<dynamic>)ques[j].Tag;
                        if (data[0] == 1) subtitle.SponserSwitcher(data[1], data[2], data[3], data[4], data[5], bypass);
                        else if (data[0] == 2)
                        {
                            var time = data[2] ? data[1] : (data[1] * -1);
                            subtitle.ShiftTime(time, 0, bypass);
                        }
                        else if (data[0] == 3) subtitle.ChangeSpeed(data[1]);
                        else throw new Exception("알 수 없는 오류 - 명령어가 올바르지 않습니다.");
                    }

                    // 변환된 파일 저장
                    var stringified = Parser.Stringify(subtitle);
                    var savepath = path;
                    if (SaveOther.Checked) savepath = Path.Combine(SaveDir.Text, files[i].Text);
                    var saveEncoding = Encoding.GetEncoding(949, MainWindow.EcdFallback, MainWindow.DcdFallback);

                    try
                    {
                        if (!this.ANSI) throw new EncoderFallbackException(); // ANSI 저장 스킵
                        using (var sw = new StreamWriter(savepath, false, saveEncoding))
                        {
                            sw.WriteLine(stringified);
                        }
                    }
                    catch (EncoderFallbackException)
                    {
                        // 저장 실패시 UTF-8로 Fallback
                        try
                        {
                            using (var sw = new StreamWriter(savepath, false, new UTF8Encoding(false, true)))
                            {
                                sw.WriteLine(stringified);
                            }
                        }
                        catch (EncoderFallbackException)
                        {
                            // 저장 실패시 UTF-16으로 저장. 인코딩할 수 없는 문자가 있어도 교체해서 저장. (UTF-32 포맷까지 확장할 수도 있지만 메모장으로 편집 가능한 UTF-16까지만 사용)
                            using (var sw = new StreamWriter(savepath, false, Encoding.Unicode))
                            {
                                sw.WriteLine(stringified);
                            }
                        }
                    }


                }
                catch (Exception error)
                {
                    log.Add(files[i].Text + " 처리 오류 : " + error.Message);
                }
            }

            if (log.Count > 0)
            {
                var report = String.Join("\r\n", log);
                using (var rpd = new reportDialog(report, "Batch Subtitle Sync - 변환 결과"))
                {
                    var dr = rpd.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("변환 완료!", "Batch Subtitle Sync - 변환 결과");
            }
            Apply.Enabled = true;
        }

        private void QueDel_Click(object sender, EventArgs e)
        {
            var selected = queList.SelectedItems[0];
            queList.Items.Remove(selected);
        }

        private void QueUp_Click(object sender, EventArgs e)
        {
            var selected = queList.SelectedItems[0];
            var i = selected.Index;
            queList.Items.Remove(selected);

            var inserted = queList.Items.Insert(i - 1, selected);
            inserted.Selected = true;

        }

        private void QueDown_Click(object sender, EventArgs e)
        {
            var selected = queList.SelectedItems[0];
            var i = selected.Index;
            queList.Items.Remove(selected);

            var inserted = queList.Items.Insert(i + 1, selected);
            inserted.Selected = true;
        }

        private void QueClear_Click(object sender, EventArgs e)
        {
            queList.Items.Clear();
        }

        private void ListDel_Click(object sender, EventArgs e)
        {
            var selected = fileList.SelectedItems[0];
            fileList.Items.Remove(selected);
        }

        private void ListClear_Click(object sender, EventArgs e)
        {
            fileList.Items.Clear();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string Codepage { get; set; }
        public bool NoFallback { get; set; }
        public bool ANSI { get; set; }
        public static EncoderExceptionFallback EcdFallback { get; }
        public static DecoderExceptionFallback DcdFallback { get; }

    }
}
