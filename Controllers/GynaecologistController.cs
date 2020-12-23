using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sunrisehospital.Models;

namespace sunrisehospital.Controllers
{
    public class GynaecologistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
    }
}