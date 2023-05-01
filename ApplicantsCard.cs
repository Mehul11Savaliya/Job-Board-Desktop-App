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

namespace Project2
{
    public partial class ApplicantsCard : UserControl
    {
        JObject applidata,jobdata;
        private ApiHandler apiHandler;
        public ApplicantsCard(JObject data,JObject jobdata)
        {
            InitializeComponent();
            this.applidata = data;
            this.jobdata = jobdata;
            apiHandler = new ApiHandler();
        }

        private void ApplicantsCard_Load(object sender, EventArgs e)
        {
            this.message.Visible = false;

            this.fnamelname.Text = applidata.GetValue("fname").ToString() + " " + applidata.GetValue("lname").ToString();
            this.email.Text += applidata.GetValue("email").ToString();
            this.phone.Text += applidata.GetValue("phone").ToString();
            //  MessageBox.Show(applidata.GetValue("resume").ToString());

            try
            {
                string iurl = @"http://127.0.0.1:5555" + applidata.GetValue("profile").ToString().Substring(1);
                string imageUrl = iurl;

                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);
                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {

                        //rrsizing image
                        Bitmap x = (Bitmap)Bitmap.FromStream(memoryStream);
                        x = new Bitmap(x, new Size(258, 228));

                        profile.Image = x;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //  MessageBox.Show(ex.Message);
            }

        }

        private void resume_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = @"http://127.0.0.1:80" + applidata.GetValue("resume").ToString().Substring(1),
                UseShellExecute = true
            });
        }

        private void accept_Click(object sender, EventArgs e)
        {
            JObject body = new JObject();
            body.Add("cemail",jobdata.GetValue("pjemail").ToString());
            body.Add("ttl",jobdata.GetValue("pjttl").ToString());
            body.Add("uemail", applidata.GetValue("email").ToString());

            MessageBox.Show(apiHandler.acceptApplicants(body).ToString());
        }
    }
}
