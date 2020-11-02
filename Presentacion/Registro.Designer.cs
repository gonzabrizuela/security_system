namespace Presentacion
{
    partial class Registro
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_confirmacion = new System.Windows.Forms.Label();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_confirmacion = new System.Windows.Forms.TextBox();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_contraseña = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtx_confir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Image = global::Presentacion.Properties.Resources._142042_gallery_for_gucci_wallpapers_for_walls_1922x1080_h;
            this.lbl_email.Location = new System.Drawing.Point(316, 191);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(64, 17);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "E-MAIL:";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_contraseña.Image = global::Presentacion.Properties.Resources._142042_gallery_for_gucci_wallpapers_for_walls_1922x1080_h;
            this.lbl_contraseña.Location = new System.Drawing.Point(284, 225);
            this.lbl_contraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(96, 17);
            this.lbl_contraseña.TabIndex = 2;
            this.lbl_contraseña.Text = "Contraseña:";
            // 
            // lbl_confirmacion
            // 
            this.lbl_confirmacion.AutoSize = true;
            this.lbl_confirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmacion.ForeColor = System.Drawing.Color.White;
            this.lbl_confirmacion.Image = global::Presentacion.Properties.Resources._142042_gallery_for_gucci_wallpapers_for_walls_1922x1080_h;
            this.lbl_confirmacion.Location = new System.Drawing.Point(164, 263);
            this.lbl_confirmacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_confirmacion.Name = "lbl_confirmacion";
            this.lbl_confirmacion.Size = new System.Drawing.Size(216, 17);
            this.lbl_confirmacion.TabIndex = 3;
            this.lbl_confirmacion.Text = "Confirmacion de contraseña:";
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(525, 301);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(95, 45);
            this.btn_siguiente.TabIndex = 4;
            this.btn_siguiente.Text = "Enviar codigo de confirmación";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(400, 191);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(120, 20);
            this.txt_email.TabIndex = 6;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(400, 225);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(120, 20);
            this.txt_contraseña.TabIndex = 7;
            this.txt_contraseña.UseSystemPasswordChar = true;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.txt_contraseña_TextChanged);
            // 
            // txt_confirmacion
            // 
            this.txt_confirmacion.Location = new System.Drawing.Point(400, 260);
            this.txt_confirmacion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_confirmacion.Name = "txt_confirmacion";
            this.txt_confirmacion.Size = new System.Drawing.Size(120, 20);
            this.txt_confirmacion.TabIndex = 8;
            this.txt_confirmacion.UseSystemPasswordChar = true;
            this.txt_confirmacion.TextChanged += new System.EventHandler(this.txt_confirmacion_TextChanged);
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.ForeColor = System.Drawing.Color.White;
            this.lbl_registro.Image = global::Presentacion.Properties.Resources._142042_gallery_for_gucci_wallpapers_for_walls_1922x1080_h;
            this.lbl_registro.Location = new System.Drawing.Point(180, 101);
            this.lbl_registro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(165, 26);
            this.lbl_registro.TabIndex = 9;
            this.lbl_registro.Text = "Nuevo usuario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btn_minimizar);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 20);
            this.panel3.TabIndex = 16;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Presentacion.Properties.Resources.Sin_título;
            this.btn_minimizar.Location = new System.Drawing.Point(710, 0);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(16, 18);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 10;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Presentacion.Properties.Resources._60487699_x_icono_de_cierre_botón_de_internet_sobre_fondo_azul_;
            this.btnCerrar.Location = new System.Drawing.Point(731, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 18);
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
            this.panel1.Controls.Add(this.btn_volver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 468);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(9, 361);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 30);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.simbolo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_volver
            // 
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(9, 361);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(2);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(144, 30);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_contraseña
            // 
            this.btn_contraseña.Location = new System.Drawing.Point(525, 257);
            this.btn_contraseña.Name = "btn_contraseña";
            this.btn_contraseña.Size = new System.Drawing.Size(90, 28);
            this.btn_contraseña.TabIndex = 18;
            this.btn_contraseña.Text = "Ver contraseña";
            this.btn_contraseña.UseVisualStyleBackColor = true;
            this.btn_contraseña.Click += new System.EventHandler(this.btn_contraseña_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Presentacion.Properties.Resources._142042_gallery_for_gucci_wallpapers_for_walls_1922x1080_h;
            this.label1.Location = new System.Drawing.Point(197, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo de confirmacion:";
            // 
            // txtx_confir
            // 
            this.txtx_confir.Location = new System.Drawing.Point(400, 378);
            this.txtx_confir.Margin = new System.Windows.Forms.Padding(2);
            this.txtx_confir.Name = "txtx_confir";
            this.txtx_confir.Size = new System.Drawing.Size(120, 20);
            this.txtx_confir.TabIndex = 20;
            this.txtx_confir.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources._142042_gallery_for_gucci_wallpapers_for_walls_1922x1080_h;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtx_confir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_contraseña);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_registro);
            this.Controls.Add(this.txt_confirmacion);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.lbl_confirmacion);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(750, 488);
            this.MinimumSize = new System.Drawing.Size(750, 488);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_confirmacion;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_confirmacion;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_contraseña;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtx_confir;
        private System.Windows.Forms.Button button1;
    }
}