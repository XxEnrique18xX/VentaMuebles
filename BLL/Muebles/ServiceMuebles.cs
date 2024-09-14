using DAL.Muebles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Muebles
{
    public class ServiceMuebles : IServiceMuebles
    {
        private readonly RepositoryMuebles _mueblesDAL = new RepositoryMuebles();

        public IEnumerable<dynamic> ListarMuebles(int idCategoria)
        {
            // Pasar idCategoria al repositorio para filtrar los muebles
            return _mueblesDAL.GetMuebles(idCategoria);
        }
    }
}