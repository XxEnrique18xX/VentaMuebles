using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Usuario
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        private readonly IDbConnection _conexion = new Conexion().Cadena();
        public IEnumerable<dynamic> GetUsuarios()
        {
            using (var connection = _conexion)
            {
                connection.Open();
                return connection.Query<dynamic>("SELECT Usuario,IdRol,Estado FROM Usuario WHERE Usuario.Estado = 1");
            }
        }
        public int GetRol(string idUsuario)
        {
            using (var connection = _conexion)
            {
                connection.Open();
                string query = "SELECT IdRol FROM Usuario WHERE Usuario = @IdUsuario";
                return connection.QueryFirstOrDefault <int>(query, new {IdUsuario = idUsuario});

            }
        }
       
        public IEnumerable<dynamic> BuscarUsuario(string username, string password)
        {
            using (var connection = _conexion)
            {
                connection.Open();
                return connection.Query("VerificarUsuario", new { Username = username, Password = password }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public string AgregarUsuario(string username, string password, int rol, string estado)
        {
            string respuesta = "";
            using (var connection = _conexion)
            {
                connection.Open();
                var resultado = connection.Query("InsertarUsuario", new { Username = username, Password = password, IdRol = rol, Estado = estado}, commandType: CommandType.StoredProcedure).FirstOrDefault();

                if (resultado != null)
                {
                    var valorPrimeraCelda = ((IDictionary<string, object>)resultado).Values.ElementAt(0);
                    if (valorPrimeraCelda.ToString().Contains("Error"))
                        respuesta = "Error al grabar";
                    else
                        respuesta = "Usuario registrado correctamente";
                }
            }
            return respuesta;
        }
    }
}
