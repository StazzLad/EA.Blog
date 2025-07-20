using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public User()
        {
            this.BlogPosts = new HashSet<BlogPost>();
        }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        
        // Navigation properties can be added here if needed
         public virtual ICollection<BlogPost> BlogPosts { get; set; } 
    }
    
}
