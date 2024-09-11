using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Empleados;

namespace BLL.Empleados
{
    public class ServiceEmpleados : IServiceEmpleados
    {
        private readonly RepositoryEmpleados _empleadosDAL = new RepositoryEmpleados();
       //Método para obtener todos los Empleados de la base de datos   
       public IEnumerable<dynamic> ListarEmpleados()
        {
            return _empleadosDAL.GetEmpleados();
        }
    }
}
