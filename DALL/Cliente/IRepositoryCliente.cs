using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Cliente
{
    internal interface IRepositoryCliente
    {
        IEnumerable<dynamic> GetClientes();
        void Agrega(string nombreCliente, string direccionFacCliente, string telefonoCliente, string correoCliente, string fechaRegistroCliente, string estadoCliente);
        string Actualiza(string id, string nombreCliente, string direccionFacCliente, string telefonoCliente, string correoCliente, string fechaRegistroCliente, string estadoCliente);
        string Borra(string id);
    }
}
