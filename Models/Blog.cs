using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcApplication1.Models;

namespace MvcApplication1.Models
{
    public class Blog
    {       
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Informacion { get; set; }
        [Required]
        public string Fecha { get; set; }
    }

    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Blogger> Blogger { get; set; }
        public DbSet<Entradas> Entrada { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public BlogContext() : base("DBBlogger") { }

        public DbSet<InfoBlog> InfoBlogs { get; set; }
    }
}