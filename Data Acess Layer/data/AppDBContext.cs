using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.data.configuration;
using Data_Acess_Layer.models.DepartmentModel;
using Data_Acess_Layer.models.EmployeeModel;
using Data_Acess_Layer.models.identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data_Acess_Layer.data
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
       
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=mazen01;Trusted_Connection=true;"); 
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Department> departments { get; set; }  
        public DbSet<Employee> employees { get; set; }  
    }
}
