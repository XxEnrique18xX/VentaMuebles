using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Cliente
{
    internal interface IServiceCliente
    {
        IEnumerable<dynamic> ListarClientes();
        string NuevoCliente(string nombreCliente, string direccionFacCliente, string telefonoCliente, string correoCliente, string fechaRegistroCliente, string estadoCliente);
        string ActualizaClientes(string id, string nombreCliente, string direccionFacCliente, string telefonoCliente, string correoCliente, string fechaRegistroCliente, string estadoCliente);
        string BorraClientes(string id);
    }
}
