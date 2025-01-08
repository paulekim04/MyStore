using Microsoft.Extensions.DependencyInjection;

namespace MyStore.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;

        services.AddMediatR(config => config.RegisterServicesFromAssembly(applicationAssembly));

        services.AddAutoMapper(applicationAssembly);
    }
}
