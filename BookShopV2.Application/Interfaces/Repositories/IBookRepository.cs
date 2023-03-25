using BookShopV2.Core.Models;

namespace BookShopV2.Application.Interfaces.Repositories
{
    public interface IBookRepository
    {
        public Task DeleteBookAsync(Book book);

        public Task<Book> GetBookByIdAsync(int Id);
        public Task<Book> CreateBookAsync(Book book);
        public Task<Book> UpdateBookAsync(Book book);

        public Task<List<Book>> GetAllBooksAsync();
    }
}
