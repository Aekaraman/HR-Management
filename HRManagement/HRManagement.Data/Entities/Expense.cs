using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagement.Data.Entities
{
    public class Expense:BaseEntity
    {
        public string ExpenseType { get; set; }
        public decimal? Amount { get; set; } //harcamalar
        public DateTime? PaymentsLastDay { get; set; }
        public long PersonelID { get; set; }
        public Personel Personel { get; set; }
    }
}
