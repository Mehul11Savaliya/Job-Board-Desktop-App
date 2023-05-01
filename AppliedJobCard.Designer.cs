namespace Project2
{
    partial class AppliedJobCard
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
            this.remove = new System.Windows.Forms.Button();
            this.reqreview = new System.Windows.Forms.Button();
            this.cmpny = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttl = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.contacts = new System.Windows.Forms.Label();
            this.sendsms = new System.Windows.Forms.Button();
            this.visitsite = new System.Windows.Forms.Button();
            this.discr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.remove.ForeColor = System.Drawing.Color.Red;
            this.remove.Location = new System.Drawing.Point(48, 12);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(94, 29);
            this.remove.TabIndex = 0;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // reqreview
            // 
            this.reqreview.ForeColor = System.Drawing.Color.Black;
            this.reqreview.Location = new System.Drawing.Point(197, 12);
            this.reqreview.Name = "reqreview";
            this.reqreview.Size = new System.Drawing.Size(133, 29);
            this.reqreview.TabIndex = 1;
            this.reqreview.Text = "Request Review";
            this.reqreview.UseVisualStyleBackColor = true;
            this.reqreview.Click += new System.EventHandler(this.reqreview_Click);
            // 
            // cmpny
            // 
            this.cmpny.AutoSize = true;
            this.cmpny.Location = new System.Drawing.Point(390, 16);
            this.cmpny.Name = "cmpny";
            this.cmpny.Size = new System.Drawing.Size(83, 20);
            this.cmpny.TabIndex = 2;
            this.cmpny.Text = "Company : ";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(599, 16);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(96, 20);
            this.date.TabIndex = 3;
            this.date.Text = "Applied On : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discription : ";
            // 
            // ttl
            // 
            this.ttl.AutoSize = true;
            this.ttl.Location = new System.Drawing.Point(93, 89);
            this.ttl.Name = "ttl";
            this.ttl.Size = new System.Drawing.Size(49, 20);
            this.ttl.TabIndex = 5;
            this.ttl.Text = "Title : ";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(93, 234);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(60, 20);
            this.salary.TabIndex = 6;
            this.salary.Text = "Salary : ";
            // 
            // contacts
            // 
            this.contacts.AutoSize = true;
            this.contacts.Location = new System.Drawing.Point(93, 153);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(77, 20);
            this.contacts.TabIndex = 7;
            this.contacts.Text = "Contacts : ";
            this.contacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sendsms
            // 
            this.sendsms.Location = new System.Drawing.Point(390, 256);
            this.sendsms.Name = "sendsms";
            this.sendsms.Size = new System.Drawing.Size(130, 29);
            this.sendsms.TabIndex = 10;
            this.sendsms.Text = "Send Message";
            this.sendsms.UseVisualStyleBackColor = true;
            this.sendsms.Click += new System.EventHandler(this.sendsms_Click);
            // 
            // visitsite
            // 
            this.visitsite.Location = new System.Drawing.Point(599, 256);
            this.visitsite.Name = "visitsite";
            this.visitsite.Size = new System.Drawing.Size(120, 29);
            this.visitsite.TabIndex = 11;
            this.visitsite.Text = "Visite Website";
            this.visitsite.UseVisualStyleBackColor = true;
            this.visitsite.Click += new System.EventHandler(this.visitsite_Click);
            // 
            // discr
            // 
            this.discr.Location = new System.Drawing.Point(491, 111);
            this.discr.Multiline = true;
            this.discr.Name = "discr";
            this.discr.ReadOnly = true;
            this.discr.Size = new System.Drawing.Size(319, 126);
            this.discr.TabIndex = 12;
            // 
            // AppliedJobCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.discr);
            this.Controls.Add(this.visitsite);
            this.Controls.Add(this.sendsms);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.ttl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.cmpny);
            this.Controls.Add(this.reqreview);
            this.Controls.Add(this.remove);
            this.Name = "AppliedJobCard";
            this.Size = new System.Drawing.Size(841, 300);
            this.Load += new System.EventHandler(this.AppliedJobCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button remove;
        private Button reqreview;
        private Label cmpny;
        private Label date;
        private Label label3;
        private Label ttl;
        private Label salary;
        private Label contacts;
        private Button sendsms;
        private Button visitsite;
        private TextBox discr;
    }
}
