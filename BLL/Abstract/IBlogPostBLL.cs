using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IBlogPostBLL
    {
        bool Add(BlogPost blogPost);
        bool Update(BlogPost blogPost);
        bool Delete(Guid id);
        Task<BlogPost> GetByIdAsync(Guid id);
        Task<List<BlogPost>> GetAllAsync();
        Task<BlogPost> GetByIdAsync(Guid id, bool includeComments = true);
        int GetAllComments(Guid id);
        int GetAllLikes(Guid id);

    }
}
