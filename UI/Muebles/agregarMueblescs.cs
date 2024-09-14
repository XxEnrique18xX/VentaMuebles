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
            cmb_categoria.Items.Add("Muebles de almacenamiento");
            cmb_categoria.SelectedIndex = 0;
        }

        private void agregarMueblescs_Load(object sender, EventArgs e)
        {
         
        }
    }
}
