using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Models
{
    public class VavuDbContext:DbContext
    {
        public VavuDbContext(DbContextOptions<VavuDbContext> options):base(options) { }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Room> Rooms { get; set; }


        // One to Many
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCategory>()
                .HasMany(c => c.Foods)
                .WithOne(f => f.FoodCategory);
        }


        // One to Many
        public DbSet<VavuBakuMVCcore.Models.Blog> Blog { get; set; }
    }
}
