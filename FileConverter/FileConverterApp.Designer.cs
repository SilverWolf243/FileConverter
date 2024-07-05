namespace FileConverter
{
    partial class FileConverterApp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.filePathBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(397, 286);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SubmitBtn.Location = new System.Drawing.Point(415, 263);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(176, 35);
            this.SubmitBtn.TabIndex = 1;
            this.SubmitBtn.Text = "실행";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 313);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(630, 38);
            this.progressBar.TabIndex = 2;
            // 
            // filePathText
            // 
            this.filePathText.Enabled = false;
            this.filePathText.Location = new System.Drawing.Point(415, 12);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(227, 21);
            this.filePathText.TabIndex = 3;
            // 
            // filePathBtn
            // 
            this.filePathBtn.Location = new System.Drawing.Point(415, 39);
            this.filePathBtn.Name = "filePathBtn";
            this.filePathBtn.Size = new System.Drawing.Size(143, 31);
            this.filePathBtn.TabIndex = 4;
            this.filePathBtn.Text = "결과물 파일 경로 지정";
            this.filePathBtn.UseVisualStyleBackColor = true;
            this.filePathBtn.Click += new System.EventHandler(this.filePathBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(415, 76);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(210, 181);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // FileConverterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 368);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.filePathBtn);
            this.Controls.Add(this.filePathText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.listView);
            this.Name = "FileConverterApp";
            this.Text = "파일변환기_made_By 은랑";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Button filePathBtn;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

