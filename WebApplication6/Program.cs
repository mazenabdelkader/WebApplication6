using Bussiness_Logic_Layer.profiles;
using Bussiness_Logic_Layer.services.attachmentservice;
using Bussiness_Logic_Layer.services.classes;
using Bussiness_Logic_Layer.services.interfaces;
using Data_Acess_Layer.data;
using Data_Acess_Layer.data.repository.classes;
using Data_Acess_Layer.data.repository.interfaces;
using Data_Acess_Layer.unitofwork;
using Microsoft.EntityFrameworkCore;

namespace WebApplication6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddScoped<AppDBContext>();

            builder.Services.AddDbContext<AppDBContext>(Options =>
            {
                Options   // Enable lazy loading 
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            }
        );
            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>(); // allow dependency injection for IEmployeeRepository
            builder.Services.AddScoped<IDepartmentRepository, DepartmentReopistory>();
            builder.Services.AddScoped<IEmployeerepository, EmployeeRepository>(); // allow dependency injection for IEmployeeRepository

            builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();
            //builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            builder.Services.AddAutoMapper(M => M.AddProfile(new MappingProfiles()));
            builder.Services.AddScoped<IEmployeerepository, EmployeeRepository>();  

            builder.Services.AddScoped<IUnitOfwork, UnitOfWork>();
            builder.Services.AddScoped<IAttachmentService, AttachmentService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
