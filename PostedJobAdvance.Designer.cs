namespace Project2
{
    partial class PostedJobAdvance
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
            pjdisc = new TextBox();
            pjttl = new Label();
            pjposter = new LinkLabel();
            pjdate = new Label();
            pjsalary = new Label();
            gender = new Label();
            pjemail = new Label();
            pjfile = new PictureBox();
            imglink = new LinkLabel();
            details = new Button();
            button2 = new Button();
            applicantsHolder = new FlowLayoutPanel();
            applicantsMeta = new Label();
            close = new Button();
            ((System.ComponentModel.ISupportInitialize)pjfile).BeginInit();
            SuspendLayout();
            // 
            // pjdisc
            // 
            pjdisc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pjdisc.Location = new Point(376, 89);
            pjdisc.Multiline = true;
            pjdisc.Name = "pjdisc";
            pjdisc.ReadOnly = true;
            pjdisc.ScrollBars = ScrollBars.Vertical;
            pjdisc.Size = new Size(486, 79);
            pjdisc.TabIndex = 18;
            pjdisc.Text = "job discription";
            // 
            // pjttl
            // 
            pjttl.AutoSize = true;
            pjttl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pjttl.Location = new Point(376, 22);
            pjttl.Name = "pjttl";
            pjttl.Size = new Size(92, 24);
            pjttl.TabIndex = 17;
            pjttl.Text = "Job Title";
            // 
            // pjposter
            // 
            pjposter.AutoSize = true;
            pjposter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pjposter.Location = new Point(938, 48);
            pjposter.Name = "pjposter";
            pjposter.Size = new Size(78, 28);
            pjposter.TabIndex = 16;
            pjposter.TabStop = true;
            pjposter.Text = "Job File";
            pjposter.LinkClicked += pjposter_LinkClicked;
            // 
            // pjdate
            // 
            pjdate.AutoSize = true;
            pjdate.ForeColor = SystemColors.WindowFrame;
            pjdate.Location = new Point(376, 56);
            pjdate.Name = "pjdate";
            pjdate.Size = new Size(52, 20);
            pjdate.TabIndex = 14;
            pjdate.Text = "Date : ";
            // 
            // pjsalary
            // 
            pjsalary.AutoSize = true;
            pjsalary.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pjsalary.Location = new Point(376, 297);
            pjsalary.Name = "pjsalary";
            pjsalary.Size = new Size(78, 25);
            pjsalary.TabIndex = 13;
            pjsalary.Text = " Salary : ";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            gender.Location = new Point(376, 242);
            gender.Name = "gender";
            gender.Size = new Size(151, 25);
            gender.TabIndex = 12;
            gender.Text = "Who Can Apply : ";
            // 
            // pjemail
            // 
            pjemail.AutoSize = true;
            pjemail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pjemail.Location = new Point(376, 188);
            pjemail.Name = "pjemail";
            pjemail.Size = new Size(68, 25);
            pjemail.TabIndex = 11;
            pjemail.Text = "Email : ";
            // 
            // pjfile
            // 
            pjfile.Location = new Point(13, 22);
            pjfile.Name = "pjfile";
            pjfile.Size = new Size(300, 300);
            pjfile.TabIndex = 10;
            pjfile.TabStop = false;
            // 
            // imglink
            // 
            imglink.AutoSize = true;
            imglink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            imglink.Location = new Point(940, 119);
            imglink.Name = "imglink";
            imglink.Size = new Size(101, 28);
            imglink.TabIndex = 19;
            imglink.TabStop = true;
            imglink.Text = "Image File";
            imglink.LinkClicked += imglink_LinkClicked;
            // 
            // details
            // 
            details.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            details.Location = new Point(938, 211);
            details.Name = "details";
            details.Size = new Size(94, 34);
            details.TabIndex = 20;
            details.Text = "Details";
            details.UseVisualStyleBackColor = true;
            details.Click += details_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(938, 282);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 21;
            button2.Text = "Schedules";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // applicantsHolder
            // 
            applicantsHolder.AutoScroll = true;
            applicantsHolder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            applicantsHolder.Location = new Point(13, 394);
            applicantsHolder.Name = "applicantsHolder";
            applicantsHolder.Size = new Size(1120, 315);
            applicantsHolder.TabIndex = 22;
            // 
            // applicantsMeta
            // 
            applicantsMeta.AutoSize = true;
            applicantsMeta.Location = new Point(36, 361);
            applicantsMeta.Name = "applicantsMeta";
            applicantsMeta.Size = new Size(79, 20);
            applicantsMeta.TabIndex = 23;
            applicantsMeta.Text = "Applicants";
            // 
            // close
            // 
            close.Location = new Point(966, 352);
            close.Name = "close";
            close.Size = new Size(66, 38);
            close.TabIndex = 24;
            close.Text = "🛩";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // PostedJobAdvance
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(close);
            Controls.Add(applicantsMeta);
            Controls.Add(applicantsHolder);
            Controls.Add(button2);
            Controls.Add(details);
            Controls.Add(imglink);
            Controls.Add(pjdisc);
            Controls.Add(pjttl);
            Controls.Add(pjposter);
            Controls.Add(pjdate);
            Controls.Add(pjsalary);
            Controls.Add(gender);
            Controls.Add(pjemail);
            Controls.Add(pjfile);
            Name = "PostedJobAdvance";
            Size = new Size(1148, 720);
            Load += PostedJobAdvance_Load;
            ((System.ComponentModel.ISupportInitialize)pjfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pjdisc;
        private Label pjttl;
        private LinkLabel pjposter;
        private Label pjdate;
        private Label pjsalary;
        private Label gender;
        private Label pjemail;
        private PictureBox pjfile;
        private LinkLabel imglink;
        private Button details;
        private Button button2;
        private FlowLayoutPanel applicantsHolder;
        private Label applicantsMeta;
        private Button close;
    }
}
