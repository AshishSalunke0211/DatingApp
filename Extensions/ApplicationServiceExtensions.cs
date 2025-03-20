using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration config)
    {
        services.AddControllers();
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlite(config.GetConnectionString("DefaultConnection")); // Inject DbContext
        });

        services.AddCors();
        services.AddScoped<ITokenService, TokenService>(); // Inject interface with implemented class
        services.AddScoped<IUserRepository , UserRepository>(); // Inject UserRepository 
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); // Inject Automapper profile

        return services;

    }
}