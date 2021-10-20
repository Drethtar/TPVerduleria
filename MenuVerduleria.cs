using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TPVerduleria
{
    public partial class MenuVerduleria : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public MenuVerduleria()
        {
            InitializeComponent();
        }

        private void MenuVerduleria_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Verduleria.accdb";

            lbNombreUsuario.Text = "Bienvenido " + IniciarSesion.ObtenerDatosUsuario.NombreDelUsuario;

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            command.CommandText = "SELECT * FROM Comida WHERE ID=" + IniciarSesion.ObtenerDatosUsuario.IDComidaFavorita + "";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            string ComidaFav = reader["Nombre"].ToString();

            lbVerduraFavorita.Text = "Comida Favorita: " + ComidaFav;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IniciarSesion().ShowDialog();
            this.Show();
        }

        private void btnCambiarVerdura_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CambioDeVerdura().ShowDialog();
            this.Show();
        }
    }
}
