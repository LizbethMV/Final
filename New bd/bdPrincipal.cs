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
    }
}
