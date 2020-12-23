using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sunrisehospital.Helper;
using sunrisehospital.Models;

namespace sunrisehospital.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly AppDbContext _context;
        public AppointmentController(AppDbContext context)
        {
            _context = context;
        }
        [Route("~/")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
         [HttpPost] 
       [Route("Index")]
        [ValidateAntiForgeryToken]   
        public IActionResult Create(BookAppointment bookAppointment)
        {
          
                _context.Add(bookAppointment);
                _context.SaveChanges();
            ModelState.Clear();
            string content = "Department: " + bookAppointment.Department;
            content += "<br>Doctor: " + bookAppointment.Doctor;
            content += "<br>Haveuvisitbefore: " + bookAppointment.Haveuvisitbefore;
            content += "<br>Number: " + bookAppointment.Number;
            content += "<br>Date: " + bookAppointment.Date;
            content += "<br>Name: " + bookAppointment.Name;
            content += "<br>Message: " + bookAppointment.Message;
            content += "<br>Email: " + bookAppointment.Email;

            if (MailHelper.Create(bookAppointment.Email, "", bookAppointment.Message, content))
            {
                ViewBag.msg = "Success";
            }
            else
            {
                ViewBag.msg = "Error";

            }
            return View("Index");

        }

    }
}
