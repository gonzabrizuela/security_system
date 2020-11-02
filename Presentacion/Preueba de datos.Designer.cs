namespace Presentacion
{
    partial class Preueba_de_datos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBuscarPuertos = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnEnviarDatos = new System.Windows.Forms.Button();
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.CboBaudios = new System.Windows.Forms.ComboBox();
            this.LblBaudRate = new System.Windows.Forms.Label();
            this.LblDatosIngreso = new System.Windows.Forms.Label();
            this.Txt_DatosRecibidos = new System.Windows.Forms.TextBox();
            this.TxtDatos_a_Enviar = new System.Windows.Forms.TextBox();
            this.SplPuertos = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAlarma = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtp_willy = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tXT_TEMPMAX = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txt_usuarios = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarPuertos
            // 
            this.btnBuscarPuertos.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPuertos.Location = new System.Drawing.Point(205, 160);
            this.btnBuscarPuertos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarPuertos.Name = "btnBuscarPuertos";
            this.btnBuscarPuertos.Size = new System.Drawing.Size(111, 53);
            this.btnBuscarPuertos.TabIndex = 0;
            this.btnBuscarPuertos.Text = "BUSCAR PUERTOS:";
            this.btnBuscarPuertos.UseVisualStyleBackColor = true;
            this.btnBuscarPuertos.Click += new System.EventHandler(this.btnBuscarPuertos_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.Location = new System.Drawing.Point(475, 175);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(111, 36);
            this.BtnConectar.TabIndex = 1;
            this.BtnConectar.Text = "CONECTAR";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnEnviarDatos
            // 
            this.BtnEnviarDatos.Location = new System.Drawing.Point(221, 306);
            this.BtnEnviarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEnviarDatos.Name = "BtnEnviarDatos";
            this.BtnEnviarDatos.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviarDatos.TabIndex = 2;
            this.BtnEnviarDatos.Text = "ENVIAR DATOS";
            this.BtnEnviarDatos.UseVisualStyleBackColor = true;
            this.BtnEnviarDatos.Click += new System.EventHandler(this.BtnEnviarDatos_Click);
            // 
            // CboPuertos
            // 
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(347, 175);
            this.CboPuertos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(121, 24);
            this.CboPuertos.TabIndex = 3;
            this.CboPuertos.SelectedIndexChanged += new System.EventHandler(this.CboPuertos_SelectedIndexChanged);
            // 
            // CboBaudios
            // 
            this.CboBaudios.FormattingEnabled = true;
            this.CboBaudios.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.CboBaudios.Location = new System.Drawing.Point(347, 249);
            this.CboBaudios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboBaudios.Name = "CboBaudios";
            this.CboBaudios.Size = new System.Drawing.Size(121, 24);
            this.CboBaudios.TabIndex = 4;
            this.CboBaudios.Text = "9600";
            this.CboBaudios.SelectedIndexChanged += new System.EventHandler(this.CboBaudios_SelectedIndexChanged);
            // 
            // LblBaudRate
            // 
            this.LblBaudRate.AutoSize = true;
            this.LblBaudRate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblBaudRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBaudRate.ForeColor = System.Drawing.Color.White;
            this.LblBaudRate.Image = global::Presentacion.Properties.Resources._142042_gallery_for_gucci_wallpapers_for_walls_1922x1080_h;
            this.LblBaudRate.Location = new System.Drawing.Point(217, 252);
            this.LblBaudRate.Name = "LblBaudRate";
            this.LblBaudRate.Size = new System.Drawing.Size(93, 19);
            this.LblBaudRate.TabIndex = 5;
            this.LblBaudRate.Text = "BAUD RATE:";
            // 
            // LblDatosIngreso
            // 
            this.LblDatosIngreso.AutoSize = true;
            this.LblDatosIngreso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDatosIngreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDatosIngreso.Image = global::Presentacion.Properties.Resources._142042_gallery_for_gucci_wallpapers_for_walls_1922x1080_h;
            this.LblDatosIngreso.Location = new System.Drawing.Point(219, 382);
            this.LblDatosIngreso.Name = "LblDatosIngreso";
            this.LblDatosIngreso.Size = new System.Drawing.Size(133, 17);
            this.LblDatosIngreso.TabIndex = 6;
            this.LblDatosIngreso.Text = "DATOS RECIBIDOS";
            // 
            // Txt_DatosRecibidos
            // 
            this.Txt_DatosRecibidos.Location = new System.Drawing.Point(379, 378);
            this.Txt_DatosRecibidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_DatosRecibidos.Name = "Txt_DatosRecibidos";
            this.Txt_DatosRecibidos.Size = new System.Drawing.Size(200, 22);
            this.Txt_DatosRecibidos.TabIndex = 7;
            this.Txt_DatosRecibidos.TextChanged += new System.EventHandler(this.Txt_DatosRecibidos_TextChanged);
            // 
            // TxtDatos_a_Enviar
            // 
            this.TxtDatos_a_Enviar.Location = new System.Drawing.Point(347, 306);
            this.TxtDatos_a_Enviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDatos_a_Enviar.Name = "TxtDatos_a_Enviar";
            this.TxtDatos_a_Enviar.Size = new System.Drawing.Size(100, 22);
            this.TxtDatos_a_Enviar.TabIndex = 8;
            // 
            // SplPuertos
            // 
            this.SplPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 65);
            this.button1.TabIndex = 10;
            this.button1.Text = "Base de datos:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(833, 190);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(835, 222);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(835, 258);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 14;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(733, 197);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(90, 17);
            this.lblTemperatura.TabIndex = 15;
            this.lblTemperatura.Text = "Temperatura";
            this.lblTemperatura.Click += new System.EventHandler(this.lblTemperatura_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(773, 299);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(47, 17);
            this.Fecha.TabIndex = 16;
            this.Fecha.Text = "Fecha";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(781, 230);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 17);
            this.lblPeso.TabIndex = 17;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // lblAlarma
            // 
            this.lblAlarma.AutoSize = true;
            this.lblAlarma.Location = new System.Drawing.Point(771, 267);
            this.lblAlarma.Name = "lblAlarma";
            this.lblAlarma.Size = new System.Drawing.Size(52, 17);
            this.lblAlarma.TabIndex = 18;
            this.lblAlarma.Text = "Alarma";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btn_minimizar);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 25);
            this.panel3.TabIndex = 20;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Presentacion.Properties.Resources.Sin_título;
            this.btn_minimizar.Location = new System.Drawing.Point(947, 0);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(21, 22);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 10;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Presentacion.Properties.Resources._60487699_x_icono_de_cierre_botón_de_internet_sobre_fondo_azul_;
            this.btnCerrar.Location = new System.Drawing.Point(975, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 576);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(12, 444);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 37);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.simbolo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 444);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(893, 331);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtp_willy
            // 
            this.dtp_willy.CustomFormat = "dd/MM/yyyy ";
            this.dtp_willy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_willy.Location = new System.Drawing.Point(835, 290);
            this.dtp_willy.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_willy.Name = "dtp_willy";
            this.dtp_willy.Size = new System.Drawing.Size(131, 22);
            this.dtp_willy.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 425);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaximumSize = new System.Drawing.Size(132, 20);
            this.textBox2.MinimumSize = new System.Drawing.Size(200, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 25;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(605, 377);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 22);
            this.textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(605, 423);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 22);
            this.textBox6.TabIndex = 27;
            // 
            // tXT_TEMPMAX
            // 
            this.tXT_TEMPMAX.Location = new System.Drawing.Point(379, 469);
            this.tXT_TEMPMAX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tXT_TEMPMAX.Name = "tXT_TEMPMAX";
            this.tXT_TEMPMAX.Size = new System.Drawing.Size(200, 22);
            this.tXT_TEMPMAX.TabIndex = 28;
            this.tXT_TEMPMAX.TextChanged += new System.EventHandler(this.tXT_TEMPMAX_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(379, 514);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 22);
            this.textBox7.TabIndex = 29;
            // 
            // txt_usuarios
            // 
            this.txt_usuarios.Location = new System.Drawing.Point(605, 469);
            this.txt_usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_usuarios.Name = "txt_usuarios";
            this.txt_usuarios.Size = new System.Drawing.Size(200, 22);
            this.txt_usuarios.TabIndex = 30;
            // 
            // Preueba_de_datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources._142042_gallery_for_gucci_wallpapers_for_walls_1922x1080_h;
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.txt_usuarios);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tXT_TEMPMAX);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dtp_willy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblAlarma);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtDatos_a_Enviar);
            this.Controls.Add(this.Txt_DatosRecibidos);
            this.Controls.Add(this.LblDatosIngreso);
            this.Controls.Add(this.LblBaudRate);
            this.Controls.Add(this.CboBaudios);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.BtnEnviarDatos);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.btnBuscarPuertos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 601);
            this.MinimumSize = new System.Drawing.Size(1000, 601);
            this.Name = "Preueba_de_datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexiones";
            this.Load += new System.EventHandler(this.Preueba_de_datos_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarPuertos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnEnviarDatos;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.ComboBox CboBaudios;
        private System.Windows.Forms.Label LblBaudRate;
        private System.Windows.Forms.Label LblDatosIngreso;
        private System.Windows.Forms.TextBox Txt_DatosRecibidos;
        private System.Windows.Forms.TextBox TxtDatos_a_Enviar;
        private System.IO.Ports.SerialPort SplPuertos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAlarma;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtp_willy;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tXT_TEMPMAX;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txt_usuarios;
    }
}