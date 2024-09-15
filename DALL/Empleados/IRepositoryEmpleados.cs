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
        //Crear nuevos Empleados en la base de datos    
        void AgregarEmpleados(string nombre, string cargo, DateTime fechaContratacion, decimal salario, string usuario, string contrasenia, int idRol);
        //Actualizar los empleados en la base de datos
        string ActualizarEmpleados(int idEmpleado,string nombre, string cargo, DateTime fechaContratacion, decimal salario, string usuario, string contrasenia, int idRol);
        //Método para ocultar los datos del dataGridView
        string Borrar(string id);
    }
}