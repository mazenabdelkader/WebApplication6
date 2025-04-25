using Bussiness_Logic_Layer.services;
using Data_Acess_Layer.data;
using Data_Acess_Layer.data.repository.classes;
using Data_Acess_Layer.data.repository.interfaces;
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
                Options
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            }
        );
            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentReopistory>();
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
