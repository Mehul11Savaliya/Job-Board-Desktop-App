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
    public partial class InterviewDetailCard : Form
    {
        JObject data = null;
        public InterviewDetailCard(JObject data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void InterviewDetailCard_Load(object sender, EventArgs e)
        {
            this.ttl.Text += data.GetValue("ttl").ToString();
            this.cpemail.Text += data.GetValue("cpemail").ToString();
            this.cpphone.Text += data.GetValue("cpphone").ToString();
            this.location.Text += data.GetValue("location").ToString();
            this.hr.Text += data.GetValue("hr").ToString();
            this.hr_email.Text += data.GetValue("hr_email").ToString();
            this.hr_phone.Text += data.GetValue("hr_phone").ToString();
            this.datetime.Text = "Date : " + data.GetValue("date").ToString() + "  Time : " + data.GetValue("time").ToString();
            this.extradetails.Text = data.GetValue("extradetails").ToString();
            this.req_doc.Text = data.GetValue("req_doc").ToString();
        }

        private void InterviewDetailCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
