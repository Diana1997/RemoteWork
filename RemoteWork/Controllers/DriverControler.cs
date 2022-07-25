using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RemoteWork.Responses;
using RemoteWork.Responses.LX_VDetail_OrderInteractive;

namespace RemoteWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {
	    [HttpGet("LX_VDetail_OrderInteractive_create_pdf")]
	    public IActionResult LX_VDetail_OrderInteractive_Create_Pdf()
	    {
		    string body = XmlService.LX_VDetail_OrderInteractiveRequest();
		    Stream response = HttpHelper.Post(body);
		    var record = XmlService.LX_VDetail_OrderInteractiveResponseString(response);
		  //string html =   FileCreator.XmlToHtml(record);
		//    FileCreator.CreatePdfFromHtml(html);
		 //   FileCreator.CreatePdf(@"D:\Pdf\test.pdf", record);
		    return Ok(record);
	    }
	    
        [HttpGet("LX_VDetail_OrderInteractive")]
        public IActionResult LX_VDetail_OrderInteractive()
        {
            string body = XmlService.LX_VDetail_OrderInteractiveRequest();
            Stream response = HttpHelper.Post(body);
            Record record = XmlService.LX_VDetail_OrderInteractiveResponse(response);
           return Ok(record);
        }

        [HttpGet("DL_OrderInteractive")]
        public IActionResult DL_OrderInteractive()
        {
            string body = XmlService.DL_OrderInteractiveRequest();
            Stream response = HttpHelper.Post(body);
            Responses.DL_OrderInteractive.Record record = XmlService.DL_OrderInteractiveResponse(response);
            return Ok(record);
        }
        
        
        [HttpGet("LX_Full_OrderInteractive")]
        public IActionResult LX_Full_OrderInteractive()
        {
            string body = XmlService.LX_Full_OrderInteractiveRequest();
            Stream response = HttpHelper.Post(body);
            var  record = XmlService.LX_Full_OrderInteractiveResponse(response);  //todo xml serialization exception
            return Ok(record);
        }
        
        [HttpGet("LX_Activity_OrderInteractive")]
        public IActionResult LX_Activity_OrderInteractive()
        {
            string body = XmlService.LX_Activity_OrderInteractiveRequest();
            Stream response = HttpHelper.Post(body);
            var record = XmlService.LX_Activity_OrderInteractiveResponse(response);
            return Ok(record);
        }
        

        [HttpGet("DL_SendOrders")]
        public IActionResult DL_SendOrders()
        {
            string body = XmlService.DL_SendOrdersRequest();
            Stream response = HttpHelper.Post(body);
            var record = XmlService.DL_SendOrdersResponse(response);
            return Ok(record);
        }

        [HttpGet]
        public IActionResult Test()
        {
            string xml = @"	<EventList>
			<EventItem>
				<Common>
					<Subtype>ACC</Subtype>
					<State>
						<Abbrev>CA</Abbrev>
						<Full>CALIFORNIA</Full>
					</State>
					<Date>
						<Year>2017</Year>
						<Month>2</Month>
						<Day>1</Day>
					</Date>
					<ModifiedDate>
						<Year>2017</Year>
						<Month>2</Month>
						<Day>27</Day>
					</ModifiedDate>
					<Location>SACRAMENTO</Location>
					<IsHazMat>N</IsHazMat>
					<IsCommercial>N</IsCommercial>
					<Plate>6TTT666</Plate>
				</Common>
				<DescriptionList>
					<DescriptionItem>
						<AdrLargeDescription>** ACCIDENT **</AdrLargeDescription>
						<AdrSmallDescription>** ACCIDENT **</AdrSmallDescription>
						<StateDescription>** ACCIDENT **</StateDescription>
						<Acd>-</Acd>
						<Avd1>AA01</Avd1>
						<TableKey>CAA01** ACCIDENT **</TableKey>
					</DescriptionItem>
				</DescriptionList>
				<Accident>
					<ReportNumber>34040000407</ReportNumber>
				</Accident>
			</EventItem>
			<EventItem>
				<Common>
					<Subtype>SUSPENSION</Subtype>
					<State>
						<Abbrev>CA</Abbrev>
						<Full>CALIFORNIA</Full>
					</State>
					<Date>
						<Year>2014</Year>
						<Month>7</Month>
						<Day>3</Day>
					</Date>
					<IsHazMat>N</IsHazMat>
					<IsCommercial>N</IsCommercial>
				</Common>
				<NoteList>
					<NoteItem>
						<Note>VERBAL NOTICE DOCUMENT ON FILE</Note>
					</NoteItem>
				</NoteList>
				<DescriptionList>
					<DescriptionItem>
						<AdrLargeDescription>FAILURE TO APPEAR NOTICE</AdrLargeDescription>
						<AdrSmallDescription>FAILURE TO APPEAR NOTICE</AdrSmallDescription>
						<StateDescription>FAILURE TO APPEAR NOTICE</StateDescription>
						<StateCode>938</StateCode>
						<Acd>D40</Acd>
						<Avd1>UE02</Avd1>
						<TableKey>CAA03938</TableKey>
					</DescriptionItem>
				</DescriptionList>
				<Action>
					<ActualDate>
						<Year>2017</Year>
						<Month>9</Month>
						<Day>25</Day>
					</ActualDate>
					<MailDate>
						<Year>2014</Year>
						<Month>6</Month>
						<Day>3</Day>
					</MailDate>
				</Action>
			</EventItem>
			<EventItem>
				<Common>
					<Subtype>FTA</Subtype>
					<State>
						<Abbrev>CA</Abbrev>
						<Full>CALIFORNIA</Full>
					</State>
					<Date>
						<Year>2017</Year>
						<Month>2</Month>
						<Day>1</Day>
					</Date>
					<ModifiedDate>
						<Year>2017</Year>
						<Month>5</Month>
						<Day>16</Day>
					</ModifiedDate>
					<Location>SACRAMENTO</Location>
					<LocationCode>34470</LocationCode>
					<DocketNumber>*CC0000</DocketNumber>
					<Plate>6TTT666</Plate>
				</Common>
				<DescriptionList>
					<DescriptionItem>
						<AdrLargeDescription>DRIVING WHEN PRIVILEGE SUSPENDED/REVOKED FOR OTHER REASONS</AdrLargeDescription>
						<AdrSmallDescription>DRV SUSP/REVK-OTHER REASON</AdrSmallDescription>
						<StateDescription>DRIVING WHEN PRIVILEGE SUSPENDED/REVOKED FOR OTHER REASONS</StateDescription>
						<StateCode>14601.1</StateCode>
						<Acd>B26</Acd>
						<Avd1>DB09</Avd1>
						<TableKey>CAA01146011</TableKey>
					</DescriptionItem>
					<DescriptionItem>
						<AdrLargeDescription>NOTICE TO DMV-FAILURE TO APPEAR</AdrLargeDescription>
						<AdrSmallDescription>NOTICE TO DMV-FAILURE TO APPEAR</AdrSmallDescription>
						<StateDescription>NOTICE TO DMV-FAILURE TO APPEAR</StateDescription>
						<StateCode>40509.5</StateCode>
						<Acd>D40</Acd>
						<Avd1>UE02</Avd1>
						<TableKey>CAA01405095</TableKey>
					</DescriptionItem>
				</DescriptionList>
			</EventItem>
		</EventList>";
            var response = xml.DeserializeXML<Responses.LX_Full_OrderInteractive.EventList>();
            return Ok(response);

        }
    }
}