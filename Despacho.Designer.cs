namespace AyudaLogica
{
    partial class Despacho
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
            pb_despacho = new PictureBox();
            dgv_despacho = new DataGridView();
            btn_salir = new Button();
            label1 = new Label();
            lbl_ver = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_despacho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_despacho).BeginInit();
            SuspendLayout();
            // 
            // pb_despacho
            // 
            pb_despacho.Location = new Point(505, 70);
            pb_despacho.Name = "pb_despacho";
            pb_despacho.Size = new Size(223, 218);
            pb_despacho.SizeMode = PictureBoxSizeMode.Zoom;
            pb_despacho.TabIndex = 0;
            pb_despacho.TabStop = false;
            // 
            // dgv_despacho
            // 
            dgv_despacho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_despacho.Location = new Point(50, 70);
            dgv_despacho.Name = "dgv_despacho";
            dgv_despacho.Size = new Size(402, 341);
            dgv_despacho.TabIndex = 1;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(713, 12);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(317, 12);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 3;
            label1.Text = "Despacho";
            // 
            // lbl_ver
            // 
            lbl_ver.AutoSize = true;
            lbl_ver.Location = new Point(505, 369);
            lbl_ver.Name = "lbl_ver";
            lbl_ver.Size = new Size(38, 15);
            lbl_ver.TabIndex = 4;
            lbl_ver.Text = "label2";
            // 
            // Despacho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_ver);
            Controls.Add(label1);
            Controls.Add(btn_salir);
            Controls.Add(dgv_despacho);
            Controls.Add(pb_despacho);
            Name = "Despacho";
            Text = "Despacho";
            ((System.ComponentModel.ISupportInitialize)pb_despacho).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_despacho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_despacho;
        private DataGridView dgv_despacho;
        private Button btn_salir;
        private Label label1;
        private Label lbl_ver;
    }
}