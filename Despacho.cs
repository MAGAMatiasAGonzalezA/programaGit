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
    public partial class Despacho : Form
    {
        private ConexionBD conexion;
        public Despacho()
        {
            InitializeComponent();
            conexion = new ConexionBD();

            dgv_despacho.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_despacho.Font, FontStyle.Bold);
            CargarItems();
        }

        private void CargarItems()
        {
            //string consulta = "SELECT receta_nombre AS Receta, porciones AS Porciones, fecha AS Fecha FROM plaza";
            string consulta = "SELECT * FROM plaza";
            DataTable datos = conexion.ObtenerDatos(consulta);
            dgv_despacho.DataSource = datos;

            dgv_despacho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AgregarBotonesIndividuales();
        }

        private void AgregarBotonesIndividuales()
        {

            //verifico que no exista para no duplicar
            if (dgv_despacho.Columns["btn_usar"] == null)
            {
                //creo los botones y modifico algunas propiedades básicas
                DataGridViewButtonColumn btn_usar = new DataGridViewButtonColumn();
                btn_usar.Name = "btn_usar";
                btn_usar.HeaderText = "Usar";
                btn_usar.Text = "Despachar";
                btn_usar.UseColumnTextForButtonValue = true;
                btn_usar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //agrego el boton como nueva columna
                dgv_despacho.Columns.Add(btn_usar);
            }
            dgv_despacho.AllowUserToAddRows = false;
            dgv_despacho.CellClick += Dgv_despacho_CellClick;
        }

        private void Dgv_despacho_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string plaza_id = dgv_despacho.Rows[e.RowIndex].Cells["plaza_id"].Value.ToString();
                string porciones = dgv_despacho.Rows[e.RowIndex].Cells["porciones"].Value.ToString();
                if (e.RowIndex >= 0 && e.ColumnIndex == dgv_despacho.Columns["btn_usar"].Index)
                {
                    lbl_ver.Text = $"id => {plaza_id}, porciones => {porciones}";
                    string consulta = $"UPDATE plaza SET porciones = porciones - 1 WHERE plaza_id = '{plaza_id}';";
                    DataTable datos = conexion.ObtenerDatos(consulta);
                }
                CargarItems();
                //return;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                throw new NotImplementedException();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
