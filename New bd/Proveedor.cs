using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace proyecto.New_bd
{
    public class Proveedor
    {
        [Key]
        public int IDProveedor { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
    }
}
