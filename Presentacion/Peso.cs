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
    public partial class Peso : Form
    {
        private Timer ti;
        BaseDeDatos bd = new BaseDeDatos();

        public Peso()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de peso
            Menu menu = new Menu(); //instancio un nuevo form
            menu.Show();    // muestro from de menu
        }
        private void Peso_Load(object sender, EventArgs e)
        {
            //dgv_Peso.DataSource = bd.SelectDataTable("select Peso, fecha from Registro");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
         }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Peso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Peso_Load_1(object sender, EventArgs e)
        {
            //dgv_Peso.DataSource = bd.SelectDataTable("select Peso, fecha from Registro");
            lbl_peso.Text = Datos.PESO.strpeso;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl_peso.Text = Datos.PESO.strpeso;
        }

        private void btn_RE_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el from de temperaturas
            Peso peso = new Peso();
            peso.Show();    // muestro from de menu
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                this.Refresh();
            }
        }
    }
    
}
