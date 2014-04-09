using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class Blogger
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Biografia { get; set; }
        public string RedesSociales { get; set; }
    }
}