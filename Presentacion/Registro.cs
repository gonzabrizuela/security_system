using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//////ATENCION LIBRERIA MYSQL
using System.Data.SqlClient;
using Presentacion.Properties;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class Registro : Form
    {
        BaseDeDatos bdusuarios = new BaseDeDatos();
        Random rdm = new Random();
        
        int a;
        public Registro(string Conexion)
        {
            InitializeComponent();
            this.Conexion = Conexion;
        }
        public Registro()
        {
            InitializeComponent();
         
        }
        // public Registro()
        //  {
        //      InitializeComponent();
        //  }

        private void btn_siguiente_Click(object sender, EventArgs e)

        {
            string contraseña = txt_contraseña.Text;
            string confirmacioncontraseña = txt_confirmacion.Text;
            a = rdm.Next(1000, 100000);
            if (contraseña == confirmacioncontraseña)

            {


                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                mmsg.To.Add(txt_email.Text);
                mmsg.Subject = ("Confirmacion de usuario:");////////////agregar datos a emviar
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

                mmsg.Body = a.ToString();//mando codigo
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                //mmsg.IsBodyHtml = true;//chequear
                mmsg.From = new System.Net.Mail.MailAddress("grupo02pio2019@gmail.com");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential("grupo02pio2019@gmail.com", "pizzaycafe");
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";
                //  cliente.Send(mmsg); 

                try
                {
                    cliente.Send(mmsg);
                }
                catch (Exception)
                {

                    MessageBox.Show("error al enviar");
                }

                //  string agregar = "INSERT INTO Usuarios(Usuario,Contraseña) VALUES('" +txt_email.Text+ "','" + confirmacioncontraseña+ "')";


                /**Properties.Settings.Default.Save();
                My.Settings.Usuario = txt_usuario.Text;
                Properties.Settings.Save();
                Properties.Settings.Reload();

                Properties.Settings.Email = txt_email.Text;
                Properties.Settings.Save();
                Properties.Settings.Reload();

                Properties.Settings.Contraseña = txt_contraseña.Text;
                Properties.Settings.Save();
                Properties.Settings.Reload();
               **/

            }
            else
            {
                MessageBox.Show("no es la misma contraseña");
            }










        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de peso
            Bienvenido bienvenido = new Bienvenido(); //instancio un nuevo form
            bienvenido.Show();    // muestro from de menu
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_contraseña_Click(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = false;//rev
            txt_confirmacion.UseSystemPasswordChar = false;//rev


        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        /*public void confir()
        {
            int a = rdm.Next(1000, 100000);
        }
        */
        // public Registro(string Conexion)
        //   {
        //     InitializeComponent();

        //  }
        string Conexion;
        private void button1_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtx_confir.Text) == a)
            {

                MessageBox.Show("Usuario cargado a la base");
                this.Hide();            //oculto el form de elecciones
                Menu menu = new Menu();
                menu.Show();    // muestro from de aperturas

                string agregar = "INSERT INTO Usuarios(Usuario, Contraseña) VALUES('" + txt_email.Text + "','" + txt_contraseña.Text + "')";
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = Datos.Conexion.strCONEXION;
                //MySqlConnection cnn = new MySqlConnection(Conexion);
                //MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
                //cnn.ConnectionString = "server=10.1.5.205; DATABASE = G02_Tecnica_2019;UID=G02_Tecnica_2019;PASSWORD=proyectogrupo2;";
                //cnn.ConnectionString = "server=186.18.252.243; DATABASE = G02_Tecnica_2019;UID=G02_Tecnica_2019;PASSWORD=proyectogrupo2;";
                

                    MySqlCommand mc = new MySqlCommand(agregar, connection);
                    try
                    {
                        connection.Open();
                        //MySqlDataReader reader = mc.ExecuteReader();
                        mc.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("LA CONCHADE LA LORAAAAAA");
                    }

                 
               
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void txt_confirmacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
