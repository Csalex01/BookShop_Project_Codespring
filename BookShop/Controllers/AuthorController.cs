using BookShopV2.DTOs;
using BookShopV2.Core.Models;
using Microsoft.AspNetCore.Mvc;
using BookShopV2.Application.Interfaces.Services;

namespace BookShopV2.Controllers
{
    [ApiController]
    [Route("author")]
    public class AuthorController: ControllerBase
    {
        private IAuthorService _service;

        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            var authors = await _service.GetAllAuthorsServiceAsync();

            return Ok(authors);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAuthorById(int Id)
        {
            var author = await _service.GetAuthorByIdServicesAsync(Id);

            if (author == null) return NotFound();

            return Ok(author);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorDTO authorDTO)
        {
            var newAuthor = await _service.CreateAuthorServicesAsync(new Author
            {
                Name = authorDTO.Name
            });

            return Ok(newAuthor);
        }



        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAuthor([FromBody] AuthorDTO authorDTO, int Id)
        {
            var existingAuthor = await _service.GetAuthorByIdServicesAsync(Id);
            await _service.DeleteAuthorServiceAsync(existingAuthor.Id);

            return Ok();
        }
    }
}
