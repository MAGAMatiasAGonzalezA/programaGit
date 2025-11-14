namespace AyudaLogica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_inventario = new Button();
            btn_plaza = new Button();
            btn_recetas = new Button();
            btn_despacho = new Button();
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
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(278, 12);
            label1.Name = "label1";
            label1.Size = new Size(257, 50);
            label1.TabIndex = 1;
            label1.Text = "Estado Cocina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 100);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Inventario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 154);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Recetas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 208);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Plaza";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 259);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 5;
            label5.Text = "Despacho";
            // 
            // btn_inventario
            // 
            btn_inventario.Location = new Point(221, 92);
            btn_inventario.Name = "btn_inventario";
            btn_inventario.Size = new Size(75, 23);
            btn_inventario.TabIndex = 6;
            btn_inventario.Text = "Ver";
            btn_inventario.UseVisualStyleBackColor = true;
            btn_inventario.Click += btn_inventario_Click;
            // 
            // btn_plaza
            // 
            btn_plaza.Location = new Point(221, 200);
            btn_plaza.Name = "btn_plaza";
            btn_plaza.Size = new Size(75, 23);
            btn_plaza.TabIndex = 7;
            btn_plaza.Text = "Ver";
            btn_plaza.UseVisualStyleBackColor = true;
            btn_plaza.Click += btn_plaza_Click;
            // 
            // btn_recetas
            // 
            btn_recetas.Location = new Point(221, 146);
            btn_recetas.Name = "btn_recetas";
            btn_recetas.Size = new Size(75, 23);
            btn_recetas.TabIndex = 8;
            btn_recetas.Text = "Ver";
            btn_recetas.UseVisualStyleBackColor = true;
            btn_recetas.Click += btn_recetas_Click;
            // 
            // btn_despacho
            // 
            btn_despacho.Location = new Point(221, 251);
            btn_despacho.Name = "btn_despacho";
            btn_despacho.Size = new Size(75, 23);
            btn_despacho.TabIndex = 9;
            btn_despacho.Text = "Ver";
            btn_despacho.UseVisualStyleBackColor = true;
            btn_despacho.Click += btn_despacho_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_despacho);
            Controls.Add(btn_recetas);
            Controls.Add(btn_plaza);
            Controls.Add(btn_inventario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_salir);
            Name = "Form1";
            Text = "Form1";
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
        private Button btn_inventario;
        private Button btn_plaza;
        private Button btn_recetas;
        private Button btn_despacho;
    }
}
