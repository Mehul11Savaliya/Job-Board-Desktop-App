using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Schedules : Form
    {
        private JObject jobdetails,cpdata;
        private JArray applic;
        public Schedules(JArray applic, JObject jobdetails,JObject cpdata)
        {
            InitializeComponent();
            this.applic = applic;
            this.jobdetails = jobdetails;
            this.Text = "schedules for :"+jobdetails.GetValue("pjttl").ToString();
            this.cpdata = cpdata;
        }

        private void Schedules_Load(object sender, EventArgs e)
        {
            int i = 1;

            foreach (JObject item in applic)
            {
                this.tableLayoutPanel1.RowCount++;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));

                this.tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = i.ToString(),
                    Anchor = AnchorStyles.Top,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Size = new Size(18, 28)
            });
                this.tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = item.GetValue("fname").ToString(),
                    Anchor = AnchorStyles.Top,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Size = new Size(115, 28)

            });
                this.tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = item.GetValue("lname").ToString(),
                    Anchor = AnchorStyles.Top,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Size = new Size(115, 28)

            });
                this.tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = "under devlopment",
                    Anchor = AnchorStyles.Top,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Size = new Size(87, 28)

            });
                this.tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = item.GetValue("email").ToString(),
                    Anchor = AnchorStyles.Top,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Size = new Size(64, 28)

            });
                this.tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = item.GetValue("phone").ToString(),
                    Anchor = AnchorStyles.Top,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Size = new Size(71, 28)

            });

                LinkLabel l = new LinkLabel()
                {
                    Text = "View",
                    Anchor = AnchorStyles.Top,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Size = new Size(86, 28)

            };
                l.Click += (sender, e) =>
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = @"http://127.0.0.1:80" + item.GetValue("resume").ToString().Substring(1),
                        UseShellExecute = true
                    });
                };

                this.tableLayoutPanel1.Controls.Add(l);
                Button b = new Button()
                {
                    Text = "Schedule",
                    Anchor = AnchorStyles.Top,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Size = new Size(108, 56)

            };
                b.Click += (s, e) =>
                {
                   ScheduleDialog sd =new ScheduleDialog(item, jobdetails,cpdata);
                    sd.Text = "Schedule for : " +item.GetValue("fname")+" "+item.GetValue("lname");
                    sd.StartPosition = FormStartPosition.CenterScreen;
                    sd.ShowDialog();
                };
                this.tableLayoutPanel1.Controls.Add(b);

                i++;
            }
        }
    }
}
