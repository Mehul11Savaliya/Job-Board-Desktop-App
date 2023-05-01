using Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class UserPage : Form
    {
        private JObject userdata;
        private ApiHandler apiHandler;
        private JArray jobsArr = null;
        private string currJobFileUrl = null;
        private JObject currJobObj = null;

        public UserPage(JObject data)
        {
            userdata = data;
            apiHandler = new ApiHandler();


            InitializeComponent();
            //   var materialSkinManager = MaterialSkinManager.Instance;
            // materialSkinManager.AddFormToManage(this);
            //  materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.Text = "Welcome : " + userdata.GetValue("fname").ToString() + " " + userdata.GetValue("lname").ToString();

            this.refreshJobs();


        }


        private void UserPage_Load(object sender, EventArgs e)
        {
            this.fname.Text += " : " + this.userdata.GetValue("fname").ToString();
            this.lname.Text += " : " + this.userdata.GetValue("lname").ToString();
            this.email.Text += " : " + this.userdata.GetValue("email").ToString();
            this.phone.Text += " : " + this.userdata.GetValue("phone").ToString();
            this.pass.Text += " : " + this.userdata.GetValue("password").ToString();

            string imageUrl = @"http://127.0.0.1:5555" + userdata.GetValue("profile").ToString().Substring(1).Trim();
            string pdfurl = @"http://127.0.0.1:80" + userdata.GetValue("resume").ToString();


            imageUrl = imageUrl.Replace("webp", "jpg");
            var request = WebRequest.Create(imageUrl);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Bitmap x = (Bitmap)Bitmap.FromStream(stream);

                x = new Bitmap(x, new Size(250, 250));
                this.profile.Image = x;
                //this.profile.Image = x;
            }



        }

        private void UserPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mainx m = new Mainx();
            m.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pdfurl = string.Concat("http://127.0.0.1", userdata.GetValue("resume").ToString());
            try
            {
                Process.Start(new ProcessStartInfo(pdfurl)
                {
                    FileName = pdfurl,
                    UseShellExecute = true
                });

                // var client = new WebClient();
                // client.DownloadFile(new Uri(pdfurl, UriKind.Absolute), "/download/test.pdf");

                //        WebRequest request = WebRequest.Create(pdfurl);
                //      WebResponse response = request.GetResponse();
                //    string originalFileName = response.ResponseUri.AbsolutePath.Substring(response.ResponseUri.AbsolutePath.LastIndexOf("/") + 1);
                //  Stream streamWithFileBody = response.GetResponseStream();
                //  using (Stream output = File.OpenWrite(@"/downloads/"+ originalFileName))
                //{
                //  streamWithFileBody.CopyTo(output);
                //}
                // MessageBox.Show("Downloaded");

                //Console.WriteLine("Downloded : " + originalFileName);
            }
            catch (Exception ex)
            {
                this.linkLabel1.Text = pdfurl;
                MessageBox.Show("Unable to start : " + ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillTable(JObject data)
        {
            this.cname.Text = data.GetValue("pjcpname").ToString();
            this.jdiscr.Text = data.GetValue("pjdisc").ToString();
            this.jemail.Text = data.GetValue("pjemail").ToString();
            this.currJobFileUrl = "http:127.0.0.1" + data.GetValue("pjposter").ToString();
            this.jgender.Text = data.GetValue("gender").ToString();
            this.jposition.Text = data.GetValue("pjttl").ToString();
            this.jsalary.Text = data.GetValue("pjsalary").ToString();

        }

        private void refreshJobs()
        {
            this.jobsArr = apiHandler.getAllJobs();
            foreach (JObject jsn in jobsArr)
            {
                // MessageBox.Show(jsn.ToString());
                JobCard ax = new JobCard(jsn);

                ax.Click += (object a, EventArgs e) =>
                {
                    currJobObj = jsn;
                    fillTable(jsn);
                };

                this.jobs.Controls.Add(ax);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.jobs.Controls.Clear();
            refreshJobs();
        }

        private void jfile_Click(object sender, EventArgs e)
        {
            try
            {

                Process.Start(new ProcessStartInfo()
                {
                    FileName = currJobFileUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Job First");
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (currJobObj == null)
            {
                MessageBox.Show("No Job Selected!!");
            }
            else
            {
                try
                {
                    Console.WriteLine(currJobObj.ToString());
                    currJobObj.Remove("uemail");
                    currJobObj.Remove("upass");
                    currJobObj.Add("uemail", userdata.GetValue("email").ToString());
                    currJobObj.Add("upass", userdata.GetValue("password").ToString());
                    MessageBox.Show(apiHandler.appyJob(currJobObj).ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void refshappliedjob_Click(object sender, EventArgs e)
        {
            this.tabPage2_Enter(sender, e);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.appliedjobs.Controls.Clear();
            JObject udata = new JObject();
            udata.Add("uemail", userdata.GetValue("email").ToString());
            udata.Add("upass", userdata.GetValue("email").ToString());
            //  this.appliedjobs.Controls.Add(new AppliedJobCard(null));
            // MessageBox.Show(apiHandler.getAppliedJob(udata).ToString());

            JArray appjobs = apiHandler.getAppliedJob(udata);

            AppliedJobCard tmp;
            foreach (JObject data in appjobs)
            {
                tmp = new AppliedJobCard(data, udata);
                this.appliedjobs.Controls.Add(tmp);
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            //this.receivedjobholder.Controls.Add(new ReceivedJobCard());
            JObject data = new JObject();
            data.Add("uemail", userdata.GetValue("email").ToString());
            data.Add("upass", userdata.GetValue("password").ToString());

            schedulepanel.Controls.Clear();
            this.schedulepanel.Controls.Add(this.label24, 6, 0);
            this.schedulepanel.Controls.Add(this.label23, 5, 0);
            this.schedulepanel.Controls.Add(this.label22, 4, 0);
            this.schedulepanel.Controls.Add(this.label21, 3, 0);
            this.schedulepanel.Controls.Add(this.label20, 2, 0);
            this.schedulepanel.Controls.Add(this.label19, 1, 0);
            this.schedulepanel.Controls.Add(this.label18, 0, 0);

            //for ()
            //{

            //}

            JArray recievedJob = apiHandler.getAcceptedJob(data);
            //ReceivedJobCard tmp;

            //schedulepanel.Controls.re

            int i = 1;
            //schedulepanel.Ro
            foreach (JObject dta in recievedJob)
            {
                // MessageBox.Show(dta.ToString());
                //   tmp = new ReceivedJobCard(dta);
                //   receivedjobholder.Controls.Add(tmp);

                dta.Add("idx", i.ToString());



                schedulepanel.RowCount++;

                schedulepanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));

                schedulepanel.Controls.Add(new Label()
                {
                    Text = i.ToString(),
                    AutoSize = true,
                    Anchor = System.Windows.Forms.AnchorStyles.Top


                });
                schedulepanel.Controls.Add(new Label()
                {
                    Text = dta.GetValue("pjcpname").ToString(),
                    AutoSize = true,
                    Anchor = System.Windows.Forms.AnchorStyles.Top

                });
                schedulepanel.Controls.Add(new Label()
                {
                    Text = dta.GetValue("pjemail").ToString(),
                    AutoSize = true,
                    Anchor = System.Windows.Forms.AnchorStyles.Top

                });
                schedulepanel.Controls.Add(new Label()
                {
                    Text = "not implemented",
                    AutoSize = true,
                    Anchor = System.Windows.Forms.AnchorStyles.Top

                });
                schedulepanel.Controls.Add(new Label()
                {
                    Text = dta.GetValue("pjttl").ToString(),
                    AutoSize = true,
                    Anchor = System.Windows.Forms.AnchorStyles.Top

                });


                LinkLabel l = new LinkLabel()
                {
                    Text = "Click Here",
                    AutoSize = true,
                    Anchor = System.Windows.Forms.AnchorStyles.Top,
                };
                l.Click += (o, e) =>
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = dta.GetValue("pjurl").ToString(),
                        UseShellExecute = true
                    });
                };
                schedulepanel.Controls.Add(l);

                Button b = new Button()
                {
                    Text = "View",
                    AutoSize = true,
                    Anchor = System.Windows.Forms.AnchorStyles.Top
                };
                b.Click += (sender, eventergs) =>
                {
                    JObject body = new JObject();
                    body.Add("jsemail", this.userdata.GetValue("email").ToString());
                    body.Add("ttl", dta.GetValue("pjttl").ToString());
                    body.Add("password", this.userdata.GetValue("password").ToString());
                    JObject data = apiHandler.getInterviewDetails(body);
                    if (data == null)
                    {
                        MessageBox.Show("No Schedule Found 🐦");
                    }
                    else
                    {
                        InterviewDetailCard idc = new InterviewDetailCard(data);
                        idc.StartPosition = FormStartPosition.CenterParent;
                        idc.ShowDialog();

                    }
                };

                schedulepanel.Controls.Add(b);
                i++;
            }


        }

        private void rupload_Click(object sender, EventArgs e)
        {
            UserUploadMedia uum = new UserUploadMedia(this.userdata);
            uum.StartPosition = FormStartPosition.CenterParent;
            uum.ShowDialog();
        }
    }
}
