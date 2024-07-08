namespace GoPresent.Api.Features.Presentations;

public static class ServiceRegister
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddTransient<IPresentationService, PresentationService>();
        return services;
    }
}