using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Proveedor
{
    internal interface IRepositoryProveedor
    {
        IEnumerable<dynamic> GetProveedores();
        void Agrega(string nombreProveedor, string telefonoProveedor, string correoProveedor, string estadoProveedor);
        string Actualiza(string id, string nombreProveedor, string telefonoProveedor, string correoProveedor, string estadoProveedor);
        string Borra(string id);
    }
}
