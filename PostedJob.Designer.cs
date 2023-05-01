namespace Project2
{
    partial class PostedJob
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
            pjfile = new PictureBox();
            pjemail = new Label();
            gender = new Label();
            pjsalary = new Label();
            pjdate = new Label();
            delete = new Button();
            pjposter = new LinkLabel();
            pjttl = new Label();
            pjdisc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pjfile).BeginInit();
            SuspendLayout();
            // 
            // pjfile
            // 
            pjfile.Location = new Point(557, 49);
            pjfile.Name = "pjfile";
            pjfile.Size = new Size(250, 240);
            pjfile.TabIndex = 0;
            pjfile.TabStop = false;
            // 
            // pjemail
            // 
            pjemail.AutoSize = true;
            pjemail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pjemail.Location = new Point(26, 160);
            pjemail.Name = "pjemail";
            pjemail.Size = new Size(68, 25);
            pjemail.TabIndex = 2;
            pjemail.Text = "Email : ";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            gender.Location = new Point(26, 206);
            gender.Name = "gender";
            gender.Size = new Size(151, 25);
            gender.TabIndex = 3;
            gender.Text = "Who Can Apply : ";
            // 
            // pjsalary
            // 
            pjsalary.AutoSize = true;
            pjsalary.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pjsalary.Location = new Point(26, 253);
            pjsalary.Name = "pjsalary";
            pjsalary.Size = new Size(78, 25);
            pjsalary.TabIndex = 4;
            pjsalary.Text = " Salary : ";
            // 
            // pjdate
            // 
            pjdate.AutoSize = true;
            pjdate.ForeColor = SystemColors.WindowFrame;
            pjdate.Location = new Point(26, 304);
            pjdate.Name = "pjdate";
            pjdate.Size = new Size(52, 20);
            pjdate.TabIndex = 5;
            pjdate.Text = "Date : ";
            // 
            // delete
            // 
            delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            delete.Location = new Point(289, 286);
            delete.Name = "delete";
            delete.Size = new Size(94, 38);
            delete.TabIndex = 6;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // pjposter
            // 
            pjposter.AutoSize = true;
            pjposter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pjposter.Location = new Point(434, 296);
            pjposter.Name = "pjposter";
            pjposter.Size = new Size(78, 28);
            pjposter.TabIndex = 7;
            pjposter.TabStop = true;
            pjposter.Text = "Job File";
            pjposter.Click += pjposter_Click;
            // 
            // pjttl
            // 
            pjttl.AutoSize = true;
            pjttl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pjttl.Location = new Point(26, 15);
            pjttl.Name = "pjttl";
            pjttl.Size = new Size(92, 24);
            pjttl.TabIndex = 8;
            pjttl.Text = "Job Title";
            // 
            // pjdisc
            // 
            pjdisc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pjdisc.Location = new Point(26, 66);
            pjdisc.Multiline = true;
            pjdisc.Name = "pjdisc";
            pjdisc.ReadOnly = true;
            pjdisc.ScrollBars = ScrollBars.Vertical;
            pjdisc.Size = new Size(486, 79);
            pjdisc.TabIndex = 9;
            pjdisc.Text = "job discription";
            // 
            // PostedJob
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pjdisc);
            Controls.Add(pjttl);
            Controls.Add(pjposter);
            Controls.Add(delete);
            Controls.Add(pjdate);
            Controls.Add(pjsalary);
            Controls.Add(gender);
            Controls.Add(pjemail);
            Controls.Add(pjfile);
            Name = "PostedJob";
            Size = new Size(850, 340);
            Load += PostedJob_Load;
            ((System.ComponentModel.ISupportInitialize)pjfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pjfile;
        private Label pjemail;
        private Label gender;
        private Label pjsalary;
        private Label pjdate;
        private Button delete;
        private LinkLabel pjposter;
        private Label pjttl;
        private TextBox pjdisc;
    }
}
