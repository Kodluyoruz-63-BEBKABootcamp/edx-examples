using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace edx_project
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //services.AddControllersWithViews(configuration => configuration.EnableEndpointRouting=false);
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
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseMvcWithDefaultRoute();

            //app.UseMvc(routes => {
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //    routes.MapRoute(
            //        name: "productSearch",
            //        template: "search/{kw?}",
            //        defaults: new { controller = "Product", action = "Search" });
            //    routes.MapRoute(
            //        name: "docSearch",
            //        template: "help/{kw?}",
            //        defaults: new { controller = "Help", action = "FullTextSearch" });
            //});

            //conventional routing
            app.UseEndpoints(endpoints =>
            {
                endpoints.Map(
                    pattern: "homepage",
                    requestDelegate: context =>
                    {
                        context.Response.Redirect("/home/index");
                        return Task.CompletedTask;
                    });
                endpoints.Map(
                    pattern: "adminpage",
                    requestDelegate: context =>
                    {
                        context.Response.Redirect("/admin/home/index");
                        return Task.CompletedTask;
                    });
                endpoints.Map(
                    pattern: "editorpage",
                    requestDelegate: context =>
                    {
                        context.Response.Redirect("/editor/home/index");
                        return Task.CompletedTask;
                    });
                endpoints.Map(
                    pattern: "test",
                    requestDelegate: context =>
                    {
                        context.Response.Redirect("/forms/TestPartialView");
                        return Task.CompletedTask;
                    });
                endpoints.MapControllerRoute(
                    name: "Admin",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id=0}/{name:alpha?}");
            });
        }
    }
}
