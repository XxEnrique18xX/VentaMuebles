namespace UI.Empleados
{
    partial class CRUD_Empleados
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
            groupBox1 = new GroupBox();
            btn_actualizar = new Button();
            lbl_id = new Label();
            label8 = new Label();
            btn_guardar = new Button();
            cmb_rol = new ComboBox();
            txt_contrasenia = new TextBox();
            txt_usuario = new TextBox();
            txt_salario = new TextBox();
            txt_nombre = new TextBox();
            txt_fechaContratacion = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(950, 555);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Eliminar);
            groupBox1.Controls.Add(btn_actualizar);
            groupBox1.Controls.Add(lbl_id);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btn_guardar);
            groupBox1.Controls.Add(cmb_rol);
            groupBox1.Controls.Add(txt_contrasenia);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Controls.Add(txt_salario);
            groupBox1.Controls.Add(txt_nombre);
            groupBox1.Controls.Add(txt_fechaContratacion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1019, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 722);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(145, 667);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(112, 34);
            btn_actualizar.TabIndex = 19;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click_1;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(410, 67);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(59, 25);
            lbl_id.TabIndex = 18;
            lbl_id.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(359, 67);
            label8.Name = "label8";
            label8.Size = new Size(34, 25);
            label8.TabIndex = 17;
            label8.Text = "ID:";
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(17, 667);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(112, 34);
            btn_guardar.TabIndex = 15;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cmb_rol
            // 
            cmb_rol.FormattingEnabled = true;
            cmb_rol.Location = new Point(248, 242);
            cmb_rol.Name = "cmb_rol";
            cmb_rol.Size = new Size(182, 33);
            cmb_rol.TabIndex = 14;
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.Location = new Point(248, 589);
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.Size = new Size(237, 31);
            txt_contrasenia.TabIndex = 13;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(248, 504);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(237, 31);
            txt_usuario.TabIndex = 12;
            // 
            // txt_salario
            // 
            txt_salario.Location = new Point(248, 416);
            txt_salario.Name = "txt_salario";
            txt_salario.Size = new Size(237, 31);
            txt_salario.TabIndex = 11;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(248, 160);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(237, 31);
            txt_nombre.TabIndex = 10;
            // 
            // txt_fechaContratacion
            // 
            txt_fechaContratacion.Location = new Point(248, 322);
            txt_fechaContratacion.Name = "txt_fechaContratacion";
            txt_fechaContratacion.Size = new Size(237, 31);
            txt_fechaContratacion.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 595);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 6;
            label7.Text = "Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 504);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 5;
            label6.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 422);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 4;
            label5.Text = "Salario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 298);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 328);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha de contratación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 250);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Cargo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 166);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(281, 667);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(112, 34);
            btn_Eliminar.TabIndex = 20;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // CRUD_Empleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 792);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "CRUD_Empleados";
            Text = "CRUD_Empleados";
            Load += CRUD_Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btn_guardar;
        private ComboBox cmb_rol;
        private TextBox txt_contrasenia;
        private TextBox txt_usuario;
        private TextBox txt_salario;
        private TextBox txt_nombre;
        private TextBox txt_fechaContratacion;
        private Label lbl_id;
        private Label label8;
        private Button btn_actualizar;
        private Button btn_Eliminar;
    }
}