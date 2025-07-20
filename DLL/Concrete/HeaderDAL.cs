using DAL.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class HeaderDAL : IHeaderDAL
    {
        private readonly DbBlogContext _context;
        public HeaderDAL()
        {
            _context = new DbBlogContext();
        }
        public int Add(Header header)
        {
            _context.Headers.Add(header);
            return _context.SaveChanges();
        }

        public int Delete(Guid id)
        {
            _context.Headers.Remove(_context.Headers.Find(id));
            return _context.SaveChanges();


        }

       

        public async Task<List<Header>> GetAllAsync()
        {
            List<Header> headers = await _context.Headers.AsNoTracking().Where(x => x.Status != 2).ToListAsync();
            return headers;
        }

        public async Task<Header?> GetByIdAsync(Guid id)
        {
            Header? header = await _context.Headers.AsNoTracking().FirstOrDefaultAsync(x =>x.Id == id);
            if (header == null)
            {
                throw new Exception("Header not found");
            }
            return header;
        }

        public async Task<Header>Activate(Guid id)
        {
            Header? HeaderActive = await _context.Headers.FirstOrDefaultAsync(x => x.Id == id && x.IsActive == true);
            if (HeaderActive == null)
            {
                HeaderActive = await _context.Headers.FirstOrDefaultAsync(x => x.Id == id);
                HeaderActive.IsActive = true;
                _context.Headers.Update(HeaderActive);
                await _context.SaveChangesAsync();
            }
            HeaderActive.IsActive = false;
            _context.Headers.Update(HeaderActive);
            Header? header = await _context.Headers.FirstOrDefaultAsync(x => x.Id == id);
            header.IsActive = true;
            _context.Headers.Update(header);
             await _context.SaveChangesAsync();
            return header;
            
        }

        public int Update(Header header)
        {
            Header? existingHeader = _context.Headers.Find(header.Id);
            if (existingHeader == null)
            {
                throw new Exception("Header not found");
            }
            existingHeader.Title = header.Title;
            existingHeader.ImageUrl = header.ImageUrl;
            existingHeader.IsActive = header.IsActive;
            _context.Headers.Update(existingHeader);
            return _context.SaveChanges();

        }

       
    }
}
