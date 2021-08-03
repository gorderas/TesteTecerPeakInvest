using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTecerPeakInvestRepository;
using TesteTecerPeakInvestService;
using TesteTecerPeakInvestServiceDomain.Interface;

namespace TesteTecerPeakInvestIoC
{
    public static class RegisterDependency
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IService, Service>();

            services.AddTransient<IRepository, Repository>();
        }
    }
}
