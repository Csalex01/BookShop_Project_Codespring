using BookShopV2.Infrastructure;
using BookShopV2.Application.Interfaces.Repositories;
using BookShopV2.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopV2.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookShopContext _context;

        public BookRepository(BookShopContext context)
        {
            _context = context;
        }

        public async Task<Book> CreateBookAsync(Book book)
        {
            _context.Books.Add(Converter.FromBookToBookDAL(book));
            await _context.SaveChangesAsync();

            return book;
        }

        public async Task DeleteBookAsync(Book book)
        {
            _context.Books.Remove(Converter.FromBookToBookDAL(book));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var result = _context.Books.Include(book => book.Author).Select(Converter.FromBookDALToBook);
            return await Task.FromResult(result.ToList());
        }

        public async Task<Book> GetBookByIdAsync(int Id)
        {
            var result = await _context.Books.AsNoTracking().Include(book => book.Author).FirstOrDefaultAsync(b => b.Id == Id);
            return Converter.FromBookDALToBook(result);
        }

        public async Task<Book> UpdateBookAsync(Book book)
        {
            var savedBook = await _context.Books.FindAsync(book.Id);

            savedBook.Title = book.Title;
            savedBook.Description = book.Description;
            savedBook.AuthorId = book.AuthorId;

            await _context.SaveChangesAsync();

            return Converter.FromBookDALToBook(savedBook);
        }
    }
}