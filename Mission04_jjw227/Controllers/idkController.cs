using Microsoft.AspNetCore.Mvc;
using Mission04_jjw227.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_jjw227.Controllers
{
    public class idkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult calculator(GradeCalculator model)
        {
            return View();
        }
    }
}
