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
        public string ShortContent { get; set; }
        public string Author { get; set; }
        public int Likes { get; set; } = 0; // Default value for Likes
        [ValidateNever]
        public string ImageUrl { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        [ValidateNever]
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();   
        public virtual User? User { get; set; } // Navigation property to User
        public int CommentCount => Comments.Count; // Computed property for comment count
    }
}
