namespace AyudaLogica
{
    partial class Inventario
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
            components = new System.ComponentModel.Container();
            dgw_inventario = new DataGridView();
            label1 = new Label();
            btn_salir = new Button();
            conexionBDBindingSource = new BindingSource(components);
            btn_ingresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw_inventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBDBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgw_inventario
            // 
            dgw_inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_inventario.Location = new Point(51, 52);
            dgw_inventario.Name = "dgw_inventario";
            dgw_inventario.Size = new Size(707, 326);
            dgw_inventario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 40);
            label1.TabIndex = 1;
            label1.Text = "Stock Inventario";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(713, 9);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // conexionBDBindingSource
            // 
            conexionBDBindingSource.DataSource = typeof(ConexionBD);
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(51, 12);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(117, 23);
            btn_ingresar.TabIndex = 3;
            btn_ingresar.Text = "Nuevo Ingreso";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ingresar);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(dgw_inventario);
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dgw_inventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBDBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw_inventario;
        private Label label1;
        private Button btn_salir;
        private BindingSource conexionBDBindingSource;
        private Button btn_ingresar;
    }
}