using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Data.Entities
{
    public class Personel:BaseUserEntity
    {
        public string ProfilPicUrl { get; set; }
        public DateTime HiredDate { get; set; }
        public string Phone { get; set; }
        public Departments Departments { get; set; }
        public long CompanyID { get; set; }
        public Company Company { get; set; }
        public ICollection<OffDay> OffDays { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}
