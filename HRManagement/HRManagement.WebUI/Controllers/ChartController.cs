using HRManagement.Data.Entities;
using HRManagement.Data.Repositories.Concrete;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.WebUI.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [Produces("application/json")]
        public IActionResult VisualizeDepartmantResult()
        {

            List<DepartmanCountView> departmanCountViews = new List<DepartmanCountView>()
            {
                new DepartmanCountView { ID = "Kullanılan", Value = 4 },
            new DepartmanCountView { ID = "Kalan", Value = 16 }
        };

            return Json(departmanCountViews);
        }


        [Produces("application/json")]
        public IActionResult EmployeeLimitResult()
        {

            List<DepartmanCountView> departmanCountViews = new List<DepartmanCountView>()
            {
                new DepartmanCountView { ID = "Aktif Personel", Value = 4 },
                new DepartmanCountView { ID = "Pasif Personel", Value = 16 },
                new DepartmanCountView { ID = "Kalan Personel Limiti", Value = 16 }
        };

            return Json(departmanCountViews);
        }

        [Produces("application/json")]
        public IActionResult EmployeeOffDayChartVisualize()
        {

            List<DepartmanCountView> departmanCountViews = new List<DepartmanCountView>()
            {
                new DepartmanCountView { ID = "Kullanılan", Value = 60 },
                new DepartmanCountView { ID = "Kullanılmakta", Value = 60 },
                new DepartmanCountView { ID = "Kalan", Value = 200 }
            };

            return Json(departmanCountViews);
        }

        [Produces("application/json")]
        public IActionResult PackageUsageChartVisualize()
        {
            List<PackageUsageView> packageUsageViews = new List<PackageUsageView>()
            {
              new PackageUsageView{ Value="Kullanılan",Day=30},
              new PackageUsageView{ Value="Kalan",Day=90}
            };


            return Json(packageUsageViews);
        }

        [Produces("application/json")]
        public IActionResult PersonelLimitChartVisualize()
        {
            List<ChartValueView> ChartValueViews = new List<ChartValueView>()
            {
                new ChartValueView { Name = "Kullanılan", Value = 60 },
                new ChartValueView { Name = "Kalan", Value = 200 }
            };

            return Json(ChartValueViews);
        }

        [Produces("application/json")]
        public IActionResult UpcomingPaymentsChartVisualize()
        {
            List<ChartValueView> ChartValueViews = new List<ChartValueView>()
            {
                new ChartValueView { Name = "5/19/2021", Value = 60 },
                new ChartValueView { Name = "4/19/2021", Value = 200 },
                new ChartValueView { Name = "3/19/2021", Value = 1200 },
                new ChartValueView { Name = "2/19/2021", Value = 2200 },
                new ChartValueView { Name = "1/19/2021", Value = 600 }
            };

            return Json(ChartValueViews);
        }

    }
}
