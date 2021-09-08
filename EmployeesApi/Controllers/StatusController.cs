using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApi.Controllers
{
    public class StatusController : ControllerBase
    {
        // GET / status -> 200
        [HttpGet("status")]
        public ActionResult GetTheStatus()
        {
            var response = new GetStatusResponse
            {
                Message = "The server is running great!",
                WhenChecked = DateTime.Now
            };
            return Ok(response);
        }

    }


    public class GetStatusResponse
    {
        public string Message { get; set; }
        public DateTime WhenChecked { get; set; }
        public StandbyDeveloperInfo StandByDeveloper { get; set; }
    }


    public class StandbyDeveloperInfo
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }

}
