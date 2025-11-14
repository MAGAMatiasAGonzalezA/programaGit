namespace AyudaLogica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.ShowDialog();
        }

        private void btn_recetas_Click(object sender, EventArgs e)
        {
            Recetario recetario = new Recetario();
            recetario.ShowDialog();
        }

        private void btn_plaza_Click(object sender, EventArgs e)
        {
            Plaza plaza = new Plaza();
            plaza.ShowDialog();
        }

        private void btn_despacho_Click(object sender, EventArgs e)
        {
            Despacho despacho = new Despacho();
            despacho.ShowDialog();
        }
    }
}
