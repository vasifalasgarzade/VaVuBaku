using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaVuBaku.Models;


namespace VaVuBaku.Data
{
    public class VaVuDb:DbContext
    {
        public VaVuDb(DbContextOptions<VaVuDb> options):base(options)
        {

        }
       
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<FoodCategory> FoodCategory { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }









    }
}
