using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//////ATENCION LIBRERIA MYSQL
using System.Data.SqlClient;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Configuration;

namespace Presentacion
{
    public partial class Preueba_de_datos : Form
    {
        private string strBufferIn;
        private int intMemoria=0;
        private int intMemorias = 0;
        private string strxd;
        private string strBufferOut;
        //private string straa
        BaseDeDatos bd = new BaseDeDatos();
        private delegate void DelegadoAcceso(string accion);
        public string strPrueba;
        public string tempactual;
        public string tempMAX;
        public string pesoactual;
        public string alarma;
        public string Conexion;
        public string usuario;
        public string abierto;
        DateTime ya = DateTime.Now;
        string willy = "BRIZUELA ORTIZ, Gonzalo";
        string kova = "KOVALOW, Maximiliano";
        string naza = "SANCHEZ, Nazareno";
        string scape = "SCAPELLATO, Federico";
        string Villa = "VILLAMEDIANA, Joaquìn";

        public Preueba_de_datos()
        {
            InitializeComponent();            
        }

        private void AccesoForm(string accion)
        {
            strBufferIn = accion;            
            strxd = strBufferIn;
            
            int i = 0;
            int largo = 0;
            largo = strxd.Length;
                            
            if (largo > 12)
            {
                if (strxd[0] == '<')
                {

                    if (strxd[3] == 'C')
                    {
                        if (strxd[8] == 'K')
                        {
                            strPrueba = strxd;
                            tempactual = "Temperatura Actual: " + strPrueba[1] + strPrueba[2] + "Cª";
                            Datos.Temperatura.temp = tempactual;
                            textBox2.Text = strPrueba[1] + strPrueba[2] + "Cª";
                            pesoactual = strPrueba[6] + "." + strPrueba[7] + "Kg";
                            Datos.PESO.strpeso = pesoactual;
                            textBox5.Text = "Peso Actual: " + strPrueba[7] + "." + strPrueba[8] + "Kg";
                            tempMAX = "Temperatura maxima: " + strPrueba[4] + strPrueba[5] + "Cª";
                            tXT_TEMPMAX.Text = "Temperatura maxima: " + strPrueba[4] + strPrueba[5] + "Cª";
                            Datos.Temperatura.tempmax = tempMAX;

                            try
                            {
                                if (strPrueba[13] == '1')
                                {
                                    textBox7.Text = "Estado de cerradura: ABIERTO";
                                }

                            }
                            catch (Exception EX)
                            {
                                textBox7.Text = "Estado de cerradura: CERRADO";
                                
                            }
                                  

                            if ((strPrueba[12] == '1')&& (intMemorias == 0))
                            {
                                usuario = "Abierto por: BRIZUELA ORTIZ, Gonzalo";
                                Datos.Historial.Usuario = usuario;
                                txt_usuarios.Text = usuario;
                                string agregarusuario = "INSERT INTO Aperturas(Usuario, Fecha) VALUES('" + willy + "','" + ya.ToString("yyyy-MM-dd hh:mm:ss") + "');";
                                MySqlConnection connection = new MySqlConnection();
                                connection.ConnectionString = Datos.Conexion.strCONEXION;
                                MySqlCommand mc = new MySqlCommand(agregarusuario, connection);
                                try
                                {
                                    connection.Open();
                                    //MySqlDataReader reader = mc.ExecuteReader();
                                    mc.ExecuteNonQuery();
                                    connection.Close();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("LA CONCHADE LA LORAAAAAA");
                                }
                                intMemorias = 1;

                            }
                            if ((strxd[12] == '2') && (intMemorias == 0))
                            {
                                usuario = "Abierto por: KOVALOW, Maximiliano";
                                Datos.Historial.Usuario = usuario;
                                txt_usuarios.Text = usuario;
                                string agregarusuario = "INSERT INTO Aperturas(Usuario, Fecha) VALUES('" +  kova+ "','" + ya.ToString("yyyy-MM-dd hh:mm:ss") + "');";
                                MySqlConnection connection = new MySqlConnection();
                                connection.ConnectionString = Datos.Conexion.strCONEXION;
                                MySqlCommand mc = new MySqlCommand(agregarusuario, connection);
                                try
                                {
                                    connection.Open();
                                    //MySqlDataReader reader = mc.ExecuteReader();
                                    mc.ExecuteNonQuery();
                                    connection.Close();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("LA CONCHADE LA LORAAAAAA");
                                }

                                intMemorias = 1;
                            }
                            if ((strxd[12] == '3')&& (intMemorias == 0))
                            {
                                usuario = "Abierto por: SANCHEZ, Nazareno";
                                Datos.Historial.Usuario = usuario;
                                txt_usuarios.Text = usuario;
                                string agregarusuario = "INSERT INTO Aperturas(Usuario, Fecha) VALUES('" + naza+ "','" + ya.ToString("yyyy-MM-dd hh:mm:ss") + "');";
                                MySqlConnection connection = new MySqlConnection();
                                connection.ConnectionString = Datos.Conexion.strCONEXION;
                                MySqlCommand mc = new MySqlCommand(agregarusuario, connection);
                                try
                                {
                                    connection.Open();
                                    //MySqlDataReader reader = mc.ExecuteReader();
                                    mc.ExecuteNonQuery();
                                    connection.Close();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("LA CONCHADE LA LORAAAAAA");
                                }
                                intMemorias = 1;
                            }
                            if ((strxd[12] == '4')&& (intMemorias == 0))
                            {
                                usuario = "Abierto por: SCAPELLATO, Federico";
                                Datos.Historial.Usuario = usuario;
                                txt_usuarios.Text = usuario;
                                string agregarusuario = "INSERT INTO Aperturas(Usuario, Fecha) VALUES('" + scape + "','" + ya.ToString("yyyy-MM-dd hh:mm:ss") + "');";
                                MySqlConnection connection = new MySqlConnection();
                                connection.ConnectionString = Datos.Conexion.strCONEXION;
                                MySqlCommand mc = new MySqlCommand(agregarusuario, connection);
                                try
                                {
                                    connection.Open();
                                    //MySqlDataReader reader = mc.ExecuteReader();
                                    mc.ExecuteNonQuery();
                                    connection.Close();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("LA CONCHADE LA LORAAAAAA");
                                }
                                intMemorias = 1;
                            }
                            if ((strxd[12] == '5')&& (intMemorias == 0))
                            {
                                usuario = "Abierto por: VILLAMEDIANA, Joaquin";
                                Datos.Historial.Usuario = usuario;
                                txt_usuarios.Text = usuario;
                                string agregarusuario = "INSERT INTO Aperturas(Usuario, Fecha) VALUES('" + Villa+ "','" + ya.ToString("yyyy-MM-dd hh:mm:ss") + "');";
                                MySqlConnection connection = new MySqlConnection();
                                connection.ConnectionString = Datos.Conexion.strCONEXION;
                                MySqlCommand mc = new MySqlCommand(agregarusuario, connection);
                                try
                                {
                                    connection.Open();
                                    //MySqlDataReader reader = mc.ExecuteReader();
                                    mc.ExecuteNonQuery();
                                    connection.Close();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("LA CONCHADE LA LORAAAAAA");
                                }
                                intMemorias = 1;
                            }




                            if ((strxd[11] == '1') && (intMemoria==0))
                            {
                                textBox6.Text = "Estado alarma: ACTIVADO";
                                alarma = "Activada";
                                string agregar = "INSERT INTO Registro(Temperatura, Peso, Fecha,TemperaturaMax) VALUES('" + strPrueba[1]+ strPrueba[2] + strPrueba[3] +"','" + strPrueba[6] + strPrueba[7]+ "','"+ya.ToString("yyyy-MM-dd hh:mm:ss")+ "','" + strPrueba[4] + strPrueba[5]+ "');";
                                MySqlConnection connection = new MySqlConnection();
                                connection.ConnectionString = Datos.Conexion.strCONEXION;                                
                                MySqlCommand mc = new MySqlCommand(agregar, connection);
                                try
                                {
                                    connection.Open();
                                    //MySqlDataReader reader = mc.ExecuteReader();
                                    mc.ExecuteNonQuery();
                                    connection.Close();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("LA CONCHADE LA LORAAAAAA");
                                }



                                intMemoria = 1;
                            }
                            else
                            {
                                textBox6.Text = "estado alarma: DESACTIVADA";
                                alarma = "Desactivada";
                                
                            }
                            if((strxd[11] == '0'))
                            {
                                intMemoria = 0;
                            }
                            
                        }
                        else
                        {
                            Txt_DatosRecibidos.Text = "Error4";
                        }
                    }
                    else
                    {
                        Txt_DatosRecibidos.Text = "Error3";
                    }
                }
                else
                {
                    Txt_DatosRecibidos.Text = "Error2";
                }
            }
            else
            {
                Txt_DatosRecibidos.Text = "Error1";
            }
               
        }
        private void AccesoInterrupcion(string Accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { Accion };
            base.Invoke(Var_DelegadoAcceso,arg);

        }

