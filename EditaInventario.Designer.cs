namespace AyudaLogica
{
    partial class EditaInventario
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
            btn_salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_registro = new TextBox();
            txt_usuario = new TextBox();
            txt_item = new TextBox();
            txt_cantidad = new TextBox();
            txt_fecha = new TextBox();
            btn_guardar = new Button();
            txt_nuevaCant = new TextBox();
            SuspendLayout();
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(713, 12);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 0;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(278, 14);
            label1.Name = "label1";
            label1.Size = new Size(297, 47);
            label1.TabIndex = 1;
            label1.Text = "Ingreso-Exgreso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 104);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Registro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 146);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 183);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Item";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 229);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 5;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 267);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 6;
            label6.Text = "Fecha";
            // 
            // txt_registro
            // 
            txt_registro.Location = new Point(241, 96);
            txt_registro.Name = "txt_registro";
            txt_registro.Size = new Size(100, 23);
            txt_registro.TabIndex = 7;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(241, 138);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 8;
            // 
            // txt_item
            // 
            txt_item.Location = new Point(241, 183);
            txt_item.Name = "txt_item";
            txt_item.Size = new Size(100, 23);
            txt_item.TabIndex = 9;
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(241, 221);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(53, 23);
            txt_cantidad.TabIndex = 10;
            // 
            // txt_fecha
            // 
            txt_fecha.Location = new Point(241, 259);
            txt_fecha.Name = "txt_fecha";
            txt_fecha.Size = new Size(100, 23);
            txt_fecha.TabIndex = 11;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(266, 323);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 12;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_nuevaCant
            // 
            txt_nuevaCant.Location = new Point(293, 221);
            txt_nuevaCant.Name = "txt_nuevaCant";
            txt_nuevaCant.Size = new Size(48, 23);
            txt_nuevaCant.TabIndex = 13;
            // 
            // EditaInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_nuevaCant);
            Controls.Add(btn_guardar);
            Controls.Add(txt_fecha);
            Controls.Add(txt_cantidad);
            Controls.Add(txt_item);
            Controls.Add(txt_usuario);
            Controls.Add(txt_registro);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_salir);
            Name = "EditaInventario";
            Text = "EditaInventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_registro;
        private TextBox txt_usuario;
        private TextBox txt_item;
        private TextBox txt_cantidad;
        private TextBox txt_fecha;
        private Button btn_guardar;
        private TextBox txt_nuevaCant;
    }
}