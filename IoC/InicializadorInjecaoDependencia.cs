using System;
using System.Collections.Generic;
using System.Text;
using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class InicializadorInjecaoDependencia
    {
        public static void RegistrarServicos(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();

            services.AddScoped<IServicoTransferencia, ServicoTransferencia>();
            services.AddScoped<IRepositorioTransferencia, RepositorioTransferencia>();
        }
    }
}
