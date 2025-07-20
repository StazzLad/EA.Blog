using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IHeaderDAL
    {
        Task<Header> GetByIdAsync(Guid id);
        Task<List<Header>> GetAllAsync();
        int Add(Header header);
        int Update(Header header);
        int Delete(Guid id);
        Task<Header> Activate(Guid id);


    }
}