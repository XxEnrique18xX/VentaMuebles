using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Muebles;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DAL.Muebles   
{
    public class RepositoryMuebles : IRepositoryMuebles
    {
        private readonly IDbConnection _conexion = new Conexion().Cadena();
        //Obtener los muebles
        public IEnumerable<dynamic> GetMuebles(int idCategoria)
        {
            using (var connection = _conexion)
            {
                connection.Open();

                if (idCategoria == 0)
                {
                    return connection.Query<dynamic>("SELECT * FROM Mueble WHERE Estado = 1");
                }
                else
                {
                    return connection.Query<dynamic>("SELECT * FROM Mueble WHERE IdCategoria = @IdCategoria AND Estado = 1", new { IdCategoria = idCategoria });
                }
            }
        }
        //Agregar nuevos muebles a la base de datos
        public void agregarMuebles(string categoria, int precioVenta, float porcentajeDescuento, string marca, string modelo, int existenciaStock, int existenciaMinima, int tiempoGarantia, int idCategoria)
        {
            using (var conecction = _conexion)
            {
                var sql = "INSERT INTO Mueble (Descripcion, Precio_Venta, Porcentaje_Descuento, Marca, Modelo, Existencia_Stock, Existencia_Minima, Tiempo_Garantia, IdCategoria, Estado) " +
                          "VALUES (@Descripcion, @Precio_Venta, @Porcentaje_Descuento, @Marca, @Modelo, @Existencia_Stock, @Existencia_Minima, @Tiempo_Garantia, @IdCategoria, @Estado)";
                conecction.Execute(sql, new
                {
                    Descripcion = categoria,
                    Precio_Venta = precioVenta,
                    Porcentaje_Descuento = porcentajeDescuento,
                    Marca = marca,
                    Modelo = modelo,
                    Existencia_Stock = existenciaStock,
                    Existencia_Minima = existenciaMinima,
                    Tiempo_Garantia = tiempoGarantia,
                    IdCategoria = idCategoria,
                    Estado = 1  // Valor predeterminado para el estado
                });
            }
        }
        //Método para ocultar los datos del dataGridView
        public string Borrar(string idMueble)
        {
            using (var connection = _conexion)
            {
                connection.Open();
                using (var transaccion = connection.BeginTransaction())
                {
                    try
                    {
                        // Ocultar el mueble en la tabla Mueble
                        var sqlEmpleado = "UPDATE Mueble SET Estado = @Estado WHERE IdMueble = @IdMueble";
                        connection.Execute(sqlEmpleado, new { IdMueble = idMueble, Estado = "0" }, transaccion); // Estado como número                                                                                                        
                        // Confirmar la transacción
                        transaccion.Commit();
                        return "Mueble ocultado exitosamente!";
                    }
                    catch (Exception ex)
                    {
                        // Si hay un error, revertir la transacción
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }
        public IEnumerable<dynamic> GetMuebles()
        {
            throw new NotImplementedException();
        }
    }
}