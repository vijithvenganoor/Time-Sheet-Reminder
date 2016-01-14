using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TimeSheetReminder.Controllers
{
    public class TimeSheetController : ApiController
    {
        [HttpGet]
        public bool CheckTime()
        {

            return true;
        }
    }
}
