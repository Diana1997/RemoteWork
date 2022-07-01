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
         
         var body = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">" + "\n" +
                    @"    <Body>" + "\n" +
                    @"    <OrderInteractive xmlns=""http://adrconnect.mvrs.com/adrconnect/2013/04/"">" + "\n" +
                    @"            <inCommunications>" + "\n" +
                    @"                <![CDATA[" + "\n" +
                    @"                <Communications>" + "\n" +
                    @"                    <Account>K1808</Account>" + "\n" +
                    @"                    <UserID>01</UserID>" + "\n" +
                    @"                    <Password>Test_123</Password>" + "\n" +
                    @"                    <ReportTypes>" + "\n" +
                    @"                        <Type>XML2.03</Type>" + "\n" +
                    @"                    </ReportTypes>" + "\n" +
                    @"                </Communications>]]>" + "\n" +
                    @"        	</inCommunications>" + "\n" +
                    @"	        <inOrder>" + "\n" +
                    @"	            <OrderXml>" + "\n" +
                    @"	                <![CDATA[" + "\n" +
                    @"	                <Order>" + "\n" +
                    @"						<Handling>OL</Handling>" + "\n" +
                    @"						<Misc>Test Ref</Misc>" + "\n" +
                    @"						<BillCode>Test BC</BillCode>" + "\n" +
                    @"						<State>" + "\n" +
                    @"							<Abbrev>AZ</Abbrev>" + "\n" +
                    @"							<Full></Full>" + "\n" +
                    @"						</State>" + "\n" +
                    @"						<Subtype>ST</Subtype>" + "\n" +
                    @"						<ProductID>LX</ProductID>" + "\n" +
                    @"						<HintMvrInsuranceOption>VDETAIL</HintMvrInsuranceOption>" + "\n" +
                    @"						<HintVertical>Insurance</HintVertical>" + "\n" +
                    @"						<Purpose>AA</Purpose>" + "\n" +
                    @"						<License>A20203005</License>" + "\n" +
                    @"						<FirstName>JOHN</FirstName>" + "\n" +
                    @"						<LastName>DOE</LastName>" + "\n" +
                    @"						<DOB>" + "\n" +
                    @"							<Year>1990</Year>" + "\n" +
                    @"							<Month>06</Month>" + "\n" +
                    @"							<Day>04</Day>" + "\n" +
                    @"						</DOB>" + "\n" +
                    @"					</Order>]]>" + "\n" +
                    @"					</OrderXml>" + "\n" +
                    @"			</inOrder>" + "\n" +
                    @"		</OrderInteractive>" + "\n" +
                    @"	</Body>" + "\n" +
                    @"</Envelope>         ";
         
        body =  XmlHelper.CreateObject();
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