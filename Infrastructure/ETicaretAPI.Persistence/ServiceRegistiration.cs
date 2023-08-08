using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(opts => opts.UseNpgsql("User ID=postgres;Password=asd;Host=localhost;Port=5432;Database=ETicaretAPIDb;"));
            services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
