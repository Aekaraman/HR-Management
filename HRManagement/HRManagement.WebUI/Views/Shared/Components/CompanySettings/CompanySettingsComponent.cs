using HRManagement.Data.Entities;
using HRManagement.Data.Repositories.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.WebUI.Views.Shared.Components.
    
    Settings
{
    [ViewComponent(Name = "CompanySettings")]
    public class CompanySettingsComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(Personel personel)
        {
            Company company = new Company();
             company= CompanyRepository.CompanRep.GetCompanyByID(personel.CompanyID);
            return Task.FromResult<IViewComponentResult>(View(company));
        }
    }
}
