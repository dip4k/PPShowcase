using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PPShowcase.Data;
using PPShowcase.Data.Repository.impl;
using PPShowcase.Data.Repository;
using PPShowcase.Models;

namespace PPShowcase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<PPShowcaseContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("PPShowcaseContext") ?? throw new InvalidOperationException("Connection string 'PPShowcaseContext' not found.")));

            builder.Services.AddAutoMapper(typeof(Program));
            // Add services to the container.
            builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();


            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            //using (var scope = app.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;

            //    SeedData.Initialize(services);
            //}
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Product}/{action=Index}/{id?}");

            app.Run();
        }
    }
}