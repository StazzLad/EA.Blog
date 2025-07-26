using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IBlogPost
    {
        Task<BlogPost> GetByIdAsync(Guid id);
        Task<List<BlogPost>> GetAllAsync();
        int Add(BlogPost blogPost);
        int Update(BlogPost blogPost);
        int Delete(Guid id);
        Task <int> GetAllLikes(Guid id);
        Task<int> GetAllComments(Guid id);
        Task<string> GetImageUrl(Guid id);
        

    }
}
