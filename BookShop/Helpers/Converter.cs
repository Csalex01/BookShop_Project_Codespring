using BookShopV2.DTOs;
using BookShopV2.Core.Models;

namespace BookShopV2
{
    public static class Converter
    {
        public static BookDTO FromBookDTOToBook(Book book)
        {
            BookDTO bookDTO = new BookDTO
            {
                Title = book.Title,
                Description = book.Description,
                NumberOfCharacters = book.NumberOfCharacters
            };

            return bookDTO;
        }

        public static Book FromBookToBookDTO(BookDTO bookDTO)
        {
            Book book = new Book
            {
                Title = bookDTO.Title,
                Description = bookDTO.Description,
                NumberOfCharacters = bookDTO.NumberOfCharacters,
            };

            return book;
        }
    }

}
