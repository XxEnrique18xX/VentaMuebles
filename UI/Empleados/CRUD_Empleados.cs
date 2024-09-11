using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Empleados;

namespace UI.Empleados
{
    public partial class CRUD_Empleados : Form
    {
        public CRUD_Empleados()
        {
            InitializeComponent();
            ListarEmpleados();
        }

        private void CRUD_Empleados_Load(object sender, EventArgs e)
        {

        }
        //Método para llamar a todos los Empleados de la base de datos
        public void ListarEmpleados()
        {
            var logica = new ServiceEmpleados();
            var datos = logica.ListarEmpleados();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }
    }
}
