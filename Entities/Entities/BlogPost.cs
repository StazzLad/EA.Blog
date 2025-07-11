using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Entity.Entities
{
    [Table("BlogPosts")]
    public class BlogPost : BaseEntity
    {
        public BlogPost()
        {
            this.Comments = new HashSet<Comment>();
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int Likes { get; set; } 
        [ValidateNever]
        public string ImageUrl { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        [ValidateNever]
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();   
    }
}
