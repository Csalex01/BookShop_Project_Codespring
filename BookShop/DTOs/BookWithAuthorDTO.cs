namespace BookShopV2.DTOs
{
    public class BookWithAuthorDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public AuthorDTO Author { get; set; }
    }
}
