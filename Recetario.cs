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
    public partial class Recetario : Form
    {
        private ConexionBD conexion;
        private DataTable datos;
        private int registroActual = 0;
        public Recetario()
        {
            InitializeComponent();
            conexion = new ConexionBD();

            dgw_ingredientes.ColumnHeadersDefaultCellStyle.Font = new Font(dgw_ingredientes.Font, FontStyle.Bold);
        }

        private void CargarDatos()
        {
            string consulta = "SELECT * FROM recetas";
            datos = conexion.ObtenerDatos(consulta);
            if (datos.Rows.Count > 0)
            {
                registroActual = 0;
                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("No hay datos en la tabla");
            }
        }

        private void MostrarRegistroActual()
        {
            if (datos.Rows.Count == 0) return;

            DataRow fila = datos.Rows[registroActual];

            txt_receta_id.Text = fila["receta_id"].ToString();
            txt_receta_nombre.Text = fila["receta_nombre"].ToString();
            lbl_ingredientes_cant.Text = fila["ingredientes_cant"].ToString();
            ObtenerIngredientes();
            txt_procedimiento.Text = fila["procedimiento"].ToString();
            txt_usuario.Text = fila["usuario"].ToString();
            txt_porciones.Text = fila["porciones"].ToString();

            lbl_contador.Text = $"Registro {registroActual + 1} de {datos.Rows.Count}";

            btn_anterior.Enabled = (registroActual > 0);
            btn_siguiente.Enabled = (registroActual < datos.Rows.Count - 1);

            txt_receta_nombre.ReadOnly = true;
            txt_procedimiento.ReadOnly = true;
            txt_porciones.ReadOnly = true;
            btn_guardar.Visible = false;
            btn_cancelar.Visible = false;
            btn_modificar.Visible = true;
            btn_anterior.Visible = true;
            btn_siguiente.Visible = true;
            lbl_contador.Visible = true;
            comboBox1.Visible = false;
        }

        private void ObtenerIngredientes()
        {
            int id = Convert.ToInt32(txt_receta_id.Text.ToString());
            string consulta = $"SELECT item_nombre AS Item, cantidad AS Cantidad FROM ingredientesreceta WHERE receta_id = {id}";
            DataTable datos = conexion.ObtenerDatos(consulta);

            dgw_ingredientes.DataSource = null;
            dgw_ingredientes.Rows.Clear();
            dgw_ingredientes.Columns.Clear();

            dgw_ingredientes.DataSource = datos;
            dgw_ingredientes.AllowUserToAddRows = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recetario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            if (registroActual > 0)
            {
                registroActual--;
                MostrarRegistroActual();
            }
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            if (registroActual < datos.Rows.Count - 1)
            {
                registroActual++;
                MostrarRegistroActual();
            }
        }

        private void btn_receta_Click(object sender, EventArgs e)
        {
            //limpio DataGrid
            dgw_ingredientes.DataSource = null;
            dgw_ingredientes.Rows.Clear();

            //limpio DataGrid y le agrego 2 columnas
            dgw_ingredientes.Columns.Clear();
            dgw_ingredientes.Columns.Add("Item", "Item");
            dgw_ingredientes.Columns.Add("Cantidad", "Cantidad");
            dgw_ingredientes.AllowUserToAddRows = false;

            //limpio los campos
            txt_receta_id.Clear();
            txt_receta_nombre.Clear();
            txt_usuario.Clear();
            txt_procedimiento.Clear();
            txt_porciones.Clear();
            //lbl_ingredientes_cant.Text = "0";
            lbl_ingredientes_cant.Visible = false;

            label2.Visible = false;
            txt_receta_id.Visible = false;
            txt_receta_nombre.ReadOnly = false;
            txt_procedimiento.ReadOnly = false;
            txt_porciones.ReadOnly = false;
            //txt_ingrediente_cant.ReadOnly = false;
            //txt_ingrediente_cant.Visible = true;
            btn_guardar.Visible = true;
            btn_cancelar.Visible = true;
            btn_modificar.Visible = false;
            btn_receta.Visible = false;
            //btn_agregarIngredientes.Visible = true;
            btn_anterior.Visible = false;
            btn_siguiente.Visible = false;
            lbl_contador.Visible = false;

            DataTable ingredientes = conexion.Items();
            comboBox1.Items.Clear();

            //foreach (DataTable row in ingredientes.Rows)
            //{
            //    if (row.IsNewRow)
            //}
            //{
            //    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == comboBox1.SelectedItem.ToString());
            //    {
            //        return; // Ya existe, no lo agregues
            //    }
            //}

            //dgw_ingredientes.Rows.Add(comboBox1.SelectedItem);
            foreach (DataRow fila in ingredientes.Rows)
            {
                comboBox1.Items.Add(fila["Item"].ToString());
            }
            //comboBox1.DataSource = ingredientes;
            //comboBox1.DisplayMember = "Item";
            //comboBox1.ValueMember = "Item";
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = -1;

            //comboBox1.SelectedIndexChanged != -1
            //if (dgw_ingredientes.Rows[] == IsNewRow)
            //{
            //}
            //if(dgw_ingredientes.Rows.Add(comboBox1.SelectedItem.ToString()) == null)
            //{

            //}
            //dgw_ingredientes.Rows.Add(comboBox1.SelectedItem);

        }

        private void btn_agregarIngredientes_Click(object sender, EventArgs e)
        {
            dgw_ingredientes.Rows.Add("", "");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_receta_id.Text))
            {
                string nombreReceta = txt_receta_nombre.Text;
                string procedimiento = txt_procedimiento.Text;
                string usuario = txt_usuario.Text;
                int ingredientesCant = dgw_ingredientes.Rows.Count;
                int porciones = int.Parse(txt_porciones.Text);

                string consulta = $"INSERT INTO recetas (receta_nombre, ingredientes_cant, procedimiento, usuario, porciones) VALUES ('{nombreReceta}', '{ingredientesCant}', '{procedimiento}', '{usuario}', '{porciones}')";

                DataTable datos = conexion.ObtenerDatos(consulta);

                string consulta_id = $"SELECT receta_id FROM recetas WHERE receta_nombre = '{nombreReceta}'";
                DataTable dato_id = conexion.ObtenerDatos(consulta_id);

                //if(dato_id.Rows.Count > 0)
                //{
                int id_actual = Convert.ToInt32(dato_id.Rows[0]["receta_id"]);
                //}

                foreach (DataGridViewRow fila in dgw_ingredientes.Rows)
                {
                    // evita la fila vacía
                    if (fila.IsNewRow) continue;

                    string item = fila.Cells["Item"].Value.ToString();
                    double cantidad = Convert.ToDouble(fila.Cells["Cantidad"].Value.ToString());

                    string consultaIngredientes = $"INSERT INTO ingredientesreceta (receta_id, item_nombre, cantidad) VALUES ('{id_actual}', '{item}', '{cantidad}')";

                    conexion.ObtenerDatos(consultaIngredientes);
                }
                MessageBox.Show("Receta ingresada");
                CargarDatos();
                
            }
            else
            {
                int id = Convert.ToInt32(txt_receta_id.Text);
                string nombreReceta = txt_receta_nombre.Text;
                string procedimiento = txt_procedimiento.Text;
                string usuario = txt_usuario.Text;
                int ingredientesCant = dgw_ingredientes.Rows.Count;
                int porciones = int.Parse(txt_porciones.Text);

                string consulta = $"UPDATE recetas SET receta_nombre = '{nombreReceta}', ingredientes_cant = '{ingredientesCant}', procedimiento = '{procedimiento}', porciones = '{porciones}' WHERE receta_id = '{id}';";
                DataTable modificada = conexion.ObtenerDatos(consulta);
                MessageBox.Show("Modificado XD, sin ingredientes... AUCH");

                // ACA SEGUIR CON LA CONSULTA DE INGREDIENTES 

                foreach (DataGridViewRow fila in dgw_ingredientes.Rows)
                {
                    // evita la fila vacía
                    if (fila.IsNewRow) continue;

                    string item = fila.Cells["Item"].Value.ToString();
                    double cantidad = Convert.ToDouble(fila.Cells["Cantidad"].Value.ToString());

                    string consultaIngredientes = $"";

                }
                CargarDatos();
                
            }


               
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            // chequear existencia del ID


            int id = Convert.ToInt32(txt_receta_id.Text.ToString());
            string nombre = txt_receta_nombre.Text.ToString();
            string procedimiento = txt_procedimiento.Text.ToString();
            int porciones = Convert.ToInt32(txt_porciones.Text.ToString());
            int ingredientesCan = Convert.ToInt32(lbl_ingredientes_cant.Text.ToString());
            string usuario = txt_usuario.Text.ToString();

            txt_receta_nombre.ReadOnly = false;
            txt_procedimiento.ReadOnly = false;
            txt_porciones.ReadOnly = false;
            //dgw_ingredientes.AllowUserToAddRows = true;
            btn_anterior.Visible = false;
            btn_siguiente.Visible = false;
            lbl_contador.Visible = false;
            lbl_ingredientes_cant.Visible = false;
            btn_receta.Visible = false;
            btn_guardar.Visible = true;
            btn_modificar.Visible = false;
            btn_cancelar.Visible = true;
            comboBox1.Visible = true;

            DataTable ingredientes = conexion.Items();
            comboBox1.Items.Clear();
            foreach (DataRow fila in ingredientes.Rows)
            {
                comboBox1.Items.Add(fila["Item"].ToString());
            }
            comboBox1.SelectedIndex = -1;

            //recupero datos del datagrid
            List<Ingredientes> listaIngredientes = new List<Ingredientes>();

            foreach (DataGridViewRow fila in dgw_ingredientes.Rows)
            {
                // evita la fila vacía
                if (fila.IsNewRow) continue;

                Ingredientes ingrediente = new Ingredientes
                {
                    Item = fila.Cells["Item"].Value.ToString(),
                    Cantidad = Convert.ToDouble(fila.Cells["Cantidad"].Value.ToString())
                };
                listaIngredientes.Add(ingrediente);
            }
            //limpio DataGrid y le agrego 2 columnas
            dgw_ingredientes.DataSource = null;
            dgw_ingredientes.Rows.Clear();
            dgw_ingredientes.Columns.Clear();
            dgw_ingredientes.Columns.Add("Item", "Item");
            dgw_ingredientes.Columns.Add("Cantidad", "Cantidad");
            dgw_ingredientes.AllowUserToAddRows = false;

            foreach (var ing in listaIngredientes)
            {
                int nuevaFila = dgw_ingredientes.Rows.Add();
                dgw_ingredientes.Rows[nuevaFila].Cells["Item"].Value = ing.Item;
                dgw_ingredientes.Rows[nuevaFila].Cells["Cantidad"].Value = ing.Cantidad;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string itemSelecionado = comboBox1.SelectedItem.ToString();
            //string itemSelecionado = comboBox1.Text;

            bool esta = false;
            foreach (DataGridViewRow fila in dgw_ingredientes.Rows)
            {
                if (fila.Cells["Item"].Value != null && fila.Cells["Item"].Value.ToString() == itemSelecionado)
                {
                    esta = true;
                    break;
                }
            }
            if (!esta)
            {
                int nuevaFila = dgw_ingredientes.Rows.Add();
                dgw_ingredientes.Rows[nuevaFila].Cells["Item"].Value = itemSelecionado;
                dgw_ingredientes.Rows[nuevaFila].Cells["Cantidad"].Value = "";
            }
            else
            {
                MessageBox.Show("Ingrediente ya ingresado");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            txt_receta_nombre.ReadOnly = true;
            txt_procedimiento.ReadOnly = true;
            txt_porciones.ReadOnly = true;
            btn_guardar.Visible = false;
            btn_cancelar.Visible = false;
            btn_modificar.Visible = true;
            btn_receta.Visible = true;
            //btn_agregarIngredientes.Visible = false;
            btn_anterior.Visible = true;
            btn_siguiente.Visible = true;
            lbl_contador.Visible = true;
            comboBox1.Visible = false;
        }
    }
}
