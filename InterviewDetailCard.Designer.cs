namespace Project2
{
    partial class InterviewDetailCard
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
            ttl = new Label();
            cpemail = new Label();
            cpphone = new Label();
            hr = new Label();
            hr_email = new Label();
            hr_phone = new Label();
            datetime = new Label();
            label11 = new Label();
            location = new Label();
            label10 = new Label();
            extradetails = new TextBox();
            req_doc = new TextBox();
            SuspendLayout();
            // 
            // ttl
            // 
            ttl.AutoSize = true;
            ttl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ttl.Location = new Point(21, 28);
            ttl.Name = "ttl";
            ttl.Size = new Size(91, 25);
            ttl.TabIndex = 0;
            ttl.Text = "Job Title : ";
            // 
            // cpemail
            // 
            cpemail.AutoSize = true;
            cpemail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cpemail.Location = new Point(21, 83);
            cpemail.Name = "cpemail";
            cpemail.Size = new Size(150, 25);
            cpemail.TabIndex = 1;
            cpemail.Text = "Company Email : ";
            // 
            // cpphone
            // 
            cpphone.AutoSize = true;
            cpphone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cpphone.Location = new Point(21, 138);
            cpphone.Name = "cpphone";
            cpphone.Size = new Size(158, 25);
            cpphone.TabIndex = 2;
            cpphone.Text = "Company Phone : ";
            // 
            // hr
            // 
            hr.AutoSize = true;
            hr.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            hr.Location = new Point(426, 37);
            hr.Name = "hr";
            hr.Size = new Size(102, 25);
            hr.TabIndex = 3;
            hr.Text = "HR Name : ";
            // 
            // hr_email
            // 
            hr_email.AutoSize = true;
            hr_email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            hr_email.Location = new Point(426, 84);
            hr_email.Name = "hr_email";
            hr_email.Size = new Size(97, 25);
            hr_email.TabIndex = 4;
            hr_email.Text = "HR Email : ";
            // 
            // hr_phone
            // 
            hr_phone.AutoSize = true;
            hr_phone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            hr_phone.Location = new Point(426, 133);
            hr_phone.Name = "hr_phone";
            hr_phone.Size = new Size(105, 25);
            hr_phone.TabIndex = 5;
            hr_phone.Text = "HR Phone : ";
            // 
            // datetime
            // 
            datetime.AutoSize = true;
            datetime.Location = new Point(426, 9);
            datetime.Name = "datetime";
            datetime.Size = new Size(69, 20);
            datetime.TabIndex = 6;
            datetime.Text = "datetime";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(409, 261);
            label11.Name = "label11";
            label11.Size = new Size(178, 25);
            label11.TabIndex = 7;
            label11.Text = "Required Documents";
            // 
            // location
            // 
            location.AutoSize = true;
            location.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            location.Location = new Point(21, 203);
            location.Name = "location";
            location.Size = new Size(93, 25);
            location.TabIndex = 8;
            location.Text = "Location : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 261);
            label10.Name = "label10";
            label10.Size = new Size(113, 25);
            label10.TabIndex = 9;
            label10.Text = "Extra Details ";
            // 
            // extradetails
            // 
            extradetails.Location = new Point(12, 307);
            extradetails.Multiline = true;
            extradetails.Name = "extradetails";
            extradetails.ReadOnly = true;
            extradetails.Size = new Size(341, 137);
            extradetails.TabIndex = 10;
            // 
            // req_doc
            // 
            req_doc.Location = new Point(409, 307);
            req_doc.Multiline = true;
            req_doc.Name = "req_doc";
            req_doc.ReadOnly = true;
            req_doc.Size = new Size(342, 137);
            req_doc.TabIndex = 11;
            // 
            // InterviewDetailCard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(782, 469);
            Controls.Add(req_doc);
            Controls.Add(extradetails);
            Controls.Add(label10);
            Controls.Add(location);
            Controls.Add(label11);
            Controls.Add(datetime);
            Controls.Add(hr_phone);
            Controls.Add(hr_email);
            Controls.Add(hr);
            Controls.Add(cpphone);
            Controls.Add(cpemail);
            Controls.Add(ttl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InterviewDetailCard";
            Text = "InterviewDetails";
            FormClosed += InterviewDetailCard_FormClosed;
            Load += InterviewDetailCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ttl;
        private Label cpemail;
        private Label cpphone;
        private Label hr;
        private Label hr_email;
        private Label hr_phone;
        private Label datetime;
        private Label label11;
        private Label location;
        private Label label10;
        private TextBox extradetails;
        private TextBox req_doc;
    }
}