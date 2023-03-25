using BookShopV2.Core.Models;

namespace BookShopV2.Application.Interfaces.Services
{
    public interface IAuthorService
    {
        public Task<List<Author>> GetAllAuthorsServiceAsync();

        public Task<Author> GetAuthorByIdServicesAsync(int Id);
        public Task<Author> CreateAuthorServicesAsync(Author author);
        public Task<Author> UpdateAuthorServicesAsync(Author author);

        public Task DeleteAuthorServiceAsync(int Id);
    }
}
