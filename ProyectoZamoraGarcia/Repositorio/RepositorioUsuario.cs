using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoZamoraGarcia.Entidades;

namespace ProyectoZamoraGarcia.Repositorio
{
    internal class RepositorioUsuario : IRepositorioUsuario
    {

        private readonly ApplicationDbContext _context;

        public RepositorioUsuario(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Usuarios> ActualizarUsuario(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public Task<int> CrearUsuario(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public Task<int> EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> ObtenerUsuarioPorCorreo(string correo)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> ObtenerUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuarios>> ObtenerUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
