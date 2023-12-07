using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal BasePrice { get; set; }
    }
}
