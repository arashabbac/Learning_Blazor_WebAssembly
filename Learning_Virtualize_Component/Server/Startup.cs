using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Server
{
    public class Startup : object
    {
        public const string AdminCorsPolicy = "_ADMIN_CORS_POLICY";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(AdminCorsPolicy,
                    builder =>
                    {
                        builder
                            //.WithOrigins("http://31.47.54.247:5000")
                            .WithOrigins("https://localhost:3001")
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });

            services.AddControllers();
            services.AddHttpClient();
            services.AddHttpContextAccessor();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Server", Version = "v1" });
            });

            services.AddTransient<Data.IUnitOfWork, Data.UnitOfWork>(sp =>
            {
                Data.Tools.Options options =
                    new Data.Tools.Options
                    {
                        Provider =
                            (Data.Tools.Enums.Provider)
                            System.Convert.ToInt32(Configuration.GetSection(key: "databaseProvider").Value),

                        ConnectionString =
                            Configuration.GetSection(key: "ConnectionStrings").GetSection(key: "MyConnectionString").Value,
                    };

                return new Data.UnitOfWork(options: options);
            });

            services.AddTransient
                (serviceType: typeof(Dtx.Logging.ILogger<>),
                implementationType: typeof(Dtx.Logging.NLogAdapter<>));

            services.AddTransient<Data.Repositories.IDapper, Data.Repositories.Dapper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Server v1"));
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            app.UseCors(policyName: AdminCorsPolicy);
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
