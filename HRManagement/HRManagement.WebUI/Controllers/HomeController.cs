using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using ClosedXML.Excel;
using HRManagement.Data.Entities;
using HRManagement.Data.Repositories.Concrete;
using HRManagement.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HRManagement.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CompanyManagerHomePage()
        {

            var ay = DateTime.Now.Month.ToString();
            switch (ay)
            {
                case "1":
                    ay = "Ocak";
                    break;
                case "2":
                    ay = "Şubat";
                    break;
                case "3":
                    ay = "Mart";
                    break;
                case "4":
                    ay = "Nisan";
                    break;
                case "5":
                    ay = "Mayıs";
                    break;
                case "6":
                    ay = "Haziran";
                    break;
                case "7":
                    ay = "Temmuz";
                    break;
                case "8":
                    ay = "Ağustos";
                    break;
                case "9":
                    ay = "Eylül";
                    break;
                case "10":
                    ay = "Ekim";
                    break;
                case "11":
                    ay = "Kasım";
                    break;
                case "12":
                    ay = "Aralık";
                    break;
            }
            ViewBag.ay = ay;

            return View();

        }

        public IActionResult SettingsPage()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ExportBirthdays()
        {
            DataTable dt = new DataTable("Grid");
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Çalışan Adı"),
                                        new DataColumn("Doğum günü"),
                                        new DataColumn("Mail"),
                                        new DataColumn("Telefon") });

            var personels = PersonelRepository.PersonelsRepository.GetPersonelBirthdayByCompanyID(1);

            foreach (var personel in personels)
            {
                dt.Rows.Add(personel.FirstName + " " + personel.LastName, personel.BirthDay, personel.Mail, personel.Phone);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YaklasanDogumGunleri" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx");
                }
            }
        }

        [HttpPost]
        public IActionResult ExportPayments()
        {
            DataTable dt = new DataTable("Grid");
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Çalışan Adı"),
                                        new DataColumn("Doğum günü"),
                                        new DataColumn("Mail"),
                                        new DataColumn("Telefon") });

            var personels = PersonelRepository.PersonelsRepository.GetPersonelBirthdayByCompanyID(1);

            foreach (var personel in personels)
            {
                dt.Rows.Add(personel.FirstName + " " + personel.LastName, personel.BirthDay, personel.Mail, personel.Phone);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YaklasanOdemeler" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx");
                }
            }
        }

        public IActionResult UserLogin()
        {
            //cookie yaz

            CookieOptions options = new CookieOptions();
            options.Expires = new DateTimeOffset(DateTime.Now.AddDays(1));
            string mail = Request.Form["userMail"].ToString();
            string pass = Request.Form["userPass"].ToString();
            Personel personel = PersonelRepository.PersonelsRepository.GetPersonelLogin(mail, pass);


            if (!HttpContext.Request.Cookies.ContainsKey("userMail") || HttpContext.Request.Cookies["userMail"] == "" || !HttpContext.Request.Cookies.ContainsKey("userPass") || HttpContext.Request.Cookies["userPass"] == "")
            {

                HttpContext.Response.Cookies.Append("userID", personel.ID.ToString());
                HttpContext.Response.Cookies.Append("CompanyID", personel.CompanyID.ToString());
                HttpContext.Response.Cookies.Append("userRole", personel.Role.ToString());
                ViewData["Message"] = "Success";
                if (personel.ModifiedDate == personel.CreatedDate)
                {

                    return RedirectToAction("Index", "Settings", personel);
                }
                else
                {


                    return RedirectToAction("Index", "Home");
                }

            }




            ViewData["Message"] = "Fail";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Append("userID", "");
            HttpContext.Response.Cookies.Append("CompanyID", "");
            HttpContext.Response.Cookies.Append("userRole", "");
            return RedirectToAction("Index", "Home");
        }
    }
}
