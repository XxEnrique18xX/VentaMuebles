using DAL.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Usuario
{
    public class ServiceUsuario : IServiceUsuario
    {
        private readonly RepositoryUsuario _usuariosDAL = new RepositoryUsuario();

        public string AgregarUsuario(string username, string password, int rol, string estado)
        {
            string resultado = "";
            try
            {
                resultado = _usuariosDAL.AgregarUsuario(username, password, rol,estado);
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }

        public IEnumerable<dynamic> BuscarUsuario(string username, string password)
        {
            return _usuariosDAL.BuscarUsuario(username, password);
        }
    }
}
