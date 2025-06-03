using DataAccess.Models;
using DataAccess.Repositories;

// Сервис заметок
namespace BusinessLogic.Services
{
    internal class NoteService(INoteRepository noteRepository) : INoteService
    {
        // Создание новой заметки
        public async Task CreateAsync(string text, CancellationToken cancellationToken = default)
        {
            var note = new Node
            { 
                Title = text
            };

            await noteRepository.CreateAsync(note, cancellationToken);
        }

        // Удаление заметки
        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var note = await noteRepository.GetByIdAsync(id, cancellationToken);
            if (note is null)
            {
                throw new Exception("Note don't found");
            }
            await noteRepository.DeleteAsync(note, cancellationToken);
        }

        // Получение текста заметки
        public async Task<string> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var note = await noteRepository.GetByIdAsync(id, cancellationToken);
            if(note is null)
            {
                throw new Exception("Note don't found");
            }
            return note.Title;
        }

        // Обновление текста заметки
        public async Task UpdateAsync(Guid id, string text, CancellationToken cancellationToken = default)
        {
            var note = await noteRepository.GetByIdAsync(id, cancellationToken);
            if (note is null)
            {
                throw new Exception("Note don't found");
            }

            note.Title = text;
            await noteRepository.UpdateAsync(note, cancellationToken).ConfigureAwait(false);
        }
    }
}
