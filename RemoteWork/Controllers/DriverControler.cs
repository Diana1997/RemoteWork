﻿using System;
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


        public DriverController()
        {
            
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
            var  record = XmlService.LX_Full_OrderInteractiveResponse(response);
            return Ok(record);
        }
    }
}