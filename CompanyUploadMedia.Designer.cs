namespace Project2
{
    partial class CompanyUploadMedia
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
            kryptonWebBrowser1 = new Krypton.Toolkit.KryptonWebBrowser();
            SuspendLayout();
            // 
            // kryptonWebBrowser1
            // 
            kryptonWebBrowser1.Dock = DockStyle.Fill;
            kryptonWebBrowser1.Location = new Point(0, 0);
            kryptonWebBrowser1.Name = "kryptonWebBrowser1";
            kryptonWebBrowser1.Size = new Size(382, 423);
            kryptonWebBrowser1.TabIndex = 0;
            // 
            // CompanyUploadMedia
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(382, 423);
            Controls.Add(kryptonWebBrowser1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CompanyUploadMedia";
            Text = "CompanyUploadMedia";
            FormClosed += CompanyUploadMedia_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonWebBrowser kryptonWebBrowser1;
    }
}