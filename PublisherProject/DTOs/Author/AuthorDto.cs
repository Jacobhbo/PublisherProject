using PublisherProject.DTOs.Book;
using PublisherProject.Models;
using System.ComponentModel.DataAnnotations;

namespace PublisherProject.DTOs.Author
{
    public class AuthorDto
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookDto> Books { get; set; } = new List<BookDto>();
    }
}
