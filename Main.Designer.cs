namespace Project2
{
    partial class Mainx
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jobs = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.register = new MaterialSkin.Controls.MaterialButton();
            this.login = new MaterialSkin.Controls.MaterialButton();
            this.id = new MaterialSkin.Controls.MaterialTextBox();
            this.pass = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 60);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Boarding";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 747);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 103);
            this.panel1.TabIndex = 2;
            // 
            // jobs
            // 
            this.jobs.AutoScroll = true;
            this.jobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.jobs.Location = new System.Drawing.Point(3, 124);
            this.jobs.Name = "jobs";
            this.jobs.Size = new System.Drawing.Size(464, 623);
            this.jobs.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.register);
            this.panel3.Controls.Add(this.login);
            this.panel3.Controls.Add(this.id);
            this.panel3.Controls.Add(this.pass);
            this.panel3.Controls.Add(this.materialLabel2);
            this.panel3.Controls.Add(this.materialLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(467, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 623);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // register
            // 
            this.register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.register.Depth = 0;
            this.register.HighEmphasis = true;
            this.register.Icon = null;
            this.register.Location = new System.Drawing.Point(306, 300);
            this.register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.register.MouseState = MaterialSkin.MouseState.HOVER;
            this.register.Name = "register";
            this.register.NoAccentTextColor = System.Drawing.Color.Empty;
            this.register.Size = new System.Drawing.Size(89, 36);
            this.register.TabIndex = 6;
            this.register.Text = "Register";
            this.register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.register.UseAccentColor = false;
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // login
            // 
            this.login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.login.Depth = 0;
            this.login.HighEmphasis = true;
            this.login.Icon = null;
            this.login.Location = new System.Drawing.Point(148, 300);
            this.login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.login.MouseState = MaterialSkin.MouseState.HOVER;
            this.login.Name = "login";
            this.login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.login.Size = new System.Drawing.Size(64, 36);
            this.login.TabIndex = 5;
            this.login.Text = "login";
            this.login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.login.UseAccentColor = false;
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // id
            // 
            this.id.AnimateReadOnly = false;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Depth = 0;
            this.id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.id.LeadingIcon = null;
            this.id.Location = new System.Drawing.Point(183, 103);
            this.id.MaxLength = 50;
            this.id.MouseState = MaterialSkin.MouseState.OUT;
            this.id.Multiline = false;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(310, 50);
            this.id.TabIndex = 4;
            this.id.Text = "";
            this.id.TrailingIcon = null;
            // 
            // pass
            // 
            this.pass.AnimateReadOnly = false;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Depth = 0;
            this.pass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pass.LeadingIcon = null;
            this.pass.Location = new System.Drawing.Point(183, 195);
            this.pass.MaxLength = 50;
            this.pass.MouseState = MaterialSkin.MouseState.OUT;
            this.pass.Multiline = false;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(310, 50);
            this.pass.TabIndex = 3;
            this.pass.Text = "";
            this.pass.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(86, 195);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(116, 114);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Email";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // Mainx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.jobs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Mainx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobBoard 0.0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainx_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel jobs;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox pass;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox id;
        private MaterialSkin.Controls.MaterialButton register;
        private MaterialSkin.Controls.MaterialButton login;
    }
}