using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace Contacts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.(DI)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            // We configured SQL Server and object class 
            services.AddEntityFrameworkSqlServer();
            services.AddDbContext<ContactsContext>(options=>
            {
                // Specify how to find connection string, use collen to boundary separate
                options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.(ASP.NET MVC)
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            // initialization code to configure () primarly because it fires POST dependency injection in the setup where we configure our EF and our content
            // get an instance of an single service
            using
        }
    }
}
