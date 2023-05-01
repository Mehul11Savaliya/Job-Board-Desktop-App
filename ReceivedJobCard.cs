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
    public partial class ReceivedJobCard : UserControl
    {
        private JObject data;
        public ReceivedJobCard(JObject data)
        {
            this.data = data;
            InitializeComponent();
        }

        private void ReceivedJobCard_Load(object sender, EventArgs e)
        {
            this.rc_idx.Text = data.GetValue("idx").ToString();
            this.rc_interviewsched.Text = "not implemented";
            this.rc_posit.Text = data.GetValue("pjttl").ToString();
            this.rc_addr.Text = "not implemented yet";//data.GetValue("").ToString();
            this.rc_cpemail.Text = data.GetValue("pjemail").ToString();
            this.rc_cpname.Text =data.GetValue("pjcpname").ToString() ;
            this.rc_webst.Text = data.GetValue("pjurl").ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
