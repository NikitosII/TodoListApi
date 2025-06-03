namespace BusinessLogic.Services
{
    // Интерфейс сервиса
    public interface INoteService
    {
        Task CreateAsync(string text, CancellationToken cancellationToken = default);
        Task<string> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task UpdateAsync(Guid id, string text,  CancellationToken cancellationToken = default);
        Task DeleteAsync(Guid id,  CancellationToken cancellationToken = default);
    }
}