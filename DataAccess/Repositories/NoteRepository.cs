using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

// Репозиторий заметок
namespace DataAccess.Repositories
{
    internal class NoteRepository(AppContext context) : INoteRepository
    {
        // Создание
        public async Task CreateAsync(Node note, CancellationToken cancellationToken = default)
        {
            note.CreatedAt = DateTime.UtcNow;
            await context.Nodes.AddAsync(note, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        // Удаление 
        public async Task DeleteAsync(Node note, CancellationToken cancellationToken = default)
        {
            context.Remove(note);
            await context.SaveChangesAsync(cancellationToken);
        }

        // Получение  
        public async Task<Node?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await context.Nodes.FirstOrDefaultAsync(x => x.Id == id);
        }

        // Обновление 
        public async Task UpdateAsync(Node note, CancellationToken cancellationToken = default)
        {
            context.Nodes.Update(note);
            await context.SaveChangesAsync(cancellationToken);
        }

    }
}
