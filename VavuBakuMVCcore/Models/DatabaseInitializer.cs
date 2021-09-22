using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace VavuBakuMVCcore.Models
{
    public class DatabaseInitializer
    {
        internal static void Seed(IServiceProvider services)
        {
            using (var context = new VavuDbContext(services.GetRequiredService<DbContextOptions<VavuDbContext>>()))
            {
                if (!context.Users.Any(x => x.Role == RoleType.Admin))
                {
                    User admin = new User()
                    {
                        IsActive = true,
                        Role = RoleType.Admin,
                        Username = "VasifVusal",
                        Photo = "VasifAdmin.jpg",
                        Password = Crypto.HashPassword("PikachuBitch")
                    };
                    context.Users.Add(admin);
                    context.SaveChanges();
                }
            }
        }
    }
}
