using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

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
                return connection.Query<dynamic>("SELECT * FROM Empleado"); 
            }
        }
    }
}
