using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Cliente
{
    public class RepositoryCliente : IRepositoryCliente
    {
        private readonly IDbConnection _conexion = new Conexion().Cadena();
        public IEnumerable<dynamic> GetClientes()
        {
            using (var connection = _conexion)
            {
                connection.Open();
                return connection.Query<dynamic>("SELECT * FROM Cliente WHERE Cliente.Estado = 1");
            }
        }
        public void Agrega(string nombreCliente, string direccionFacCliente, string telefonoCliente, string correoCliente, string fechaRegistroCliente, string estadoCliente)
        {
            using (var connection = _conexion)
            {
                var sql = "INSERT INTO Cliente ( Nombre, Direccion_Facturacion,Telefono,Correo_Electronico, Fecha_Registro, Estado) VALUES ( @Nombre, @Direccion_Facturacion,@Telefono,@Correo_Electronico, @Fecha_Registro, @Estado)";
                connection.Execute(sql, new { Nombre = nombreCliente, Direccion_Facturacion = direccionFacCliente, Telefono = telefonoCliente, Correo_Electronico = correoCliente, Fecha_Registro = fechaRegistroCliente, Estado = estadoCliente });
            }
        }
        public string Actualiza(string id, string nombreCliente, string direccionFacCliente, string telefonoCliente, string correoCliente, string fechaRegistroCliente, string estadoCliente)
        {
            using (var connection = _conexion)      
            {
                var sql = "UPDATE Cliente SET Nombre=@Nombre, Direccion_Facturacion=@Direccion_Facturacion, Telefono=@Telefono, Correo_Electronico=@Correo_Electronico,Fecha_Registro=@Fecha_Registro, Estado=@Estado WHERE idCliente=@idCliente";
                connection.Execute(sql, new { idCliente = id, Nombre = nombreCliente, Direccion_Facturacion = direccionFacCliente, Telefono = telefonoCliente, Correo_Electronico = correoCliente, Fecha_Registro = fechaRegistroCliente, Estado = estadoCliente });
                return "SE ACTUALIZO LA INFORMACIÓN";
            }
        }
        public string Borra(string id)
        {
            using (var connection = _conexion)
            {
                var sql = "UPDATE Cliente SET Estado=@Estado WHERE idCliente = @idCliente";
                connection.Execute(sql, new { idCliente = id, Estado = "0" });
                return "CLIENTE BORRADO CON EXITO";
            }

        }
    }
}
