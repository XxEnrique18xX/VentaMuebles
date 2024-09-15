using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Muebles
{
    public interface IServiceMuebles
    {
        // Listar Muebles filtrados por IdCategoria
        IEnumerable<dynamic> ListarMuebles(int idCategoria);
        //Agregar nuevo método
        string NuevoMueble(string categoria, int precioVenta, float porcentajeDescuento, string marca, string modelo, int existenciaStock, int existenciaMinima, int tiempoGarantia, int idCategoria);
        //Ocultar a los muebles para que no se vean en el dataGrid pero aún se mantengan en el SQL
        string BorrarMuebles(string id);
    }
}