using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AyudaLogica
{

    public partial class EditaInventario : Form
    {
        private ConexionBD conexion;
        private string accion;

        public EditaInventario(string operacion)//string usuario,
        {
            InitializeComponent();
            conexion = new ConexionBD();
            txt_registro.Visible = false;
            txt_cantidad.Visible = false;
            txt_fecha.Visible = false;
            txt_usuario.Visible = false;
            //txt_usuario.Text = usuario;
            accion = operacion;
        }
        public EditaInventario(int registro, string usuario, string item, double cant, string fecha,string operacion)
        {
            InitializeComponent();
            conexion = new ConexionBD();
            txt_registro.Text = registro.ToString();
            txt_registro.ReadOnly = true;
            txt_usuario.Text = usuario.ToString();
            txt_usuario.ReadOnly = true;
            txt_item.Text = item.ToString();
            txt_item.ReadOnly = true;
            txt_cantidad.Text = cant.ToString();
            txt_cantidad.ReadOnly = true;
            txt_fecha.Text = fecha.ToString();
            txt_fecha.ReadOnly = true;
            accion = operacion;
        }

        private void IngresoRegistro(int registroId, double cantidad, double nuevaCant)
        {
            try
            {
                    string consulta = $"UPDATE inventario SET cantidad = cantidad + {nuevaCant} WHERE inventario_id = {registroId};";
                    DataTable datos = conexion.ObtenerDatos(consulta);
                    MessageBox.Show("Modificación exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EgresoRegistro(int registroId, double cantidad, double nuevaCant)
        {
            try
            {
                string consulta = $"UPDATE inventario SET cantidad = cantidad - {nuevaCant} WHERE inventario_id = {registroId};";
                DataTable datos = conexion.ObtenerDatos(consulta);
                MessageBox.Show("Modificación exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NuevoIngreso(double cantidad,string item)//string usuario, 
        {
            
            try
            {
                string usuario = "Mafiu";
                string consulta = $"CALL insert_item('{usuario}', '{item}', '{cantidad}');";
                DataTable datos = conexion.ObtenerDatos(consulta);
                MessageBox.Show("Ingreso exitoso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(accion == "ingreso")
            {
                double ingreso = Convert.ToDouble(txt_nuevaCant.Text);
                int registro = Convert.ToInt32(txt_registro.Text);
                double cantidad = Convert.ToDouble(txt_cantidad.Text);

                IngresoRegistro(registro, cantidad, ingreso);
                this.Close();
            }
            if(accion == "egreso")
            {
                double ingreso = Convert.ToDouble(txt_nuevaCant.Text);
                int registro = Convert.ToInt32(txt_registro.Text);
                double cantidad = Convert.ToDouble(txt_cantidad.Text);

                EgresoRegistro(registro, cantidad, ingreso);
                this.Close();
            }
            if(accion == "nuevo")
            {
                double ingreso = Convert.ToDouble(txt_nuevaCant.Text);
                string item = txt_item.Text.ToString();
                //string usuario = txt_usuario.Text.ToString();

                NuevoIngreso(ingreso, item );
                this.Close();
            }
        }
    }
}
