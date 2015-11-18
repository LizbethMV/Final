using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.New_bd
{
    public class bdPrincipal : DbContext
    {
        public DbSet<inven> invens { get; set; }
        public DbSet<Compras> compra { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<ventas> venta { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
    }
}
