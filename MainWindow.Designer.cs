using System.Drawing;

namespace BatchSubtitleSync
{
    partial class MainWindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ListClear = new System.Windows.Forms.Button();
            this.ListDel = new System.Windows.Forms.Button();
            this.DirOpen = new System.Windows.Forms.Button();
            this.FileOpen = new System.Windows.Forms.Button();
            this.QueClear = new System.Windows.Forms.Button();
            this.QueDown = new System.Windows.Forms.Button();
            this.QueUp = new System.Windows.Forms.Button();
            this.ListLabel = new System.Windows.Forms.Label();
            this.QueLabel = new System.Windows.Forms.Label();
            this.saveGroup = new System.Windows.Forms.GroupBox();
            this.saveGroupLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SaveOrig = new System.Windows.Forms.RadioButton();
            this.SaveOther = new System.Windows.Forms.RadioButton();
            this.SaveDir = new System.Windows.Forms.TextBox();
            this.SaveDirOpen = new System.Windows.Forms.Button();
            this.BypassSync = new System.Windows.Forms.CheckBox();
            this.QueDel = new System.Windows.Forms.Button();
            this.Encode = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.tab1Row0Label = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.tab1Add = new System.Windows.Forms.Button();
            this.tab1Row1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab1Row1Label1 = new System.Windows.Forms.Label();
            this.SponserTime = new System.Windows.Forms.NumericUpDown();
            this.tab1Row1Label2 = new System.Windows.Forms.Label();
            this.tab1Row1Label3 = new System.Windows.Forms.Label();
            this.LineOffset = new System.Windows.Forms.NumericUpDown();
            this.tab1Row2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab1Row2Label1 = new System.Windows.Forms.Label();
            this.IgnoreLine = new System.Windows.Forms.NumericUpDown();
            this.tab1Row2Label2 = new System.Windows.Forms.Label();
            this.IgnoreTime = new System.Windows.Forms.NumericUpDown();
            this.tab1Row2Label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.tab2Add = new System.Windows.Forms.Button();
            this.tab2Row = new System.Windows.Forms.FlowLayoutPanel();
            this.tab2RowLabel1 = new System.Windows.Forms.Label();
            this.SyncTime = new System.Windows.Forms.NumericUpDown();
            this.tab2RowLabel2 = new System.Windows.Forms.Label();
            this.tab2VerticalComponents = new System.Windows.Forms.FlowLayoutPanel();
            this.OffsetSlow = new System.Windows.Forms.RadioButton();
            this.OffsetFast = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tab3Add = new System.Windows.Forms.Button();
            this.tab3Row = new System.Windows.Forms.FlowLayoutPanel();
            this.tab3RowLabel1 = new System.Windows.Forms.Label();
            this.SyncSpeed = new System.Windows.Forms.NumericUpDown();
            this.tab3RowLabel2 = new System.Windows.Forms.Label();
            this.SaveLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.queList = new System.Windows.Forms.ListView();
            this.taskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskOption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileList = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainLayout.SuspendLayout();
            this.saveGroup.SuspendLayout();
            this.saveGroupLayout.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabLayout1.SuspendLayout();
            this.tab1Row1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SponserTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineOffset)).BeginInit();
            this.tab1Row2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IgnoreLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IgnoreTime)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabLayout2.SuspendLayout();
            this.tab2Row.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncTime)).BeginInit();
            this.tab2VerticalComponents.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tab3Row.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncSpeed)).BeginInit();
            this.SaveLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainLayout.Controls.Add(this.ListClear, 1, 10);
            this.MainLayout.Controls.Add(this.ListDel, 1, 9);
            this.MainLayout.Controls.Add(this.DirOpen, 1, 8);
            this.MainLayout.Controls.Add(this.FileOpen, 1, 7);
            this.MainLayout.Controls.Add(this.QueClear, 1, 5);
            this.MainLayout.Controls.Add(this.QueDown, 1, 4);
            this.MainLayout.Controls.Add(this.QueUp, 1, 3);
            this.MainLayout.Controls.Add(this.ListLabel, 0, 6);
            this.MainLayout.Controls.Add(this.QueLabel, 0, 1);
            this.MainLayout.Controls.Add(this.saveGroup, 0, 13);
            this.MainLayout.Controls.Add(this.QueDel, 1, 2);
            this.MainLayout.Controls.Add(this.Encode, 1, 12);
            this.MainLayout.Controls.Add(this.tabControl1, 0, 0);
            this.MainLayout.Controls.Add(this.SaveLayout, 0, 14);
            this.MainLayout.Controls.Add(this.queList, 0, 2);
            this.MainLayout.Controls.Add(this.fileList, 0, 7);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Padding = new System.Windows.Forms.Padding(5);
            this.MainLayout.RowCount = 15;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.Size = new System.Drawing.Size(424, 661);
            this.MainLayout.TabIndex = 0;
            // 
            // ListClear
            // 
            this.ListClear.BackgroundImage = global::BatchSubtitleSync.Properties.Resources.clear;
            this.ListClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ListClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListClear.FlatAppearance.BorderSize = 0;
            this.ListClear.Location = new System.Drawing.Point(390, 426);
            this.ListClear.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.ListClear.Name = "ListClear";
            this.ListClear.Size = new System.Drawing.Size(24, 24);
            this.ListClear.TabIndex = 10;
            this.ListClear.UseVisualStyleBackColor = true;
            this.ListClear.Click += new System.EventHandler(this.ListClear_Click);
            // 
            // ListDel
            // 
            this.ListDel.BackgroundImage = global::BatchSubtitleSync.Properties.Resources.remove;
            this.ListDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ListDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListDel.FlatAppearance.BorderSize = 0;
            this.ListDel.Location = new System.Drawing.Point(390, 396);
            this.ListDel.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.ListDel.Name = "ListDel";
            this.ListDel.Size = new System.Drawing.Size(24, 24);
            this.ListDel.TabIndex = 9;
            this.ListDel.UseVisualStyleBackColor = true;
            this.ListDel.Click += new System.EventHandler(this.ListDel_Click);
            // 
            // DirOpen
            // 
            this.DirOpen.BackgroundImage = global::BatchSubtitleSync.Properties.Resources.folder;
            this.DirOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DirOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirOpen.FlatAppearance.BorderSize = 0;
            this.DirOpen.Location = new System.Drawing.Point(390, 366);
            this.DirOpen.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.DirOpen.Name = "DirOpen";
            this.DirOpen.Size = new System.Drawing.Size(24, 24);
            this.DirOpen.TabIndex = 8;
            this.DirOpen.UseVisualStyleBackColor = true;
            this.DirOpen.Click += new System.EventHandler(this.DirOpen_Click);
            // 
            // FileOpen
            // 
            this.FileOpen.BackgroundImage = global::BatchSubtitleSync.Properties.Resources.file;
            this.FileOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FileOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileOpen.FlatAppearance.BorderSize = 0;
            this.FileOpen.Location = new System.Drawing.Point(390, 336);
            this.FileOpen.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(24, 24);
            this.FileOpen.TabIndex = 7;
            this.FileOpen.UseVisualStyleBackColor = true;
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // QueClear
            // 
            this.QueClear.BackgroundImage = global::BatchSubtitleSync.Properties.Resources.clear;
            this.QueClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.QueClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueClear.FlatAppearance.BorderSize = 0;
            this.QueClear.Location = new System.Drawing.Point(390, 282);
            this.QueClear.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.QueClear.Name = "QueClear";
            this.QueClear.Size = new System.Drawing.Size(24, 24);
            this.QueClear.TabIndex = 6;
            this.QueClear.UseVisualStyleBackColor = true;
            this.QueClear.Click += new System.EventHandler(this.QueClear_Click);
            // 
            // QueDown
            // 
            this.QueDown.BackgroundImage = global::BatchSubtitleSync.Properties.Resources.down;
            this.QueDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.QueDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueDown.FlatAppearance.BorderSize = 0;
            this.QueDown.Location = new System.Drawing.Point(390, 252);
            this.QueDown.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.QueDown.Name = "QueDown";
            this.QueDown.Size = new System.Drawing.Size(24, 24);
            this.QueDown.TabIndex = 5;
            this.QueDown.UseVisualStyleBackColor = true;
            this.QueDown.Click += new System.EventHandler(this.QueDown_Click);
            // 
            // QueUp
            // 
            this.QueUp.BackgroundImage = global::BatchSubtitleSync.Properties.Resources.up;
            this.QueUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.QueUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueUp.FlatAppearance.BorderSize = 0;
            this.QueUp.Location = new System.Drawing.Point(390, 222);
            this.QueUp.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.QueUp.Name = "QueUp";
            this.QueUp.Size = new System.Drawing.Size(24, 24);
            this.QueUp.TabIndex = 4;
            this.QueUp.UseVisualStyleBackColor = true;
            this.QueUp.Click += new System.EventHandler(this.QueUp_Click);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.MainLayout.SetColumnSpan(this.ListLabel, 2);
            this.ListLabel.Location = new System.Drawing.Point(10, 319);
            this.ListLabel.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(57, 12);
            this.ListLabel.TabIndex = 0;
            this.ListLabel.Text = "파일 목록";
            // 
            // QueLabel
            // 
            this.QueLabel.AutoSize = true;
            this.MainLayout.SetColumnSpan(this.QueLabel, 2);
            this.QueLabel.Location = new System.Drawing.Point(10, 175);
            this.QueLabel.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.QueLabel.Name = "QueLabel";
            this.QueLabel.Size = new System.Drawing.Size(57, 12);
            this.QueLabel.TabIndex = 15;
            this.QueLabel.Text = "작업 목록";
            // 
            // saveGroup
            // 
            this.MainLayout.SetColumnSpan(this.saveGroup, 2);
            this.saveGroup.Controls.Add(this.saveGroupLayout);
            this.saveGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveGroup.Location = new System.Drawing.Point(8, 547);
            this.saveGroup.Name = "saveGroup";
            this.saveGroup.Size = new System.Drawing.Size(408, 76);
            this.saveGroup.TabIndex = 2;
            this.saveGroup.TabStop = false;
            this.saveGroup.Text = "저장 옵션";
            // 
            // saveGroupLayout
            // 
            this.saveGroupLayout.ColumnCount = 4;
            this.saveGroupLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.saveGroupLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.saveGroupLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.saveGroupLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.saveGroupLayout.Controls.Add(this.SaveOrig, 0, 0);
            this.saveGroupLayout.Controls.Add(this.SaveOther, 0, 1);
            this.saveGroupLayout.Controls.Add(this.SaveDir, 1, 1);
            this.saveGroupLayout.Controls.Add(this.SaveDirOpen, 3, 1);
            this.saveGroupLayout.Controls.Add(this.BypassSync, 2, 0);
            this.saveGroupLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveGroupLayout.Location = new System.Drawing.Point(3, 17);
            this.saveGroupLayout.Margin = new System.Windows.Forms.Padding(0);
            this.saveGroupLayout.Name = "saveGroupLayout";
            this.saveGroupLayout.RowCount = 2;
            this.saveGroupLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveGroupLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveGroupLayout.Size = new System.Drawing.Size(402, 56);
            this.saveGroupLayout.TabIndex = 0;
            // 
            // SaveOrig
            // 
            this.SaveOrig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveOrig.AutoSize = true;
            this.SaveOrig.Checked = true;
            this.SaveOrig.Location = new System.Drawing.Point(3, 3);
            this.SaveOrig.Name = "SaveOrig";
            this.SaveOrig.Size = new System.Drawing.Size(115, 22);
            this.SaveOrig.TabIndex = 0;
            this.SaveOrig.TabStop = true;
            this.SaveOrig.Text = "원본 위치에 저장";
            this.SaveOrig.UseVisualStyleBackColor = true;
            // 
            // SaveOther
            // 
            this.SaveOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveOther.AutoSize = true;
            this.SaveOther.Location = new System.Drawing.Point(3, 31);
            this.SaveOther.Name = "SaveOther";
            this.SaveOther.Size = new System.Drawing.Size(115, 22);
            this.SaveOther.TabIndex = 1;
            this.SaveOther.Text = "다른 위치에 저장";
            this.SaveOther.UseVisualStyleBackColor = true;
            // 
            // SaveDir
            // 
            this.saveGroupLayout.SetColumnSpan(this.SaveDir, 2);
            this.SaveDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveDir.Location = new System.Drawing.Point(124, 31);
            this.SaveDir.Name = "SaveDir";
            this.SaveDir.Size = new System.Drawing.Size(215, 21);
            this.SaveDir.TabIndex = 3;
            // 
            // SaveDirOpen
            // 
            this.SaveDirOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveDirOpen.Location = new System.Drawing.Point(345, 31);
            this.SaveDirOpen.Name = "SaveDirOpen";
            this.SaveDirOpen.Size = new System.Drawing.Size(54, 22);
            this.SaveDirOpen.TabIndex = 2;
            this.SaveDirOpen.Text = "...";
            this.SaveDirOpen.UseVisualStyleBackColor = true;
            this.SaveDirOpen.Click += new System.EventHandler(this.SaveDirOpen_Click);
            // 
            // BypassSync
            // 
            this.BypassSync.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BypassSync.AutoSize = true;
            this.saveGroupLayout.SetColumnSpan(this.BypassSync, 2);
            this.BypassSync.Location = new System.Drawing.Point(295, 3);
            this.BypassSync.Name = "BypassSync";
            this.BypassSync.Size = new System.Drawing.Size(104, 22);
            this.BypassSync.TabIndex = 4;
            this.BypassSync.Text = "싱크 꼬임 무시";
            this.BypassSync.UseVisualStyleBackColor = true;
            // 
            // QueDel
            // 
            this.QueDel.BackgroundImage = global::BatchSubtitleSync.Properties.Resources.remove;
            this.QueDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.QueDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueDel.FlatAppearance.BorderSize = 0;
            this.QueDel.Location = new System.Drawing.Point(390, 192);
            this.QueDel.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.QueDel.Name = "QueDel";
            this.QueDel.Size = new System.Drawing.Size(24, 24);
            this.QueDel.TabIndex = 3;
            this.QueDel.UseVisualStyleBackColor = true;
            this.QueDel.Click += new System.EventHandler(this.QueDel_Click);
            // 
            // Encode
            // 
            this.Encode.BackgroundImage = global::BatchSubtitleSync.Properties.Resources.encode;
            this.Encode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Encode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Encode.FlatAppearance.BorderSize = 0;
            this.Encode.Location = new System.Drawing.Point(390, 517);
            this.Encode.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(24, 24);
            this.Encode.TabIndex = 11;
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // tabControl1
            // 
            this.MainLayout.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 154);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabLayout1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "스폰서 변환";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabLayout1
            // 
            this.tabLayout1.ColumnCount = 2;
            this.tabLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayout1.Controls.Add(this.tab1Row0Label, 0, 0);
            this.tabLayout1.Controls.Add(this.SearchText, 1, 0);
            this.tabLayout1.Controls.Add(this.tab1Add, 0, 3);
            this.tabLayout1.Controls.Add(this.tab1Row1, 1, 1);
            this.tabLayout1.Controls.Add(this.tab1Row2, 1, 2);
            this.tabLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayout1.Location = new System.Drawing.Point(3, 3);
            this.tabLayout1.Name = "tabLayout1";
            this.tabLayout1.RowCount = 4;
            this.tabLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tabLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tabLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tabLayout1.Size = new System.Drawing.Size(394, 122);
            this.tabLayout1.TabIndex = 0;
            // 
            // tab1Row0Label
            // 
            this.tab1Row0Label.AutoSize = true;
            this.tab1Row0Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1Row0Label.Location = new System.Drawing.Point(3, 0);
            this.tab1Row0Label.Name = "tab1Row0Label";
            this.tab1Row0Label.Size = new System.Drawing.Size(69, 31);
            this.tab1Row0Label.TabIndex = 3;
            this.tab1Row0Label.Text = "검색 텍스트";
            this.tab1Row0Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchText
            // 
            this.SearchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchText.Location = new System.Drawing.Point(78, 3);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(313, 21);
            this.SearchText.TabIndex = 0;
            // 
            // tab1Add
            // 
            this.tabLayout1.SetColumnSpan(this.tab1Add, 2);
            this.tab1Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1Add.Location = new System.Drawing.Point(3, 98);
            this.tab1Add.Name = "tab1Add";
            this.tab1Add.Size = new System.Drawing.Size(388, 21);
            this.tab1Add.TabIndex = 3;
            this.tab1Add.Text = "추가하기";
            this.tab1Add.UseVisualStyleBackColor = true;
            this.tab1Add.Click += new System.EventHandler(this.tab1Add_Click);
            // 
            // tab1Row1
            // 
            this.tab1Row1.Controls.Add(this.tab1Row1Label1);
            this.tab1Row1.Controls.Add(this.SponserTime);
            this.tab1Row1.Controls.Add(this.tab1Row1Label2);
            this.tab1Row1.Controls.Add(this.tab1Row1Label3);
            this.tab1Row1.Controls.Add(this.LineOffset);
            this.tab1Row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1Row1.Location = new System.Drawing.Point(75, 31);
            this.tab1Row1.Margin = new System.Windows.Forms.Padding(0);
            this.tab1Row1.Name = "tab1Row1";
            this.tab1Row1.Size = new System.Drawing.Size(319, 32);
            this.tab1Row1.TabIndex = 1;
            // 
            // tab1Row1Label1
            // 
            this.tab1Row1Label1.AutoSize = true;
            this.tab1Row1Label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tab1Row1Label1.Location = new System.Drawing.Point(3, 0);
            this.tab1Row1Label1.Name = "tab1Row1Label1";
            this.tab1Row1Label1.Size = new System.Drawing.Size(97, 27);
            this.tab1Row1Label1.TabIndex = 2;
            this.tab1Row1Label1.Text = "스폰서 영상 길이";
            this.tab1Row1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SponserTime
            // 
            this.SponserTime.DecimalPlaces = 2;
            this.SponserTime.Location = new System.Drawing.Point(103, 3);
            this.SponserTime.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.SponserTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SponserTime.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.SponserTime.Name = "SponserTime";
            this.SponserTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SponserTime.Size = new System.Drawing.Size(55, 21);
            this.SponserTime.TabIndex = 0;
            this.SponserTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SponserTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tab1Row1Label2
            // 
            this.tab1Row1Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab1Row1Label2.AutoSize = true;
            this.tab1Row1Label2.Location = new System.Drawing.Point(161, 0);
            this.tab1Row1Label2.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.tab1Row1Label2.Name = "tab1Row1Label2";
            this.tab1Row1Label2.Size = new System.Drawing.Size(17, 27);
            this.tab1Row1Label2.TabIndex = 4;
            this.tab1Row1Label2.Text = "초";
            this.tab1Row1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab1Row1Label3
            // 
            this.tab1Row1Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab1Row1Label3.AutoSize = true;
            this.tab1Row1Label3.Location = new System.Drawing.Point(189, 0);
            this.tab1Row1Label3.Name = "tab1Row1Label3";
            this.tab1Row1Label3.Size = new System.Drawing.Size(69, 27);
            this.tab1Row1Label3.TabIndex = 0;
            this.tab1Row1Label3.Text = "라인 오프셋";
            this.tab1Row1Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LineOffset
            // 
            this.LineOffset.Location = new System.Drawing.Point(261, 3);
            this.LineOffset.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LineOffset.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.LineOffset.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.LineOffset.Name = "LineOffset";
            this.LineOffset.Size = new System.Drawing.Size(45, 21);
            this.LineOffset.TabIndex = 1;
            this.LineOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LineOffset.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tab1Row2
            // 
            this.tab1Row2.Controls.Add(this.tab1Row2Label1);
            this.tab1Row2.Controls.Add(this.IgnoreLine);
            this.tab1Row2.Controls.Add(this.tab1Row2Label2);
            this.tab1Row2.Controls.Add(this.IgnoreTime);
            this.tab1Row2.Controls.Add(this.tab1Row2Label3);
            this.tab1Row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1Row2.Location = new System.Drawing.Point(78, 66);
            this.tab1Row2.Name = "tab1Row2";
            this.tab1Row2.Size = new System.Drawing.Size(313, 26);
            this.tab1Row2.TabIndex = 2;
            // 
            // tab1Row2Label1
            // 
            this.tab1Row2Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab1Row2Label1.AutoSize = true;
            this.tab1Row2Label1.Location = new System.Drawing.Point(3, 0);
            this.tab1Row2Label1.Name = "tab1Row2Label1";
            this.tab1Row2Label1.Size = new System.Drawing.Size(57, 27);
            this.tab1Row2Label1.TabIndex = 4;
            this.tab1Row2Label1.Text = "시작부터 ";
            this.tab1Row2Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IgnoreLine
            // 
            this.IgnoreLine.Location = new System.Drawing.Point(63, 3);
            this.IgnoreLine.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.IgnoreLine.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.IgnoreLine.Name = "IgnoreLine";
            this.IgnoreLine.Size = new System.Drawing.Size(45, 21);
            this.IgnoreLine.TabIndex = 2;
            this.IgnoreLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IgnoreLine.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tab1Row2Label2
            // 
            this.tab1Row2Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab1Row2Label2.AutoSize = true;
            this.tab1Row2Label2.Location = new System.Drawing.Point(111, 0);
            this.tab1Row2Label2.Name = "tab1Row2Label2";
            this.tab1Row2Label2.Size = new System.Drawing.Size(21, 27);
            this.tab1Row2Label2.TabIndex = 0;
            this.tab1Row2Label2.Text = "줄 ";
            this.tab1Row2Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IgnoreTime
            // 
            this.IgnoreTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IgnoreTime.DecimalPlaces = 2;
            this.IgnoreTime.Location = new System.Drawing.Point(135, 3);
            this.IgnoreTime.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.IgnoreTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.IgnoreTime.Name = "IgnoreTime";
            this.IgnoreTime.Size = new System.Drawing.Size(55, 21);
            this.IgnoreTime.TabIndex = 3;
            this.IgnoreTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IgnoreTime.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // tab1Row2Label3
            // 
            this.tab1Row2Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab1Row2Label3.AutoSize = true;
            this.tab1Row2Label3.Location = new System.Drawing.Point(190, 0);
            this.tab1Row2Label3.Margin = new System.Windows.Forms.Padding(0);
            this.tab1Row2Label3.Name = "tab1Row2Label3";
            this.tab1Row2Label3.Size = new System.Drawing.Size(69, 27);
            this.tab1Row2Label3.TabIndex = 1;
            this.tab1Row2Label3.Text = "초 무시하기";
            this.tab1Row2Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabLayout2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 128);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "싱크 조절(초)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabLayout2
            // 
            this.tabLayout2.ColumnCount = 1;
            this.tabLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayout2.Controls.Add(this.tab2Add, 0, 3);
            this.tabLayout2.Controls.Add(this.tab2Row, 0, 1);
            this.tabLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayout2.Location = new System.Drawing.Point(3, 3);
            this.tabLayout2.Name = "tabLayout2";
            this.tabLayout2.RowCount = 4;
            this.tabLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tabLayout2.Size = new System.Drawing.Size(394, 122);
            this.tabLayout2.TabIndex = 0;
            // 
            // tab2Add
            // 
            this.tabLayout2.SetColumnSpan(this.tab2Add, 2);
            this.tab2Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab2Add.Location = new System.Drawing.Point(3, 97);
            this.tab2Add.Name = "tab2Add";
            this.tab2Add.Size = new System.Drawing.Size(388, 22);
            this.tab2Add.TabIndex = 1;
            this.tab2Add.Text = "추가하기";
            this.tab2Add.UseVisualStyleBackColor = true;
            this.tab2Add.Click += new System.EventHandler(this.tab2Add_Click);
            // 
            // tab2Row
            // 
            this.tab2Row.AutoSize = true;
            this.tab2Row.Controls.Add(this.tab2RowLabel1);
            this.tab2Row.Controls.Add(this.SyncTime);
            this.tab2Row.Controls.Add(this.tab2RowLabel2);
            this.tab2Row.Controls.Add(this.tab2VerticalComponents);
            this.tab2Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab2Row.Location = new System.Drawing.Point(0, 25);
            this.tab2Row.Margin = new System.Windows.Forms.Padding(0);
            this.tab2Row.Name = "tab2Row";
            this.tab2Row.Size = new System.Drawing.Size(394, 44);
            this.tab2Row.TabIndex = 0;
            // 
            // tab2RowLabel1
            // 
            this.tab2RowLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab2RowLabel1.AutoSize = true;
            this.tab2RowLabel1.Location = new System.Drawing.Point(3, 0);
            this.tab2RowLabel1.Name = "tab2RowLabel1";
            this.tab2RowLabel1.Size = new System.Drawing.Size(61, 44);
            this.tab2RowLabel1.TabIndex = 0;
            this.tab2RowLabel1.Text = "자막 싱크 ";
            this.tab2RowLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SyncTime
            // 
            this.SyncTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SyncTime.DecimalPlaces = 2;
            this.SyncTime.Location = new System.Drawing.Point(67, 11);
            this.SyncTime.Margin = new System.Windows.Forms.Padding(0, 11, 0, 3);
            this.SyncTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SyncTime.Name = "SyncTime";
            this.SyncTime.Size = new System.Drawing.Size(55, 21);
            this.SyncTime.TabIndex = 0;
            this.SyncTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tab2RowLabel2
            // 
            this.tab2RowLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab2RowLabel2.AutoSize = true;
            this.tab2RowLabel2.Location = new System.Drawing.Point(122, 0);
            this.tab2RowLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.tab2RowLabel2.Name = "tab2RowLabel2";
            this.tab2RowLabel2.Size = new System.Drawing.Size(17, 44);
            this.tab2RowLabel2.TabIndex = 0;
            this.tab2RowLabel2.Text = "초";
            this.tab2RowLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab2VerticalComponents
            // 
            this.tab2VerticalComponents.AutoSize = true;
            this.tab2VerticalComponents.Controls.Add(this.OffsetSlow);
            this.tab2VerticalComponents.Controls.Add(this.OffsetFast);
            this.tab2VerticalComponents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tab2VerticalComponents.Location = new System.Drawing.Point(139, 0);
            this.tab2VerticalComponents.Margin = new System.Windows.Forms.Padding(0);
            this.tab2VerticalComponents.Name = "tab2VerticalComponents";
            this.tab2VerticalComponents.Size = new System.Drawing.Size(65, 44);
            this.tab2VerticalComponents.TabIndex = 1;
            // 
            // OffsetSlow
            // 
            this.OffsetSlow.AutoSize = true;
            this.OffsetSlow.Checked = true;
            this.OffsetSlow.Location = new System.Drawing.Point(3, 3);
            this.OffsetSlow.Name = "OffsetSlow";
            this.OffsetSlow.Size = new System.Drawing.Size(59, 16);
            this.OffsetSlow.TabIndex = 0;
            this.OffsetSlow.TabStop = true;
            this.OffsetSlow.Text = "느리게";
            this.OffsetSlow.UseVisualStyleBackColor = true;
            // 
            // OffsetFast
            // 
            this.OffsetFast.AutoSize = true;
            this.OffsetFast.Location = new System.Drawing.Point(3, 25);
            this.OffsetFast.Name = "OffsetFast";
            this.OffsetFast.Size = new System.Drawing.Size(59, 16);
            this.OffsetFast.TabIndex = 1;
            this.OffsetFast.Text = "빠르게";
            this.OffsetFast.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(400, 128);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "싱크 조절(%)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tab3Add, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tab3Row, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 122);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tab3Add
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tab3Add, 2);
            this.tab3Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab3Add.Location = new System.Drawing.Point(3, 97);
            this.tab3Add.Name = "tab3Add";
            this.tab3Add.Size = new System.Drawing.Size(388, 22);
            this.tab3Add.TabIndex = 1;
            this.tab3Add.Text = "추가하기";
            this.tab3Add.UseVisualStyleBackColor = true;
            this.tab3Add.Click += new System.EventHandler(this.tab3Add_Click);
            // 
            // tab3Row
            // 
            this.tab3Row.Controls.Add(this.tab3RowLabel1);
            this.tab3Row.Controls.Add(this.SyncSpeed);
            this.tab3Row.Controls.Add(this.tab3RowLabel2);
            this.tab3Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab3Row.Location = new System.Drawing.Point(0, 35);
            this.tab3Row.Margin = new System.Windows.Forms.Padding(0);
            this.tab3Row.Name = "tab3Row";
            this.tab3Row.Size = new System.Drawing.Size(394, 24);
            this.tab3Row.TabIndex = 0;
            // 
            // tab3RowLabel1
            // 
            this.tab3RowLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab3RowLabel1.AutoSize = true;
            this.tab3RowLabel1.Location = new System.Drawing.Point(3, 0);
            this.tab3RowLabel1.Name = "tab3RowLabel1";
            this.tab3RowLabel1.Size = new System.Drawing.Size(57, 27);
            this.tab3RowLabel1.TabIndex = 0;
            this.tab3RowLabel1.Text = "자막 싱크";
            this.tab3RowLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SyncSpeed
            // 
            this.SyncSpeed.Location = new System.Drawing.Point(66, 3);
            this.SyncSpeed.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.SyncSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SyncSpeed.Name = "SyncSpeed";
            this.SyncSpeed.Size = new System.Drawing.Size(55, 21);
            this.SyncSpeed.TabIndex = 0;
            this.SyncSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SyncSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tab3RowLabel2
            // 
            this.tab3RowLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab3RowLabel2.AutoSize = true;
            this.tab3RowLabel2.Location = new System.Drawing.Point(127, 0);
            this.tab3RowLabel2.Name = "tab3RowLabel2";
            this.tab3RowLabel2.Size = new System.Drawing.Size(15, 27);
            this.tab3RowLabel2.TabIndex = 0;
            this.tab3RowLabel2.Text = "%";
            this.tab3RowLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveLayout
            // 
            this.MainLayout.SetColumnSpan(this.SaveLayout, 2);
            this.SaveLayout.Controls.Add(this.Cancel);
            this.SaveLayout.Controls.Add(this.Apply);
            this.SaveLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.SaveLayout.Location = new System.Drawing.Point(5, 626);
            this.SaveLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SaveLayout.Name = "SaveLayout";
            this.SaveLayout.Size = new System.Drawing.Size(414, 30);
            this.SaveLayout.TabIndex = 12;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(336, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Apply
            // 
            this.Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Apply.Location = new System.Drawing.Point(255, 3);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 0;
            this.Apply.Text = "적용";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // queList
            // 
            this.queList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskName,
            this.taskOption});
            this.queList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queList.FullRowSelect = true;
            this.queList.HideSelection = false;
            this.queList.Location = new System.Drawing.Point(10, 192);
            this.queList.Margin = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.queList.MultiSelect = false;
            this.queList.Name = "queList";
            this.MainLayout.SetRowSpan(this.queList, 4);
            this.queList.Size = new System.Drawing.Size(374, 114);
            this.queList.TabIndex = 13;
            this.queList.UseCompatibleStateImageBehavior = false;
            this.queList.View = System.Windows.Forms.View.Details;
            // 
            // taskName
            // 
            this.taskName.Text = "작업";
            this.taskName.Width = 120;
            // 
            // taskOption
            // 
            this.taskOption.Text = "옵션";
            this.taskOption.Width = 250;
            // 
            // fileList
            // 
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.filePath});
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.FullRowSelect = true;
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(10, 336);
            this.fileList.Margin = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.fileList.Name = "fileList";
            this.MainLayout.SetRowSpan(this.fileList, 6);
            this.fileList.Size = new System.Drawing.Size(374, 205);
            this.fileList.TabIndex = 14;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "이름";
            this.fileName.Width = 120;
            // 
            // filePath
            // 
            this.filePath.Text = "경로";
            this.filePath.Width = 250;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.Apply;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(424, 661);
            this.Controls.Add(this.MainLayout);
            this.MinimumSize = new System.Drawing.Size(440, 700);
            this.Name = "MainWindow";
            this.Text = "Batch Subtitle Sync v1.0";
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.saveGroup.ResumeLayout(false);
            this.saveGroupLayout.ResumeLayout(false);
            this.saveGroupLayout.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabLayout1.ResumeLayout(false);
            this.tabLayout1.PerformLayout();
            this.tab1Row1.ResumeLayout(false);
            this.tab1Row1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SponserTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineOffset)).EndInit();
            this.tab1Row2.ResumeLayout(false);
            this.tab1Row2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IgnoreLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IgnoreTime)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabLayout2.ResumeLayout(false);
            this.tabLayout2.PerformLayout();
            this.tab2Row.ResumeLayout(false);
            this.tab2Row.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncTime)).EndInit();
            this.tab2VerticalComponents.ResumeLayout(false);
            this.tab2VerticalComponents.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tab3Row.ResumeLayout(false);
            this.tab3Row.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncSpeed)).EndInit();
            this.SaveLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Button ListClear;
        private System.Windows.Forms.Button ListDel;
        private System.Windows.Forms.Button DirOpen;
        private System.Windows.Forms.Button FileOpen;
        private System.Windows.Forms.Button QueClear;
        private System.Windows.Forms.Button QueDown;
        private System.Windows.Forms.Button QueUp;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Label QueLabel;
        private System.Windows.Forms.GroupBox saveGroup;
        private System.Windows.Forms.Button QueDel;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel saveGroupLayout;
        private System.Windows.Forms.RadioButton SaveOrig;
        private System.Windows.Forms.RadioButton SaveOther;
        private System.Windows.Forms.TextBox SaveDir;
        private System.Windows.Forms.Button SaveDirOpen;
        private System.Windows.Forms.CheckBox BypassSync;
        private System.Windows.Forms.TableLayoutPanel tabLayout1;
        private System.Windows.Forms.Label tab1Row0Label;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button tab1Add;
        private System.Windows.Forms.FlowLayoutPanel tab1Row1;
        private System.Windows.Forms.Label tab1Row1Label1;
        private System.Windows.Forms.NumericUpDown SponserTime;
        private System.Windows.Forms.Label tab1Row1Label3;
        private System.Windows.Forms.FlowLayoutPanel tab1Row2;
        private System.Windows.Forms.Label tab1Row2Label1;
        private System.Windows.Forms.NumericUpDown LineOffset;
        private System.Windows.Forms.NumericUpDown IgnoreLine;
        private System.Windows.Forms.NumericUpDown IgnoreTime;
        private System.Windows.Forms.Label tab1Row2Label3;
        private System.Windows.Forms.Label tab1Row2Label2;
        private System.Windows.Forms.FlowLayoutPanel SaveLayout;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TableLayoutPanel tabLayout2;
        private System.Windows.Forms.Button tab2Add;
        private System.Windows.Forms.FlowLayoutPanel tab2Row;
        private System.Windows.Forms.Label tab2RowLabel1;
        private System.Windows.Forms.NumericUpDown SyncTime;
        private System.Windows.Forms.Label tab2RowLabel2;
        private System.Windows.Forms.FlowLayoutPanel tab2VerticalComponents;
        private System.Windows.Forms.RadioButton OffsetSlow;
        private System.Windows.Forms.RadioButton OffsetFast;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button tab3Add;
        private System.Windows.Forms.FlowLayoutPanel tab3Row;
        private System.Windows.Forms.Label tab3RowLabel1;
        private System.Windows.Forms.NumericUpDown SyncSpeed;
        private System.Windows.Forms.Label tab3RowLabel2;
        private System.Windows.Forms.ListView queList;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader filePath;
        private System.Windows.Forms.ColumnHeader taskName;
        private System.Windows.Forms.ColumnHeader taskOption;
        private System.Windows.Forms.Label tab1Row1Label2;
    }
}

