using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {
        //private IDbConnection conexion;
        public IDbConnection Cadena()
        {
            return new SqlConnection("Server=DESKTOP-1B8L1T5; Initial Catalog=VentaMuebles; Persist Security Info=True; Encrypt=false; User ID=sa;Password=database");
        }

    }
}
