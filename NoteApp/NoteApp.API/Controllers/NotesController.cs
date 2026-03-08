using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using NoteApp.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoteApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        // GET: api/<NotesController>
        [HttpGet]
        public ActionResult< IEnumerable<Note> >Get()
        {
            IEnumerable<Note> notes = new List<Note>
            {
                new Note
                {
                    Id = 1,
                    Title = "First Note",
                    Content = "This is the content of the first note.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Note
                {
                    Id = 2,
                    Title = "Second Note",
                    Content = "This is the content of the second note.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
            return Ok(notes);
        }

        // GET api/<NotesController>/5
        [HttpGet("{id}")]
        public ActionResult<Note> Get(int id)
        {
            IEnumerable<Note> notes = new List<Note>
            {
                new Note
                {
                    Id = 1,
                    Title = "First Note",
                    Content = "This is the content of the first note.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Note
                {
                    Id = 2,
                    Title = "Second Note",
                    Content = "This is the content of the second note.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };

            Note note = notes.FirstOrDefault(x => x.Id == id);

            return Ok(note);
        }

        // POST api/<NotesController>
        [HttpPost]
        public ActionResult<Note> Post([FromBody] Note value)
        {
            IList<Note> notes = new List<Note>
            {
                new Note
                {
                    Id = 1,
                    Title = "First Note",
                    Content = "This is the content of the first note.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Note
                {
                    Id = 2,
                    Title = "Second Note",
                    Content = "This is the content of the second note.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };

            Note newNote = new Note
            {
                Id = value.Id,
                Title = value.Title,
                Content = value.Content,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            // In a real application, you would save the new note to a database here.
            notes.Add(newNote);

            return Ok(newNote);
        }

        // PUT api/<NotesController>/5
        [HttpPut("{id}")]
        public ActionResult<Note> Put(int id, [FromBody] Note value)
        {
            IList<Note> notes = new List<Note>
            {
                new Note
                {
                    Id = 1,
                    Title = "First Note",
                    Content = "This is the content of the first note.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Note
                {
                    Id = 2,
                    Title = "Second Note",
                    Content = "This is the content of the second note.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };

            Note note = notes.FirstOrDefault(x => x.Id == id);

            note = new Note
            {
                Id = id,
                Title = value.Title,
                Content = value.Content,
                CreatedAt = note.CreatedAt,
                UpdatedAt = DateTime.UtcNow
            };

            return Ok(note);
        }

        // DELETE api/<NotesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
