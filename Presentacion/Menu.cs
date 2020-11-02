using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO.Ports;
//using System.Runtime.InteropServices;
namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
                    /*SplPuertos.BaudRate = Int32.Parse(CboBaudios.Text);//atencionnn
                    SplPuertos.DataBits = 8;
                    SplPuertos.Parity = Parity.None;
                    SplPuertos.StopBits = StopBits.One;
                    SplPuertos.Handshake = Handshake.None;
                    SplPuertos.PortName = CboPuertos.Text;
                    */
        private void btn_elecciones_Click(object sender, EventArgs e)
        {
            /**    this.Hide();            //oculto el from de menu
            Elecciones elecciones = new Elecciones();
            elecciones.Show();    // muestro from de elecciones
            **/
        }

        private void btn_integrantes_Click(object sender, EventArgs e)
        {
            submenuintegrantes.Visible = true;
            /*this.Hide();            //oculto el from de menu 
            Integrantes integrantes = new Integrantes();
            integrantes.Show();    // muestro from de integrantes
            */
            
    }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_temperatura_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el from de elecciones
            Temperaturas temperaturas = new Temperaturas();
            temperaturas.Show();    // muestro from de temperaturas
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Aperturas aperturas = new Aperturas();
            aperturas.Show();    // muestro from de aperturas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Bienvenido bienvenido = new Bienvenido();
            bienvenido.Show();    // muestro from de aperturas
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Preueba_de_datos prueba = new Preueba_de_datos();
            prueba.Show();    // muestro from de prueba

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Peso peso = new Peso();
            peso.Show();    // muestro from de peso
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbl_abierto.Text = Datos.Historial.Usuario;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWilly_Click(object sender, EventArgs e)
        {
            submenuintegrantes.Visible = false;
            this.Hide();            //oculto el form de elecciones
            Willy willy = new Willy();
            willy.Show();    // muestro from de prueba
        }

        private void btnKova_Click(object sender, EventArgs e)
        {
            submenuintegrantes.Visible = false;
            this.Hide();            //oculto el form de elecciones
            Kova kova = new Kova();
            kova.Show();    // muestro from de prueba
        }

       /* private void btnWilly_Click_1(object sender, EventArgs e)
        {
            submenuintegrantes.Visible = false;
            this.Hide();            //oculto el form de elecciones
            Preueba_de_datos prueba = new Preueba_de_datos();
            prueba.Show();    // muestro from de prueba
        }
        */
        private void btnnNAZA_Click(object sender, EventArgs e)
        {
            submenuintegrantes.Visible = false;
            this.Hide();            //oculto el form de elecciones
            Naza naza = new Naza();
            naza.Show();    // muestro from de prueba
        }

        private void btnScape_Click(object sender, EventArgs e)
        {
            submenuintegrantes.Visible = false;
            this.Hide();            //oculto el form de elecciones
            Scape scape = new Scape();
            scape.Show();    // muestro from de prueba
        }

        private void BtnVilla_Click(object sender, EventArgs e)
        {
            submenuintegrantes.Visible = false;
            this.Hide();            //oculto el form de elecciones
            Villa villa = new Villa();
            villa.Show();    // muestro from de prueba
        }

        private void btnWilly_Click_1(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Willy willy = new Willy();
            willy.Show();    // muestro from de prueba
        }

        private void btn_integrantes_MouseDown(object sender, MouseEventArgs e)
        {

        }

        //private void btn_minimizar_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
