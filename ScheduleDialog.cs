using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class ScheduleDialog : Form
    {
        private JObject userdata, jobdata, body, cpdata;
        private ApiHandler apiHandler;
        public ScheduleDialog(JObject userdata, JObject jobdata, JObject cpdata)
        {
            InitializeComponent();
            this.userdata = userdata;
            this.jobdata = jobdata;
            this.cpdata = cpdata;
            this.apiHandler = new ApiHandler();
        }

        private void ScheduleDialog_Load(object sender, EventArgs e)
        {
            this.sd_time.Format = DateTimePickerFormat.Time;
        }

        private void ScheduleDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(userdata.ToString());
            //MessageBox.Show(jobdata.ToString());
            //MessageBox.Show(cpdata.ToString());

            if (this.sd_location.Text == string.Empty ||
                this.sd_date.Text == string.Empty ||
                this.sd_hrcontacts_email.Text == string.Empty ||
                this.sd_hrcontacts_phone.Text == string.Empty ||
               this.sd_hrname.Text == string.Empty ||
               this.sd_reqrdocs.Text == string.Empty ||
                this.sd_time.Text == string.Empty)
            {
                MessageBox.Show("Fill Valid Details If Possible🐦");
            }
            else
            {
                this.body = new JObject();

                body.Add("location", this.sd_location.Text);
                body.Add("reqrdocs", this.sd_reqrdocs.Text);
                body.Add("hrname", this.sd_hrname.Text);
                body.Add("hrcontacts-email", this.sd_hrcontacts_email.Text);
                body.Add("hrcontacts-phone", this.sd_hrcontacts_phone.Text);
                body.Add("date", this.sd_date.Value.ToString("dd-MMMM-yyyy"));
                body.Add("time", this.sd_time.Value.ToString("H-mm-ss"));
                body.Add("extradetail", this.sd_extradetail.Text);
                body.Add("cpemail", this.cpdata.GetValue("cpemail").ToString());
                body.Add("cpphone", this.cpdata.GetValue("cpphone").ToString());
                body.Add("email", this.userdata.GetValue("email").ToString());
                body.Add("phone", this.userdata.GetValue("phone").ToString());
                body.Add("ttl", this.jobdata.GetValue("pjttl").ToString());
                //MessageBox.Show(body.ToString());
                try
                {
                    MessageBox.Show(apiHandler.setInterview(body).ToString());
                }
                catch (Exception R)
                {
                    MessageBox.Show(R.Message);
                    Console.WriteLine(R.Message);
                }
            }

        }
    }
}
