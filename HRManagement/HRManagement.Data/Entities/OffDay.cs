using System;
using System.Collections.Generic;

namespace HRManagement.Data.Entities
{
    public class OffDay:BaseEntity
    {
     
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? OffDayLimit { get; set; }
        public string OffDayType { get; set; }
        public long PersonelID { get; set; }
        public Personel Personel { get; set; }

    }
}
