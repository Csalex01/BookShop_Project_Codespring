using BookShopV2.Application.Interfaces.Services;
using BookShopV2.Application.Interfaces.Repositories;
using BookShopV2.Core.Models;

namespace BookShopV2.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _repository;

        public AuthorService(IAuthorRepository repository)
        {
            _repository = repository;
        }

        public async Task<Author> CreateAuthorServicesAsync(Author author)
        {
            return await _repository.CreateAuthorAsync(author);
        }

        public async Task DeleteAuthorServiceAsync(int Id)
        {
            Author author = await GetAuthorByIdServicesAsync(Id);
            await _repository.DeleteAuthorAsync(author);
        }

        public async Task<List<Author>> GetAllAuthorsServiceAsync()
        {
            return await _repository.GetAllAuthorsAsync();
        }

        public async Task<Author> GetAuthorByIdServicesAsync(int Id)
        {
            return await _repository.GetAuthorByIdAsync(Id);
        }

        public async Task<Author> UpdateAuthorServicesAsync(Author author)
        {
            return await _repository.UpdateAuthorAsync(author);
        }
    }
}
