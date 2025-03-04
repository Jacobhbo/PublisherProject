using PublisherProject.Models;
using System.ComponentModel.DataAnnotations;

namespace PublisherProject.DTOs.Author
{
    public class UpdateAuthorRequestDto
    {
        // I thought about this. Should i bring in the books? I did not since that would be an update to the book itself.
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
