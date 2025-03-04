using Microsoft.EntityFrameworkCore;
using PublisherProject.Data;
using PublisherProject.DTOs.Author;
using PublisherProject.Interfaces;
using PublisherProject.Models;

namespace PublisherProject.Repositories
{
    public class AuthorRepository: IAuthorRepository
    {
        private readonly PublisherContext _context;

        public AuthorRepository(PublisherContext context)
        {
            this._context = context;
        }

        public async Task<Author> CreateAsync(Author authorModel)
        {
            await _context.Authors.AddAsync(authorModel);
            await _context.SaveChangesAsync();
            return authorModel;
        }

        public async Task<Author?> DeleteAsync(int id)
        {
            var authorModel = await _context.Authors.FirstOrDefaultAsync(x => x.AuthorId == id);

            if (authorModel == null)
            {
                return null;
            }
            _context.Authors.Remove(authorModel);
            await _context.SaveChangesAsync();
            return authorModel;
        }

        public async Task<List<Author>> GetAllAsync()
        {
            return await _context.Authors.Include(c => c.Books).ToListAsync();
        }

        public async Task<Author?> GetByIdAsync(int id, bool withoutBooks)
        {
            if (withoutBooks) { 
                return await _context.Authors.FirstOrDefaultAsync(x => x.AuthorId == id); 
            }
            else { 
                return await _context.Authors.Include(c => c.Books).FirstOrDefaultAsync(x => x.AuthorId == id);
            }
        }

        public async Task<bool> Exists(int id)
        {
            return await _context.Authors.AnyAsync(s => s.AuthorId == id);
        }

        public async Task<Author?> UpdateAsync(int id, UpdateAuthorRequestDto authorDto)
        {
            var existingAuthor = await _context.Authors.FirstOrDefaultAsync(x => x.AuthorId == id);

            if (existingAuthor == null)
            {
                return null;
            }

            existingAuthor.FirstName = authorDto.FirstName;
            existingAuthor.LastName = authorDto.LastName;
 
            await _context.SaveChangesAsync();
            return existingAuthor;
        }
    }
}
