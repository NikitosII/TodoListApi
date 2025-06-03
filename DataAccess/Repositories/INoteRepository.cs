using DataAccess.Models;

// Интерфейс репозитория
namespace DataAccess.Repositories
{
    public interface INoteRepository
    {
        Task CreateAsync(Node note, CancellationToken cancellationToken = default);
        Task<Node?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task UpdateAsync(Node note, CancellationToken cancellationToken = default);
        Task DeleteAsync(Node note, CancellationToken cancellationToken = default);
    }
}
