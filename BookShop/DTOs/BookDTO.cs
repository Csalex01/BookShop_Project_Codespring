namespace BookShopV2.DTOs
{
    public class BookDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int AuthorId { get; set; }
        public int NumberOfCharacters { get; set; }
    }
}
