using HRManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagement.Data.Mapping
{
    public class ExpenseMapping : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.PaymentsLastDay).IsRequired(false);
            builder.Property(a => a.Amount).IsRequired(false);
            builder.Property(a => a.ExpenseType).IsRequired(false);
            builder.HasOne(a => a.Personel).WithMany(a => a.Expenses).HasForeignKey(a => a.PersonelID);
        }
    }
}
