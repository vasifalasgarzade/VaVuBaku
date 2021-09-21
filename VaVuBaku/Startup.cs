using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VaVuBaku.Data;
using VaVuBaku.Models;
using VaVuBaku.Repositories;
using VaVuBaku.Repositories.Abstracts;
using VaVuBaku.Repositories.Abstracts.Product;

namespace VaVuBaku
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
            services.AddControllers();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddSwaggerDocument();
            services.AddDbContext<VaVuDb>(options =>
                                          options.UseSqlServer(
                                          Configuration.GetConnectionString("Dbservice")));
            services.AddDbContext<AdminContext>(a => a.UseSqlServer(Configuration.GetConnectionString(nameof(AdminContext))));
            services.AddScoped<ITransactions<Product>, ProductsRepos>();
            services.AddScoped<IProduct<Product>, ProductsRepos>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSwaggerUi3();
            app.UseOpenApi();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
