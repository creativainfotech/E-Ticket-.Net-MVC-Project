using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.Models
{
    public class Category
    { 
        [Key]
        public int Id { get; set; }
        [Required]
        public string? CName { get; set; } 
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
