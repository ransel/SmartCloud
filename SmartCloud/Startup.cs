using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartCloud.Domain.Entities;
using SmartCloud.Domain.Settings;
using SmartCloud.Services;
using SmartCloud.Services.Interfaces;
using SmartCloud.Services.Repositories;

namespace SmartCloud
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.Configure<IISOptions>(options => 
            {
                options.ForwardClientCertificate = false;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMemoryCache();
            services.AddMediatR();

            services.Configure<NotificationSettings>(Configuration.GetSection("NotificationSettings"));
            services.Configure<SqlServerSettings>(Configuration.GetSection("SqlServerSettings"));

            // System Services 
            services.AddScoped<ILoggingService, LoggingService>();
            services.AddScoped<IValidationService, ValidationService>();
            services.AddScoped<IMapperService, MapperService>();
            services.AddScoped<ICacheService, CacheService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IContextService, ContextService>();

            // Specialized Services
            services.AddScoped<IAccountService, AccountService>();

            // Repositories
            services.AddScoped<IAccountRepository, AccountRepository>();

            services.AddDbContext<MVP_DBContext>(options => 
                options.UseSqlServer(Configuration.GetValue<string>("SqlServerSettings:ConnectionString")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
