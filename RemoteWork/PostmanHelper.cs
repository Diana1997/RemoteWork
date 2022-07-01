using System;

namespace RemoteWork
{
    public class PostmanHelper
    {
        public static void Post()
        {
            /*var client = new RestClient("https://demo2.mvrs.com/AdrConnect/AdrConnectWebService.svc");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Content-Type", "text/xml");
request.AddHeader("SOAPAction", "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/OrderInteractive");
var body = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">" + "\n" +
@"    <Body>" + "\n" +
@"        <OrderInteractive xmlns=""http://adrconnect.mvrs.com/adrconnect/2013/04/"">" + "\n" +
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
request.AddParameter("text/xml", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);*/
        }
    }
}