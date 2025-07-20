using BLL.Abstract;
using DAL.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class HeaderBLL : IHeaderBLL
    {
        private readonly IHeaderDAL _DAL;
        public HeaderBLL()
        {
            _DAL = new HeaderDAL(); // Assuming HeaderDAL implements IHeaderDAL
        }
        public Task<Header> GetByIdAsync(Guid id)
        {
            return _DAL.GetByIdAsync(id);
        }
        public Task<List<Header>> GetAllAsync()
        {
            return _DAL.GetAllAsync();
        }
        public bool Add(Header header)
        {
            try
            {
                int result = _DAL.Add(header);
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
        public bool Update(Header header)
        {
            try
            {
                int result = _DAL.Update(header);
                if (result > 0)
                    return true;

                return false;
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
        public Task<Header> Activate(Guid id)
        {
            return _DAL.Activate(id);
        }
    }
}