        private void Preueba_de_datos_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;
            BtnEnviarDatos.Enabled = false;            
        }

        private void btnBuscarPuertos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            CboPuertos.Items.Clear();
            foreach (string puerto_simple in PuertosDisponibles)
            {
                CboPuertos.Items.Add(puerto_simple);
            }
            if (CboPuertos.Items.Count > 0)
            {
                CboPuertos.SelectedIndex = 0;
                MessageBox.Show("Seleccionar el puerto de trabajo");
                BtnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ningun puerto detectado");
                CboPuertos.Items.Clear();
                CboPuertos.Text = "                      ";
                strBufferIn = "";
                strBufferOut = "";
                BtnConectar.Enabled = false;
                BtnEnviarDatos.Enabled = false;
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnConectar.Text=="CONECTAR")
                {
                    SplPuertos.BaudRate = Int32.Parse(CboBaudios.Text);//atencionnn
                    SplPuertos.DataBits = 8;
                    SplPuertos.Parity = Parity.None;
                    SplPuertos.StopBits = StopBits.One;
                    SplPuertos.Handshake = Handshake.None;
                    SplPuertos.PortName = CboPuertos.Text;
                    try
                    {
                        SplPuertos.Open();
                        BtnConectar.Text = "DESCONECTAR";
                        BtnEnviarDatos.Enabled = true;
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());
                    }
                }
                else if (BtnConectar.Text == "DESCONECTAR")
                {
                    SplPuertos.Close();
                    BtnConectar.Text = "CONECTAR";
                    BtnEnviarDatos.Enabled = false;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            
            
        }

        private void BtnEnviarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                SplPuertos.DiscardOutBuffer();
                strBufferOut = TxtDatos_a_Enviar.Text;
                SplPuertos.Write(strBufferOut);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(SplPuertos.ReadExisting());            
        }

        private void BtN_VOLVER_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de elecciones
            Menu menu = new Menu();
            menu.Show();    // muestro from de prueba
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "sendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de Configuracion
            Menu menu = new Menu(); //instancio un nuevo form
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();            //oculto el form de Configuracion
            Menu menu = new Menu(); //instancio un nuevo form
            menu.Show();    // muestro from de menu
        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void lblTemperatura_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {                     
            string temperatura = this.textBox1.Text;
            string peso = this.textBox3.Text;
            string alrma = this.textBox4.Text;
            //string  fecha = textBox4.Text;

            string agregarSE = "INSERT INTO Usuarios(Temperatura, Peso, Alarma, Fecha) VALUES('" +temperatura+"','" +peso+"','"+alrma+ "','"+this.dtp_willy.Text+"');";
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand mcN = new MySqlCommand(agregarSE, cnn);

            
            try
            {
                cnn.Open();
                
                mcN.ExecuteNonQuery();
               
            }
            catch (Exception)
            {

                MessageBox.Show("no");
            }
                        cnn.Close();
        }

        private void Txt_DatosRecibidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text="Temperatura Actual: "+strPrueba[1]+strPrueba[2]+"."+strPrueba[3]+"Cª";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection();
            cnn.ConnectionString = "server=186.18.252.243; DATABASE = G02_Tecnica_2019;UID=G02_Tecnica_2019;PASSWORD=proyectogrupo2;";
        }

        private void btn_local_Click(object sender, EventArgs e)
        {

        }

        private void tXT_TEMPMAX_TextChanged(object sender, EventArgs e)
        {
            tXT_TEMPMAX.Text = "Temperatura maxima: " + strPrueba[4] + strPrueba[5] + "Cª";
        }

        private void CboPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CboBaudios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }
