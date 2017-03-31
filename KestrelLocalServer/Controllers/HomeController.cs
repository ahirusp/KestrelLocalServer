using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace KestrelLocalServer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public JsonResult Index()
        {
            return new JsonResult("Hello");
        }
    }
}
