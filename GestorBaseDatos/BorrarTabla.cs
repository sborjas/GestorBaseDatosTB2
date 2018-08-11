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
    public partial class BorrarTabla : Form
    {
        public BorrarTabla()
        {
            InitializeComponent();
        }

        private void cmdDelTable_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Esta seguro que desea eliminar la tabla?",
            "Mensaje de Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String tablaDel = txtNameTabDel.Text;

                OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

                try
                {
                    con.Open();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                OdbcCommand eliminarTabla = new OdbcCommand(@"drop table "+tablaDel) //ELIMINAR TABLA
                {
                    Connection = con
                };

                try
                {
                    OdbcDataReader lectura = eliminarTabla.ExecuteReader();
                    lectura.Read();

                    MessageBox.Show("TABLA ELIMINADA EXISTOSAMENTE");
                    txtNameTabDel.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
