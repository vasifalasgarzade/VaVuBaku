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
        public DbSet<Product> Products { get; set; }
    }
}
