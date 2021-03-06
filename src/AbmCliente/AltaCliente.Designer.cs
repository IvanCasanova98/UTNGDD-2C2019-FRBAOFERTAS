﻿namespace FrbaOfertas.AbmCliente
{
    partial class AltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCliente));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Detalles = new System.Windows.Forms.GroupBox();
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dpto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmd_darAlta = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Detalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(80, 25);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(313, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(80, 51);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(313, 20);
            this.txt_apellido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(80, 77);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(313, 20);
            this.txt_dni.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calle";
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(80, 103);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(313, 20);
            this.txt_calle.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TEL.";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(80, 209);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(313, 20);
            this.txt_tel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "MAIL";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(80, 238);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(313, 20);
            this.txt_mail.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // Detalles
            // 
            this.Detalles.Controls.Add(this.cmd_limpiar);
            this.Detalles.Controls.Add(this.txt_localidad);
            this.Detalles.Controls.Add(this.label11);
            this.Detalles.Controls.Add(this.txt_dpto);
            this.Detalles.Controls.Add(this.label10);
            this.Detalles.Controls.Add(this.txt_piso);
            this.Detalles.Controls.Add(this.label9);
            this.Detalles.Controls.Add(this.cmd_darAlta);
            this.Detalles.Controls.Add(this.cmd_cancelar);
            this.Detalles.Controls.Add(this.dateTimePicker);
            this.Detalles.Controls.Add(this.label1);
            this.Detalles.Controls.Add(this.txt_nombre);
            this.Detalles.Controls.Add(this.label8);
            this.Detalles.Controls.Add(this.txt_apellido);
            this.Detalles.Controls.Add(this.label2);
            this.Detalles.Controls.Add(this.txt_dni);
            this.Detalles.Controls.Add(this.label6);
            this.Detalles.Controls.Add(this.label3);
            this.Detalles.Controls.Add(this.txt_mail);
            this.Detalles.Controls.Add(this.txt_calle);
            this.Detalles.Controls.Add(this.label5);
            this.Detalles.Controls.Add(this.label4);
            this.Detalles.Controls.Add(this.txt_tel);
            this.Detalles.Location = new System.Drawing.Point(9, 12);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(405, 356);
            this.Detalles.TabIndex = 0;
            this.Detalles.TabStop = false;
            this.Detalles.Text = "Detalles Cliente";
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_limpiar.Location = new System.Drawing.Point(165, 308);
            this.cmd_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(86, 34);
            this.cmd_limpiar.TabIndex = 12;
            this.cmd_limpiar.Text = "Limpiar";
            this.cmd_limpiar.UseVisualStyleBackColor = false;
            this.cmd_limpiar.Click += new System.EventHandler(this.cmd_limpiar_Click);
            // 
            // txt_localidad
            // 
            this.txt_localidad.Location = new System.Drawing.Point(80, 180);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(313, 20);
            this.txt_localidad.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Localidad";
            // 
            // txt_dpto
            // 
            this.txt_dpto.Location = new System.Drawing.Point(80, 154);
            this.txt_dpto.Name = "txt_dpto";
            this.txt_dpto.Size = new System.Drawing.Size(313, 20);
            this.txt_dpto.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Dpto";
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(80, 129);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(313, 20);
            this.txt_piso.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Piso";
            // 
            // cmd_darAlta
            // 
            this.cmd_darAlta.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_darAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_darAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_darAlta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_darAlta.Location = new System.Drawing.Point(265, 308);
            this.cmd_darAlta.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_darAlta.Name = "cmd_darAlta";
            this.cmd_darAlta.Size = new System.Drawing.Size(128, 34);
            this.cmd_darAlta.TabIndex = 11;
            this.cmd_darAlta.Text = "Guardar";
            this.cmd_darAlta.UseVisualStyleBackColor = false;
            this.cmd_darAlta.Click += new System.EventHandler(this.cmd_darAlta_Click);
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_cancelar.Location = new System.Drawing.Point(23, 308);
            this.cmd_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(128, 34);
            this.cmd_cancelar.TabIndex = 13;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = false;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(119, 268);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(274, 20);
            this.dateTimePicker.TabIndex = 10;
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(426, 374);
            this.Controls.Add(this.Detalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaCliente";
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.Detalles.ResumeLayout(false);
            this.Detalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox Detalles;
        private System.Windows.Forms.Button cmd_darAlta;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txt_dpto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmd_limpiar;
    }
}