namespace BatchSubtitleSync
{
    partial class encodeDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.fallBack = new System.Windows.Forms.CheckBox();
            this.saveANSI = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(12, 96);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "확인";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(97, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "자동",
            "EUC-KR",
            "UTF-8",
            "UTF-16LE",
            "UTF-16BE",
            "직접 입력"});
            this.comboBox.Location = new System.Drawing.Point(12, 28);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(160, 20);
            this.comboBox.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 10);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(97, 12);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "자막 인코딩 설정";
            // 
            // fallBack
            // 
            this.fallBack.AutoSize = true;
            this.fallBack.Location = new System.Drawing.Point(12, 54);
            this.fallBack.Name = "fallBack";
            this.fallBack.Size = new System.Drawing.Size(144, 16);
            this.fallBack.TabIndex = 3;
            this.fallBack.Text = "감지 실패시 변환 안함";
            this.fallBack.UseVisualStyleBackColor = true;
            // 
            // saveANSI
            // 
            this.saveANSI.AutoSize = true;
            this.saveANSI.Location = new System.Drawing.Point(12, 74);
            this.saveANSI.Name = "saveANSI";
            this.saveANSI.Size = new System.Drawing.Size(144, 16);
            this.saveANSI.TabIndex = 4;
            this.saveANSI.Text = "가능하면 ANSI로 저장";
            this.saveANSI.UseVisualStyleBackColor = true;
            // 
            // encodeDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(184, 126);
            this.Controls.Add(this.saveANSI);
            this.Controls.Add(this.fallBack);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "encodeDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "인코딩 설정";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.CheckBox fallBack;
        private System.Windows.Forms.CheckBox saveANSI;
    }
}