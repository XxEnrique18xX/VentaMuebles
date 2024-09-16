using DAL.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Proveedor
{
    public class ServiceProveedor : IServiceProveedor
    {
        private readonly RepositoryProveedor _proveedoresDal = new RepositoryProveedor();
        public IEnumerable<dynamic> ListarProveedores()
        {
            return _proveedoresDal.GetProveedores();
        }
        public string NuevoProveedor(string nombreProveedor, string telefonoProveedor, string correoProveedor, string estadoProveedor)
        {
            string resultado = "";
            try
            {
                _proveedoresDal.Agrega( nombreProveedor,  telefonoProveedor,  correoProveedor,  estadoProveedor);
                resultado = "SE AGREGO EL CLIENTE CON NOMBRE: " + nombreProveedor;
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
        public string ActualizaProveedor(string id, string nombreProveedor, string telefonoProveedor, string correoProveedor, string estadoProveedor)
        {
            string resultado = " ";
            try
            {
                if (id != null && id != "")
                {
                    _proveedoresDal.Actualiza(id, nombreProveedor,telefonoProveedor,correoProveedor,estadoProveedor);
                    resultado = "SE ACTUALIZO EL CLIENTE CON CODIGO: " + id;
                }
                else
                    resultado = "EL CODIGO NO EXISTE";
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
        public string BorraProveedor(string id)
        {
            string resultado = " ";
            try
            {
                if (id != null && id != "")
                {
                    _proveedoresDal.Borra(id);
                    resultado = "SE BORRO EL CLIENTE";
                }
                else
                    resultado = "EL CODIGO NO EXISTE";
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;

        }
    }
}
