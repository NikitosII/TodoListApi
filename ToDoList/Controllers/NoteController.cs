using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;

// Контроллер заметок 
namespace ToDoList.Controllers
{
    [ApiController]
    [Route("Note")]
    public class NoteController(INoteService noteService) : ControllerBase
    {
        // Создание
        [HttpPost]
        public async Task<IActionResult> CreateAsync(string text)
        {
            await noteService.CreateAsync(text);
            return NoContent();
        }

        // Получение
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetNoteAsync([FromRoute]Guid id)
        {
            var res = await noteService.GetByIdAsync(id);
            return Ok(res);
        }

        // Обновление
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateNoteAsync([FromRoute] Guid id, string text)
        {
            await noteService.UpdateAsync(id, text);
            return NoContent();
        }

        // Удаление
        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteNoteAsync([FromRoute] Guid id)
        {
            await noteService.DeleteAsync(id);
            return NoContent();
        }
    }
}
