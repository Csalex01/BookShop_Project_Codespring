
using BookShopV2.Core.Models;

namespace BookShopV2.Application.Interfaces.Repositories
{
    public interface IAuthorRepository
    {
        public Task DeleteAuthorAsync(Author author);

        public Task<Author> GetAuthorByIdAsync(int Id);
        public Task<Author> CreateAuthorAsync(Author author);
        public Task<Author> UpdateAuthorAsync(Author author);

        public Task<List<Author>> GetAllAuthorsAsync();
    }
}
