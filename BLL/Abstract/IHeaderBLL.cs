using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IHeaderBLL
    {
        Task<Header> GetByIdAsync(Guid id);
        Task<List<Header>> GetAllAsync();
        bool Add(Header header);
        bool Update(Header header);
        bool Delete(Guid id);
        Task<Header> Activate(Guid id);
    }
}
