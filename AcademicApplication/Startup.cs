using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AcademicApplication.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AcademicApplication.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using AcademicApplication.Services;
using Microsoft.AspNetCore.Routing;
using Stripe;

namespace AcademicApplication
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

            services.AddScoped<UserManager<AppUser>>();
            services.AddScoped<SignInManager<AppUser>>();


            services.AddSingleton(Configuration);
            services.AddDbContext<AcademicAppDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("AcademicAppConnectionString")));
            services.AddIdentity<AppUser, AppRole>(
                Configuration =>
                {
                    Configuration.SignIn.RequireConfirmedEmail = true;
                })
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<AcademicAppDbContext>()
                .AddDefaultTokenProviders();
            services.AddTransient<IEFRepository, EFRepository>();


            //External Login Authentication...

            services.AddAuthentication()
      .AddFacebook(facebookOptions =>
     {
       facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
       facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
   }).AddGoogle(options =>
   {
       IConfigurationSection googleAuthNSection =
           Configuration.GetSection("Authentication:Google");

       options.ClientId = googleAuthNSection["ClientId"];
       options.ClientSecret = googleAuthNSection["ClientSecret"];
   })
    .AddMicrosoftAccount(microsoftOptions =>
    {
        microsoftOptions.ClientId = Configuration["Authentication:Microsoft:ClientId"];
        microsoftOptions.ClientSecret = Configuration["Authentication:Microsoft:ClientSecret"];
    });




            //Email And Sms Configuration
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.Configure<SMSoptions>(Configuration);


            services.Configure<IdentityOptions>(Option =>
            {
                Option.User.RequireUniqueEmail = true;
                Option.Password.RequireDigit = true;
                Option.Password.RequiredLength = 8;
                Option.Password.RequireLowercase = false;
                Option.Password.RequireUppercase = false;
                Option.Password.RequiredUniqueChars = 0;
                Option.Password.RequireNonAlphanumeric = false;

                Option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                Option.Lockout.MaxFailedAccessAttempts = 5;
                Option.Lockout.AllowedForNewUsers = true;

                // User settings.
                Option.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                Option.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(config =>
            {
                config.AccessDeniedPath = "";
                config.Cookie.Expiration = TimeSpan.FromMinutes(30);
                config.Cookie.HttpOnly = true;
                config.Cookie.Name = "LearningCookie";
                config.LoginPath = "/SignIn/Index";
                config.LogoutPath = "/SignIn/SignOut";
                config.ReturnUrlParameter = "ReturnUrl";


            });
            services.AddMvc(options => options.EnableEndpointRouting = true)
    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            StripeConfiguration.SetApiKey(Configuration["Stripe:SecretKey"]);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {

                routes.MapRoute(
                      name: "areas",
                      template: "{area:exists}/{controller}/{action}/{id?}",
                      defaults: new
                      {
                          controller = "Home",
                          action = "Index"

                      }
                      );

                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller}/{action}/{id?}",
                    defaults: new
                    {
                        controller = "AdminHome",
                        action = "Index"

                    }
                    );

                routes.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new
                    {
                        controller = "Home",
                        action = "Index"
                    }
                    );
            });
        }
    }
}
