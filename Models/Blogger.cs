﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Blogger
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }        
        [Required]
        public string Biografia { get; set; }
        [Required]
        public string RedesSociales { get; set; }

    }
}