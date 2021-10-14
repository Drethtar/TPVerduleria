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
    public partial class IniciarSesion : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Verduleria.accdb";
        }

        private void lbIrACrear_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CrearCuenta().ShowDialog();
            this.Show();
        }
    }
}
