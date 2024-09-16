using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

            if (VariablesGlobales.administrador == true)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
            }
            else if (VariablesGlobales.bodeguero == true)
            {

            }
            else if (VariablesGlobales.vendedor == true)
            {

            }
            else if (VariablesGlobales.gerente == true)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cliente formCliente = new Cliente();
            formCliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedor formProveedor = new Proveedor();
            formProveedor.ShowDialog();
        }
    }
}
