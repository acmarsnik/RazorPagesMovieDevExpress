using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Models;
using Microsoft.EntityFrameworkCore;
using DevExpress.AspNetCore;

namespace RazorPagesMovie
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
            // requires 
            // using RazorPagesMovie.Models;
            // using Microsoft.EntityFrameworkCore;
            // using DevExpress.AspNetCore;

            services.AddDbContext<MovieContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MovieContext")));
            // set up the services utilized by DevExpress controls
            services.AddDevExpressControls();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            // register DevExpress middleware components before calling UseMvc()
            app.UseDevExpressControls();
            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
