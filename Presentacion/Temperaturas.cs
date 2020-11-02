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

namespace Presentacion
{
    public partial class Temperaturas : Form
    {
        private Timer ti;
        BaseDeDatos bd = new BaseDeDatos();

        public Temperaturas()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }

        private void eventoTimer(object ob, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            lbl_reloj.Text = hoy.ToString("hh:mm:ss tt");
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el from de temperaturas
            Menu menu = new Menu();
            menu.Show();    // muestro from de menu

            /**this.Hide();            //oculto el from de temperaturas
            Elecciones elecciones = new Elecciones();
            elecciones.Show();    // muestro from de elecciones
            **/
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            
        }

        private void Temperaturas_Load(object sender, EventArgs e)
        {
            label2.Text = Datos.Temperatura.tempmax;
            //dgv_temperatura.DataSource = bd.SelectDataTable("select Temperatura, fecha from Registro");
            lbl_tmp.Text = Datos.Temperatura.temp;
          //  this.Refresh();
        }

        private void lbl_temperatura_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el from de temperaturas
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "sendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_temperatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el from de temperaturas
            Temperaturas temperaturas = new Temperaturas();
            temperaturas.Show();    // muestro from de menu
        }

        private void btn_RE_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el from de temperaturas
            Temperaturas temperaturas = new Temperaturas();
            temperaturas.Show();    // muestro from de menu
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                this.Hide();            //oculto el from de temperaturas
                Temperaturas temperaturas = new Temperaturas();
                temperaturas.Show();    // muestro from de menu

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

