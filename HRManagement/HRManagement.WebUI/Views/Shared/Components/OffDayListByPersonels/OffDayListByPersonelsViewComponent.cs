using HRManagement.Data.Entities;
using HRManagement.Data.Repositories.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.WebUI.Views.Shared.Components.OffDayListByPersonels
{
    public class OffDayListByPersonelsViewComponent:ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<OffDay> offDays;
            OffDayRepository.OffDayRep.GetOffDays(out offDays);
            foreach (var item in offDays)
            {
                Personel personel= PersonelRepository.PersonelsRepository.GetPersonelByID(item.PersonelID);
                item.Personel = personel;
            }
            return Task.FromResult<IViewComponentResult>(View(offDays));
        }
    }
}
