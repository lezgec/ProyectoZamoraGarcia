using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZamoraGarcia.Entidades
{
    public class Usuarios
    {
        public int Id { get; set; } // Clave primaria
        public string Nombre { get; set; } // Nombre del usuario
        public string Apellido { get; set; } // Apellido del usuario
        public string Correo { get; set; } // Correo electrónico
        public string Telefono { get; set; } // Número de teléfono
        public int Edad { get; set; } // Edad del usuario
        public string Contrasena { get; set; } // Contraseña
        public DateTime FechaCreacion { get; set; } // Fecha de creación
        public DateTime? FechaActualizacion { get; set; } // Fecha de actualización opcional
        public DateTime? FechaEliminacion { get; set; } // Fecha de eliminación opcional
        public bool Eliminado { get; set; } // Eliminación lógica
    }
}
