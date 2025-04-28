using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.models.EmployeeModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Acess_Layer.data.configuration
{
    public class EmployeeConfiguration :BaseEntityConfiguration<Employee> ,IEntityTypeConfiguration<Employee>
    {
        public new void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Name).HasColumnType("varchar(50)");
            builder.Property(p => p.Address).HasColumnType("varchar(50)");
            builder.Property(p => p.Salary).HasColumnType("decimal(10,2)");

            //builder.Property(E => E.gender)
            //    .HasConversion((empgender)=> empgender.ToString(),
            //        genderString => genderString);

            //builder.Property(E => E.EmployeeType)
            //    .HasConversion(
            //        empType => empType.ToString(),
            
            //       empTypeString => empTypeString);

            base.Configure(builder);
        }

    }
}
