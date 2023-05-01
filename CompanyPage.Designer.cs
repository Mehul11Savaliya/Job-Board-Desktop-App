namespace Project2
{
    partial class CompanyPage
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
            tabcntrl = new TabControl();
            tab_postjob = new TabPage();
            refresh = new Button();
            postedJobHolder = new FlowLayoutPanel();
            cp_tbp1_postjob = new Button();
            tab_postedjob = new TabPage();
            refresh1 = new Button();
            advancePostedJobHolder = new FlowLayoutPanel();
            tab_schedule = new TabPage();
            refreshSchedule = new Button();
            schedulesHolder = new FlowLayoutPanel();
            tab_profile = new TabPage();
            cp_addr = new TextBox();
            cp_website = new LinkLabel();
            cp_profile = new PictureBox();
            cp_phone = new Label();
            cp_email = new Label();
            cp_size = new Label();
            label5 = new Label();
            cp_lname = new Label();
            cp_fname = new Label();
            cp_name = new Label();
            uimg = new Button();
            tabcntrl.SuspendLayout();
            tab_postjob.SuspendLayout();
            tab_postedjob.SuspendLayout();
            tab_schedule.SuspendLayout();
            tab_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cp_profile).BeginInit();
            SuspendLayout();
            // 
            // tabcntrl
            // 
            tabcntrl.Controls.Add(tab_postjob);
            tabcntrl.Controls.Add(tab_postedjob);
            tabcntrl.Controls.Add(tab_schedule);
            tabcntrl.Controls.Add(tab_profile);
            tabcntrl.Dock = DockStyle.Fill;
            tabcntrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabcntrl.Location = new Point(0, 0);
            tabcntrl.Name = "tabcntrl";
            tabcntrl.SelectedIndex = 0;
            tabcntrl.Size = new Size(1236, 833);
            tabcntrl.TabIndex = 0;
            // 
            // tab_postjob
            // 
            tab_postjob.Controls.Add(refresh);
            tab_postjob.Controls.Add(postedJobHolder);
            tab_postjob.Controls.Add(cp_tbp1_postjob);
            tab_postjob.Location = new Point(4, 37);
            tab_postjob.Name = "tab_postjob";
            tab_postjob.Padding = new Padding(3);
            tab_postjob.Size = new Size(1228, 792);
            tab_postjob.TabIndex = 0;
            tab_postjob.Text = "Post Job";
            tab_postjob.UseVisualStyleBackColor = true;
            tab_postjob.Enter += tab_postjob_Enter;
            // 
            // refresh
            // 
            refresh.Location = new Point(703, 17);
            refresh.Name = "refresh";
            refresh.Size = new Size(120, 36);
            refresh.TabIndex = 2;
            refresh.Text = "Refresh 🎡";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // postedJobHolder
            // 
            postedJobHolder.AutoScroll = true;
            postedJobHolder.Location = new Point(29, 76);
            postedJobHolder.Name = "postedJobHolder";
            postedJobHolder.Size = new Size(850, 690);
            postedJobHolder.TabIndex = 1;
            // 
            // cp_tbp1_postjob
            // 
            cp_tbp1_postjob.BackColor = Color.FromArgb(0, 192, 0);
            cp_tbp1_postjob.Location = new Point(532, 6);
            cp_tbp1_postjob.Name = "cp_tbp1_postjob";
            cp_tbp1_postjob.Size = new Size(94, 40);
            cp_tbp1_postjob.TabIndex = 0;
            cp_tbp1_postjob.Text = "Post Job";
            cp_tbp1_postjob.UseVisualStyleBackColor = false;
            cp_tbp1_postjob.Click += cp_tbp1_postjob_Click;
            // 
            // tab_postedjob
            // 
            tab_postedjob.Controls.Add(refresh1);
            tab_postedjob.Controls.Add(advancePostedJobHolder);
            tab_postedjob.Location = new Point(4, 37);
            tab_postedjob.Name = "tab_postedjob";
            tab_postedjob.Padding = new Padding(3);
            tab_postedjob.Size = new Size(1228, 792);
            tab_postedjob.TabIndex = 1;
            tab_postedjob.Text = "Posted Job";
            tab_postedjob.UseVisualStyleBackColor = true;
            tab_postedjob.Enter += tab_postedjob_Enter;
            // 
            // refresh1
            // 
            refresh1.Location = new Point(1014, 6);
            refresh1.Name = "refresh1";
            refresh1.Size = new Size(126, 41);
            refresh1.TabIndex = 1;
            refresh1.Text = "Refresh 🎡";
            refresh1.UseVisualStyleBackColor = true;
            refresh1.Click += refresh1_Click;
            // 
            // advancePostedJobHolder
            // 
            advancePostedJobHolder.AutoScroll = true;
            advancePostedJobHolder.Location = new Point(40, 53);
            advancePostedJobHolder.Name = "advancePostedJobHolder";
            advancePostedJobHolder.Size = new Size(1150, 715);
            advancePostedJobHolder.TabIndex = 0;
            // 
            // tab_schedule
            // 
            tab_schedule.Controls.Add(refreshSchedule);
            tab_schedule.Controls.Add(schedulesHolder);
            tab_schedule.Location = new Point(4, 37);
            tab_schedule.Name = "tab_schedule";
            tab_schedule.Padding = new Padding(3);
            tab_schedule.Size = new Size(1228, 792);
            tab_schedule.TabIndex = 2;
            tab_schedule.Text = "Schedules";
            tab_schedule.UseVisualStyleBackColor = true;
            tab_schedule.Enter += tab_schedule_Enter;
            // 
            // refreshSchedule
            // 
            refreshSchedule.Location = new Point(963, 6);
            refreshSchedule.Name = "refreshSchedule";
            refreshSchedule.Size = new Size(118, 40);
            refreshSchedule.TabIndex = 1;
            refreshSchedule.Text = "Refresh 🎡";
            refreshSchedule.UseVisualStyleBackColor = true;
            refreshSchedule.Click += refreshSchedule_Click;
            // 
            // schedulesHolder
            // 
            schedulesHolder.AutoScroll = true;
            schedulesHolder.Location = new Point(26, 24);
            schedulesHolder.Name = "schedulesHolder";
            schedulesHolder.Padding = new Padding(2);
            schedulesHolder.Size = new Size(810, 745);
            schedulesHolder.TabIndex = 0;
            // 
            // tab_profile
            // 
            tab_profile.Controls.Add(uimg);
            tab_profile.Controls.Add(cp_addr);
            tab_profile.Controls.Add(cp_website);
            tab_profile.Controls.Add(cp_profile);
            tab_profile.Controls.Add(cp_phone);
            tab_profile.Controls.Add(cp_email);
            tab_profile.Controls.Add(cp_size);
            tab_profile.Controls.Add(label5);
            tab_profile.Controls.Add(cp_lname);
            tab_profile.Controls.Add(cp_fname);
            tab_profile.Controls.Add(cp_name);
            tab_profile.Location = new Point(4, 37);
            tab_profile.Name = "tab_profile";
            tab_profile.Padding = new Padding(3);
            tab_profile.Size = new Size(1228, 792);
            tab_profile.TabIndex = 3;
            tab_profile.Text = "Profile";
            tab_profile.UseVisualStyleBackColor = true;
            tab_profile.Enter += tab_profile_Enter;
            // 
            // cp_addr
            // 
            cp_addr.Location = new Point(179, 295);
            cp_addr.Multiline = true;
            cp_addr.Name = "cp_addr";
            cp_addr.ReadOnly = true;
            cp_addr.Size = new Size(285, 124);
            cp_addr.TabIndex = 10;
            // 
            // cp_website
            // 
            cp_website.AutoSize = true;
            cp_website.Location = new Point(53, 237);
            cp_website.Name = "cp_website";
            cp_website.Size = new Size(171, 28);
            cp_website.TabIndex = 9;
            cp_website.TabStop = true;
            cp_website.Text = "Company Website";
            cp_website.LinkClicked += cp_website_LinkClicked;
            // 
            // cp_profile
            // 
            cp_profile.Location = new Point(660, 43);
            cp_profile.Name = "cp_profile";
            cp_profile.Size = new Size(230, 160);
            cp_profile.TabIndex = 8;
            cp_profile.TabStop = false;
            // 
            // cp_phone
            // 
            cp_phone.AutoSize = true;
            cp_phone.Location = new Point(53, 586);
            cp_phone.Name = "cp_phone";
            cp_phone.Size = new Size(81, 28);
            cp_phone.TabIndex = 7;
            cp_phone.Text = "Phone : ";
            // 
            // cp_email
            // 
            cp_email.AutoSize = true;
            cp_email.Location = new Point(53, 515);
            cp_email.Name = "cp_email";
            cp_email.Size = new Size(73, 28);
            cp_email.TabIndex = 6;
            cp_email.Text = "Email : ";
            // 
            // cp_size
            // 
            cp_size.AutoSize = true;
            cp_size.Location = new Point(53, 453);
            cp_size.Name = "cp_size";
            cp_size.Size = new Size(150, 28);
            cp_size.TabIndex = 5;
            cp_size.Text = "Company Size : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 295);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 4;
            label5.Text = "Address : ";
            // 
            // cp_lname
            // 
            cp_lname.AutoSize = true;
            cp_lname.Location = new Point(53, 174);
            cp_lname.Name = "cp_lname";
            cp_lname.Size = new Size(117, 28);
            cp_lname.TabIndex = 2;
            cp_lname.Text = "Last Name : ";
            // 
            // cp_fname
            // 
            cp_fname.AutoSize = true;
            cp_fname.Location = new Point(53, 111);
            cp_fname.Name = "cp_fname";
            cp_fname.Size = new Size(120, 28);
            cp_fname.TabIndex = 1;
            cp_fname.Text = "First Name : ";
            // 
            // cp_name
            // 
            cp_name.AutoSize = true;
            cp_name.Location = new Point(53, 43);
            cp_name.Name = "cp_name";
            cp_name.Size = new Size(167, 28);
            cp_name.TabIndex = 0;
            cp_name.Text = "Company Name : ";
            // 
            // uimg
            // 
            uimg.Location = new Point(704, 259);
            uimg.Name = "uimg";
            uimg.Size = new Size(94, 36);
            uimg.TabIndex = 11;
            uimg.Text = "Update Image";
            uimg.UseVisualStyleBackColor = true;
            uimg.Click += uimg_Click;
            // 
            // CompanyPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 833);
            Controls.Add(tabcntrl);
            Name = "CompanyPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompanyPage";
            FormClosed += CompanyPage_FormClosed;
            Load += CompanyPage_Load;
            tabcntrl.ResumeLayout(false);
            tab_postjob.ResumeLayout(false);
            tab_postedjob.ResumeLayout(false);
            tab_schedule.ResumeLayout(false);
            tab_profile.ResumeLayout(false);
            tab_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cp_profile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcntrl;
        private TabPage tab_postjob;
        private TabPage tab_postedjob;
        private TabPage tab_schedule;
        private TabPage tab_profile;
        private PictureBox cp_profile;
        private Label cp_phone;
        private Label cp_email;
        private Label cp_size;
        private Label label5;
        private Label cp_lname;
        private Label cp_fname;
        private Label cp_name;
        private TextBox cp_addr;
        private LinkLabel cp_website;
        private Button cp_tbp1_postjob;
        private FlowLayoutPanel postedJobHolder;
        private Button refresh;
        private FlowLayoutPanel advancePostedJobHolder;
        private Button refresh1;
        private FlowLayoutPanel schedulesHolder;
        private Button refreshSchedule;
        private Button uimg;
    }
}