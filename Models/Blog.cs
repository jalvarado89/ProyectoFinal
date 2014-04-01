using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProyectoFinal.Models
{
    public class Blog
    {        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Informacion { get; set; }
    }

    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Blogger> Blogger { get; set; }
        public DbSet<Entradas> Entrada { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public BlogContext() : base("DBBlogger") { }
    }
}