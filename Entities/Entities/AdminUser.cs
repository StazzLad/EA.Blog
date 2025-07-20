using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    [Table("AdminUsers")]   
    public class AdminUser: BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsSuperAdmin { get; set; } // Indicates if the admin user has super admin privileges
        // Additional properties and methods can be added as needed
    }
    
    
}
