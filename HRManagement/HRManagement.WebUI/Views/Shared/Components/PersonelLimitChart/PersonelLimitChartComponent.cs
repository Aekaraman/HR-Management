using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.WebUI.Views.Shared.Components.PersonelLimitChart
{

    [ViewComponent(Name = "PersonelLimitChart")]
    public class UpcomingPaymentsChartComponent : ViewComponent
    {
        public UpcomingPaymentsChartComponent()
        {
        }

        //veri okumaları asynrn yapı olduğu için componentler aşağıdaki gibi olmalı . asynrn olmadığındada IViewComponentResult şeklinde olmalı IActionResult değil

        public Task<IViewComponentResult> InvokeAsync()
        {
            

            //asyrn olarak dönüş
            return Task.FromResult<IViewComponentResult>(View());
        }

    }
}
