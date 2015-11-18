using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace proyecto.New_bd
{
    public class Compras
    {
        [Key]
        public int IDcompras { get; set; }
        public int Idproveedor { get; set; }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}
