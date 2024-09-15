using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Muebles
{
    internal interface IRepositoryMuebles
    {
        //Listar a todos los Empleados de la base de datos
        IEnumerable<dynamic> GetMuebles();
        //Métdo para agreagar muebles a la base de datos
        void agregarMuebles(string categoria, int precioVenta, float porcentajeDescuento, string marca, string modelo, int existenciaStock, int existenciaMinima, int tiempoGarantia, int idCategoria);

        //Método para ocultar los datos del dataGridView
        string Borrar(string id);
    }
}