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
    public partial class PostedJob : UserControl
    {
        private JObject postedJobJson;
        private ApiHandler apiHandler;
        public PostedJob(JObject postedJobJson)
        {
            InitializeComponent();
            this.postedJobJson = postedJobJson;
            apiHandler = new ApiHandler();
        }

        private void PostedJob_Load(object sender, EventArgs e)
        {
            this.pjttl.Text = postedJobJson.GetValue("pjttl").ToString();
            this.pjemail.Text += postedJobJson.GetValue("pjemail").ToString();
            this.pjdisc.Text = postedJobJson.GetValue("pjdisc").ToString();
            //this.pjdate;
            this.pjsalary.Text += postedJobJson.GetValue("pjsalary").ToString();
            this.gender.Text += postedJobJson.GetValue("gender").ToString();

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

        private void pjposter_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = @"http://127.0.0.1" + postedJobJson.GetValue("pjposter").ToString(),
                UseShellExecute = true
            });
        }

        private void delete_Click(object sender, EventArgs e)
        {
            JObject body = new JObject();
            body.Add("cpemail", postedJobJson.GetValue("pjemail").ToString());
            body.Add("cpttl", postedJobJson.GetValue("pjttl").ToString());
            body.Add("cpname", postedJobJson.GetValue("pjcpname").ToString());
            body.Add("extimg", postedJobJson.GetValue("pjfile").ToString().Split('.')[1]);

            MessageBox.Show(apiHandler.deleteJob(body).ToString());            
        }
    }
}
