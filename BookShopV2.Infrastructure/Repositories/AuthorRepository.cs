using BookShopV2.Application.Interfaces.Repositories;
using BookShopV2.Core.Models;
using BookShopV2.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopV2.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private BookShopContext _context;

        public AuthorRepository(BookShopContext context)
        {
            _context = context;
        }

        public async Task<Author> CreateAuthorAsync(Author author)
        {
            _context.Authors.Add(Converter.FromAuthorToAuthorDAL(author));
            await _context.SaveChangesAsync();

            return author;
        }

        public async Task DeleteAuthorAsync(Author author)
        {
            _context.Authors.Remove(Converter.FromAuthorToAuthorDAL(author));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Author>> GetAllAuthorsAsync()
        {
            List<Author> authors = new List<Author>();

            foreach (AuthorDAL authorDAL in _context.Authors.ToList())
                authors.Add(Converter.FromAuthorDALToAuthor(authorDAL));

            return authors;
        }

        public async Task<Author> GetAuthorByIdAsync(int Id)
        {
            var result = await _context.Authors.FindAsync(Id);

            return Converter.FromAuthorDALToAuthor(result);
        }

        public Task<Author> UpdateAuthorAsync(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
