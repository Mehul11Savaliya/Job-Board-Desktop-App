using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Project2
{
    public partial class JobCard : UserControl
    {
        JObject data;
        public JobCard(JObject data)
        {
            this.data = data;
            InitializeComponent();
            try { 
          //  this.gender.Text = "ksjdbvdj";
            this.pjcpname.Text = "Company Name : " +data.GetValue("pjcpname").ToString();
            this.email.Text = "Email : "+ data.GetValue("pjemail").ToString();
            this.salary.Text = "Salary : " +data.GetValue("pjsalary").ToString();
            this.disc.Text = "Discription : "+ data.GetValue("pjdisc").ToString();
            this.gender.Text = "Who Can Apply : " +data.GetValue("gender").ToString();
            //this.pjcpname.Text = "" data.GetValue("pjcpname").ToString();
           this.date.Text = data.GetValue("datetime")==null? "no date found old data" : data.GetValue("datetime").ToString();
            this.ttl2.Text = data.GetValue("pjttl").ToString();
           
                 //   MessageBox.Show(data.GetValue("datetime").ToString());
            
            }catch (Exception e)
            {
              //  MessageBox.Show(e.ToString());
               
                this.date.Text = e.Message;
            }
            try
            {
                string iurl = @"http://127.0.0.1:5555" + data.GetValue("pjfile").ToString();
                string imageUrl =iurl;
             
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);
                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {

                        //rrsizing image
                       Bitmap x = (Bitmap) Bitmap.FromStream(memoryStream);
                       x = new Bitmap(x,new Size(424,255));
                       // System.Drawing.Image image =
                        pjfile.Image = x;
                    }
                }
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message);
            }

            //setting link in link label
            
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void pjposter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string purl = @"http://127.0.0.1" + data.GetValue("pjposter").ToString();
            Process.Start(new ProcessStartInfo()
            {  FileName=purl,
                UseShellExecute = true
            });
        }

        private void JobCard_Load(object sender, EventArgs e)
        {

        }
    }
}
