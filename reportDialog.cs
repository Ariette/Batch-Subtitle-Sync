using System.Windows.Forms;

namespace BatchSubtitleSync
{
    public class reportDialog : Form
    {
        public reportDialog()
        {
            InitializeComponent();
        }

        public reportDialog(string reportText, string reportTitle = "Report Viewer")
        {
            InitializeComponent();
            txtReportContents.Text = reportText;
            Text = reportTitle;
        }

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
            this.txtReportContents = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReportContents
            // 
            this.txtReportContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportContents.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtReportContents.Location = new System.Drawing.Point(15, 12);
            this.txtReportContents.Multiline = true;
            this.txtReportContents.Name = "txtReportContents";
            this.txtReportContents.ReadOnly = true;
            this.txtReportContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReportContents.Size = new System.Drawing.Size(373, 169);
            this.txtReportContents.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(313, 187);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "확인";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // reportDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 214);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.txtReportContents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reportDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Viewer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtReportContents;
        private Button okButton;
    }
}
