using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class AppliedJobCard : UserControl
    {
        private JObject jobjson = null;
        private ApiHandler apiHandler;
        private JObject udata;
        public AppliedJobCard(JObject jobjson, JObject udata)
        {
            this.jobjson = jobjson;
            apiHandler = new ApiHandler();
            InitializeComponent();
            this.udata = udata;
        }

        private void AppliedJobCard_Load(object sender, EventArgs e)
        {
            this.cmpny.Text += jobjson.GetValue("cpname").ToString();
            this.ttl.Text += jobjson.GetValue("jobttl").ToString();
            this.contacts.Text += jobjson.GetValue("cpemail").ToString();
            this.salary.Text += JObject.Parse(jobjson.GetValue("details").ToString()).GetValue("pjsalary").ToString();
            this.discr.Text += JObject.Parse(jobjson.GetValue("details").ToString()).GetValue("pjdisc").ToString();
            this.date.Text += jobjson.GetValue("datetime").ToString();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            JObject cptmp = new JObject();
            /*{
             cpname: cpny,
      cpemail: email,
      jobttl: ttl}
             */
            
            cptmp.Add("cpname",jobjson.GetValue("cpname").ToString());
            cptmp.Add("cpemail", jobjson.GetValue("cpemail").ToString());
            cptmp.Add("jobttl", jobjson.GetValue("jobttl").ToString());
            cptmp.Add("uemail", udata.GetValue("uemail").ToString());
            cptmp.Add("upass", udata.GetValue("upass").ToString());

            MessageBox.Show(apiHandler.deleteJobUser(cptmp).ToString());
        }

        private void reqreview_Click(object sender, EventArgs e)
        {

        }

        private void sendsms_Click(object sender, EventArgs e)
        {

        }

        private void visitsite_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = JObject.Parse(jobjson.GetValue("details").ToString()).GetValue("pjurl").ToString(),
                UseShellExecute = true
            });
        }
    }
}
