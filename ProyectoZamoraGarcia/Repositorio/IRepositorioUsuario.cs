using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoZamoraGarcia.Entidades;

namespace ProyectoZamoraGarcia.Repositorio
{
    public interface IRepositorioUsuario
    {
        Task<Usuarios> ObtenerUsuarioPorId(int id);
        Task<Usuarios> ObtenerUsuarioPorCorreo(string correo);
        Task<List<Usuarios>> ObtenerUsuarios();
        Task<int> CrearUsuario(Usuarios usuario);
        Task<Usuarios> ActualizarUsuario(Usuarios usuario);
        Task<int> EliminarUsuario(int id);

    }
}
