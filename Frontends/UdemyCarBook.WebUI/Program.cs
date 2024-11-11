using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace UdemyCarBook.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddHttpClient();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddCookie(JwtBearerDefaults.AuthenticationScheme,
                
                opt =>{
                          opt.LoginPath = "/Login/Index";
                          opt.LogoutPath = "/Default/Index";
                          opt.AccessDeniedPath = "/Default/Index";
                          opt.Cookie.SameSite = SameSiteMode.Strict;
                          opt.Cookie.HttpOnly = true;
                          opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                          opt.Cookie.Name = "CarBookJwt";
                      }
                );
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
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=AdminCar}/{action=Index}/{id?}");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });


            app.Run();
        }
    }
}
