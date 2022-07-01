using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RemoteWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {


        public DriverController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> Test()
        {
            try
            {
            string url = @"https://demo2.mvrs.com/AdrConnect/AdrConnectWebService.svc";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            byte[] bytes;
         

       string body =  XmlHelper.CreateObject();
        body = body.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
         
            bytes = System.Text.Encoding.ASCII.GetBytes(body);
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            request.Headers.Add("Content-Type", "text/xml");
            request.Headers.Add("SOAPAction", "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/OrderInteractive");
            request.Headers.Add("Accept", "*/*");
            request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            request.Headers.Add("Connection", "keep-alive");
            using (Stream requestStream = request.GetRequestStream())
            {
                 requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
            }


            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();

            }
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return Ok();
        }
    }
}