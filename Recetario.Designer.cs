namespace AyudaLogica
{
    partial class Recetario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbl_contador = new Label();
            btn_salir = new Button();
            btn_anterior = new Button();
            btn_siguiente = new Button();
            txt_receta_id = new TextBox();
            txt_receta_nombre = new TextBox();
            txt_porciones = new TextBox();
            txt_usuario = new TextBox();
            dgw_ingredientes = new DataGridView();
            txt_procedimiento = new TextBox();
            lbl_ingredientes_cant = new Label();
            btn_receta = new Button();
            btn_modificar = new Button();
            btn_agregarIngredientes = new Button();
            txt_ingrediente_cant = new TextBox();
            btn_guardar = new Button();
            comboBox1 = new ComboBox();
            btn_cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw_ingredientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(329, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 50);
            label1.TabIndex = 0;
            label1.Text = "Recetario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 89);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Registro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 118);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Receta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 139);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Ingredientes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 273);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Procedimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 345);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 5;
            label6.Text = "Porciones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 374);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 6;
            label7.Text = "Usuario";
            // 
            // lbl_contador
            // 
            lbl_contador.AutoSize = true;
            lbl_contador.Location = new Point(362, 426);
            lbl_contador.Name = "lbl_contador";
            lbl_contador.Size = new Size(38, 15);
            lbl_contador.TabIndex = 7;
            lbl_contador.Text = "label8";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(713, 9);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 8;
            btn_salir.Text = "Cerrar";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_anterior
            // 
            btn_anterior.Location = new Point(293, 396);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(75, 23);
            btn_anterior.TabIndex = 9;
            btn_anterior.Text = "<<";
            btn_anterior.UseVisualStyleBackColor = true;
            btn_anterior.Click += btn_anterior_Click_1;
            // 
            // btn_siguiente
            // 
            btn_siguiente.Location = new Point(446, 396);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(75, 23);
            btn_siguiente.TabIndex = 10;
            btn_siguiente.Text = ">>";
            btn_siguiente.UseVisualStyleBackColor = true;
            btn_siguiente.Click += btn_siguiente_Click_1;
            // 
            // txt_receta_id
            // 
            txt_receta_id.Location = new Point(227, 81);
            txt_receta_id.Name = "txt_receta_id";
            txt_receta_id.Size = new Size(100, 23);
            txt_receta_id.TabIndex = 11;
            // 
            // txt_receta_nombre
            // 
            txt_receta_nombre.Location = new Point(227, 110);
            txt_receta_nombre.Name = "txt_receta_nombre";
            txt_receta_nombre.Size = new Size(173, 23);
            txt_receta_nombre.TabIndex = 12;
            // 
            // txt_porciones
            // 
            txt_porciones.Location = new Point(227, 337);
            txt_porciones.Name = "txt_porciones";
            txt_porciones.Size = new Size(100, 23);
            txt_porciones.TabIndex = 13;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(227, 366);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 14;
            // 
            // dgw_ingredientes
            // 
            dgw_ingredientes.BackgroundColor = SystemColors.Window;
            dgw_ingredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_ingredientes.Location = new Point(227, 139);
            dgw_ingredientes.Name = "dgw_ingredientes";
            dgw_ingredientes.Size = new Size(344, 113);
            dgw_ingredientes.TabIndex = 15;
            // 
            // txt_procedimiento
            // 
            txt_procedimiento.Location = new Point(227, 265);
            txt_procedimiento.Multiline = true;
            txt_procedimiento.Name = "txt_procedimiento";
            txt_procedimiento.Size = new Size(344, 66);
            txt_procedimiento.TabIndex = 16;
            // 
            // lbl_ingredientes_cant
            // 
            lbl_ingredientes_cant.AutoSize = true;
            lbl_ingredientes_cant.Location = new Point(162, 139);
            lbl_ingredientes_cant.Name = "lbl_ingredientes_cant";
            lbl_ingredientes_cant.Size = new Size(38, 15);
            lbl_ingredientes_cant.TabIndex = 17;
            lbl_ingredientes_cant.Text = "label8";
            // 
            // btn_receta
            // 
            btn_receta.Location = new Point(74, 12);
            btn_receta.Name = "btn_receta";
            btn_receta.Size = new Size(85, 23);
            btn_receta.TabIndex = 18;
            btn_receta.Text = "Nueva receta";
            btn_receta.UseVisualStyleBackColor = true;
            btn_receta.Click += btn_receta_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(611, 336);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 19;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_agregarIngredientes
            // 
            btn_agregarIngredientes.Location = new Point(611, 139);
            btn_agregarIngredientes.Name = "btn_agregarIngredientes";
            btn_agregarIngredientes.Size = new Size(132, 23);
            btn_agregarIngredientes.TabIndex = 20;
            btn_agregarIngredientes.Text = "Agregar Ingredientes";
            btn_agregarIngredientes.UseVisualStyleBackColor = true;
            btn_agregarIngredientes.Visible = false;
            btn_agregarIngredientes.Click += btn_agregarIngredientes_Click;
            // 
            // txt_ingrediente_cant
            // 
            txt_ingrediente_cant.Location = new Point(191, 131);
            txt_ingrediente_cant.Name = "txt_ingrediente_cant";
            txt_ingrediente_cant.Size = new Size(30, 23);
            txt_ingrediente_cant.TabIndex = 21;
            txt_ingrediente_cant.Visible = false;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(611, 367);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 22;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Visible = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(613, 173);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 23;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(692, 366);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 24;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Visible = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // Recetario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancelar);
            Controls.Add(comboBox1);
            Controls.Add(btn_guardar);
            Controls.Add(txt_ingrediente_cant);
            Controls.Add(btn_agregarIngredientes);
            Controls.Add(btn_modificar);
            Controls.Add(btn_receta);
            Controls.Add(lbl_ingredientes_cant);
            Controls.Add(txt_procedimiento);
            Controls.Add(dgw_ingredientes);
            Controls.Add(txt_usuario);
            Controls.Add(txt_porciones);
            Controls.Add(txt_receta_nombre);
            Controls.Add(txt_receta_id);
            Controls.Add(btn_siguiente);
            Controls.Add(btn_anterior);
            Controls.Add(btn_salir);
            Controls.Add(lbl_contador);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Recetario";
            Text = "Recetario";
            Load += Recetario_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_ingredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbl_contador;
        private Button btn_salir;
        private Button btn_anterior;
        private Button btn_siguiente;
        private TextBox txt_receta_id;
        private TextBox txt_receta_nombre;
        private TextBox txt_porciones;
        private TextBox txt_usuario;
        private DataGridView dgw_ingredientes;
        private TextBox txt_procedimiento;
        private Label lbl_ingredientes_cant;
        private Button btn_receta;
        private Button btn_modificar;
        private Button btn_agregarIngredientes;
        private TextBox txt_ingrediente_cant;
        private Button btn_guardar;
        private ComboBox comboBox1;
        private Button btn_cancelar;
    }
}