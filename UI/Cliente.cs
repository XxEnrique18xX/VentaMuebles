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
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var logica = new ServiceCliente();
            string resultado;
            resultado = logica.NuevoCliente(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show(resultado);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var logica = new ServiceCliente();
            var datos = logica.ListarClientes();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var logica = new ServiceCliente();
            string resultado;
            resultado = logica.ActualizaClientes(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show(resultado);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
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
            textBox6.Clear();
            textBox7.Clear();
        }
    }
}
