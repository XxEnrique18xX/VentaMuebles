using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL.Muebles;
using DAL;

namespace UI.Muebles
{
    public partial class CRUD_Muebles : Form
    {
        public CRUD_Muebles()
        {
            InitializeComponent();
            // Agregar el menú de opciones al combo box
            cmb_opciones.Items.Add("Todas");
            cmb_opciones.Items.Add("Sofás");
            cmb_opciones.Items.Add("Mesas de comedor");
            cmb_opciones.Items.Add("Sillas");
            cmb_opciones.Items.Add("Camas");
            cmb_opciones.Items.Add("Escritorios");
            cmb_opciones.Items.Add("Estanterías");
            cmb_opciones.Items.Add("Muebles de almacenamiento");
            cmb_opciones.SelectedIndex = 0;
        }

        // Este método se ejecutará cuando el formulario se cargue
        private void CRUD_Muebles_Load(object sender, EventArgs e)
        {
            // Llamamos al método para listar todos los muebles cuando se carga el formulario
            MostrarTodosLosMuebles();
        }

        // Método para listar todos los muebles
        private void MostrarTodosLosMuebles()
        {
            var logica = new ServiceMuebles();
            var datos = logica.ListarMuebles(0); // 0 o un valor que represente "todas las categorías"
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        //Método para listar muebles basados en la selección del combo box
        private void btn_listar_Click(object sender, EventArgs e)
        {
            var logica = new ServiceMuebles();
            int idCategoria = 0;

            // Determinar el idCategoria basado en la selección
            switch (cmb_opciones.Text)
            {
                case "Todas":
                    MostrarTodosLosMuebles();
                    break;
                case "Sofás":
                    idCategoria = 1;
                    break;
                case "Mesas de comedor":
                    idCategoria = 2;
                    break;
                case "Sillas":
                    idCategoria = 3;
                    break;
                case "Camas":
                    idCategoria = 4;
                    break;
                case "Escritorios":
                    idCategoria = 5;
                    break;
                case "Estanterías":
                    idCategoria = 6;
                    break;
                case "Muebles de almacenamiento":
                    idCategoria = 7;
                    break;
                default:
                    idCategoria = 0; // Para listar todos los muebles si no selecciona ninguna opción específica
                    break;
            }

            var datos = logica.ListarMuebles(idCategoria);
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            agregarMueblescs siguiente = new agregarMueblescs();
            siguiente.Show();
            this.Hide();
        }

        private void cmb_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

