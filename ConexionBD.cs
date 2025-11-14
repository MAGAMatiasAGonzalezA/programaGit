using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AyudaLogica
{
    public class ConexionBD
    {
        private string conexion = "Server=localhost;Database=usuarioscocina;Uid=root;Pwd=;";

        public DataTable ObtenerDatos(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conectar = new MySqlConnection(conexion))
                {
                    conectar.Open();
                    using (MySqlCommand comando = new MySqlCommand(consultaSQL, conectar))
                    {
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}");
            }
            return tabla;
        }

        public DataTable Items()
        {
            string consulta = $"SELECT item_nombre AS Item FROM inventario";
            DataTable inventario = this.ObtenerDatos(consulta);
            return inventario;
        } 
    }
}
