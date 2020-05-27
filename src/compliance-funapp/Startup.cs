using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Compliance.Domain.Data;
using Compliance.Domain.Services;


[assembly: FunctionsStartup(typeof(Compliance.Startup))]

namespace Compliance
{

    public class Startup: FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            
            builder.Services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(
                    Environment.GetEnvironmentVariable("ConnectionStrings:inteligo-db")
                    );
            });

            var services =
                builder.Services;

            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<IWorldcheckService,WorldcheckService>();

        }
    }
}