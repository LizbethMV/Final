using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace proyecto.New_bd
{
    public class inven
    {
        
        public int Id { get; set; }

        public string NombreProducto { get; set; }

        public string Categoria { get; set; }

        public float precio { get; set; }
        public virtual ICollection<ventas> venta { get; set; }
    }
}
