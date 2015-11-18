using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace proyecto.New_bd
{
    public class ventas
    {
        [Key]
        public int IDventas { get; set; }
        public int IDProducto { get; set; }
        public float cantidad { get; set; }
        public int Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
