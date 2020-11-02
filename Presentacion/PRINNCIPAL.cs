using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;//////ATENCION LIBRERIA MYSQL
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;
namespace Presentacion
{
    public partial class PRINNCIPAL : Form
    {
        public string Conexion;
      
       // registro.Visible = true;
        public PRINNCIPAL()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }             
            
        private void cbdireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdireccion.SelectedItem.Equals("Casa Salesiana PIOIX"))
            {
                Datos.Conexion.strCONEXION = "server = 10.1.5.205; DATABASE = G02_Tecnica_2019; UID = G02_Tecnica_2019; PASSWORD = proyectogrupo2; ";
                
            }
            if (cbdireccion.SelectedItem.Equals("Otro/a"))
            {
                Datos.Conexion.strCONEXION = "server = 186.18.252.243; DATABASE = G02_Tecnica_2019; UID = G02_Tecnica_2019; PASSWORD = proyectogrupo2; ";
               
            }
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Bienvenido bnv = new Bienvenido();
            bnv.Show();    // muestro from de aperturas
        }

        private void PRINNCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
          
        }
    }
}
