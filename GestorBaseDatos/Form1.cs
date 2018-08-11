using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorBaseDatos
{
    public partial class Conexion : Form
    {
        public Conexion()
        {
            InitializeComponent();
        }

        public static bool Connect(String strUserName, String strPassword, String strPort, String strHostName, String dbName)
        {
            OdbcConnection con = null;
            try
            {
                String conString = "Driver={Adaptive Server Enterprise};server=" + strHostName + ";" + "port=" + strPort + ";db=" + dbName + ";uid=" + strUserName + ";pwd=" + strPassword + ";";
                con = new OdbcConnection(conString);
                con.Open();
                return true;
            }
            catch (Exception exp)
            {
                con = null;
                MessageBox.Show(exp.Message);
                return false;
            }

        }

        private void cmdAutenticar_Click(object sender, EventArgs e)
        {
            String userName = txtUsuario.Text;
            String PassWord = txtPass.Text;
            //String errorMsg;
            if (Connect(userName, PassWord, "5000", "sybase-PC", "master"))
            {
                MessageBox.Show("CONEXION ESTABLECIDA");
                Pantalla_Principal pantalla_Principal = new Pantalla_Principal();
                pantalla_Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR EN CONEXION");
                txtUsuario.Clear();
                txtPass.Clear();

            }
        }
    }
}
