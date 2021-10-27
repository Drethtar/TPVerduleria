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

            connection.Close();
            
        }


        private void btnCambiarVerdura_Click(object sender, EventArgs e)
        {

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            command.CommandText = "select * from Comida where Nombre='" + cbxVerduras.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();

            string IDVeruda = reader["ID"].ToString();

            connection.Close();
            connection.Open();

            command.CommandText = "update Usuario set ComidaFavorita='" + IDVeruda + "' where Usuario='" + IniciarSesion.ObtenerDatosUsuario.NombreDelUsuario + "'";
            command.ExecuteNonQuery();

            MessageBox.Show("Tu Comida Se Cambio!");

            connection.Close();
        }

        private void cbxColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxVerduras.Items.Clear();
            cbxVerduras.Text = "";

            if (cbxColores.Text == "Verde")
            {
                cbxVerduras.Items.Add("Pera");
                cbxVerduras.Items.Add("Palta");
                cbxVerduras.Items.Add("Lechuga");
            }
            else if (cbxColores.Text == "Rojo")
            {
                cbxVerduras.Items.Add("Tomate");
                cbxVerduras.Items.Add("Frutilla");
                cbxVerduras.Items.Add("Cerezas");
            }
            else if (cbxColores.Text == "Amarillo")
            {
                cbxVerduras.Items.Add("Limon");
                cbxVerduras.Items.Add("Banana");
                cbxVerduras.Items.Add("Melon");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IniciarSesion().ShowDialog();
            this.Show();
        }
    }
}
