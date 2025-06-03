
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic
{
    public static class Extensions
    {
        public static IServiceCollection AddLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<Services.INoteService, Services.NoteService>();
            return serviceCollection;
        }
    }
}
