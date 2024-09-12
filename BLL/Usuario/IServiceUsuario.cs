using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Usuario
{
    internal interface IServiceUsuario
    {
        IEnumerable<dynamic> BuscarUsuario(string username, string password);
        string AgregarUsuario(string username, string password, int rol);
    }
}
