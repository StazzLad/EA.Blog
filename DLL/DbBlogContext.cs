using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbBlogContext : DbContext
    {
        public DbBlogContext()
        {
            
        }

        public DbBlogContext(DbContextOptions<DbBlogContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=BlogDB;User Id=sa;Password=E93.melanion;Encrypt=False;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment>Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }

    }
}
