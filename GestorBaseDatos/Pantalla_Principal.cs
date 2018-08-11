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
    public partial class Pantalla_Principal : Form
    {
        public Pantalla_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            Titulo.ResetText();
        }

        private void crearTabla_Click(object sender, EventArgs e)
        {
            CrearTablas crear_tabla = new CrearTablas();
            crear_tabla.Show();
        }

        private void listarTabla_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            Titulo.Text = "TABLAS";
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            //con.GetSchema("Tables").AsEnumerable().Where(r => r.Field<string>("TABLE_TYPE") == "TABLE");
            //String sql = @"UPDATE people SET jobTitle=""Chef"" WHERE name=""Lister""";
            OdbcCommand selectTablas = new OdbcCommand(@"exec sp_tables '%', '%', 'master',""'TABLE'""")
            {
                Connection = con
            };
            try
            {
                OdbcDataReader lectura = selectTablas.ExecuteReader();
                while (lectura.Read())
                {
                    TreeNode node = new TreeNode(lectura["table_name"].ToString());
              
                    treeView1.Nodes.Add(node);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listarVista_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            Titulo.Text = "VISTAS";
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand selectVistas = new OdbcCommand(@"select * from sysobjects where type = 'V'")
            {
                Connection = con
            };
            try
            {
                OdbcDataReader lectura = selectVistas.ExecuteReader();
                while (lectura.Read())
                {
                    TreeNode node = new TreeNode(lectura["name"].ToString());
                    treeView1.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listarPA_Click(object sender, EventArgs e)
        {
            Titulo.Text = "PROCEDIMIENTOS ALMACENADOS";
            treeView1.Nodes.Clear();
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
               OdbcCommand selectPA = new OdbcCommand(@"exec sp_stored_procedures '%' ")
            {
                Connection = con
            };
            try
            {
                OdbcDataReader lectura = selectPA.ExecuteReader();
                while (lectura.Read())
                {
                    TreeNode node = new TreeNode(lectura["procedure_name"].ToString());
                    treeView1.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listarTrigger_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            Titulo.Text = "TRIGGERS";
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand selectTriggers = new OdbcCommand(@"select * from sysobjects where type = 'TR'")
            {
                Connection = con
            };
            try
            {
                OdbcDataReader lectura = selectTriggers.ExecuteReader();
                while (lectura.Read())
                {
                    TreeNode node = new TreeNode(lectura["name"].ToString());
                    treeView1.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listarBD_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            Titulo.Text = "BASE DE DATOS";
            //sp_helpdb
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand selectDB = new OdbcCommand(@"sp_helpdb")
            {
                Connection = con
            };
            try
            {
                OdbcDataReader lectura = selectDB.ExecuteReader();
                while (lectura.Read())
                {
                    TreeNode node = new TreeNode(lectura["name"].ToString());
                    treeView1.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listarUsuario_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            Titulo.Text = "USUARIOS";
            //select name from dbo.sysusers where uid < 16384 order by name
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand selectUsuarios = new OdbcCommand(@"select name from dbo.sysusers where uid < 16384 order by name")
            {
                Connection = con
            };
            try
            {
                OdbcDataReader lectura = selectUsuarios.ExecuteReader();
                while (lectura.Read())
                {
                    TreeNode node = new TreeNode(lectura["name"].ToString());
                    treeView1.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void crearBD_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabBaseDatos);
            labeBD.Visible = true;
            labelNameBD.Visible = true;
            txtDBName.Visible = true;
            labelTamBD.Visible = true;
            txtDBSize.Visible = true;
            cmdCrearBD.Visible = true;
            
        }

        private void cmdCrearBD_Click(object sender, EventArgs e)
        {
            String nombreBD = txtDBName.Text;
            int size = int.Parse(txtDBSize.Text);

            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand crearBD = new OdbcCommand(@"create database " + nombreBD +
                                                    " on default = " + size)
            {
                Connection = con
            };

            try
            {
                OdbcDataReader lectura = crearBD.ExecuteReader();
                lectura.Read();
                MessageBox.Show("BASE DE DATOS CREADA EXITOSAMENTE");
                txtDBName.Text = "";
                txtDBSize.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void borrarBD_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabBaseDatos);
            labelBorrarBD.Visible = true;
            labelNombreBorrarBD.Visible = true;
            txtNomBorrarBD.Visible = true;
            cmdBorrarBd.Visible = true;
            
        }

        private void cmdSalirCreadorBD_Click(object sender, EventArgs e)
        {
            labeBD.Visible = false;
            labelNameBD.Visible = false;
            txtDBName.Visible = false;
            labelTamBD.Visible = false;
            txtDBSize.Visible = false;
            cmdCrearBD.Visible = false;
            
        }

        private void cmdSalirBorradoBD_Click(object sender, EventArgs e)
        {
            labelBorrarBD.Visible = false;
            labelNombreBorrarBD.Visible = false;
            txtNomBorrarBD.Visible = false;
            cmdBorrarBd.Visible = false;
            
        }

        private void cmdBorrarBd_Click(object sender, EventArgs e)
        {
            String borrarBD = txtNomBorrarBD.Text;
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand borraBD = new OdbcCommand(@"drop database " + borrarBD)
            {
                Connection = con
            };

            try
            {
                OdbcDataReader lectura = borraBD.ExecuteReader();
                lectura.Read();
                MessageBox.Show("BASE DE DATOS ELIMINADA");
                txtNomBorrarBD.Text = "";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificarBD_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabBaseDatos);
            labelModBD.Visible = true;
            labelNewNameBD.Visible = true;
            txtNewNameBD.Visible = true;
            labelNewTamBD.Visible = true;
            txtNewTaBD.Visible = true;
            cmdModificarBD.Visible = true;
            
        }

        private void crearUsuario_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(TabUsuarios);
        }

        private void modificarUsuario_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(TabUsuarios);
        }

        private void borrarUsuario_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(TabUsuarios);
        }

        private void cmdCreateUser_Click(object sender, EventArgs e)
        {
            String newUser = txtNewUser.Text;
            String newPass = txtNewPasUser.Text;
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand creacionPerfil = new OdbcCommand(@"create login "+newUser+" with password "+newPass) //CREACION DE PERFIL DE USUARIO
            {
                Connection = con
            };

            OdbcCommand addaBD = new OdbcCommand(@"sp_adduser "+newUser) //AGREGAR USUARIO A TABLA DE USUARIOS
            {
                Connection = con
            };

            OdbcCommand permiso = new OdbcCommand(@"grant all to "+newUser) //DAR FULL PERMISOS AL USUARIO
            {
                Connection = con
            };

            try
            {
                OdbcDataReader lectura = creacionPerfil.ExecuteReader();
                OdbcDataReader lectura1 = addaBD.ExecuteReader();
                OdbcDataReader lectura2 = permiso.ExecuteReader();
                lectura.Read();
                lectura1.Read();
                lectura2.Read();
                MessageBox.Show("USUARIO CREADO EXITOSAMENTE");
                txtNomBorrarBD.Text = "";
                txtNewPasUser.Text = "";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdBorrarUser_Click(object sender, EventArgs e)
        {
            String userDel = txtUserDel.Text;          
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand delete1 = new OdbcCommand(@"sp_droplogin " + userDel) //BORRAR USUARIO
            {
                Connection = con
            };
            OdbcCommand delete = new OdbcCommand(@"sp_dropuser "+userDel) //BORRAR USUARIO
            {
                Connection = con
            };

            try
            {
                OdbcDataReader lectura = delete.ExecuteReader();
                lectura.Read();

                MessageBox.Show("USUARIO ELIMINADO");
                txtUserDel.Text = "";      

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdActualizarUser_Click_1(object sender, EventArgs e)
        {
            String userMod = txtUserMod.Text;
            String oldPass = txtOldPassUser.Text;
            String newPass = txtNewPassUser.Text;

            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            OdbcCommand modificarUser = new OdbcCommand(@"alter user "+userMod+
                                                          " set password "+newPass +
                                                            " verify password"+oldPass) //MODIFICAR USUARIO
            {
                Connection = con
            };

            try
            {
                OdbcDataReader lectura = modificarUser.ExecuteReader();
                lectura.Read();

                MessageBox.Show("USUARIO MODIFICADO");
                txtUserDel.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        OdbcDataAdapter adapter;
        DataSet ds;

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            String NombreTabla = txtTableName.Text;
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
                /*
                DataTable tabla = new DataTable();
                OdbcDataAdapter pasoInfo = new OdbcDataAdapter(pasarInfoaGrid);
                pasoInfo.Fill(tabla);
                dgv1.DataSource = tabla;
                */
                adapter = new OdbcDataAdapter("SELECT * FROM " + NombreTabla, con);
                ds = new System.Data.DataSet();
                adapter.Fill(ds, NombreTabla);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void borrarTabla_Click(object sender, EventArgs e)
        {
            BorrarTabla borrar_tabla = new BorrarTabla();
            borrar_tabla.Show();
        }

        private void cmdCommit_Click(object sender, EventArgs e)
        {
            OdbcCommandBuilder cmbuild;
            String NombreTabla = txtTableName.Text;
            OdbcConnection con = new OdbcConnection("Driver={Adaptive Server Enterprise};server=" + "sybase-PC" + ";" + "port=" + "5000" + ";db=" + "master" + ";uid=" + "sa" + ";pwd=" + "root10" + ";");

            try
            {
                con.Open();
                cmbuild = new OdbcCommandBuilder(adapter);
                adapter.Update(ds, NombreTabla);
                MessageBox.Show("Informacion Actualizada", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }
    }
}
