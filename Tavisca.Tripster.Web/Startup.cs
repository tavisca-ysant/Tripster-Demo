using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Tavisca.Tripster.Contracts.DatabaseSettings;
using Tavisca.Tripster.Core.Contracts;
using Tavisca.Tripster.Core.Service;
using Tavisca.Tripster.Data.UnitOfWork;

namespace Tavisca.Tripster.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<TripDatabaseSettings>(
        Configuration.GetSection(nameof(TripDatabaseSettings)));
            
            services.AddSingleton<IDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<TripDatabaseSettings>>().Value);
            services.AddSingleton<ITripService, TripService>();
            services.AddSingleton<TripUnitOfWork>();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                    });
            });
            services.AddMvc()
                            .AddMvcOptions(o => o.OutputFormatters.Add(
                        new XmlDataContractSerializerOutputFormatter()
                        ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
           

            app.UseCors("AllowAll");

           
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
