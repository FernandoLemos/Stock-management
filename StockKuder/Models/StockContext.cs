using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace StockKuder.Models
{
    public class StockContext : DbContext
    {
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public StockContext()
            : base("con") { }
    }
}