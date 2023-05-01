namespace Project2
{
    partial class PostjobDialog
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            pj_female = new RadioButton();
            pj_male = new RadioButton();
            pj_ttl = new TextBox();
            pj_email = new TextBox();
            pj_salary = new TextBox();
            pj_selectfile = new TextBox();
            pj_selectposter = new TextBox();
            pj_disc = new TextBox();
            button1 = new Button();
            selectfile = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 71);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 241);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 2;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 297);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 28);
            label4.TabIndex = 3;
            label4.Text = "File";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 363);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 4;
            label5.Text = "Poster";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 430);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 5;
            label6.Text = "Discription";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pj_female);
            groupBox1.Controls.Add(pj_male);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(37, 131);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(458, 98);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "For";
            // 
            // pj_female
            // 
            pj_female.AutoSize = true;
            pj_female.Location = new Point(232, 36);
            pj_female.Margin = new Padding(4);
            pj_female.Name = "pj_female";
            pj_female.Size = new Size(95, 32);
            pj_female.TabIndex = 1;
            pj_female.Text = "Female";
            pj_female.UseVisualStyleBackColor = true;
            pj_female.CheckedChanged += pj_female_CheckedChanged;
            // 
            // pj_male
            // 
            pj_male.AutoSize = true;
            pj_male.Location = new Point(28, 36);
            pj_male.Margin = new Padding(4);
            pj_male.Name = "pj_male";
            pj_male.Size = new Size(76, 32);
            pj_male.TabIndex = 0;
            pj_male.Text = "Male";
            pj_male.UseVisualStyleBackColor = true;
            pj_male.CheckedChanged += pj_male_CheckedChanged;
            // 
            // pj_ttl
            // 
            pj_ttl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pj_ttl.Location = new Point(174, 13);
            pj_ttl.Margin = new Padding(4);
            pj_ttl.Name = "pj_ttl";
            pj_ttl.PlaceholderText = "SDE,DevOps etc";
            pj_ttl.Size = new Size(170, 34);
            pj_ttl.TabIndex = 7;
            // 
            // pj_email
            // 
            pj_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pj_email.Location = new Point(174, 71);
            pj_email.Margin = new Padding(4);
            pj_email.Name = "pj_email";
            pj_email.Size = new Size(170, 34);
            pj_email.TabIndex = 8;
            // 
            // pj_salary
            // 
            pj_salary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pj_salary.Location = new Point(174, 237);
            pj_salary.Margin = new Padding(4);
            pj_salary.Name = "pj_salary";
            pj_salary.Size = new Size(170, 34);
            pj_salary.TabIndex = 9;
            // 
            // pj_selectfile
            // 
            pj_selectfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pj_selectfile.Location = new Point(173, 297);
            pj_selectfile.Margin = new Padding(4);
            pj_selectfile.Name = "pj_selectfile";
            pj_selectfile.ReadOnly = true;
            pj_selectfile.ScrollBars = ScrollBars.Horizontal;
            pj_selectfile.Size = new Size(273, 34);
            pj_selectfile.TabIndex = 10;
            pj_selectfile.Text = "select discription file";
            pj_selectfile.Click += pj_selectfile_Click;
            // 
            // pj_selectposter
            // 
            pj_selectposter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pj_selectposter.Location = new Point(174, 359);
            pj_selectposter.Margin = new Padding(4);
            pj_selectposter.Name = "pj_selectposter";
            pj_selectposter.ReadOnly = true;
            pj_selectposter.ScrollBars = ScrollBars.Horizontal;
            pj_selectposter.Size = new Size(272, 34);
            pj_selectposter.TabIndex = 11;
            pj_selectposter.Text = "select poster image";
            pj_selectposter.Click += pj_selectposter_Click;
            // 
            // pj_disc
            // 
            pj_disc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pj_disc.Location = new Point(173, 430);
            pj_disc.Margin = new Padding(4);
            pj_disc.Multiline = true;
            pj_disc.Name = "pj_disc";
            pj_disc.PlaceholderText = "Description About Job";
            pj_disc.ScrollBars = ScrollBars.Both;
            pj_disc.Size = new Size(290, 127);
            pj_disc.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(36, 518);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 13;
            button1.Text = "Post";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // selectfile
            // 
            selectfile.FileName = "selectfile";
            // 
            // PostjobDialog
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 596);
            Controls.Add(button1);
            Controls.Add(pj_disc);
            Controls.Add(pj_selectposter);
            Controls.Add(pj_selectfile);
            Controls.Add(pj_salary);
            Controls.Add(pj_email);
            Controls.Add(pj_ttl);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "PostjobDialog";
            Text = "PostjobDialog";
            FormClosed += PostjobDialog_FormClosed;
            Load += PostjobDialog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox pj_ttl;
        private TextBox pj_email;
        private TextBox pj_salary;
        private TextBox pj_selectfile;
        private TextBox pj_selectposter;
        private TextBox pj_disc;
        private RadioButton pj_female;
        private RadioButton pj_male;
        private Button button1;
        private OpenFileDialog selectfile;
    }
}