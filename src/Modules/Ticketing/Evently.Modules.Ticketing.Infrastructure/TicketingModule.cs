using Evently.Common.Presentation.Endpoints;
using Evently.Modules.Ticketing.Application.Carts;
using Microsoft.Extensions.DependencyInjection;

namespace Evently.Modules.Ticketing.Infrastructure;
public static class TicketingModule
{
    public static IServiceCollection AddTicketingModule(
        this IServiceCollection services)
    {
        services.AddInfrastructure();

        services.AddEndpoints(Presentation.AssemblyReference.Assembly);

        return services;
    }

#pragma warning disable S1172 // Unused method parameters should be removed
    private static void AddInfrastructure(this IServiceCollection services)
#pragma warning restore S1172 // Unused method parameters should be removed
    {
        services.AddSingleton<CartService>();
    }
}
