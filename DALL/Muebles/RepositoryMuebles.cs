using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Muebles;


namespace DAL.Muebles
{
    public class RepositoryMuebles
    {
        private readonly IDbConnection _conexion = new Conexion().Cadena(); // Asumiendo que `Conexion` es una clase que manejas

        public IEnumerable<dynamic> GetMuebles(int idCategoria)
        {
            using (var connection = _conexion)
            {
                connection.Open();

                if (idCategoria == 0)
                {
                    return connection.Query<dynamic>("SELECT * FROM Mueble");
                }
                else
                {
                    return connection.Query<dynamic>("SELECT * FROM Mueble WHERE IdCategoria = @IdCategoria", new { IdCategoria = idCategoria });
                }
            }
        }
    }
}