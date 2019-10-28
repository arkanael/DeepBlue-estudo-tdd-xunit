using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DeepBlue.Infra.Data.Contracts.Repository;
using DeepBlue.Infra.Data.Entities;
using DeepBlue.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace DeepBlue.Presentation
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.AddSingleton<IProdutoRepository, ProdutoRepository>(map => new ProdutoRepository(new ConcurrentDictionary<Guid, Produto>()));

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(
                  swagger =>
                  {
                      swagger.SwaggerDoc("v1",
                          new Info
                          {
                              Title = "Sistema Asp.Net Web API - Controle de Produtos",
                              Version = "v1",
                              Description = "Curso de C# WebDeveloper Avançado",
                              Contact = new Contact
                              {
                                  Name = "Luiz Guilherme Bandeira",
                                  Url = "https://www.linkedin.com/in/lbandeira/",
                                  Email = "arkanael@gmail.com"
                              }
                          });
                  }
              );
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(
                    swagger =>
                    {
                        swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "Projeto");
                    }
                );
        }
    }
}
