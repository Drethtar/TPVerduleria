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
    public partial class CambioDeVerdura : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public CambioDeVerdura()
        {
            InitializeComponent();
        }

        private void CambioDeVerdura_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Verduleria.accdb";


        }

        private void btnCambiarComida_Click(object sender, EventArgs e)
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

            this.Hide();
            new IniciarSesion().ShowDialog();
            this.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuVerduleria().ShowDialog();
            this.Show();
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
    }
}
