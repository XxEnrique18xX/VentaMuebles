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
            string resultado = servicio.AgregarUsuario(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text),textBox4.Text);
            MessageBox.Show(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var servicio = new ServiceUsuario();
            var resultado = servicio.BuscarUsuario(textBox1.Text, textBox2.Text);

            if (resultado.Any())
            {
                MessageBox.Show("Usuario autenticado correctamente.");
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
