using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Empleados
{
    internal interface IServiceEmpleados
    {
        //Lista todos los Empleados de la base de datos.
        IEnumerable<dynamic> ListarEmpleados();
    }
}
