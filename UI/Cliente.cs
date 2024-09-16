using BLL.Cliente;
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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public void ListarClientes()
        {
            var logica = new ServiceCliente();
            var datos = logica.ListarClientes();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
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
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value); ;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
            }
            else if(textBox4.Text.Length < 8)
            {
                MessageBox.Show("INGRESE UN NUMERO DE TELEFONO VALIDO");
            }
            else
            {
                DateTime fecha = dateTimePicker1.Value;
                string fechaFormatoDB = fecha.ToString("MM/dd/yyyy");
                var logica = new ServiceCliente();
                string resultado;
                resultado = logica.NuevoCliente(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, fechaFormatoDB, "1");
                MessageBox.Show(resultado);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                ListarClientes();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
            }
            else if (textBox4.Text.Length < 8)
            {
                MessageBox.Show("INGRESE UN NUMERO DE TELEFONO VALIDO");
            }
            else
            {
                DateTime fecha = dateTimePicker1.Value;
                string fechaFormatoDB = fecha.ToString("MM/dd/yyyy");
                var logica = new ServiceCliente();
                string resultado;
                resultado = logica.ActualizaClientes(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, fechaFormatoDB, "1");
                MessageBox.Show(resultado);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                ListarClientes();
            }
            
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var logica = new ServiceCliente();
            string resultado;
            resultado = logica.BorraClientes(textBox1.Text);
            MessageBox.Show(resultado);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            ListarClientes();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 8)
            {
                textBox4.Text = textBox4.Text.Substring(0, 8);
                textBox4.SelectionStart = textBox4.Text.Length;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' &&
               e.KeyChar != '-' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
               e.KeyChar != '-' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evitar que se ingrese cualquier otro carácter
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
