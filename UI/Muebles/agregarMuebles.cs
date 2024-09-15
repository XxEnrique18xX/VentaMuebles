using BLL.Empleados;
using BLL.Muebles;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Muebles
{
    public partial class agregarMuebles : Form
    {
        public string Id { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string precioVenta {  get; set; }
        public string porcentajeDescuento { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string existenciaStock { get; set; }
        public string existenciaMinima { get; set; }
        public string tiempoGarantia { get; set; }
        public int categoriaInt = 0; 

        public agregarMuebles()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.agregarMueblescs_Load);
            cmb_categoria.Items.Add("Todas");
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


            // Establece el valor del Id
            if (!string.IsNullOrEmpty(Id))
            {
                txt_id.Text = Id;
            }
            //Establece el valor de la categoría
            if (!string.IsNullOrEmpty(Categoria))
            {
                if(categoriaInt == 1)
                {
                    cmb_categoria.Text = "Sofás";
                }else if(categoriaInt == 2)
                {
                    cmb_categoria.Text = "Mesas";
                }else if(categoriaInt == 3)
                {
                    cmb_categoria.Text = "Sillas";
                }else if(categoriaInt == 4)
                {
                    cmb_categoria.Text = "Camas";
                }else if(categoriaInt == 5)
                {
                    cmb_categoria.Text = "Escritorios";
                }else if(categoriaInt == 6)
                {
                    cmb_categoria.Text = "Estanterías";
                }else if(categoriaInt == 7)
                {
                    cmb_categoria.Text = "Muebles";
                }
            }
            //Estable el valor de la descripción
            if(!string.IsNullOrEmpty(Descripcion))
            {
                txt_descripcion.Text = Descripcion;
            }
            //Establece el valor del precioVenta
            if(!string.IsNullOrEmpty(precioVenta))
            {
                txt_precioVenta.Text = precioVenta;
            }
            //Establece el valor del porcentajeDescuento
            if(!string.IsNullOrEmpty(porcentajeDescuento))
            {
                txt_porcentajeDescuento.Text = porcentajeDescuento;
            }
            //Establece la marca
            if (!string.IsNullOrEmpty(marca))
            {
               txt_marca.Text = marca;
            }
            //Establece el modelo
            if (!string.IsNullOrEmpty(modelo))
            {
                txt_modelo.Text = modelo;
            }
            //Establece la existenciaStock
            if (!string.IsNullOrEmpty(existenciaStock))
            {
                txt_existenciaStock.Text = existenciaStock;
            }
            //Establece la existenciaMinima
            if (!string.IsNullOrEmpty(existenciaMinima))
            {
                txt_existenciaMinima.Text = existenciaMinima;
            }
            //Establece el tiempo de garantia
            if (!string.IsNullOrEmpty(tiempoGarantia))
            {
                txt_tiempoGarantia.Text = tiempoGarantia;
            }
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
            }
            else if (cmb_categoria.Text == "Mesas")
            {
                categoria = 2;
            }
            else if (cmb_categoria.Text == "Sillas")
            {
                categoria = 3;
            }
            else if (cmb_categoria.Text == "Camas")
            {
                categoria = 4;
            }
            else if (cmb_categoria.Text == "Escritorios")
            {
                categoria = 5;
            }
            else if (cmb_categoria.Text == "Estanterías")
            {
                categoria = 6;
            }
            else if (cmb_categoria.Text == "Muebles")
            {
                categoria = 7;
            }

            var logica = new ServiceMuebles();
            string resultado;
            resultado = logica.NuevoMueble(txt_descripcion.Text, precioVenta, porcentajeDescuento, txt_marca.Text, txt_modelo.Text, existenciaStock, existenciaMinima, garantia, categoria);
            MessageBox.Show(resultado);
            this.Hide();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
