using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    [Table("Comments")]
    public class Comment : BaseEntity
    {
        
        public Guid BlogPostId { get; set; } // Foreign key to BlogPost
        public string Author { get; set; }
        public string Content { get; set; }
        [ForeignKey("BlogPostId")]
        [ValidateNever]
        public virtual BlogPost? BlogPost { get; set; }
        public int Likes { get; set; }
    }
}
