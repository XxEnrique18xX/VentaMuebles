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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UI.Empleados
{
    public partial class CRUD_Empleados : Form
    {
        //Variable para guardar los datos del comboBox
        int rolname = 0;
        public CRUD_Empleados()
        {
            InitializeComponent();
            ListarEmpleados();
            //Agregar listado de opciones para el comboBox
            cmb_rol.Items.Add("Administrador");
            cmb_rol.Items.Add("Bodeguero");
            cmb_rol.Items.Add("Vendedor");
            cmb_rol.Items.Add("Gerente");
            cmb_rol.SelectedIndex = 0;
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
        //Botón para guardar los datos
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Convertir los text Box a los valores correspondientes
            string nombre = txt_nombre.Text;
            string cargo = cmb_rol.Text;
            string usuario = txt_usuario.Text;
            string contrasenia = txt_contrasenia.Text;
            //Convertir la Fecha al valor correspondiente
            DateTime fechaContratacion;
            if (!DateTime.TryParse(txt_fechaContratacion.Text, out fechaContratacion))
            {
                MessageBox.Show("La fecha de contratación no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Convertir el Salario al valor correspondiente
            decimal salario;
            if (!decimal.TryParse(txt_salario.Text, out salario))
            {
                MessageBox.Show("El salario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Verficiar la elección del usuario mediante el ComboBox
            if (cmb_rol.Text == "Administrador")
            {
                rolname = 1;
            }
            else if (cmb_rol.Text == "Bodeguero")
            {
                rolname = 2;
            }
            else if (cmb_rol.Text == "Vendedor")
            {
                rolname = 3;
            }
            else if (cmb_rol.Text == "Gerente")
            {
                rolname = 4;
            }
            // Llamar al método de agregar con los valores correctos
            var logica = new ServiceEmpleados();
            string resultado;
            resultado = logica.NuevosEmpleados(nombre, cargo, fechaContratacion, salario, usuario, contrasenia, rolname);
            MessageBox.Show("Se ha agregado un nuevo registro!!");
            ListarEmpleados(); // Actualiza el DataGridView
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Trasladar el contenido de cada texto hacia las cajas de texto
            if (e.RowIndex >= 0)
            {
                lbl_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmb_rol.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_fechaContratacion.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_salario.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_usuario.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_contrasenia.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
        //Botón para actualizar los datos
        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            // Convertir los text Box a los valores correspondientes
            string nombre = txt_nombre.Text;
            string cargo = cmb_rol.Text;
            string usuario = txt_usuario.Text;
            string contrasenia = txt_contrasenia.Text;
            int id = int.Parse(lbl_id.Text);
            // Convertir la Fecha al valor correspondiente
            DateTime fechaContratacion;
            if (!DateTime.TryParse(txt_fechaContratacion.Text, out fechaContratacion))
            {
                MessageBox.Show("La fecha de contratación no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Convertir el Salario al valor correspondiente
            decimal salario;
            if (!decimal.TryParse(txt_salario.Text, out salario))
            {
                MessageBox.Show("El salario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar la elección del usuario mediante el ComboBox
            if (cmb_rol.Text == "Administrador")
            {
                rolname = 1;
            }
            else if (cmb_rol.Text == "Bodeguero")
            {
                rolname = 2;
            }
            else if (cmb_rol.Text == "Vendedor")
            {
                rolname = 3;
            }
            else if (cmb_rol.Text == "Gerente")
            {
                rolname = 4;
            }
            // Llamar al método de actualizar con los valores correctos
            var logica = new ServiceEmpleados();
            string resultado = logica.ActualizarEmpleados(id, nombre, cargo, fechaContratacion, salario, usuario, contrasenia, rolname);
            MessageBox.Show(resultado);
            ListarEmpleados(); // Actualiza el DataGridView
        }
    }
}
