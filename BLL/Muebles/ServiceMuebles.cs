using DAL.Muebles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Muebles
{
    public class ServiceMuebles : IServiceMuebles
    {
        private readonly RepositoryMuebles _mueblesDAL = new RepositoryMuebles();
        //Método para ocultar a los empleados de el dataGird
        public string BorrarMuebles(string id)
        {
            
           
                string resultado = "";
                try
                {
                    _mueblesDAL.Borrar(id);
                    resultado = "Empleado eliminado exitosamente!!";
                }
                catch (Exception error)
                {
                    resultado = error.Message;
                }
                return resultado; // Asegúrate de retornar el resultado
            
        }

        public IEnumerable<dynamic> ListarMuebles(int idCategoria)
        {
            // Pasar idCategoria al repositorio para filtrar los muebles
            return _mueblesDAL.GetMuebles(idCategoria);
        }

        public string NuevoMueble(string categoria, int precioVenta, float porcentajeDescuento, string marca, string modelo, int existenciaStock, int existenciaMinima, int tiempoGarantia, int idCategoria)
        {
            string resultado = "";
            try
            {
                _mueblesDAL.agregarMuebles(categoria, precioVenta, porcentajeDescuento, marca, modelo, existenciaStock, existenciaMinima, tiempoGarantia, idCategoria);
                resultado = "Se agrego nuevo mueble";
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
    }
}