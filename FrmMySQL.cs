using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConexionMySQL
{
    public partial class FrmMySQL : Form
    {
        public FrmMySQL()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                String sServidor = "localhost";
                String sUsuario = "root";
                String sPassword = "12345678";
                String sBaseDeDatos = "test";
                String sPuerto = "3306";

                String sCadenaConexion = String.Format("Server={0};Uid={1};Pwd={2};Database={3};Port={4};", sServidor, sUsuario, sPassword, sBaseDeDatos, sPuerto);

                MySqlConnection conexionMySQL = new MySqlConnection(sCadenaConexion);

                conexionMySQL.Open();

                conexionMySQL.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
