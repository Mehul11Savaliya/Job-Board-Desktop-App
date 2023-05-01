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
    public partial class CompanyUploadMedia : Form
    {
        JObject udata;

        public CompanyUploadMedia(JObject udata)
        {
            InitializeComponent();
            this.udata = udata;

         //   MessageBox.Show(udata.ToString());

            this.kryptonWebBrowser1.DocumentText = @"<!DOCTYPE html>
<html lang='en'>

<head>
    <meta charset='UTF-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>upload Image</title>
    <link href='https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD' crossorigin='anonymous'>
</head>

<body>
    <div class='container-fluid' style='width: 50vw;'>
    <form action='http://localhost:5555/upload2/cpupdatemedia' method='post' enctype='multipart/form-data'>
        <label class='form-label' for='customFile'>Profile</label>
            <input type='hidden' name ='cpemail' value='" + this.udata.GetValue("cpemail").ToString()+@"'>
            <input type='hidden' name ='cppass' value='"+ this.udata.GetValue("cppass").ToString() + @"'>
<input type='file' class='form-control' name='profilepic' accept='.jpg,.png' />
        <input type='submit' value='submit'>
    </form>
    <h1><%=data.msg%></h1>
</div>
</body>

</html>";

        }

        private void CompanyUploadMedia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
