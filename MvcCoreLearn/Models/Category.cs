using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreLearn.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        [Display(Name = "Category Name")]
        [MaxLength(150, ErrorMessage = "Max Length 150 Character Only")]
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
