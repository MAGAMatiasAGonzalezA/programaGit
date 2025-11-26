using Microsoft.Win32;
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
    public partial class Inventario : Form
    {
        private ConexionBD conexion;
        public Inventario()
        {
            InitializeComponent();
            conexion = new ConexionBD();

            dgw_inventario.ColumnHeadersDefaultCellStyle.Font = new Font(dgw_inventario.Font, FontStyle.Bold);
            dgw_inventario.AllowUserToAddRows = false;
            CargarItems();
        }

        private void CargarItems()
        {
            string consulta = "SELECT inventario_id AS Registro, item_nombre AS Item, cantidad AS Cantidad, usuario AS Usuario, fecha AS Fecha FROM inventario";
            DataTable datos = conexion.ObtenerDatos(consulta);
            dgw_inventario.DataSource = datos;

            dgw_inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgw_inventario.Columns["Registro"].Width = 70;
            dgw_inventario.Columns["Item"].Width = 150;
            dgw_inventario.Columns["Cantidad"].Width = 80;
            dgw_inventario.Columns["Usuario"].Width = 80;
            dgw_inventario.Columns["Fecha"].Width = 100;
            AgregarBotonesIndividuales();
        }

        private void AgregarBotonesIndividuales()
        {

            //verifico que no exista para no duplicar
            if (dgw_inventario.Columns["btn_ingreso"] == null)
            {
                //creo los botones y modifico algunas propiedades básicas
                DataGridViewButtonColumn btn_ingreso = new DataGridViewButtonColumn();
                btn_ingreso.Name = "btn_ingreso";
                btn_ingreso.HeaderText = "Ingreso";
                btn_ingreso.Text = "Alta";
                btn_ingreso.UseColumnTextForButtonValue = true;
                btn_ingreso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //agrego los botones como nuevas columnas
                dgw_inventario.Columns.Add(btn_ingreso);
            }

            if (dgw_inventario.Columns["btn_egreso"] == null)
            {
                DataGridViewButtonColumn btn_egreso = new DataGridViewButtonColumn();
                btn_egreso.Name = "btn_egreso";
                btn_egreso.HeaderText = "Egreso";
                btn_egreso.Text = "Baja";
                btn_egreso.UseColumnTextForButtonValue = true;
                btn_egreso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //agrego los botones como nuevas columnas
                dgw_inventario.Columns.Add(btn_egreso);
            }

            if (dgw_inventario.Columns["btn_eliminar"] == null)
            {
                DataGridViewButtonColumn btn_eliminar = new DataGridViewButtonColumn();
                btn_eliminar.Name = "btn_Eliminar";
                btn_eliminar.HeaderText = "Eliminar";
                btn_eliminar.Text = "Eliminar";
                btn_eliminar.UseColumnTextForButtonValue = true;
                btn_eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //agrego los botones como nuevas columnas
                dgw_inventario.Columns.Add(btn_eliminar);
            }
            //creo evento para manejar los clics
            dgw_inventario.CellClick += Dgw_inventario_CellClick;
        }

        private void Dgw_inventario_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;


                int registroId = Convert.ToInt32(dgw_inventario.Rows[e.RowIndex].Cells["Registro"].Value);
                string item = dgw_inventario.Rows[e.RowIndex].Cells["Item"].Value?.ToString() ?? "";
                double cantidad = Convert.ToDouble(dgw_inventario.Rows[e.RowIndex].Cells["Cantidad"].Value);
                string usuario = dgw_inventario.Rows[e.RowIndex].Cells["Usuario"].Value?.ToString() ?? "";
                string fecha = dgw_inventario.Rows[e.RowIndex].Cells["Fecha"].Value?.ToString() ?? "";


                if (e.ColumnIndex == dgw_inventario.Columns["btn_Eliminar"].Index)
                {
                    EliminarRegistro(registroId);
                    CargarItems();
                    return;
                }
                else if (e.ColumnIndex == dgw_inventario.Columns["btn_Ingreso"].Index)
                {
                    EditaInventario EditaForm = new EditaInventario(registroId, usuario, item, cantidad, fecha, "ingreso");
                    EditaForm.ShowDialog();
                    CargarItems();
                    return;
                }

                else if (e.ColumnIndex == dgw_inventario.Columns["btn_egreso"].Index)
                {
                    EditaInventario EditaForm = new EditaInventario(registroId, usuario, item, cantidad, fecha, "egreso");
                    EditaForm.ShowDialog();
                    CargarItems();
                    return;
                }
            }
            catch (Exception ex)
            {
                
                //MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            EditaInventario NuevoItem = new EditaInventario("nuevo");
            NuevoItem.ShowDialog();
            CargarItems();
        }

        private void EliminarRegistro(int registroId)
        {
            string consulta = $"CALL borrar_Item('{registroId}');";
            DataTable datos = conexion.ObtenerDatos(consulta);
            MessageBox.Show("Se elimino el item...");
        }
    }
}
