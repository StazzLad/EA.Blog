using DAL.Abstract;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class BlogPostDAL : IBlogPost
    {
        private readonly DbBlogContext _context;

        public int Add(BlogPost blogPost)
        {
            _context.BlogPosts.Add(blogPost);
            return _context.SaveChanges();

        }

        public int Delete(Guid id)
        {
                _context.BlogPosts.Remove(_context.BlogPosts.Find(id));
                return _context.SaveChanges();
        }

        public Task<List<BlogPost>> GetAllAsync()
        {

            return _context.BlogPosts.ToListAsync();
            
        }

        public Task<int> GetAllComments(Guid id )
        {
            var post = _context.BlogPosts
        .Include(p => p.CommentCount)
        .FirstOrDefaultAsync(p => p.Id == id);



            return post.ContinueWith(t => t.Result?.CommentCount ?? 0);

        }

        public Task<int> GetAllLikes(Guid id)
        {
            var post = _context.BlogPosts
                .Include(p => p.Likes)
                .FirstOrDefaultAsync(p => p.Id == id);
            return post.ContinueWith(t => t.Result?.CommentCount ?? 0);
        }

        public async Task<BlogPost> GetByIdAsync(Guid id)
        {
           var post = await _context.BlogPosts.FindAsync(id);
            return post ?? throw new KeyNotFoundException($"Blog post with ID {id} not found.");
        }

        public Task<string> GetImageUrl(Guid id)
        {
            var post = _context.BlogPosts
                .Where(p => p.Id == id)
                .Select(p => p.ImageUrl)
                .FirstOrDefaultAsync();
            return post.ContinueWith(t => t.Result ?? string.Empty);
        }

        public int Update(BlogPost blogPost)
        {
            _context.BlogPosts.Update(blogPost);
            return _context.SaveChanges();
        }

        
    }
}
