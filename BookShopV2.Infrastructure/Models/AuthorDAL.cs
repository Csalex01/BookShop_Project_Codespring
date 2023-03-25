using BookShopV2.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopV2.Infrastructure.Models
{
    //[Table(("Authors"))]
    public class AuthorDAL
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
