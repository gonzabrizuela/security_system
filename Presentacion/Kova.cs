using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Kova : Form
    {
        public Kova()
        {
            InitializeComponent();
        }

        private void btn_integrantes_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de peso
            Menu menu = new Menu(); //instancio un nuevo form
            menu.Show();    // muestro from de menu
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
