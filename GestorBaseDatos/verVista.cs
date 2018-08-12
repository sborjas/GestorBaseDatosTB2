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
    public partial class verVista : Form
    {
        public verVista()
        {
            InitializeComponent();
        }

        private void cmdVisualizarVista_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter adapter;
            DataSet ds;
            String NombreVista = txtNombreVistaShow.Text;
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            try
            {               
                adapter = new OdbcDataAdapter("SELECT * FROM " + NombreVista, con);
                ds = new System.Data.DataSet();
                adapter.Fill(ds, NombreVista);
                dataVista.DataSource = ds.Tables[0];
                txtNombreVistaShow.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
