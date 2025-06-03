
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// Методы расширения для регистрации сервисов доступа к данным
namespace DataAccess
{
    public static class Extensions
    {
        public static IServiceCollection AddData(this IServiceCollection services)
        {
            services.AddScoped<Repositories.INoteRepository, Repositories.NoteRepository>();
            services.AddDbContext<AppContext>(
                x =>
                {
                x.UseNpgsql("Host = localhost; Database = todo_db; Username = postgres; Password = 1111");
                });
            return services;
        }
    }
}
