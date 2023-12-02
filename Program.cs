using Hospital.Models.Infrastucture;
using Microsoft.EntityFrameworkCore;

namespace Hospital
{
    public class Program
    {
        public static User CurrentUser { get; set; }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            string dbString = builder.Configuration.GetConnectionString("DbConnection");

            builder.Services.AddDbContext<MainContext>(options => options.UseSqlServer(dbString));

            var app = builder.Build();

            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Registration}");

            app.UseStaticFiles();

            app.Run();
        }
    }
}