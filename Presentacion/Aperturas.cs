using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;//////ATENCION LIBRERIA MYSQL
using System.Data.SqlClient;
using System.Configuration;
using Presentacion.aa;


namespace Presentacion
{
    public partial class Aperturas : Form
    {
        instuccion obje = new instuccion();         
        BaseDeDatos bd = new BaseDeDatos();
        

        public Aperturas()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de aperturas
            Menu menu = new Menu();
            menu.Show();    // muestro from de menu

            
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
                    }
        
        private void Aperturas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obje.vistatabla();
            dataGridView2.DataSource = obje.vistatabla2();
        }
        

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "sendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de aperturas
            Menu menu = new Menu();
            menu.Show();    // muestro from de menu
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
