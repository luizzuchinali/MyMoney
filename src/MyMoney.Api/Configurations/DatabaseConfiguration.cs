using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyMoney.Domain;
using MyMoney.Domain.Interfaces.Repositories;
using MyMoney.Infra;
using MyMoney.Infra.Repositories;

namespace MyMoney.Api.Configurations
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection ConfigureDatabase(this IServiceCollection services)
        {
            services = services ?? throw new ArgumentNullException(nameof(services));

            services.AddDbContext<MyMoneyDbContext>(x =>
            {
                x.UseSqlServer(Environment.GetEnvironmentVariable(EnvironmentVariables.DatabaseConnectionString));
                x.LogTo(Console.WriteLine);
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}