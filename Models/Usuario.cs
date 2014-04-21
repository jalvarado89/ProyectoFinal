using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string User { get; set; }
        [Required]
        [StringLength(40)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}