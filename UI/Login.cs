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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var servicio = new ServiceUsuario();
            var resultado = servicio.BuscarUsuario(textBox1.Text, textBox2.Text);
            var ServicioUsuario = new ServiceUsuario();
            int idRol = 0;
            string nombreUsuario = textBox1.Text;
            if (resultado.Any())
            {
                MessageBox.Show("Usuario autenticado correctamente.");
                idRol = ServicioUsuario.GetRol(nombreUsuario);
                if(idRol == 1)
                {
                    VariablesGlobales.administrador = true;
                    VariablesGlobales.bodeguero = false;
                    VariablesGlobales.vendedor = false;
                    VariablesGlobales.gerente = false;
                }
                else if(idRol == 2)
                {
                    VariablesGlobales.administrador = false;
                    VariablesGlobales.bodeguero = true;
                    VariablesGlobales.vendedor = false;
                    VariablesGlobales.gerente = false;
                }
                else if (idRol == 3)
                {
                    VariablesGlobales.administrador = false;
                    VariablesGlobales.bodeguero = false;
                    VariablesGlobales.vendedor = true;
                    VariablesGlobales.gerente = false;
                }
                else if (idRol == 4)
                {
                    VariablesGlobales.administrador = false;
                    VariablesGlobales.bodeguero = false;
                    VariablesGlobales.vendedor = false;
                    VariablesGlobales.gerente = true;
                }
                MessageBox.Show(idRol.ToString());
                Menu formMenu = new Menu();
                formMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    public static class VariablesGlobales
    {
        public static bool administrador = false;
        public static bool bodeguero = false;
        public static bool vendedor = false;
        public static bool gerente = false;
    }
}
