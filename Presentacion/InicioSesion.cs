using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;//////ATENCION LIBRERIA MYSQL
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        { /*
             string codigo = "Select * from Usuarios where Usuario='"+txt_usuario.Text+"'and Contraseña='"+txt_contraseña.Text+"'";
             MySqlConnection cnn = new MySqlConnection();
            cnn.ConnectionString = Datos.Conexion.strCONEXION;
                         MySqlCommand mc = new MySqlCommand(codigo,cnn);

             cnn.Open();
             mc.ExecuteNonQuery();
             MySqlDataReader leer = mc.ExecuteReader();


             if (leer.Read())
             {
                 MessageBox.Show("BIENVENIDO");
                 this.Hide();            //oculto el form de elecciones
                 Menu menus = new Menu();
                 menus.Show();    // muestro from de aperturas
             }
             else
             {
                 MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO");
             }

             cnn.Close();
            */
            this.Hide();            //oculto el form de elecciones
            Menu menus = new Menu();
            menus.Show();    // muestro from de aperturas     
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Bienvenido bienvenido = new Bienvenido();
            bienvenido.Show();    // muestro from de aperturas
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_contraseña_Click(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = false;///revisar
        }
    }
}
