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
        //Método para actualizar a los empleados
        public string ActualizarEmpleados(int idEmpleado, string nombre, string cargo, DateTime fechaContratacion, decimal salario, string usuario, string contrasenia, int idRol)
        {
            string resultado = "";
            try
            {
                if (nombre != null && nombre != "")
                {
                    _empleadosDAL.ActualizarEmpleados(idEmpleado, nombre, cargo, fechaContratacion, salario, usuario, contrasenia, idRol);
                    resultado = "Se ha actualizado el empleado";
                }
                else
                    resultado = "El código no existe";
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            return resultado;
        }

        //Método para obtener todos los Empleados de la base de datos   
        public IEnumerable<dynamic> ListarEmpleados()
        {
            return _empleadosDAL.GetEmpleados();
        }
        //Método para agregar nuevos Empleados a la base de datos
        public string NuevosEmpleados(string nombre, string cargo, DateTime fechaContratacion, decimal salario, string usuario, string contrasenia, int idRol)
        {
            string resutlado = "";
            try
            {
                _empleadosDAL.AgregarEmpleados(nombre, cargo, fechaContratacion, salario, usuario, contrasenia, idRol);
                resutlado = "Se ha agregado un usuario exitosamente!!";
            }
            catch (Exception error)
            {
                resutlado = error.Message;
            }
            return resutlado;
        }
    }
}