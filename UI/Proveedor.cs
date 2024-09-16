using BLL.Cliente;
using BLL.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public void ListarProveedores()
        {
            var logica = new ServiceProveedor();
            var datos = logica.ListarProveedores();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
            }
            else if (textBox3.Text.Length < 8)
            {
                MessageBox.Show("INGRESE UN NUMERO DE TELEFONO VALIDO");
            }
            else
            {
                var logica = new ServiceProveedor();
                string resultado;
                resultado = logica.NuevoProveedor(textBox2.Text, textBox3.Text, textBox4.Text, "1");
                MessageBox.Show(resultado);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                ListarProveedores();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarProveedores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
            }
            else if (textBox3.Text.Length < 8)
            {
                MessageBox.Show("INGRESE UN NUMERO DE TELEFONO VALIDO");
            }
            else
            {
                var logica = new ServiceProveedor();
                string resultado;
                resultado = logica.ActualizaProveedor(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, "1");
                MessageBox.Show(resultado);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                ListarProveedores();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var logica = new ServiceProveedor();
            string resultado;
            resultado = logica.BorraProveedor(textBox1.Text);
            MessageBox.Show(resultado);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            ListarProveedores();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Enabled = false;
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' &&
                e.KeyChar != '-' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evitar que se ingrese cualquier otro carácter
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 8)
            {
                textBox3.Text = textBox3.Text.Substring(0, 8);
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
