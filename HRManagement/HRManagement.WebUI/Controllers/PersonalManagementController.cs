using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManagement.Data.Entities;
using HRManagement.Data.Repositories.Concrete;

namespace HRManagement.WebUI.Controllers
{
    public class PersonalManagementController : Controller
    {
        public IActionResult Index(Personel? personel)
        {
            if (personel==null)
            {
                personel=new Personel();
            }
            return View(personel);
        }

       public IActionResult Create(Personel? personel)
        {
            if (personel == null)
            {
                personel = new Personel();
            }
            return View(personel);
        }

        public IActionResult Edit(long ID)
        {
            Personel personel=new Personel();
            personel = PersonelRepository.PersonelsRepository.GetPersonelByID(ID);
            return View("Index", personel);
        }
        public IActionResult Detail(long ID)
        {
            Personel personel = new Personel();
            personel = PersonelRepository.PersonelsRepository.GetPersonelByID(ID);
            return View(personel);
        }
        public IActionResult Update(Personel personel)
        {

            personel.BirthDay = DateTime.Now;
            personel.Password = "11";
            personel.CompanyID = 1;
            personel.Company = CompanyRepository.CompanRep.GetCompanyByID(1);
            personel.Role = UserRole.customerEmployee;
            personel.CreatedDate = DateTime.Now;
            personel.ModifiedDate = DateTime.Now;
            personel.IsActive = true;
            personel.HiredDate = DateTime.Now;
            personel.Departments = Departments.finance;
            PersonelRepository.PersonelsRepository.Update(personel);
            personel=new Personel();
            return View("Index", personel);
        }
        public IActionResult Delete(long ID,Personel? personel)
        {
            if (personel==null)personel=new Personel();
            
            PersonelRepository.PersonelsRepository.Delete(ID);
            return View("Index", personel);
        }
        public IActionResult AddPersonel(Personel? personel)
        {
            //Hazır gelmesini istediğimiz bir part varsa buraya ekleme yapılcak 
            //sadece şirket id atayın şirket objesini koymayın hata verir
            personel.CompanyID = long.Parse(Request.Cookies["CompanyID"]);
            personel.BirthDay = DateTime.Now;
            personel.Password = "11";
            personel.Phone = "1256888";
            
            personel.Role = UserRole.customerEmployee;
            personel.CreatedDate = DateTime.Now;
            personel.ModifiedDate=DateTime.Now;
            personel.IsActive = true;
            personel.HiredDate = DateTime.Now;
            personel.Departments = Departments.finance;
            if (personel!=null)
            {
                PersonelRepository.PersonelsRepository.Add(personel);
            }
            else
            {
                personel=new Personel();
            }
            personel = new Personel();
            return View("Index",personel);
        }

        public IActionResult ChangeStatu(long ID)
        {
            Personel personel = PersonelRepository.PersonelsRepository.GetPersonelByID(ID);

            if (personel.IsActive)
            {
                personel.IsActive = false;
            }
            else
            {
                personel.IsActive = true;
            }

            PersonelRepository.PersonelsRepository.Update(personel);
            personel = new Personel();
            return View("Index", personel);
        }



    }
}
