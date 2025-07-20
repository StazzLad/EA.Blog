using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    [Table("Headers")]
    public class Header : BaseEntity
    {
        public string Title { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
       
        public bool IsActive { get; set; } = false; // Default value set to false
    }
}
