using PublisherProject.DTOs.Book;
using PublisherProject.Models;

namespace PublisherProject.Mappers
{
    public static class BookMappers
    {
        public static BookDto ToBookDto(this Book bookModel)
        {
            return new BookDto
            {   Author = bookModel.Author,
                AuthorId = bookModel.AuthorId,
                BasePrice = bookModel.BasePrice,
                BookId = bookModel.BookId,
                PublishDate = bookModel.PublishDate,
                Rating = bookModel.Rating,
                Title = bookModel.Title,
            };
        }

        //public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int stockId)
        //{
        //    return new Comment
        //    {
        //        Title = commentDto.Title,
        //        Content = commentDto.Content,
        //        StockId = stockId
        //    };
        //}

        //public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        //{
        //    return new Comment
        //    {
        //        Title = commentDto.Title,
        //        Content = commentDto.Content,
        //    };
        //}
    }
}
