using BookShopV2.Core.Models;

namespace BookShopV2.Application.Interfaces.Services
{
    public interface IBookService
    {
        public Task UpdateSecondVersionOfBooks(List<int> ids);

        public Task<List<Book>> GetAllBooksServiceAsync();

        public Task<Book> GetBookByIdServiceAsync(int Id);
        public Task<Book> CreateBooksServiceAsync(Book book);
        public Task<Book> UpdateBookServiceAsync(Book book);

        public Task DeleteBookServiceAsync(int id);
    }
}
