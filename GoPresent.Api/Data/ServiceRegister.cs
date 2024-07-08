using Microsoft.EntityFrameworkCore;

namespace GoPresent.Api.Data;

public static class ServiceRegister
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<GoPresentDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("GoPresentDb")));
        return services;
    }
}