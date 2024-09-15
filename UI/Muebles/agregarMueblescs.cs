using BLL.Muebles;
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

namespace UI.Muebles
{
    public partial class agregarMueblescs : Form
    {
        public agregarMueblescs()
        {
            InitializeComponent();
            cmb_categoria.Items.Add("");
            cmb_categoria.Items.Add("Sofás");
            cmb_categoria.Items.Add("Mesas");
            cmb_categoria.Items.Add("Sillas");
            cmb_categoria.Items.Add("Camas");
            cmb_categoria.Items.Add("Escritorios");
            cmb_categoria.Items.Add("Estanterías");
            cmb_categoria.Items.Add("Muebles");
            cmb_categoria.SelectedIndex = 0;
        }

        private void agregarMueblescs_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Convertir los datos a sus valores correctos
            int existenciaStock = int.Parse(txt_existenciaStock.Text);
            int existenciaMinima = int.Parse(txt_existenciaMinima.Text);
            int garantia = int.Parse(txt_tiempoGarantia.Text);
            int categoria = 0;
            int precioVenta = int.Parse(txt_precioVenta.Text);
            float porcentajeDescuento = float.Parse(txt_porcentajeDescuento.Text);
            porcentajeDescuento = (float)Math.Round(porcentajeDescuento, 2); // Redondea a 2 decimales

            if (cmb_categoria.Text == "Sofá")
            {
                categoria = 1;
            }else if(cmb_categoria.Text == "Mesas")
            {
                categoria = 2;
            }else if(cmb_categoria.Text == "Sillas")
            {
                categoria = 3;
            }else if(cmb_categoria.Text == "Camas")
            {
                categoria = 4;
            }else if(cmb_categoria.Text == "Escritorios")
            {
                categoria = 5;
            }else if(cmb_categoria.Text == "Estanterías")
            {
                categoria = 6;
            }else if(cmb_categoria.Text == "Muebles")
            {
                categoria = 7;
            }

            var logica = new ServiceMuebles();
            string resultado;
            resultado = logica.NuevoMueble(txt_descripcion.Text, precioVenta, porcentajeDescuento, txt_marca.Text, txt_modelo.Text, existenciaStock, existenciaMinima, garantia, categoria);
            MessageBox.Show(resultado);
            this.Hide();
        }
    }
}
