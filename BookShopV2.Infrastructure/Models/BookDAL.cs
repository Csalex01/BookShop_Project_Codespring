using BookShopV2.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopV2.Infrastructure.Models
{
    //[Table("Books")]
    public class BookDAL
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public Author Author { get; set; }
    }
}
