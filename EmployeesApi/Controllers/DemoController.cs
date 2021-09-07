using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApi.Controllers
{
    public class DemoController : ControllerBase
    {
        // In the URL itself (RouteData)

        // Get /products/896342

        [HttpGet("products/{sku:int}")]
        public ActionResult LookUpProduct(int sku)
        {
            return Ok($"Here is product {sku}");
        }

        [HttpGet("/orders/{year:int}/{month:int:range(1,12)}/{day:int:range(1,31)}")]
        public ActionResult GetOrderForDate(int year, int month, int day)
        {
            return Ok($"Getting orders for {year}-{month}-{day}");
        }

    }
}
