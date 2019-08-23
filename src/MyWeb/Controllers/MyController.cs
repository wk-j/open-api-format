using System;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public dynamic Go()
        {
            return new
            {
                Date = DateTime.Now
            };
        }
    }
}