using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.models.DepartmentModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Acess_Layer.data.configuration
{
    public class DepartmentConfiguration : BaseEntityConfiguration<Department>,IEntityTypeConfiguration<Department>
    {
        public new void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.id).UseIdentityColumn(10, 10);
            builder.Property(d => d.Name).HasColumnType("varchar(20)");
            builder.Property(d => d.code).HasColumnType("varchar(20)");
            builder.Property(d => d.createdon).HasDefaultValueSql("GETDATE()");
            builder.Property(d => d.lastmodifiedon).HasComputedColumnSql("GETDATE()");

            builder.HasMany(d => d.Employeess).WithOne(e => e.department).OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(d => d.id);
         

            base.Configure(builder);
        }
    }

}
    
    

