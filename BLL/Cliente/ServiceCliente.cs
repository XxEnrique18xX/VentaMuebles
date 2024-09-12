using DAL.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Cliente
{
    public class ServiceCliente : IServiceCliente
    {
        private readonly RepositoryCliente _clientesDal = new RepositoryCliente();
        public IEnumerable<dynamic> ListarClientes()
        {
            return _clientesDal.GetClientes();
        }
        public string NuevoCliente(string nombreCliente, string direccionFacCliente, string telefonoCliente, string correoCliente, string fechaRegistroCliente, string estadoCliente)
        {
            string resultado = "";
            try
            {
                _clientesDal.Agrega(nombreCliente, direccionFacCliente, telefonoCliente, correoCliente, fechaRegistroCliente, estadoCliente);
                resultado = "SE AGREGO EL CLIENTE CON NOMBRE: " + nombreCliente;
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
        public string ActualizaClientes(string id, string nombreCliente, string direccionFacCliente, string telefonoCliente, string correoCliente, string fechaRegistroCliente, string estadoCliente)
        {
            string resultado = " ";
            try
            {
                if (id != null && id != "")
                {
                    _clientesDal.Actualiza(id, nombreCliente, direccionFacCliente, telefonoCliente, correoCliente, fechaRegistroCliente, estadoCliente);
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
        public string BorraClientes(string id)
        {
            string resultado = " ";
            try
            {
                if (id != null && id != "")
                {
                    _clientesDal.Borra(id);
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
