using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Proveedor
{
    public class RepositoryProveedor : IRepositoryProveedor
    {
        private readonly IDbConnection _conexion = new Conexion().Cadena();
        public IEnumerable<dynamic> GetProveedores()
        {
            using (var connection = _conexion)
            {
                connection.Open();
                return connection.Query<dynamic>("SELECT * FROM Proveedor WHERE Proveedor.Estado = 1");
            }
        }
        public void Agrega(string nombreProveedor, string telefonoProveedor, string correoProveedor, string estadoProveedor)
        {
            using (var connection = _conexion)
            {
                var sql = "INSERT INTO Proveedor (Nombre_Proveedor, Telefono, Correo_Electronico, Estado) VALUES ( @Nombre_Proveedor, @Telefono,@Correo_Electronico, @Estado)";
                connection.Execute(sql, new { Nombre_Proveedor = nombreProveedor, Telefono = telefonoProveedor, Correo_Electronico = correoProveedor, Estado = estadoProveedor });
            }
        }
        public string Actualiza(string id, string nombreProveedor, string telefonoProveedor, string correoProveedor, string estadoProveedor)
        {
            using (var connection = _conexion)
            {
                var sql = "UPDATE Proveedor SET Nombre_Proveedor=@Nombre_Proveedor, Telefono=@Telefono, Correo_Electronico=@Correo_Electronico, Estado=@Estado WHERE IdProveedor=@IdProveedor";
                connection.Execute(sql, new { IdProveedor = id, Nombre_Proveedor = nombreProveedor, Telefono = telefonoProveedor, Correo_Electronico = correoProveedor, Estado = estadoProveedor });
                return "SE ACTUALIZO LA INFORMACIÓN";
            }
        }
        public string Borra(string id)
        {
            using (var connection = _conexion)
            {
                var sql = "UPDATE Proveedor SET Estado=@Estado WHERE IdProveedor = @IdProveedor";
                connection.Execute(sql, new { IdProveedor = id, Estado = "0" });
                return "CLIENTE BORRADO CON EXITO";
            }

        }
    }
}
