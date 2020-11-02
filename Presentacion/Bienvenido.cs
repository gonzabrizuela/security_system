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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();    // muestro from de aperturas
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Registro registro= new Registro();
            registro.Show();    // muestro from de aperturas
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            //cbdireccion
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_registro_Click_1(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Registro registro = new Registro();
            registro.Show();    // muestro from de aperturas
        }

        private void cbdireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
          

          
        }

        private void btn_integrantes_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            PRINNCIPAL registro = new PRINNCIPAL();
            registro.Show();    // muestro from de aperturas
        }

    }
}
