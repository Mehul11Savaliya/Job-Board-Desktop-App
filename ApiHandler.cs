using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project2
{
    internal class ApiHandler
    {
        public const  string API = "http://127.0.0.1:5555/api/";
        public JArray getAllJobs()
        {
            JArray ja = null;

            var client = new RestClient();
            var request = new RestRequest("http://localhost:5555/api/getAllJobs");
            request.Method=Method.Post;
            var response = client.Execute(request);
             ja = JArray.Parse(response.Content);
          
            return ja;
        }

        public bool registerUser(JObject data) {
            bool res = false;

            HttpWebRequest webRequest;

            string requestParams = data.ToString();

            webRequest = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5555/api/uregister");

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            // Get the response.
            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    string Json = rdr.ReadToEnd(); // response from server
                    if (Json == "true") 
                    {
                        res = true;
                    }
                }
            }

            return res;
        }

        public bool registerCompany(JObject data)
        {
            bool res = false;

            HttpWebRequest webRequest;

            string requestParams = data.ToString();

            webRequest = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5555/api/cpregister");

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            // Get the response.
            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    string Json = rdr.ReadToEnd(); // response from server
                    if (Json == "true")
                    {
                        res = true;
                    }
                }
            }


            return res;
        }

        public JObject authenticateUser(JObject data)
        {
            JToken result = null;
            HttpWebRequest webRequest;

            string requestParams = data.ToString();

            webRequest = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5555/api/accept");

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            // Get the response.
            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    string Json = rdr.ReadToEnd(); // response from server              
                    
                    result = JToken.Parse(Json);
                   
                }
            }


            return JObject.Parse(result.ToString());
        }

        public  JObject appyJob(JObject currjob)
        {
            JObject result = null;
            string requestParams = currjob.ToString();


            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(API+"applyJob");

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;

            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            // Get the response.
            using (WebResponse response = webRequest.GetResponse())
            {
                //Console.WriteLine(response.StatusCode);
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    string Json = rdr.ReadToEnd(); // response from server              

                    result = JObject.Parse(JToken.Parse(Json).ToString());

                }
            }
            return result;
        }

        public JArray getAppliedJob(JObject userdata)
        {
            JArray result = null;

            string requestParams = userdata.ToString();


            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(API + "getAppliedJob");

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;

            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            // Get the response.
            using (WebResponse response = webRequest.GetResponse())
            {
                //Console.WriteLine(response.StatusCode);
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    string Json = rdr.ReadToEnd(); // response from server              

                    result = JArray.Parse(JToken.Parse(Json).ToString());

                }
            }

            return result;
        }

        public JObject deleteJobUser(JObject cpjobjson)
        {
            JObject result = null;

            try {
                result = this.httpWebrequestJson(API + "deleteJobUser", cpjobjson);
                MessageBox.Show(result.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
           
            return result;

        }

        public JArray getAcceptedJob(JObject data)
        {
            JArray tmp = null;

            try
            {
                tmp = httpWebrequestJsonArray(API+ "receivedJobUser",data);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return tmp;
        }

        public async void setJob(JObject body)
        {

            using var httpClient = new HttpClient();
            var url = "http://localhost:5555/tesxt";

         
       
      
             using var formData = new MultipartFormDataContent();
            var fileContent1 = new ByteArrayContent(File.ReadAllBytes(body.GetValue("pjposter").ToString()));
            var fileContent2 = new ByteArrayContent(File.ReadAllBytes(body.GetValue("pjfile").ToString()));
            var json = JsonConvert.SerializeObject(body);
            var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            formData.Add(stringContent, "data");
            formData.Add(fileContent1, "file1", "example1.jpg");
            formData.Add(fileContent2, "file2", "example2.pdf");
           var response = await httpClient.PostAsync(url, formData);
            httpClient.Dispose();
            MessageBox.Show("JOB Posted");
        }

        public async void updteUserMedia(JObject body)
        {

            using var httpClient = new HttpClient();
            var url = "http://localhost:5555/tesxt";




            using var formData = new MultipartFormDataContent();
            var fileContent1 = new ByteArrayContent(File.ReadAllBytes(body.GetValue("pjposter").ToString()));
            var fileContent2 = new ByteArrayContent(File.ReadAllBytes(body.GetValue("pjfile").ToString()));
            var json = JsonConvert.SerializeObject(body);
            var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            formData.Add(stringContent, "data");
            formData.Add(fileContent1, "file1", "example1.jpg");
            formData.Add(fileContent2, "file2", "example2.pdf");
            var response = await httpClient.PostAsync(url, formData);
            httpClient.Dispose();
            MessageBox.Show(response.Content.ToString());
        }

        public JArray getPostedJob(JObject cpdata)
        {
            JArray result = null;

            try
            {
                result = this.httpWebrequestJsonArray(API + "getPostedJobs", cpdata);
            }catch(Exception e)
            {
                MessageBox.Show("Api Handler : "+e.Message);
            }

            return result;
        }

        public JObject deleteJob(JObject jobDetails)
        {
            JObject result = null;
            try
            {
                result = this.httpWebrequestJson(API + "deleteJob", jobDetails);

            }
            catch (Exception e)
            {
                MessageBox.Show("Api Handler deletejob "+e.ToString());
            }
            
            return result;
        }

        public JArray getApplicants(JObject jobDetails)
        {

            JArray result = null;
            try
            {
                result = this.httpWebrequestJsonArray(API + "getApplicants", jobDetails);

            }
            catch (Exception e)
            {
                MessageBox.Show("Api Handler deletejob " + e.ToString());
            }

            return result;
        }

        public JObject acceptApplicants(JObject body)
        {
            JObject result=new JObject();
            try
            {
                result = this.httpWebrequestJson(API+ "acceptJob",body);
            }
            catch (Exception e)
            {
                MessageBox.Show("API Handler acceptApplicant Error : "+e.Message);
                
            }
            return result;
        }

        public JObject setInterview(JObject body)
        {
            JObject result=null;
            try
            {
                result = httpWebrequestJson(API+ "setInterview",body);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("API Handler setInterview Error : "+e.Message);
               
            }
            return result;
        }

        public JArray getSchedules(JObject body)
        {
            JArray data = null;
            try
            {
                data = this.httpWebrequestJsonArray(API+ "getSchedules", body);
            }
            catch (Exception E)
            {
                MessageBox.Show("API Handler getSchedule Error : " + E.Message);
                Console.WriteLine(E.Message);
            }
            return data;
        }

        public JObject deleteSchedule(JObject body)
        {
            JObject result=null;

            try
            {
                result = this.httpWebrequestJson(API + "deleteSChedule", body);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("API Handler deleteSchedule Error : "+e.Message);
            }
            return result;
        }

        public JObject getInterviewDetails(JObject body)
        {
            JObject result = null;
            try
            {
                result = this.httpWebrequestJson(API+ "getInterviewDetails", body);
            }
            catch (Exception e)
            {
                result = null;
               // ScheduleDetailsCard sdc = new ScheduleDetailsCard()
              //  MessageBox.Show("ApiHandler getInterviewDetails error "+e.Message);
            }

            return result;

        }

        private JObject httpWebrequestJson(string api,JObject body)
        {
            JObject result = null;

            string requestParams = body.ToString();


            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(api);

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;

            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            // Get the response.
            using (WebResponse response = webRequest.GetResponse())
            {
                //Console.WriteLine(response.StatusCode);
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    string Json = rdr.ReadToEnd(); // response from server              

                    result = JObject.Parse(JToken.Parse(Json).ToString());

                }
            }

            return result;
        }

        private JArray httpWebrequestJsonArray(string api,JObject body)
        {
            JArray tmp = null;


            string requestParams = body.ToString();


            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(api);

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;

            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            // Get the response.
            using (WebResponse response = webRequest.GetResponse())
            {
                //Console.WriteLine(response.StatusCode);
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    string Json = rdr.ReadToEnd(); // response from server              

                    tmp = JArray.Parse(JToken.Parse(Json).ToString());

                }
            }


            return tmp;
        }   


    }


    //referebnce sec
    /*
          var person = new Person("John Doe", "gardener");

var json = JsonConvert.SerializeObject(person);
var data = new StringContent(json, Encoding.UTF8, "application/json");

var url = "https://httpbin.org/post";
using var client = new HttpClient();

var response = await client.PostAsync(url, data);

var result = await response.Content.ReadAsStringAsync();
Console.WriteLine(result);

record Person(string Name, string Occupation);



    
            var client = new HttpClient();
            var data = new StringContent(currjob.ToString(), Encoding.UTF8, "application/json");
            
            var response = await client.PutAsync(API + "applyJob", data);
            if (response.StatusCode == HttpStatusCode.OK)
            {

            }
         
          */
}
