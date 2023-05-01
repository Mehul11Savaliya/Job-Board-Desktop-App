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
    public partial class CompanyPage : Form
    {
        private JObject cpdata;
        private Bitmap cpprofile;
        private ApiHandler apiHandler;

        public CompanyPage(JObject cpdata)
        {
            InitializeComponent();
            this.cpdata = cpdata;
            this.apiHandler = new ApiHandler();
        }

        private void CompanyPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mainx m = new Mainx();
            this.Hide();
            m.Show();

        }

        private void tab_profile_Enter(object sender, EventArgs e)
        {
            //     MessageBox.Show("Profile Activated");
            this.cp_name.Text = "Company Name : " + cpdata.GetValue("cpname").ToString();
            this.cp_fname.Text = "First Name : " + cpdata.GetValue("cpfname").ToString();
            this.cp_lname.Text = "Last Name : " + cpdata.GetValue("cplname").ToString();
            this.cp_addr.Text = "Address : " + cpdata.GetValue("cpaddr").ToString();
            this.cp_email.Text = "Email : " + cpdata.GetValue("cpemail").ToString();
            this.cp_phone.Text = "Phone : " + cpdata.GetValue("cpphone").ToString();
            this.cp_size.Text = "Size : " + cpdata.GetValue("cpsize").ToString();
            // this.cp_website;
            this.cp_profile.Image = cpprofile;


        }

        private void CompanyPage_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(cpdata.ToString());
            try
            {
                string iurl = @"http://127.0.0.1:5555" + cpdata.GetValue("profile").ToString().Substring(1);
                string imageUrl = iurl;

                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);
                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {

                        //rrsizing image
                        Bitmap x = (Bitmap)Bitmap.FromStream(memoryStream);
                        x = new Bitmap(x, new Size(230, 160));
                        this.cpprofile = x;
                        x = new Bitmap(x, new Size(16, 16));
                        IntPtr Hicon = x.GetHicon();
                        this.Icon = Icon.FromHandle(Hicon);

                    }
                }

                this.Text = cpdata.GetValue("cpname").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cp_website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = cpdata.GetValue("cpurl").ToString(),
                UseShellExecute = true
            });
        }

        private void cp_tbp1_postjob_Click(object sender, EventArgs e)
        {
            PostjobDialog pd = new PostjobDialog(cpdata);
            pd.StartPosition = FormStartPosition.CenterParent;
            pd.ShowDialog();
        }

        private void tab_postjob_Enter(object sender, EventArgs e)
        {
            JArray postedJob = apiHandler.getPostedJob(cpdata);
            this.postedJobHolder.Controls.Clear();
            foreach (JObject data in postedJob)
            {
                this.postedJobHolder.Controls.Add(new PostedJob(data));
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.tab_postjob_Enter(sender, e);
        }

        private void tab_postedjob_Enter(object sender, EventArgs e)
        {
            JArray postedJob = apiHandler.getPostedJob(cpdata);
            this.advancePostedJobHolder.Controls.Clear();
            foreach (JObject data in postedJob)
            {
                this.advancePostedJobHolder.Controls.Add(new PostedJobAdvance(data, cpdata));
            }
        }

        private void refresh1_Click(object sender, EventArgs e)
        {
            this.tab_postedjob_Enter(sender, e);
        }

        private void tab_schedule_Enter(object sender, EventArgs e)
        {
            JArray schedules = null;
            JObject body = new JObject();
            body.Add("cpemail", this.cpdata.GetValue("cpemail").ToString());
            body.Add("cppass", this.cpdata.GetValue("cppass").ToString());
            try
            {
                schedules = apiHandler.getSchedules(body);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            this.schedulesHolder.Controls.Clear();
            foreach (JObject item in schedules)
            {
                this.schedulesHolder.Controls.Add(new ScheduleDetailsCard(item, cpdata));
            }
        }

        private void refreshSchedule_Click(object sender, EventArgs e)
        {
            this.tab_schedule_Enter(sender, e);
        }

        private void uimg_Click(object sender, EventArgs e)
        {
            CompanyUploadMedia cum = new CompanyUploadMedia(this.cpdata); //🐦🐦
            cum.StartPosition = FormStartPosition.CenterParent; 
            cum.ShowDialog();

        }
    }
}
