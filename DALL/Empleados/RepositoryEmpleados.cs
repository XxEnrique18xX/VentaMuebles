using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Transactions;

namespace DAL.Empleados
{
    public class RepositoryEmpleados : IRepositoryEmpleados
    {
        private readonly IDbConnection _conexion = new Conexion().Cadena();
        //Método para listar a todos los Empleados de la base de datos
        public IEnumerable<dynamic> GetEmpleados()
        {
            using (var connection = _conexion)
            {
                connection.Open();
                string query = @"SELECT e.IdEmpleado, e.Nombre, e.Cargo, e.Fecha_Contratacion, e.Salario, u.Usuario, u.Contrasenia FROM Empleado e INNER JOIN Usuario u ON e.IdUsuario = u.IdUsuario INNER JOIN Rol r ON u.IdRol = r.IdRol WHERE e.Estado = 1 AND u.Estado = 1";
                return connection.Query<dynamic>(query);
                //1 Visble
                //0 Oculto
            }
        }
        //Método para agregar Empleados a la base de datos
        public void AgregarEmpleados(string nombre, string cargo, DateTime fechaContratacion, decimal salario, string usuario, string contrasenia, int idRol)
        {
            using (var connection = _conexion)
            {
                connection.Open();
                // Iniciar una transacción
                using (var transaccion = connection.BeginTransaction())
                {
                    try
                    {
                        // Insertar datos en la tabla Usuario y obtener el IdUsuario generado automáticamente
                        var sqlUsuario = "INSERT INTO Usuario (Usuario, Contrasenia, IdRol, Estado) VALUES (@Usuario, @Contrasenia, @IdRol, @Estado); SELECT CAST(SCOPE_IDENTITY() as int)";
                        //SELECT CAST(SCOPE_IDENTITY() as int): Sirve para cuando se esteá insertando datos en una tabla con una columna de clave primaria auto-incremental
                        var idUsuario = connection.QuerySingle<int>(sqlUsuario, new { Usuario = usuario, Contrasenia = contrasenia, IdRol = idRol, Estado = true }, transaccion);

                        // Insertar datos en la tabla Empleados usando el IdUsuario generado
                        var sqlEmpleado = "INSERT INTO Empleado (Nombre, Cargo, Fecha_Contratacion, Salario, IdUsuario, Estado) VALUES (@Nombre, @Cargo, @Fecha_Contratacion, @Salario, @IdUsuario, @Estado)";
                        var idEmpleado = connection.Execute(sqlEmpleado, new { Nombre = nombre, Cargo = cargo, Fecha_Contratacion = fechaContratacion, Salario = salario, IdUsuario = idUsuario, Estado = true }, transaccion);

                        // Confirmar la transacción si ambas inserciones son exitosas
                        transaccion.Commit();
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
        //Método para actualizar los empleados de la base de datos
        public string ActualizarEmpleados(int idEmpleado, string nombre, string cargo, DateTime fechaContratacion, decimal salario, string usuario, string contrasenia, int idRol)
        {
            using (var connection = _conexion)
            {
                connection.Open();
                // Iniciar una transacción
                using (var transaccion = connection.BeginTransaction())
                {
                    try
                    {
                        // Obtener IdUsuario relacionado con el IdEmpleado
                        var sqlIdUsuario = "SELECT IdUsuario FROM Empleado WHERE IdEmpleado = @IdEmpleado";
                        var idUsuario = connection.QuerySingle<int>(sqlIdUsuario, new { IdEmpleado = idEmpleado }, transaccion);

                        // Actualizar datos en la tabla Usuario
                        var sqlUsuario = "UPDATE Usuario SET Usuario = @Usuario, Contrasenia = @Contrasenia, IdRol = @IdRol WHERE IdUsuario = @IdUsuario";
                        connection.Execute(sqlUsuario, new { Usuario = usuario, Contrasenia = contrasenia, IdRol = idRol, IdUsuario = idUsuario }, transaccion);

                        // Actualizar datos en la tabla Empleado
                        var sqlEmpleado = "UPDATE Empleado SET Nombre = @Nombre, Cargo = @Cargo, Fecha_Contratacion = @Fecha_Contratacion, Salario = @Salario WHERE IdEmpleado = @IdEmpleado";
                        connection.Execute(sqlEmpleado, new { Nombre = nombre, Cargo = cargo, Fecha_Contratacion = fechaContratacion, Salario = salario, IdEmpleado = idEmpleado }, transaccion);

                        // Confirmar la transacción si ambas actualizaciones son exitosas
                        transaccion.Commit();
                        return "Se ha actualizado la información";
                    }
                    catch (Exception ex)
                    {
                        // Si hay un error, revertir la transacción
                        transaccion.Rollback();
                        return $"Error: {ex.Message}";
                    }
                }
            }
        }
        //Método para ocultar los datos del DataGridView
        public string Borrar(string idEmpleado)
        {
            using (var connection = _conexion)
            {
                connection.Open();
                using (var transaccion = connection.BeginTransaction())
                {
                    try
                    {
                        // Ocultar el empleado en la tabla Empleado
                        var sqlEmpleado = "UPDATE Empleado SET Estado = @Estado WHERE IdEmpleado = @IdEmpleado";
                        connection.Execute(sqlEmpleado, new { IdEmpleado = idEmpleado, Estado = "0" }, transaccion);

                        // Obtener el IdUsuario asociado al IdEmpleado
                        var sqlUsuarioId = "SELECT IdUsuario FROM Empleado WHERE IdEmpleado = @IdEmpleado";
                        var idUsuario = connection.QuerySingle<int>(sqlUsuarioId, new { IdEmpleado = idEmpleado }, transaccion);

                        // Ocultar el usuario en la tabla Usuario
                        var sqlUsuario = "UPDATE Usuario SET Estado= @Estado WHERE IdUsuario = @IdUsuario";
                        connection.Execute(sqlUsuario, new { IdUsuario = idUsuario, Estado = "0" }, transaccion);

                        // Confirmar la transacción
                        transaccion.Commit();
                        return "Empleado y usuario borrados exitosamente";
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

    }
}