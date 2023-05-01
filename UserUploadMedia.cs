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
    public partial class UserUploadMedia : Form
    {
        byte[] resumepdf;
        byte[] image;
        JObject udata;
        public UserUploadMedia(JObject udata)
        {
            InitializeComponent();

            this.udata = udata;
            MessageBox.Show(udata.ToString());
          
            kryptonWebBrowser1.DocumentText = @"
<!DOCTYPE html>
<html lang='en'>

<head>
    <meta charset='UTF-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Post Resume</title>
    <link href='https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD' crossorigin='anonymous'>
</head>

<body>
    <div class='container-fluid' style='width: 100vw;'>
    <form action='http://localhost:5555/upload2/resume_profile' method='post' enctype='multipart/form-data'>
<input type='hidden' name='email' value='" + this.udata.GetValue("email").ToString()+@"'>
<input type='hidden' name='pass' value='"+ this.udata.GetValue("password").ToString() + @"'>
        <label class='form-label' for='customFile'>Resume</label>
        <input type='file' class='form-control' name='resume' accept='.pdf' />
        <label class='form-label' for='customFile'>Profile</label>
        <input type='file' class='form-control' name='profilepic' accept='.jpg,.png,.jpeg' />
        <input type='submit' value='submit'>
    </form>
    <h1></h1>
</div>
</body>

</html>";
        }

        private void UserUploadMedia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void resume_Click(object sender, EventArgs e)
        {
            this.selectfile.Title = "Select PDF File";
            this.selectfile.Filter = "Pdf Files |*.pdf";

            if (this.selectfile.ShowDialog() == DialogResult.OK)
            {
                this.resume.Text = this.selectfile.FileName;
                resumepdf = ReadFile(this.selectfile.OpenFile());
                MessageBox.Show(resumepdf.ToString());
            }
        }

        private void photo_Click(object sender, EventArgs e)
        {
            this.selectfile.Title = "Select Image File";
            this.selectfile.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (this.selectfile.ShowDialog() == DialogResult.OK)
            {
                this.photo.Text = this.selectfile.FileName;

                image = ReadFile(this.selectfile.OpenFile());

            }
            MessageBox.Show(image.ToString());

        }

        private void submit_Click(object sender, EventArgs e)
        {
      
        }

        private void UserUploadMedia_Load(object sender, EventArgs e)
        {
            this.selectfile.InitialDirectory = @"C:\";
            this.selectfile.RestoreDirectory = true;
            this.selectfile.Multiselect = false;
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
