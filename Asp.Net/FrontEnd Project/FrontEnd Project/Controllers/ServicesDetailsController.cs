using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd_Project.Controllers
{
    public class ServicesDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
