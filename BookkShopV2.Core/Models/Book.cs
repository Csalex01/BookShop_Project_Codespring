namespace BookShopV2.Core.Models
{

    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int NumberOfCharacters { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public Author Author { get; set; }
    }
}
