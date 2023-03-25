using BookShopV2.Core.Models;
using BookShopV2.Application.Interfaces.Repositories;
using BookShopV2.Application.Interfaces.Services;

namespace BookShopV2.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<Book> CreateBooksServiceAsync(Book book)
        {
            return await _repository.CreateBookAsync(book);
        }

        public async Task DeleteBookServiceAsync(int id)
        {
            Book book = await GetBookByIdServiceAsync(id);
            await _repository.DeleteBookAsync(book);
        }
        
        public async Task<Book> GetBookByIdServiceAsync(int Id)
        {
            return await _repository.GetBookByIdAsync(Id);
        }

        public async Task<List<Book>> GetAllBooksServiceAsync()
        {
            return await _repository.GetAllBooksAsync();
        }

        public async Task UpdateSecondVersionOfBooks(List<int> ids)
        {
            foreach (int id in ids)
            {
                Book book = await _repository.GetBookByIdAsync(id);
                book.Title += "_2";
                await _repository.UpdateBookAsync(book);
            }
        }

        public async Task<Book> UpdateBookServiceAsync(Book book)
        {
            return await _repository.UpdateBookAsync(book);
        }

    }
}
