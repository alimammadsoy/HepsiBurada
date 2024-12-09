using HepsiBurada.Application.Interfaces.Repositories;
using HepsiBurada.Application.Interfaces.UnitOfWorks;
using HepsiBurada.Persistence.Context;
using HepsiBurada.Persistence.Repositories;
using HepsiBurada.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HepsiBurada.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
             services.AddDbContext<AppDbContext>(opt =>
             {
                 opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
             });

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

    }
}

