﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace proyecto.New_bd
{
    public class Usuario
    {
        [Key]
        public int Idusu { get; set; }
        public string NombreUsuario { get; set; }
        public float Contraseña { get; set; }
        
    }
}
