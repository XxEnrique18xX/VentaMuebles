using BLL.Proveedor;
using BLL.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UI
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var servicio = new ServiceUsuario();
            string resultado = servicio.AgregarUsuario(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.Text), "1");
            MessageBox.Show(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var servicio = new ServiceUsuario();
            var resultado = servicio.BuscarUsuario(textBox1.Text, textBox2.Text);
            var ServicioUsuario = new ServiceUsuario();
            int idRol=0;
            string nombreUsuario = textBox1.Text;
            if (resultado.Any())
            {
                MessageBox.Show("Usuario autenticado correctamente.");
                idRol = ServicioUsuario.GetRol(nombreUsuario);
                //MessageBox.Show(idRol.ToString());
                Menu formMenu = new Menu();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var logica = new ServiceUsuario();
            var datos = logica.ListarUsuario();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
