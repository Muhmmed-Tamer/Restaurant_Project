<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Restaurant_Project.Data;
using Restaurant_Project.Extension_Methods;
using Restaurant_Project.Models;

=======
>>>>>>> da21a9480f7601834aecb9fdb9d0cf42fcda55d4
=======
>>>>>>> da21a9480f7601834aecb9fdb9d0cf42fcda55d4
namespace Restaurant_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
<<<<<<< HEAD
<<<<<<< HEAD
            builder.Services.AddDbContext<ContextData>(Options => { Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); }); 
            builder.Services.AddIdentity<ApplicationUser , IdentityRole>(
                Options =>
                {
                   //Password 
                }
                ).AddEntityFrameworkStores<ContextData>();

            builder.Services.DependencyInjectionOfClassesAndInterfaces();
=======

>>>>>>> da21a9480f7601834aecb9fdb9d0cf42fcda55d4
=======

>>>>>>> da21a9480f7601834aecb9fdb9d0cf42fcda55d4
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
<<<<<<< HEAD
<<<<<<< HEAD
            app.UseAuthentication();
=======

>>>>>>> da21a9480f7601834aecb9fdb9d0cf42fcda55d4
=======

>>>>>>> da21a9480f7601834aecb9fdb9d0cf42fcda55d4
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
