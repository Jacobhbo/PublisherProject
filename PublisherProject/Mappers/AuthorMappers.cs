using PublisherProject.DTOs.Author;
using PublisherProject.Models;
using System.Runtime.CompilerServices;

namespace PublisherProject.Mappers
{
    public static class AuthorMappers
    {
        public static Author ToAuthorFromRequestUpdateDTO(this UpdateAuthorRequestDto updateAuthorRequestDto)
        {
            return new Author
            {
                FirstName = updateAuthorRequestDto.FirstName,
                LastName = updateAuthorRequestDto.LastName,
            };
        }
        public static AuthorDto ToAuthorDto(this Author authorModel)
        {
            return new AuthorDto
            {
                AuthorId = authorModel.AuthorId,
                FirstName = authorModel.FirstName,
                LastName = authorModel.LastName,

                Books = authorModel.Books.Select(c => c.ToBookDto()).ToList(),
            };
        }

    }
}
