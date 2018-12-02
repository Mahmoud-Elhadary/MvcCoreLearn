using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreLearn.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category name")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        [MaxLength(150)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(1000)]
        public string body { get; set; }

        [Required]
        [Display(Name = "Publicatio Date")]
        [DataType(DataType.Date)]
        public DateTime PublicatioDate { get; set; }

        [Required]
        [Display(Name = "Auther Name")]
        [MaxLength(100)]
        public string AutherName { get; set; }

        [ScaffoldColumn(false)]
        public int Readers { get; set; }

        [Display(Name = "Image")]
        [MaxLength(500)]
        public string ImageUrl { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
