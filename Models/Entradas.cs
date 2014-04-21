using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication1.Models
{
    public class Entradas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Titulo { get; set; }
        [Required]
        public string Fecha { get; set; }
        [Required]
        public string Comentario { get; set; }
        [Required]
        public bool Enable { get; set; }
        public int? IdBlog { get; set; }

        public virtual ICollection<Blog> Blog { get; set; }
    }
}