using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Empleados
{
    internal interface IServiceEmpleados
    {
        //Lista todos los Empleados de la base de datos
        IEnumerable<dynamic> ListarEmpleados();
        //Agregar a nuevos Empleados a la base de datos
        string NuevosEmpleados(string nombre, string cargo, DateTime fechaContratacion, decimal salario, string usuario, string contrasenia, int idRol);
        //Actualizar los empleados en la base de datos
        string ActualizarEmpleados(int idEmpleado, string nombre, string cargo, DateTime fechaContratacion, decimal salario, string usuario, string contrasenia, int idRol);
        //Ocultar a los empleados para que no se vean en el dataGrid pero aún se mantengan en el SQL
        string BorrarEmpleados(string id);
    }
}
