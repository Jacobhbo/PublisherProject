using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublisherProject.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public DateOnly PublishDate { get; set; }
        public decimal BasePrice { get; set; }

        //[Precision(12, 2)]
        //public decimal SalesPrice { get; set; }

        [Range(1, 13, ErrorMessage = "Price must be between 1 and 13.")]
        public int Rating { get; set; }
        public Author? Author { get; set; }
        public int AuthorId { get; set; }
        //public Cover Cover { get; set; }
    }
}
