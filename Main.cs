using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
   
    public partial class Mainx : Form
    {
        ApiHandler apiHandler= new ApiHandler();
        public Mainx()
        {
            InitializeComponent();
            renderAllJobs();
        }

        private void renderAllJobs()
        {
            Panel sp; //= new StackPanel();
            

            JArray a = apiHandler.getAllJobs();
           int i=0;
            foreach (JObject jsn in a)
            {
               // MessageBox.Show(jsn.ToString());
                JobCard ax = new JobCard(jsn);
                this.jobs.Controls.Add(ax);
            }
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            RegisterDialogcs r = new RegisterDialogcs();
            r.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string idx = id.Text;
            string passx = pass.Text;
            if (idx==""||passx=="")
            {
                MessageBox.Show("Fill All Field If Possible!");
            }
            else
            {
                JObject data = new JObject();
                data.Add("sign-email", idx);
                data.Add("sign-pass", passx);
                JObject result = apiHandler.authenticateUser(data);
                if (result.GetValue("msg")==null)
                {
                    if (result.GetValue("fname")==null)
                    {
                        CompanyPage c =new CompanyPage(result);
                        this.Hide();
                        c.Show();
                    }
                    else
                    {
                     UserPage p =    new UserPage(result);
                      
                       this.Hide();

                        p.Show();
                        
                    }
                   // MessageBox.Show(result.ToString());
                }
                else
                {
                    MessageBox.Show(result.GetValue("msg").ToString());
                }
            }
        }

        private void Mainx_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
