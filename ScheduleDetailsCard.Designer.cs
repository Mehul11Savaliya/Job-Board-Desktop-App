namespace Project2
{
    partial class ScheduleDetailsCard
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
            scd_hd_hr = new Label();
            scd_hd_hr_phone = new Label();
            scd_sd_date = new Label();
            scd_sd_time = new Label();
            scd_sd_req_doc = new Label();
            scd_hd_hr_email = new Label();
            scd_sd_extradetails = new TextBox();
            groupBox1 = new GroupBox();
            scd_ad_profile = new PictureBox();
            linkLabel1 = new LinkLabel();
            scd_ad_phone = new Label();
            scd_ad_name = new Label();
            scd_ad_fullname = new Label();
            scd_ad_email = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            delete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scd_ad_profile).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // scd_hd_hr
            // 
            scd_hd_hr.AutoSize = true;
            scd_hd_hr.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            scd_hd_hr.Location = new Point(25, 43);
            scd_hd_hr.Name = "scd_hd_hr";
            scd_hd_hr.Size = new Size(102, 25);
            scd_hd_hr.TabIndex = 6;
            scd_hd_hr.Text = "HR Name : ";
            // 
            // scd_hd_hr_phone
            // 
            scd_hd_hr_phone.AutoSize = true;
            scd_hd_hr_phone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            scd_hd_hr_phone.Location = new Point(502, 43);
            scd_hd_hr_phone.Name = "scd_hd_hr_phone";
            scd_hd_hr_phone.Size = new Size(105, 25);
            scd_hd_hr_phone.TabIndex = 7;
            scd_hd_hr_phone.Text = "HR Phone : ";
            // 
            // scd_sd_date
            // 
            scd_sd_date.AutoSize = true;
            scd_sd_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scd_sd_date.Location = new Point(18, 40);
            scd_sd_date.Name = "scd_sd_date";
            scd_sd_date.Size = new Size(67, 28);
            scd_sd_date.TabIndex = 9;
            scd_sd_date.Text = "Date : ";
            // 
            // scd_sd_time
            // 
            scd_sd_time.AutoSize = true;
            scd_sd_time.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scd_sd_time.Location = new Point(206, 40);
            scd_sd_time.Name = "scd_sd_time";
            scd_sd_time.Size = new Size(68, 28);
            scd_sd_time.TabIndex = 10;
            scd_sd_time.Text = "Time : ";
            // 
            // scd_sd_req_doc
            // 
            scd_sd_req_doc.AutoSize = true;
            scd_sd_req_doc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scd_sd_req_doc.Location = new Point(421, 40);
            scd_sd_req_doc.Name = "scd_sd_req_doc";
            scd_sd_req_doc.Size = new Size(140, 28);
            scd_sd_req_doc.TabIndex = 11;
            scd_sd_req_doc.Text = "Require Docs : ";
            // 
            // scd_hd_hr_email
            // 
            scd_hd_hr_email.AutoSize = true;
            scd_hd_hr_email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            scd_hd_hr_email.Location = new Point(294, 43);
            scd_hd_hr_email.Name = "scd_hd_hr_email";
            scd_hd_hr_email.Size = new Size(92, 25);
            scd_hd_hr_email.TabIndex = 14;
            scd_hd_hr_email.Text = "HR Email :";
            // 
            // scd_sd_extradetails
            // 
            scd_sd_extradetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scd_sd_extradetails.Location = new Point(37, 93);
            scd_sd_extradetails.Multiline = true;
            scd_sd_extradetails.Name = "scd_sd_extradetails";
            scd_sd_extradetails.ReadOnly = true;
            scd_sd_extradetails.Size = new Size(648, 113);
            scd_sd_extradetails.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(scd_ad_profile);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(scd_ad_phone);
            groupBox1.Controls.Add(scd_ad_name);
            groupBox1.Controls.Add(scd_ad_fullname);
            groupBox1.Controls.Add(scd_ad_email);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(754, 99);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Applicants Details";
            // 
            // scd_ad_profile
            // 
            scd_ad_profile.Location = new Point(7, 33);
            scd_ad_profile.Name = "scd_ad_profile";
            scd_ad_profile.Size = new Size(70, 60);
            scd_ad_profile.TabIndex = 13;
            scd_ad_profile.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(663, 51);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(74, 25);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Resume";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // scd_ad_phone
            // 
            scd_ad_phone.AutoSize = true;
            scd_ad_phone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            scd_ad_phone.Location = new Point(492, 51);
            scd_ad_phone.Name = "scd_ad_phone";
            scd_ad_phone.Size = new Size(76, 25);
            scd_ad_phone.TabIndex = 10;
            scd_ad_phone.Text = "Phone : ";
            // 
            // scd_ad_name
            // 
            scd_ad_name.AutoSize = true;
            scd_ad_name.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            scd_ad_name.Location = new Point(96, 51);
            scd_ad_name.Name = "scd_ad_name";
            scd_ad_name.Size = new Size(73, 25);
            scd_ad_name.TabIndex = 6;
            scd_ad_name.Text = "Name : ";
            // 
            // scd_ad_fullname
            // 
            scd_ad_fullname.AutoSize = true;
            scd_ad_fullname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            scd_ad_fullname.Location = new Point(175, 51);
            scd_ad_fullname.Name = "scd_ad_fullname";
            scd_ad_fullname.Size = new Size(106, 25);
            scd_ad_fullname.TabIndex = 7;
            scd_ad_fullname.Text = "Name Value";
            // 
            // scd_ad_email
            // 
            scd_ad_email.AutoSize = true;
            scd_ad_email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            scd_ad_email.Location = new Point(318, 51);
            scd_ad_email.Name = "scd_ad_email";
            scd_ad_email.Size = new Size(68, 25);
            scd_ad_email.TabIndex = 8;
            scd_ad_email.Text = "Email : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(scd_hd_hr);
            groupBox2.Controls.Add(scd_hd_hr_email);
            groupBox2.Controls.Add(scd_hd_hr_phone);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(754, 99);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "HR/Interviewer Details";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(scd_sd_date);
            groupBox3.Controls.Add(scd_sd_time);
            groupBox3.Controls.Add(scd_sd_req_doc);
            groupBox3.Controls.Add(scd_sd_extradetails);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(31, 241);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(730, 217);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Schedule Details";
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(654, 453);
            delete.Name = "delete";
            delete.Size = new Size(94, 40);
            delete.TabIndex = 19;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // ScheduleDetailsCard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(delete);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ScheduleDetailsCard";
            Size = new Size(800, 498);
            Load += ScheduleDetailsCard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scd_ad_profile).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label scd_hd_hr;
        private Label scd_hd_hr_phone;
        private Label scd_sd_date;
        private Label scd_sd_time;
        private Label scd_sd_req_doc;
        private Label scd_hd_hr_email;
        private TextBox scd_sd_extradetails;
        private GroupBox groupBox1;
        private Label scd_ad_phone;
        private Label scd_ad_email;
        private Label scd_ad_fullname;
        private Label scd_ad_name;
        private PictureBox scd_ad_profile;
        private LinkLabel linkLabel1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button delete;
    }
}
