namespace Project2
{
    partial class ApplicantsCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            profile = new PictureBox();
            fnamelname = new Label();
            email = new Label();
            phone = new Label();
            resume = new LinkLabel();
            message = new Button();
            accept = new Button();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            SuspendLayout();
            // 
            // profile
            // 
            profile.Location = new Point(28, 17);
            profile.Name = "profile";
            profile.Size = new Size(258, 228);
            profile.TabIndex = 0;
            profile.TabStop = false;
            // 
            // fnamelname
            // 
            fnamelname.AutoSize = true;
            fnamelname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fnamelname.Location = new Point(28, 270);
            fnamelname.Name = "fnamelname";
            fnamelname.Size = new Size(108, 28);
            fnamelname.TabIndex = 1;
            fnamelname.Text = "Full Name";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(28, 320);
            email.Name = "email";
            email.Size = new Size(73, 28);
            email.TabIndex = 2;
            email.Text = "Email : ";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(28, 372);
            phone.Name = "phone";
            phone.Size = new Size(81, 28);
            phone.TabIndex = 3;
            phone.Text = "Phone : ";
            // 
            // resume
            // 
            resume.AutoSize = true;
            resume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resume.Location = new Point(28, 413);
            resume.Name = "resume";
            resume.Size = new Size(114, 28);
            resume.TabIndex = 4;
            resume.TabStop = true;
            resume.Text = "Resume File";
            resume.LinkClicked += resume_LinkClicked;
            // 
            // message
            // 
            message.Location = new Point(41, 448);
            message.Name = "message";
            message.Size = new Size(94, 40);
            message.TabIndex = 5;
            message.Text = "Message";
            message.UseVisualStyleBackColor = true;
            // 
            // accept
            // 
            accept.Location = new Point(172, 448);
            accept.Name = "accept";
            accept.Size = new Size(94, 40);
            accept.TabIndex = 6;
            accept.Text = "Accept";
            accept.UseVisualStyleBackColor = true;
            accept.Click += accept_Click;
            // 
            // ApplicantsCard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(accept);
            Controls.Add(message);
            Controls.Add(resume);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(fnamelname);
            Controls.Add(profile);
            Name = "ApplicantsCard";
            Size = new Size(315, 510);
            Load += ApplicantsCard_Load;
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox profile;
        private Label fnamelname;
        private Label email;
        private Label phone;
        private LinkLabel resume;
        private Button message;
        private Button accept;
    }
}
