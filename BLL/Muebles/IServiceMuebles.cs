using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Muebles
{
    public interface IServiceMuebles
    {
        // Listar Muebles filtrados por IdCategoria
        IEnumerable<dynamic> ListarMuebles(int idCategoria);
    }
}
