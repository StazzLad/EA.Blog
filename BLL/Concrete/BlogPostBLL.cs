using DAL.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class BlogPostBLL : IBlogPost
    {
        private readonly IBlogPost _DAL;
        public BlogPostBLL(IBlogPost DAL)
        {
            _DAL = DAL ?? throw new ArgumentNullException(nameof(DAL), "Data Access Layer cannot be null.");
        }
        public bool Add(BlogPost blogPost)
        {
            try
            {
                int result = _DAL.Add(blogPost);
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                int result = _DAL.Delete(id);
                if (result > 0)
                    return true;

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task<List<BlogPost>> GetAllAsync()
        {
            return _DAL.GetAllAsync();
        }

        public Task<int> GetAllComments(Guid id)
        {
            return _DAL.GetAllComments(id);
        }

        public Task <int> GetAllLikes(Guid id)
        {
            return _DAL.GetAllLikes(id);
        }


        public Task<BlogPost> GetByIdAsync(Guid id)
        {
            return _DAL.GetByIdAsync(id);
        }

        public Task<string> GetImageUrl(Guid id)
        {
            return _DAL.GetImageUrl(id);
        }

        public bool Update(BlogPost blogPost)
        {
            try
            {
                int result = _DAL.Update(blogPost);
                if (result > 0)
                    return true;

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        int IBlogPost.Add(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        int IBlogPost.Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        int IBlogPost.Update(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
    }
