
using BLL.Abstract;
using DAL;
using DAL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EA.WebAppUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<DbBlogContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IHeaderBLL, HeaderBLL>();
           

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "Management",
                    areaName: "Management",
                    pattern: "Management/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller}/{action}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.Run();
        
    }
    }
}
