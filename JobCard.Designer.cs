namespace Project2
{
    partial class JobCard
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
            this.title = new MaterialSkin.Controls.MaterialLabel();
            this.pjcpname = new MaterialSkin.Controls.MaterialLabel();
            this.email = new MaterialSkin.Controls.MaterialLabel();
            this.salary = new MaterialSkin.Controls.MaterialLabel();
            this.gender = new MaterialSkin.Controls.MaterialLabel();
            this.pjposter = new System.Windows.Forms.LinkLabel();
            this.pjfile = new System.Windows.Forms.PictureBox();
            this.disc = new MaterialSkin.Controls.MaterialLabel();
            this.ttl2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pjfile)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Depth = 0;
            this.title.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.MouseState = MaterialSkin.MouseState.HOVER;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1, 0);
            this.title.TabIndex = 0;
            // 
            // pjcpname
            // 
            this.pjcpname.AutoSize = true;
            this.pjcpname.Depth = 0;
            this.pjcpname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pjcpname.Location = new System.Drawing.Point(15, 324);
            this.pjcpname.MouseState = MaterialSkin.MouseState.HOVER;
            this.pjcpname.Name = "pjcpname";
            this.pjcpname.Size = new System.Drawing.Size(58, 19);
            this.pjcpname.TabIndex = 1;
            this.pjcpname.Text = "cpname";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Depth = 0;
            this.email.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.email.Location = new System.Drawing.Point(15, 358);
            this.email.MouseState = MaterialSkin.MouseState.HOVER;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(40, 19);
            this.email.TabIndex = 2;
            this.email.Text = "email";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Depth = 0;
            this.salary.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.salary.Location = new System.Drawing.Point(15, 397);
            this.salary.MouseState = MaterialSkin.MouseState.HOVER;
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(44, 19);
            this.salary.TabIndex = 3;
            this.salary.Text = "salary";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Depth = 0;
            this.gender.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gender.Location = new System.Drawing.Point(15, 437);
            this.gender.MouseState = MaterialSkin.MouseState.HOVER;
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(49, 19);
            this.gender.TabIndex = 5;
            this.gender.Text = "gender";
            // 
            // pjposter
            // 
            this.pjposter.AutoSize = true;
            this.pjposter.Location = new System.Drawing.Point(15, 505);
            this.pjposter.Name = "pjposter";
            this.pjposter.Size = new System.Drawing.Size(135, 20);
            this.pjposter.TabIndex = 6;
            this.pjposter.TabStop = true;
            this.pjposter.Text = "Job Discription File";
            this.pjposter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pjposter_LinkClicked);
            // 
            // pjfile
            // 
            this.pjfile.ImageLocation = "";
            this.pjfile.Location = new System.Drawing.Point(3, 37);
            this.pjfile.Name = "pjfile";
            this.pjfile.Size = new System.Drawing.Size(424, 255);
            this.pjfile.TabIndex = 7;
            this.pjfile.TabStop = false;
            // 
            // disc
            // 
            this.disc.AutoSize = true;
            this.disc.Depth = 0;
            this.disc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.disc.Location = new System.Drawing.Point(15, 476);
            this.disc.MouseState = MaterialSkin.MouseState.HOVER;
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(43, 19);
            this.disc.TabIndex = 8;
            this.disc.Text = "pjdisc";
            // 
            // ttl2
            // 
            this.ttl2.AutoSize = true;
            this.ttl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ttl2.Location = new System.Drawing.Point(8, 6);
            this.ttl2.Name = "ttl2";
            this.ttl2.Size = new System.Drawing.Size(70, 28);
            this.ttl2.TabIndex = 9;
            this.ttl2.Text = "label1";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(14, 540);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(39, 20);
            this.date.TabIndex = 10;
            this.date.Text = "date";
            // 
            // JobCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.date);
            this.Controls.Add(this.ttl2);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.pjfile);
            this.Controls.Add(this.pjposter);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pjcpname);
            this.Controls.Add(this.title);
            this.Name = "JobCard";
            this.Size = new System.Drawing.Size(428, 568);
            this.Load += new System.EventHandler(this.JobCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pjfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel title;
        private MaterialSkin.Controls.MaterialLabel pjcpname;
        private MaterialSkin.Controls.MaterialLabel email;
        private MaterialSkin.Controls.MaterialLabel salary;
        private MaterialSkin.Controls.MaterialLabel gender;
        private LinkLabel pjposter;
        private PictureBox pjfile;
        private MaterialSkin.Controls.MaterialLabel disc;
        private Label ttl2;
        private Label date;
    }
}
