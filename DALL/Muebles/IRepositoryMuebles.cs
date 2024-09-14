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
    }
}