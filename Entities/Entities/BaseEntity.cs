using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        Guid CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        Guid? UpdatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        byte Status { get; set; }
    }

    public class BaseEntity : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; } 
        public Guid CreatedBy { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public Guid? UpdatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? UpdatedAt { get; set; } 
        public byte Status { get; set; } = 1; // Assuming 1 is for active status
    }

}
