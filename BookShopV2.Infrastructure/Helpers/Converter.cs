using BookShopV2.Infrastructure.Models;
using BookShopV2.Core.Models;

namespace BookShopV2.Infrastructure
{
    public static class Converter
    {
        public static BookDAL FromBookToBookDAL(Book book)
        {
            BookDAL bookDAL = new BookDAL
            {
                Id = book.Id,
                AuthorId = book.AuthorId,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author
            };

            return bookDAL;
        }

        public static Book FromBookDALToBook(BookDAL bookDAL)
        {
            Book book = new Book()
            {
                Id = bookDAL.Id,
                AuthorId = bookDAL.AuthorId,
                Title = bookDAL.Title,
                Description = bookDAL.Description,
                NumberOfCharacters = bookDAL.Title.Length,
                Author = bookDAL.Author
            };

            return book;
        }

        public static AuthorDAL FromAuthorToAuthorDAL(Author author)
        {
            AuthorDAL authorDAL = new AuthorDAL
            {
                Id = author.Id,
                Name = author.Name,
                Books = author.Books
            };

            return authorDAL;
        }

        public static Author FromAuthorDALToAuthor(AuthorDAL authorDAL)
        {
            Author author = new Author
            {
                Id = authorDAL.Id,
                Name = authorDAL.Name,
                Books = authorDAL.Books
            };

            return author;
        }

    }

}
