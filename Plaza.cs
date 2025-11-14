using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyudaLogica
{
    public partial class Plaza : Form
    {
        private ConexionBD conexion;
        private DataTable datos;
        private DataGridView grid;
        public Plaza()
        {
            InitializeComponent();
            conexion = new ConexionBD();

            CrearDataGridViewPlaza();
            CargarDatosEnGrids();
        }

        private void CrearDataGridViewPlaza()
        {
            //grids = new DataGridView[0];
            int panelWidth = this.ClientSize.Width;
            int panelHeight = this.ClientSize.Height;

            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false
            };

            var panel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new System.Drawing.Size(700, 400),// Ancho x Alto que desees
                Location = new System.Drawing.Point(50, 35),// X, Y desde la esquina superior izquierda
                //Dock = DockStyle.Fill,
            };

            var label = new Label
            {
                Text = "Estado de Plaza",
                Height = 30,
                Dock = DockStyle.Top,
                BackColor = System.Drawing.Color.AliceBlue,
                ForeColor = System.Drawing.Color.Brown,
                Padding = new Padding(5, 5, 5, 5),
                TextAlign = ContentAlignment.MiddleLeft
            };

            panel.Controls.Add(dgv);
            panel.Controls.Add(label);

            this.Controls.Add(panel);

            grid = dgv;
        }

        private void CargarDatosEnGrids()
        {
            string consulta = "SELECT * FROM plaza";
            datos = conexion.ObtenerDatos(consulta);

            //adapter.Fill(datos);
            grid.DataSource = datos;

        }

        private void Plaza_Load(object sender, EventArgs e)
        {
            //CrearDataGridViewPlaza();
            //CargarDatosEnGrids();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
