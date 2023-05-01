using Krypton.Toolkit;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project2
{
    public partial class RegisterDialogcs : KryptonForm
    {
        ApiHandler apiHandler;
        public RegisterDialogcs()
        {
            InitializeComponent();
            apiHandler = new ApiHandler();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void uregister_Click(object sender, EventArgs e)
        {
            string fname = ufname.Text;
            string lname = ulname.Text;
            string email = uemail.Text;
            string pass = upassword.Text;
            string phone = uphone.Text;
            JObject data = new JObject();
            data.Add("regfname", fname);
            data.Add("reglname", lname);
            data.Add("regemail", email);
            data.Add("regphone", phone);
            data.Add("regpass", pass);
            //MessageBox.Show(data.ToString());

            if (fname == "" || lname == "" || email == "" || pass == "" || phone == "")
            {
                MessageBox.Show("Fill All Details If Possible");
            }
            else { 
            if (apiHandler.registerUser(data))
            {
                MessageBox.Show("User Already Exist🐦");
            }
            else
            {
                MessageBox.Show("Successfully Registered\nYou Can Now Login!🐦");
            }
            }
        }

        private void eregister_Click(object sender, EventArgs e)
        {
            string fname = efname.Text;
            string lname = elname.Text;
            string email = eemail.Text;
            string pass = epass.Text;
            string phone = ephone.Text;
            string cpname = ecpname.Text;
            string cpwebsite = ecpwebsite.Text;
            string addresss = eaddress.Text;
            string size = ecpsize.Text;
            JObject data = new JObject();

            data.Add("ROLE", "CP");
            data.Add("cpfname", fname);
            data.Add("cplname", lname);
            data.Add("cpname", cpname);
            data.Add("cpurl", cpwebsite);
            data.Add("cpaddr", addresss);
            data.Add("cpsize", size);
            data.Add("cpemail", email);
            data.Add("cpphone", phone);
            data.Add("cppass", pass);

            if (fname == "" || lname == ""||email==""||pass==""||phone==""||cpname==""||cpwebsite==""||addresss==""||size=="")
            {
                MessageBox.Show("Fill All Details If Possible");
            }
            else { 
            if (apiHandler.registerCompany(data))
            {
                MessageBox.Show("User Already Exist🐦");

            }
            else
            {
                MessageBox.Show("Successfully Registered\nYou Can Now Login!🐦");

            }
            }
        }
    }
}
