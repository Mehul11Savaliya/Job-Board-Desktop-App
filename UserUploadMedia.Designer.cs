namespace Project2
{
    partial class UserUploadMedia
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
            submit = new Button();
            resume = new TextBox();
            photo = new TextBox();
            selectfile = new OpenFileDialog();
            kryptonWebBrowser1 = new Krypton.Toolkit.KryptonWebBrowser();
            SuspendLayout();
            // 
            // submit
            // 
            submit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            submit.Location = new Point(121, 227);
            submit.Name = "submit";
            submit.Size = new Size(94, 36);
            submit.TabIndex = 2;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // resume
            // 
            resume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resume.Location = new Point(26, 30);
            resume.Name = "resume";
            resume.PlaceholderText = "Select Resume";
            resume.ReadOnly = true;
            resume.ScrollBars = ScrollBars.Horizontal;
            resume.Size = new Size(295, 34);
            resume.TabIndex = 3;
            resume.Click += resume_Click;
            // 
            // photo
            // 
            photo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            photo.Location = new Point(26, 123);
            photo.Name = "photo";
            photo.PlaceholderText = "Select Photo";
            photo.ReadOnly = true;
            photo.ScrollBars = ScrollBars.Horizontal;
            photo.Size = new Size(295, 34);
            photo.TabIndex = 4;
            photo.Click += photo_Click;
            // 
            // selectfile
            // 
            selectfile.FileName = "openFileDialog1";
            // 
            // kryptonWebBrowser1
            // 
            kryptonWebBrowser1.Location = new Point(1, 1);
            kryptonWebBrowser1.Name = "kryptonWebBrowser1";
            kryptonWebBrowser1.Size = new Size(351, 299);
            kryptonWebBrowser1.TabIndex = 5;
            // 
            // UserUploadMedia
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(352, 300);
            Controls.Add(kryptonWebBrowser1);
            Controls.Add(photo);
            Controls.Add(resume);
            Controls.Add(submit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserUploadMedia";
            ShowInTaskbar = false;
            Text = "UserUploadMedia";
            FormClosed += UserUploadMedia_FormClosed;
            Load += UserUploadMedia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button submit;
        private TextBox resume;
        private TextBox photo;
        private OpenFileDialog selectfile;
        private Krypton.Toolkit.KryptonWebBrowser kryptonWebBrowser1;
    }
}