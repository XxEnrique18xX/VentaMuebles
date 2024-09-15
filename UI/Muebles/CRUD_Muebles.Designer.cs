namespace UI.Muebles
{
    partial class CRUD_Muebles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lbl_categoria = new Label();
            cmb_opciones = new ComboBox();
            btn_listar = new Button();
            btn_Agregar = new Button();
            btn_eliminar = new Button();
            label1 = new Label();
            txt_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1526, 592);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Location = new Point(23, 26);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(156, 25);
            lbl_categoria.TabIndex = 1;
            lbl_categoria.Text = "Producto a buscar";
            // 
            // cmb_opciones
            // 
            cmb_opciones.FormattingEnabled = true;
            cmb_opciones.Location = new Point(188, 23);
            cmb_opciones.Name = "cmb_opciones";
            cmb_opciones.Size = new Size(227, 33);
            cmb_opciones.TabIndex = 2;
            cmb_opciones.SelectedIndexChanged += cmb_opciones_SelectedIndexChanged;
            // 
            // btn_listar
            // 
            btn_listar.Location = new Point(516, 22);
            btn_listar.Name = "btn_listar";
            btn_listar.Size = new Size(112, 34);
            btn_listar.TabIndex = 3;
            btn_listar.Text = "Listar";
            btn_listar.UseVisualStyleBackColor = true;
            btn_listar.Click += btn_listar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(662, 21);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(112, 34);
            btn_Agregar.TabIndex = 4;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(795, 23);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(112, 34);
            btn_eliminar.TabIndex = 5;
            btn_eliminar.Text = "Elimiar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1207, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(1272, 27);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(91, 31);
            txt_id.TabIndex = 7;
            // 
            // CRUD_Muebles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 718);
            Controls.Add(txt_id);
            Controls.Add(label1);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_Agregar);
            Controls.Add(btn_listar);
            Controls.Add(cmb_opciones);
            Controls.Add(lbl_categoria);
            Controls.Add(dataGridView1);
            Name = "CRUD_Muebles";
            Text = "CRUD_Muebles";
            Load += CRUD_Muebles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_categoria;
        private ComboBox cmb_opciones;
        private Button btn_listar;
        private Button btn_Agregar;
        private Button btn_eliminar;
        private Label label1;
        private TextBox txt_id;
    }
}