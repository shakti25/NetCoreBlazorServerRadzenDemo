namespace Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        AddRadzenCommunicationServices(services);

        services.AddTransient<IUserService, UserService>();

        return services;
    }

    private static IServiceCollection AddRadzenCommunicationServices(this IServiceCollection services)
    {
        services.AddScoped<DialogService>();
        services.AddScoped<NotificationService>();
        services.AddScoped<TooltipService>();
        services.AddScoped<ContextMenuService>();

        return services;
    }
}
