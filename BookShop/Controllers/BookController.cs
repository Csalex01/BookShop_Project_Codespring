using BookShopV2.DTOs;
using BookShopV2.Application.Interfaces.Services;
using BookShopV2.Core.Models;

using Microsoft.AspNetCore.Mvc;
using BookShopV2;

namespace BookShopV2.Controllers
{
    [ApiController]
    [Route("books")]
    public class BookController : ControllerBase
    {

        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetBooksAsync()
        {
            var books = await _service.GetAllBooksServiceAsync();

            return Ok(books);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBookByIdAsync(int Id)
        {
            var book = await _service.GetBookByIdServiceAsync(Id);

            if(book == null) return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooksAsync([FromBody] BookDTO bookDTO)
        {
            try
            {
                var newBook = await _service.CreateBooksServiceAsync(new Book
                {
                    Description = bookDTO.Description,
                    Title = bookDTO.Title,
                    AuthorId = bookDTO.AuthorId,
                });

                return Ok(newBook);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateBookAsync([FromBody] BookDTO bookDTO, int Id)
        {
            var updatedBook = await _service.UpdateBookServiceAsync(new Book
            {
                Id = Id,
                Description = bookDTO.Description,
                Title = bookDTO.Title,
                AuthorId = bookDTO.AuthorId
            });

            return Ok(Converter.FromBookDTOToBook(updatedBook));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteBooksync(int Id)
        {
            var existingBook = await _service.GetBookByIdServiceAsync(Id);
            await _service.DeleteBookServiceAsync(Id);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSecondVersionAsync([FromBody] List<int> Ids)
        {
            await _service.UpdateSecondVersionOfBooks(Ids);
            return Ok();
        }
    }
}
