using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RouteYapilanmasi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //istediðimiz þekilde aþaðýdaki gibi özelleþtirebiliriz
                endpoints.MapControllerRoute("Default3", "{controller=Home}/{action=Index}/{id:int?}/{x:length(3)?}/{y:int:maxlength(3)?}");
                //endpoints.MapControllerRoute("Default2", "Anasayfa", new {controller="Home", action="Index"});
                //endpoints.MapControllerRoute("Default", "{controller=Personel}/{action=Index}");
                //endpoints.MapControllerRoute("Default", "{action}/ahmet/{controller}");
                //endpoints.MapControllerRoute("Default", "{action}/{controller}");


                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
