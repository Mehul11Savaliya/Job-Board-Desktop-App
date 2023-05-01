namespace Project2
{
    partial class ScheduleDialog
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            sd_hrcontacts_phone = new TextBox();
            sd_hrcontacts_email = new TextBox();
            sd_date = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            sd_time = new DateTimePicker();
            sd_location = new TextBox();
            sd_reqrdocs = new TextBox();
            sd_hrname = new TextBox();
            sd_extradetail = new TextBox();
            schedule = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 39);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "Location : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 1;
            label2.Text = "Require Documents : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 145);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 2;
            label3.Text = "HR Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 459);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 4;
            label5.Text = "Extra Details : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sd_hrcontacts_phone);
            groupBox1.Controls.Add(sd_hrcontacts_email);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(29, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 90);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "HR Contacts";
            // 
            // sd_hrcontacts_phone
            // 
            sd_hrcontacts_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sd_hrcontacts_phone.Location = new Point(241, 33);
            sd_hrcontacts_phone.Name = "sd_hrcontacts_phone";
            sd_hrcontacts_phone.PlaceholderText = "Phone num";
            sd_hrcontacts_phone.Size = new Size(202, 34);
            sd_hrcontacts_phone.TabIndex = 12;
            // 
            // sd_hrcontacts_email
            // 
            sd_hrcontacts_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sd_hrcontacts_email.Location = new Point(22, 33);
            sd_hrcontacts_email.Name = "sd_hrcontacts_email";
            sd_hrcontacts_email.PlaceholderText = "Email";
            sd_hrcontacts_email.Size = new Size(198, 34);
            sd_hrcontacts_email.TabIndex = 11;
            // 
            // sd_date
            // 
            sd_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sd_date.Location = new Point(200, 316);
            sd_date.Name = "sd_date";
            sd_date.Size = new Size(250, 34);
            sd_date.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(106, 316);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 7;
            label4.Text = "Date :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(106, 383);
            label6.Name = "label6";
            label6.Size = new Size(68, 28);
            label6.TabIndex = 8;
            label6.Text = "Time : ";
            // 
            // sd_time
            // 
            sd_time.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sd_time.Location = new Point(200, 383);
            sd_time.Name = "sd_time";
            sd_time.Size = new Size(250, 34);
            sd_time.TabIndex = 9;
            // 
            // sd_location
            // 
            sd_location.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sd_location.Location = new Point(200, 39);
            sd_location.Name = "sd_location";
            sd_location.Size = new Size(251, 34);
            sd_location.TabIndex = 10;
            // 
            // sd_reqrdocs
            // 
            sd_reqrdocs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sd_reqrdocs.Location = new Point(200, 88);
            sd_reqrdocs.Name = "sd_reqrdocs";
            sd_reqrdocs.Size = new Size(251, 34);
            sd_reqrdocs.TabIndex = 11;
            // 
            // sd_hrname
            // 
            sd_hrname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sd_hrname.Location = new Point(200, 142);
            sd_hrname.Name = "sd_hrname";
            sd_hrname.Size = new Size(251, 34);
            sd_hrname.TabIndex = 12;
            // 
            // sd_extradetail
            // 
            sd_extradetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sd_extradetail.Location = new Point(200, 459);
            sd_extradetail.Multiline = true;
            sd_extradetail.Name = "sd_extradetail";
            sd_extradetail.Size = new Size(306, 129);
            sd_extradetail.TabIndex = 13;
            // 
            // schedule
            // 
            schedule.BackColor = Color.Chartreuse;
            schedule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            schedule.Location = new Point(51, 533);
            schedule.Name = "schedule";
            schedule.Size = new Size(104, 36);
            schedule.TabIndex = 14;
            schedule.Text = "Schedule";
            schedule.UseVisualStyleBackColor = false;
            schedule.Click += schedule_Click;
            // 
            // ScheduleDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 615);
            Controls.Add(schedule);
            Controls.Add(sd_extradetail);
            Controls.Add(sd_hrname);
            Controls.Add(sd_reqrdocs);
            Controls.Add(sd_location);
            Controls.Add(sd_time);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(sd_date);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ScheduleDialog";
            Text = "ScheduleDialog";
            FormClosed += ScheduleDialog_FormClosed;
            Load += ScheduleDialog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private GroupBox groupBox1;
        private DateTimePicker sd_date;
        private Label label4;
        private Label label6;
        private DateTimePicker sd_time;
        private TextBox sd_location;
        private TextBox sd_reqrdocs;
        private TextBox sd_hrname;
        private TextBox sd_extradetail;
        private TextBox sd_hrcontacts_phone;
        private TextBox sd_hrcontacts_email;
        private Button schedule;
    }
}