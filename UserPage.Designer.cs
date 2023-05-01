namespace Project2
{
    partial class UserPage
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            apply = new Button();
            refresh = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            jdiscr = new TextBox();
            jgender = new TextBox();
            jsalary = new TextBox();
            jposition = new TextBox();
            jemail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            cname = new TextBox();
            jfile = new Button();
            search = new Button();
            textBox1 = new TextBox();
            jobs = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            refshappliedjob = new Button();
            appliedjobs = new FlowLayoutPanel();
            tabPage3 = new TabPage();
            receivedjobholder = new FlowLayoutPanel();
            schedulepanel = new TableLayoutPanel();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            tabPage4 = new TabPage();
            linkLabel1 = new LinkLabel();
            profile = new PictureBox();
            rupload = new MaterialSkin.Controls.MaterialButton();
            resume = new Label();
            pass = new Label();
            phone = new Label();
            email = new Label();
            lname = new Label();
            fname = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            schedulepanel.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(6, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1220, 803);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(apply);
            tabPage1.Controls.Add(refresh);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(search);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(jobs);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1212, 762);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Find Job";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // apply
            // 
            apply.Location = new Point(732, 701);
            apply.Name = "apply";
            apply.Size = new Size(94, 46);
            apply.TabIndex = 5;
            apply.Text = "Apply";
            apply.UseVisualStyleBackColor = true;
            apply.Click += apply_Click;
            // 
            // refresh
            // 
            refresh.Location = new Point(926, 27);
            refresh.Name = "refresh";
            refresh.Size = new Size(143, 40);
            refresh.TabIndex = 4;
            refresh.Text = "Refresh 🌌";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(jdiscr, 2, 6);
            tableLayoutPanel1.Controls.Add(jgender, 2, 5);
            tableLayoutPanel1.Controls.Add(jsalary, 2, 4);
            tableLayoutPanel1.Controls.Add(jposition, 2, 3);
            tableLayoutPanel1.Controls.Add(jemail, 2, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 6);
            tableLayoutPanel1.Controls.Add(label10, 0, 7);
            tableLayoutPanel1.Controls.Add(label11, 1, 1);
            tableLayoutPanel1.Controls.Add(label12, 1, 2);
            tableLayoutPanel1.Controls.Add(label13, 1, 3);
            tableLayoutPanel1.Controls.Add(label14, 1, 4);
            tableLayoutPanel1.Controls.Add(label15, 1, 5);
            tableLayoutPanel1.Controls.Add(label16, 1, 6);
            tableLayoutPanel1.Controls.Add(label17, 1, 7);
            tableLayoutPanel1.Controls.Add(cname, 2, 1);
            tableLayoutPanel1.Controls.Add(jfile, 2, 7);
            tableLayoutPanel1.Location = new Point(502, 85);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 215F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.Size = new Size(677, 601);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // jdiscr
            // 
            jdiscr.Anchor = AnchorStyles.None;
            jdiscr.Font = new Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            jdiscr.Location = new Point(244, 337);
            jdiscr.Multiline = true;
            jdiscr.Name = "jdiscr";
            jdiscr.Size = new Size(424, 200);
            jdiscr.TabIndex = 22;
            // 
            // jgender
            // 
            jgender.Anchor = AnchorStyles.None;
            jgender.Font = new Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            jgender.Location = new Point(244, 284);
            jgender.Name = "jgender";
            jgender.Size = new Size(424, 37);
            jgender.TabIndex = 21;
            // 
            // jsalary
            // 
            jsalary.Anchor = AnchorStyles.None;
            jsalary.Font = new Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            jsalary.Location = new Point(244, 229);
            jsalary.Name = "jsalary";
            jsalary.Size = new Size(424, 37);
            jsalary.TabIndex = 20;
            // 
            // jposition
            // 
            jposition.Anchor = AnchorStyles.None;
            jposition.Font = new Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            jposition.Location = new Point(244, 174);
            jposition.Name = "jposition";
            jposition.Size = new Size(424, 37);
            jposition.TabIndex = 19;
            // 
            // jemail
            // 
            jemail.Anchor = AnchorStyles.None;
            jemail.Font = new Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            jemail.Location = new Point(244, 119);
            jemail.Name = "jemail";
            jemail.Size = new Size(424, 37);
            jemail.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(27, 41);
            label1.TabIndex = 0;
            label1.Text = "#";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(97, 7);
            label2.Name = "label2";
            label2.Size = new Size(74, 41);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(411, 7);
            label3.Name = "label3";
            label3.Size = new Size(90, 41);
            label3.TabIndex = 2;
            label3.Text = "Value";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(5, 68);
            label4.Name = "label4";
            label4.Size = new Size(23, 28);
            label4.TabIndex = 3;
            label4.Text = "1";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(5, 123);
            label5.Name = "label5";
            label5.Size = new Size(23, 28);
            label5.TabIndex = 4;
            label5.Text = "2";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(5, 178);
            label6.Name = "label6";
            label6.Size = new Size(23, 28);
            label6.TabIndex = 5;
            label6.Text = "3";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(5, 233);
            label7.Name = "label7";
            label7.Size = new Size(23, 28);
            label7.TabIndex = 6;
            label7.Text = "4";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(5, 288);
            label8.Name = "label8";
            label8.Size = new Size(23, 28);
            label8.TabIndex = 7;
            label8.Text = "5";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(5, 423);
            label9.Name = "label9";
            label9.Size = new Size(23, 28);
            label9.TabIndex = 8;
            label9.Text = "6";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(5, 559);
            label10.Name = "label10";
            label10.Size = new Size(23, 28);
            label10.TabIndex = 9;
            label10.Text = "7";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(49, 67);
            label11.Name = "label11";
            label11.Size = new Size(170, 30);
            label11.TabIndex = 10;
            label11.Text = "Company Name";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(102, 122);
            label12.Name = "label12";
            label12.Size = new Size(64, 30);
            label12.TabIndex = 11;
            label12.Text = "Email";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(70, 177);
            label13.Name = "label13";
            label13.Size = new Size(128, 30);
            label13.TabIndex = 12;
            label13.Text = "Job Position";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(99, 232);
            label14.Name = "label14";
            label14.Size = new Size(71, 30);
            label14.TabIndex = 13;
            label14.Text = "Salary";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(44, 287);
            label15.Name = "label15";
            label15.Size = new Size(181, 30);
            label15.TabIndex = 14;
            label15.Text = "Who Can Apply : ";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(77, 422);
            label16.Name = "label16";
            label16.Size = new Size(115, 30);
            label16.TabIndex = 15;
            label16.Text = "Discription";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(37, 558);
            label17.Name = "label17";
            label17.Size = new Size(194, 30);
            label17.TabIndex = 16;
            label17.Text = "Job Discription File";
            // 
            // cname
            // 
            cname.Anchor = AnchorStyles.None;
            cname.Font = new Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            cname.Location = new Point(244, 64);
            cname.Name = "cname";
            cname.Size = new Size(424, 37);
            cname.TabIndex = 17;
            // 
            // jfile
            // 
            jfile.Anchor = AnchorStyles.None;
            jfile.Font = new Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            jfile.Location = new Point(409, 551);
            jfile.Name = "jfile";
            jfile.Size = new Size(94, 43);
            jfile.TabIndex = 23;
            jfile.Text = "Open";
            jfile.UseVisualStyleBackColor = true;
            jfile.Click += jfile_Click;
            // 
            // search
            // 
            search.Location = new Point(681, 27);
            search.Name = "search";
            search.Size = new Size(94, 34);
            search.TabIndex = 2;
            search.Text = "🔍";
            search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 34);
            textBox1.TabIndex = 1;
            // 
            // jobs
            // 
            jobs.AutoScroll = true;
            jobs.AutoScrollMargin = new Size(0, 5);
            jobs.Location = new Point(6, 76);
            jobs.Name = "jobs";
            jobs.Size = new Size(430, 680);
            jobs.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(refshappliedjob);
            tabPage2.Controls.Add(appliedjobs);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1212, 762);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Applied Job";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Enter += tabPage2_Enter;
            // 
            // refshappliedjob
            // 
            refshappliedjob.Location = new Point(941, 6);
            refshappliedjob.Name = "refshappliedjob";
            refshappliedjob.Size = new Size(143, 40);
            refshappliedjob.TabIndex = 5;
            refshappliedjob.Text = "Refresh 🌌";
            refshappliedjob.UseVisualStyleBackColor = true;
            refshappliedjob.Click += refshappliedjob_Click;
            // 
            // appliedjobs
            // 
            appliedjobs.AutoScroll = true;
            appliedjobs.Location = new Point(6, 56);
            appliedjobs.Name = "appliedjobs";
            appliedjobs.Padding = new Padding(25, 0, 25, 0);
            appliedjobs.Size = new Size(1200, 684);
            appliedjobs.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(receivedjobholder);
            tabPage3.Controls.Add(schedulepanel);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1212, 762);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Received job";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Enter += tabPage3_Enter;
            // 
            // receivedjobholder
            // 
            receivedjobholder.Location = new Point(33, 676);
            receivedjobholder.Name = "receivedjobholder";
            receivedjobholder.Padding = new Padding(10);
            receivedjobholder.Size = new Size(1150, 70);
            receivedjobholder.TabIndex = 1;
            // 
            // schedulepanel
            // 
            schedulepanel.AutoScroll = true;
            schedulepanel.ColumnCount = 7;
            schedulepanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            schedulepanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            schedulepanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            schedulepanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));
            schedulepanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            schedulepanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            schedulepanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            schedulepanel.Controls.Add(label24, 6, 0);
            schedulepanel.Controls.Add(label23, 5, 0);
            schedulepanel.Controls.Add(label22, 4, 0);
            schedulepanel.Controls.Add(label21, 3, 0);
            schedulepanel.Controls.Add(label20, 2, 0);
            schedulepanel.Controls.Add(label19, 1, 0);
            schedulepanel.Controls.Add(label18, 0, 0);
            schedulepanel.Location = new Point(33, 15);
            schedulepanel.Name = "schedulepanel";
            schedulepanel.RowCount = 1;
            schedulepanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            schedulepanel.Size = new Size(1150, 741);
            schedulepanel.TabIndex = 0;
            schedulepanel.Paint += tableLayoutPanel2_Paint;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.Location = new Point(1050, 0);
            label24.Name = "label24";
            label24.Size = new Size(96, 56);
            label24.TabIndex = 7;
            label24.Text = "Interview Schedule";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Location = new Point(937, 0);
            label23.Name = "label23";
            label23.Size = new Size(82, 28);
            label23.TabIndex = 6;
            label23.Text = "Website";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Location = new Point(797, 0);
            label22.Name = "label22";
            label22.Size = new Size(82, 28);
            label22.TabIndex = 5;
            label22.Text = "Position";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Location = new Point(606, 0);
            label21.Name = "label21";
            label21.Size = new Size(82, 28);
            label21.TabIndex = 4;
            label21.Text = "Address";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Location = new Point(375, 0);
            label20.Name = "label20";
            label20.Size = new Size(59, 28);
            label20.TabIndex = 3;
            label20.Text = "Email";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Location = new Point(80, 0);
            label19.Name = "label19";
            label19.Size = new Size(153, 28);
            label19.TabIndex = 2;
            label19.Text = "Company Name";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Location = new Point(4, 0);
            label18.Name = "label18";
            label18.Size = new Size(24, 28);
            label18.TabIndex = 0;
            label18.Text = "#";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(linkLabel1);
            tabPage4.Controls.Add(profile);
            tabPage4.Controls.Add(rupload);
            tabPage4.Controls.Add(resume);
            tabPage4.Controls.Add(pass);
            tabPage4.Controls.Add(phone);
            tabPage4.Controls.Add(email);
            tabPage4.Controls.Add(lname);
            tabPage4.Controls.Add(fname);
            tabPage4.Location = new Point(4, 37);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1212, 762);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Profile";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(304, 413);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 28);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Open";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // profile
            // 
            profile.Location = new Point(734, 89);
            profile.Name = "profile";
            profile.Size = new Size(250, 250);
            profile.TabIndex = 10;
            profile.TabStop = false;
            // 
            // rupload
            // 
            rupload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rupload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            rupload.Depth = 0;
            rupload.HighEmphasis = true;
            rupload.Icon = null;
            rupload.Location = new Point(177, 413);
            rupload.Margin = new Padding(4, 6, 4, 6);
            rupload.MouseState = MaterialSkin.MouseState.HOVER;
            rupload.Name = "rupload";
            rupload.NoAccentTextColor = Color.Empty;
            rupload.Size = new Size(78, 36);
            rupload.TabIndex = 6;
            rupload.Text = "upload";
            rupload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            rupload.UseAccentColor = false;
            rupload.UseVisualStyleBackColor = true;
            rupload.Click += rupload_Click;
            // 
            // resume
            // 
            resume.AutoSize = true;
            resume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resume.Location = new Point(53, 413);
            resume.Name = "resume";
            resume.Size = new Size(79, 28);
            resume.TabIndex = 5;
            resume.Text = "Resume";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(53, 315);
            pass.Name = "pass";
            pass.Size = new Size(93, 28);
            pass.TabIndex = 4;
            pass.Text = "Password";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(53, 247);
            phone.Name = "phone";
            phone.Size = new Size(67, 28);
            phone.TabIndex = 3;
            phone.Text = "Phone";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(53, 167);
            email.Name = "email";
            email.Size = new Size(59, 28);
            email.TabIndex = 2;
            email.Text = "Email";
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lname.Location = new Point(53, 94);
            lname.Name = "lname";
            lname.Size = new Size(103, 28);
            lname.TabIndex = 1;
            lname.Text = "Last Name";
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fname.Location = new Point(53, 32);
            fname.Name = "fname";
            fname.Size = new Size(106, 28);
            fname.TabIndex = 0;
            fname.Text = "First Name";
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 833);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPage";
            FormClosed += UserPage_FormClosed;
            Load += UserPage_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            schedulepanel.ResumeLayout(false);
            schedulepanel.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label lname;
        private Label fname;
        private Label phone;
        private Label email;
        private Label pass;
        private Label resume;
        private MaterialSkin.Controls.MaterialButton rupload;
        private PictureBox profile;
        private LinkLabel linkLabel1;
        private FlowLayoutPanel jobs;
        private Button search;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox jdiscr;
        private TextBox jgender;
        private TextBox jsalary;
        private TextBox jposition;
        private TextBox jemail;
        private TextBox cname;
        private Button jfile;
        private Button refresh;
        private Button apply;
        private FlowLayoutPanel appliedjobs;
        private Button refshappliedjob;
        private TableLayoutPanel schedulepanel;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private FlowLayoutPanel receivedjobholder;
    }
}