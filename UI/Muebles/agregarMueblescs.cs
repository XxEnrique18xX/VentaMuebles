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
            btn_categoria.Items.Add("");
            btn_categoria.Items.Add("Sofás");
            btn_categoria.Items.Add("Mesas de comedor");
            btn_categoria.Items.Add("Sillas");
            btn_categoria.Items.Add("Camas");
            btn_categoria.Items.Add("Escritorios");
            btn_categoria.Items.Add("Estanterías");
            btn_categoria.Items.Add("Muebles de almacenamiento");
            btn_categoria.SelectedIndex = 0;
        }

        private void agregarMueblescs_Load(object sender, EventArgs e)
        {

        }
    }
}
