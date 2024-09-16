using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Proveedor
{
    internal interface IServiceProveedor
    {
        IEnumerable<dynamic> ListarProveedores();
        string NuevoProveedor(string nombreProveedor, string telefonoProveedor, string correoProveedor, string estadoProveedor);
        string ActualizaProveedor(string id, string nombreProveedor, string telefonoProveedor, string correoProveedor, string estadoProveedor);
        string BorraProveedor(string id);
    }
}
