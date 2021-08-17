using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using HRManagement.Data.Entities;

namespace HRManagement.WebUI.Controllers
{
    public class PersonelsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UpcomingPayments()
        {
            return View();
        }

        public IActionResult Birthdays()
        {
            return View();
        }

        //public IActionResult jsonList()
        //{

        //    return Json(

        //}
       
    }
}
