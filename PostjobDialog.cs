using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class PostjobDialog : Form
    {

        string emailregex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        string gender = null;
        byte[] pjposter;
        byte[] pjfile;
        ApiHandler apiHandler;

        private JObject cpdata;
        public PostjobDialog(JObject cpdata)
        {
            this.cpdata = cpdata;
            InitializeComponent();
            apiHandler = new ApiHandler();
        }

        private void PostjobDialog_Load(object sender, EventArgs e)
        {
            //  this.pj_disc.Text = cpdata.ToString();
            this.selectfile.InitialDirectory = @"C:\";
            this.selectfile.RestoreDirectory = true;
            this.selectfile.Multiselect = false;
        }
        private void PostjobDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex re = new Regex(emailregex);
            bool eflag = false, sflag = false;
            double salary;

            if (re.IsMatch(this.pj_email.Text))
                eflag = true;

            try
            {
                salary = double.Parse(this.pj_salary.Text);
                sflag = true;
            }
            catch
            {
                sflag = false;
            }

            if (eflag && sflag && this.pj_ttl.Text != string.Empty && this.pj_disc.Text != string.Empty && gender != null)
            {


                JObject body = new JObject();
                body.Add("pjcpname", cpdata.GetValue("cpname").ToString());
                body.Add("pjemail", this.pj_email.Text);
                body.Add("gender", gender);
                body.Add("pjsalary", this.pj_salary.Text);
                body.Add("pjttl", this.pj_ttl.Text);
                body.Add("pjdisc", this.pj_disc.Text);
                body.Add("pjposter", this.pj_selectposter.Text);
                body.Add("pjfile", this.pj_selectfile.Text);
                body.Add("sign-pass", cpdata.GetValue("cppass").ToString());
                body.Add("sign-email", cpdata.GetValue("cpemail").ToString());
                apiHandler.setJob(body);
                // MessageBox.Show(apiHandler.setJob(body).ToString());
            }
            else
            {
                MessageBox.Show("Enter Valid Details if possible 🐦");
            }

        }

        private void pj_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void pj_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void pj_selectfile_Click(object sender, EventArgs e)
        {
            this.selectfile.Title = "Select PDF File";
            this.selectfile.Filter = "Pdf Files |*.pdf";

            if (this.selectfile.ShowDialog() == DialogResult.OK)
            {
                this.pj_selectfile.Text = this.selectfile.FileName;
                pjfile = ReadFile(this.selectfile.OpenFile());
            }
        }

        private void pj_selectposter_Click(object sender, EventArgs e)
        {
            // this.selectfile;
            this.selectfile.Title = "Select Image File";
            this.selectfile.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (this.selectfile.ShowDialog() == DialogResult.OK)
            {
                this.pj_selectposter.Text = this.selectfile.FileName;

                pjposter = ReadFile(this.selectfile.OpenFile());
                // this.pj_disc.Text = pjposter.Length.ToString();
                //try
                //{
                //    if ((myStream = theDialog.OpenFile()) != null)
                //    {
                //        using (myStream)
                //        {
                //            // Insert code to read the stream here.
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                //}
            }

        }

        private byte[] ReadFile(Stream input)
        {
            byte[] buffer = new byte[input.Length];
            //byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
