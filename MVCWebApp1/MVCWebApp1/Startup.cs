using DataAccessLayerLib;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp1
{
    public class Startup
    {
        // allows us to setup or include configuration values.
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // allows us to add services to the dependency injection container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSession();    // enabling session service
            /*services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromSeconds(5);      // session data will exist for only 5 seconds.
            });*/


            services.AddScoped<IScopedService, OperationService>();     // whenever I make use of IScopedService give me object of OperationService.
            services.AddTransient<ITransientService, OperationService>();
            services.AddSingleton<ISingletonService, OperationService>();

            services.AddScoped<EmpDataStore>();

            services.AddDbContext<MastekTrainingContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MyDBConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // allows us to add middleware and services to HTTP pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
