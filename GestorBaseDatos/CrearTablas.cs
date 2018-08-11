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
    public partial class CrearTablas : Form
    {
        public CrearTablas()
        {
            InitializeComponent();
        }

        private void cmdCrearTabla_Click(object sender, EventArgs e)
        {
            String NombreTabla = txtNameTable.Text;
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand crearTabla = new OdbcCommand(@"CREATE TABLE "+NombreTabla +
                                                        "( "+txtCamp1.Text +" int NOT NULL, "
                                                        +txtCamp2.Text+" varchar(20) NOT NULL, "
                                                        +txtCamp3.Text+ " varchar(20) NOT NULL, "
                                                        +txtCamp4.Text+ " varchar(20) NOT NULL, PRIMARY KEY NONCLUSTERED ("
                                                        +txtCamp1.Text+"))")                                                        
            {
                Connection = con
            };

            try
            {
                OdbcDataReader lectura = crearTabla.ExecuteReader();
                lectura.Read();

                MessageBox.Show("TABLA CREADA EXITOSAMENTE");
                txtNameTable.Text = "";
                txtCamp1.Text = "";
                txtCamp2.Text = "";
                txtCamp3.Text = "";
                txtCamp4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
