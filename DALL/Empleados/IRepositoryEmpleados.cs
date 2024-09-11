using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Empleados
{
    internal interface IRepositoryEmpleados
    {
        //Listar a todos los Empleados de la base de datos
        IEnumerable<dynamic> GetEmpleados();
    }
}
