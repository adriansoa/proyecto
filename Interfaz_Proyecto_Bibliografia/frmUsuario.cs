using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace Interfaz_Proyecto_Bibliografia
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //ValidarUsuario();
            Usuario.CrearUsuario(txtUsuario.Text, txtPassword.Text);
            MessageBox.Show("Usuario creado exitosamente");
            

        }

        //private void ValidarUsuario()

        //{
        //    using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION)) //Crear un objeto SqlConnection
        //    {
        //        con.Open();
        //        string textoCmd = "select * from usuario where password = '" +  txtPassword.Text+"',usuario='"+txtUsuario.Text+"'";
                
        //        if(textoCmd==txtUsuario.Text){
        //            MessageBox.Show("Este usuario ya existe");

        //        }
        //        else
        //        {
        //            if (textoCmd == txtPassword.Text)
        //            {
        //                MessageBox.Show("Este password ya existe");
        //            }
                        
        //        }
        //    }

        //}

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsuario.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Favor Ingresa el Usuario");
                    return;
                }

                if (txtPassword.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Favor Ingresa la clave");
                    return;
                }
            }
        }
    }
}
