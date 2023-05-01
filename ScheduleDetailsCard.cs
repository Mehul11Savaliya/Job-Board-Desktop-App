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
    public partial class ScheduleDetailsCard : UserControl
    {
        private JObject schedule, cpdata;
        private ApiHandler apiHandler;
        public ScheduleDetailsCard(JObject schedule, JObject cpdata,bool deletevisible=true)
        {
            InitializeComponent();
            this.schedule = schedule;
            this.cpdata = cpdata;
            this.apiHandler = new ApiHandler();
            if (deletevisible)
                this.delete.Visible = true;
            else
                this.delete.Visible = false;
        }

        private void ScheduleDetailsCard_Load(object sender, EventArgs e)
        {
            this.scd_ad_email.Text += schedule.GetValue("email").ToString();
            this.scd_ad_fullname.Text = schedule.GetValue("firstname").ToString() + " " + schedule.GetValue("lastname").ToString();
            this.scd_ad_phone.Text += schedule.GetValue("phone").ToString();
            //    this.scd_ad_profile.Text = schedule.GetValue("profile").ToString();
            this.scd_hd_hr.Text += schedule.GetValue("hr").ToString();
            this.scd_hd_hr_email.Text += schedule.GetValue("hr_email").ToString();
            this.scd_hd_hr_phone.Text += schedule.GetValue("hr_phone").ToString();
            this.scd_sd_date.Text += schedule.GetValue("date").ToString();
            this.scd_sd_extradetails.Text = schedule.GetValue("extradetails").ToString();
            this.scd_sd_req_doc.Text += schedule.GetValue("req_doc").ToString();
            this.scd_sd_time.Text += schedule.GetValue("time").ToString();
            this.groupBox1.Text += " for  job title : " + schedule.GetValue("ttl").ToString();

            try
            {
                string iurl = @"http://127.0.0.1:5555" + schedule.GetValue("profile").ToString().Substring(1);
                string imageUrl = iurl;

                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);
                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {

                        //rrsizing image
                        Bitmap x = (Bitmap)Bitmap.FromStream(memoryStream);
                        x = new Bitmap(x, new Size(70, 60));
                        // System.Drawing.Image image =
                        this.scd_ad_profile.Image = x;
                    }
                }
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = @"http://127.0.0.1" + schedule.GetValue("resume").ToString().Substring(1),
                UseShellExecute = true
            });
        }

        private void delete_Click(object sender, EventArgs e)
        {

            JObject body = new JObject();
            body.Add("jsemail", schedule.GetValue("email").ToString());
            body.Add("ttl", schedule.GetValue("ttl").ToString());
            body.Add("cpemail", schedule.GetValue("cpemail").ToString());
            body.Add("cpphone", schedule.GetValue("cpphone").ToString());
            try
            {
                MessageBox.Show(apiHandler.deleteSchedule(body).ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
