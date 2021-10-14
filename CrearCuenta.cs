﻿using System;
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
    public partial class CrearCuenta : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Verduleria.accdb";
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int count = 0;


                command.CommandText = "select * from Usuario where Usuario='" + txtUsuario.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    count += 1;
                }

                if (count == 1 || count > 1)
                {
                    MessageBox.Show("Ya existe una cuenta con los datos introducidos");
                    connection.Close();
                    return;

                }
                connection.Close();
                connection.Open();

                command.CommandText = "insert into Usuario (Usuario,Password,ComidaFavorita) " + " values ('" + txtUsuario.Text + "','" + txtPass.Text + "','" + 10 + "')";
                command.ExecuteNonQuery();

                connection.Close();



                MessageBox.Show("Se Creo La Cuenta");

                this.Hide();
                new MenuVerduleria().ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upa, algo salo mal... " + ex);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IniciarSesion().ShowDialog();
            this.Show();
        }
    }
}