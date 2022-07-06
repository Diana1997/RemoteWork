using System;
using System.IO;
using System.Net;

namespace RemoteWork
{
    public class HttpHelper
    {
        public static Stream Post(string body)
        {
            try
            {

                string url = @"https://demo2.mvrs.com/AdrConnect/AdrConnectWebService.svc";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                byte[] bytes;

            
                body = body.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
         
                bytes = System.Text.Encoding.ASCII.GetBytes(body);
                request.ContentLength = bytes.Length;
                request.Method = "POST";
                request.Headers.Add("Content-Type", "text/xml");
                request.Headers.Add("SOAPAction", "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/OrderInteractive");
         
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                }


                HttpWebResponse response = (HttpWebResponse) request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream responseStream = response.GetResponseStream();
                    return responseStream;
                    //   string responseStr = new StreamReader(responseStream).ReadToEnd();
                    // XmlService.LX_VDetail_OrderInteractiveResponse(responseStream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return null;
        }
    }
}