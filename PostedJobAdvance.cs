using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Project2
{
    public partial class PostedJobAdvance : UserControl
    {
        private JObject postedJobJson;
        private JArray applic;
        private ApiHandler apiHandler;
        private JObject cpdata;
        public PostedJobAdvance(JObject postedJobJson, JObject cpdata)
        {
            InitializeComponent();
            this.postedJobJson = postedJobJson;
            this.apiHandler = new ApiHandler();
            this.cpdata = cpdata;
        }

        private void PostedJobAdvance_Load(object sender, EventArgs e)
        {
            this.pjttl.Text = postedJobJson.GetValue("pjttl").ToString();
            this.pjemail.Text += postedJobJson.GetValue("pjemail").ToString();
            this.pjdisc.Text = postedJobJson.GetValue("pjdisc").ToString();
            //this.pjdate;
            this.pjsalary.Text += postedJobJson.GetValue("pjsalary").ToString();
            this.gender.Text += postedJobJson.GetValue("gender").ToString();
            this.Height = 350;
            try
            {
                string iurl = @"http://127.0.0.1:5555" + postedJobJson.GetValue("pjfile").ToString();
                string imageUrl = iurl;

                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);
                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {

                        //rrsizing image
                        Bitmap x = (Bitmap)Bitmap.FromStream(memoryStream);
                        x = new Bitmap(x, new Size(250, 240));

                        pjfile.Image = x;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //   MessageBox.Show(ex.Message);
            }
        }

        private void pjposter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = @"http://127.0.0.1" + postedJobJson.GetValue("pjposter").ToString(),
                UseShellExecute = true
            });
        }

        private void imglink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = @"http://127.0.0.1" + postedJobJson.GetValue("pjfile").ToString(),
                UseShellExecute = true
            });
        }

        private void details_Click(object sender, EventArgs e)
        {
            this.Height = 750;
          

            //   MessageBox.Show(apiHandler.getApplicants(body).ToString());

            this.applicantsHolder.Controls.Clear();
            this.fetchApplicants();
            foreach (JObject appli in applic)
            {
                this.applicantsHolder.Controls.Add(new ApplicantsCard(appli, postedJobJson));
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Height = 350;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.fetchApplicants();
            Schedules s = new Schedules(applic,postedJobJson,cpdata);
            s.StartPosition = FormStartPosition.CenterParent;
            s.ShowDialog();
        }

        private void fetchApplicants()
        {
            JObject body = new JObject();
            body.Add("cpemail", postedJobJson.GetValue("pjemail").ToString());
            body.Add("cpttl", postedJobJson.GetValue("pjttl").ToString());
            body.Add("cpname", postedJobJson.GetValue("pjcpname").ToString());
            var applicants = apiHandler.getApplicants(body);
            JObject aplicants = (JObject)applicants[1];

            this.applicantsMeta.Text = "Application(" + aplicants.GetValue("count").ToString() + ")";
            applic = (JArray)aplicants.GetValue("application");
        }
    }
}
