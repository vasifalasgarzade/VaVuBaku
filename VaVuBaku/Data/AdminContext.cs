using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaVuBaku.Models;

namespace VaVuBaku.Data
{
    public class AdminContext:DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDetail> MealDetails { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Activities> Activities { get; set; }
        public DbSet<Room> Rooms { get; set; }

    }
}
