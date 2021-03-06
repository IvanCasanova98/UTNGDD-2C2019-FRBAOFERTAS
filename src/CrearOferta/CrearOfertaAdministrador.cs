﻿using FrbaOfertas.Modelo;
using FrbaOfertas.Modelo.ABMHandler;
using FrbaOfertas.Modelo.Listado;
using FrbaOfertas.Modelo.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FORM PARA CARGAR OFERTAS SIENDO ADMINISTRATIVO

namespace FrbaOfertas.CrearOferta
{
    public partial class CrearOfertaAdministrador : Form
    {
        public CrearOfertaAdministrador()
        {
            InitializeComponent();
            txt_descripcion.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_precioOferta.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_stockDisponible.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_precioLista.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_maxUnidadesPorCliente.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            
        }


        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean validarDatos()
        {
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            Boolean pass = true;

            if(validador.isEmpty(txt_descripcion.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_descripcion);
                pass = false;
            } else
                if(validador.isNumeric(this.txt_descripcion.Text))
                {
                    validador.ErrornoContenerNumeros(txt_descripcion);
                    pass = false;
                }

            if (validador.isEmpty(this.txt_precioOferta.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_precioOferta);
                pass = false;
            }else
                if (!validador.isNumeric(this.txt_precioOferta.Text))
                {
                    validador.ErrornoNumeroEnteroPositivo(txt_precioOferta);
                    pass = false;
                }
            if (validador.isEmpty(this.txt_precioLista.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_precioLista);
                pass = false;
            }else
                if (!validador.isNumeric(this.txt_precioLista.Text) || (Int32.Parse(this.txt_precioLista.Text) <= 0))
                {
                    validador.ErrornoNumeroEnteroPositivo(txt_precioLista);
                    pass = false;
                }
                else if ((Int32.Parse(this.txt_precioOferta.Text)) >= (Int32.Parse(this.txt_precioLista.Text)))
                {
                    validador.ErrorPrecioOfertaNoPuedeSerMayorOIgualQuePrecioLista(txt_precioOferta);
                    pass = false;
                }

            if (validador.isEmpty(this.txt_maxUnidadesPorCliente.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_maxUnidadesPorCliente);
                pass = false;
            }else
                if (!validador.isNumeric(this.txt_maxUnidadesPorCliente.Text) || (Int32.Parse(this.txt_maxUnidadesPorCliente.Text) <= 0))
                {
                    validador.ErrornoEsNumerico(txt_maxUnidadesPorCliente);
                    pass = false;
                }

            if (validador.isEmpty(this.txt_stockDisponible.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_stockDisponible);
                pass = false;
            }else
                if (!validador.isNumeric(this.txt_stockDisponible.Text) || (Int32.Parse(this.txt_stockDisponible.Text) <= 0))
                {
                    validador.ErrornoEsNumerico(txt_stockDisponible);
                    pass = false;
                }

            if (!validador.FechaFutura(dateTimePickerOferta.Value))
            {
                MessageBox.Show("La fecha de oferta debe ser futura");
                pass = false;
            }

            if (!validador.FechaFutura(dateTimePickerVencimiento.Value))
            {
                MessageBox.Show("La fecha de vencimiento de oferta debe ser futura");
                pass = false;
            }

            if (validador.fechaAnteriorA(dateTimePickerOferta.Value,dateTimePickerVencimiento.Value))
            {
                MessageBox.Show("La fecha de vencimiento debe ser futura al de la oferta");
                pass = false;
            }


            return pass;
        }


        private void cmd_darAlta_Click(object sender, EventArgs e)
        {
            if (this.validarDatos())
            {
               
                Oferta oferta = new Oferta();

                oferta.Ofe_Stock = txt_stockDisponible.Text;
                oferta.Ofe_Descrip = txt_descripcion.Text.Trim();
                oferta.Ofe_Fecha = dateTimePickerOferta.Value;
                oferta.Ofe_Fecha_Venc = dateTimePickerVencimiento.Value;
                oferta.Ofe_Max_Cant_Por_Usuario = txt_maxUnidadesPorCliente.Text;
                oferta.Ofe_Precio = txt_precioLista.Text;
                oferta.Ofe_Precio_Ficticio = txt_precioOferta.Text;
                oferta.Ofe_Accesible = 1;
                
                FrbaOfertas.AbmProveedor.ListadoProveedor lstProveedor = new FrbaOfertas.AbmProveedor.ListadoProveedor(new ListadoOferta(oferta));
                lstProveedor.ShowDialog(this);
                this.Close();
                this.txt_precioLista.Text = "";
                this.txt_precioOferta.Text = "";
                this.txt_stockDisponible.Text = "";
                this.txt_maxUnidadesPorCliente.Text = "";
                this.txt_descripcion.Text = "";
                this.dateTimePickerOferta.Value = DateTime.Now;
                this.dateTimePickerVencimiento.Value = DateTime.Now;
            }

        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            this.txt_precioLista.Text = "";
            this.txt_precioOferta.Text = "";
            this.txt_stockDisponible.Text = "";
            this.txt_maxUnidadesPorCliente.Text = "";
            this.txt_descripcion.Text = "";
            this.dateTimePickerOferta.Value = DateTime.Now;
            this.dateTimePickerVencimiento.Value = DateTime.Now;
        }


    }
}
