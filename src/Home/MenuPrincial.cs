﻿using FrbaOfertas.Modelo.ABMHandler;
using FrbaOfertas.Modelo.Listado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Home
{
    public partial class MenuPrincial : Form
    {
        public MenuPrincial()
        {
            InitializeComponent();
        }

        private void UpdateName()
        {
            label2.Text = "Bienvenido " + FrbaOfertas.Modelo.Usuario.username;
            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id))
            {
                ListViewItem itemrol = new ListViewItem(listing);
                RolesView.Items.Add(itemrol);
            }

            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesUsername.ObtenerFuncionalidadesDeUnUsuario(FrbaOfertas.Modelo.Usuario.username))
            {
                ListViewItem itemrol = new ListViewItem(listing);
                listView1.Items.Add(itemrol);
            }

            //Itero por la lista de funciones y voy "activando los botones del menu en caso de que coincidan"


            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                List<String> Funciones = FrbaOfertas.ConectorDB.FuncionesUsername.ObtenerFuncionalidadesDeUnUsuario(FrbaOfertas.Modelo.Usuario.username);
                if (Funciones.Contains(item.Text.ToUpper()))
                {
                    item.Visible = true;
                }
                else
                {
                    if (item.Text.ToUpper() != "OPCIONES")
                       item.Visible = false;
                    
                }

                foreach (ToolStripDropDownItem rol in modificiarDatosPersonalesToolStripMenuItem.DropDownItems)
                {
                    List<String> roles = FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id);
                    if (roles.Contains(rol.Text))
                    {
                        rol.Visible = true;
                    }
                    
                }

            }
        }

        private void MenuPrincial_Load(object sender, EventArgs e)
        {

            this.UpdateName();
        }


        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrbaOfertas.LOGIN dialog = new FrbaOfertas.LOGIN();
            FrbaOfertas.Utils.Transicion.transicionForms(this, dialog);
        }

        private void altaRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmRol.AltaRol dialog = new FrbaOfertas.AbmRol.AltaRol();
            dialog.ShowDialog(this);
        }

        private void listadoRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmRol.ListadoRol dialog = new FrbaOfertas.AbmRol.ListadoRol(new ListadoModificar(new RolHandler()));
            dialog.ShowDialog(this);
            listView1.Items.Clear();
            listView1.Update();
            RolesView.Items.Clear();
            RolesView.Update();
            this.UpdateName(); 
           
        }

        private void listadoRolToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmCliente.ListadoCliente dialog = new FrbaOfertas.AbmCliente.ListadoCliente(new ListadoNormal());
            dialog.ShowDialog(this);
        }

        private void listadoRolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmRol.ListadoRol dialog = new FrbaOfertas.AbmRol.ListadoRol(new ListadoNormal());
            dialog.ShowDialog(this);
        }

        private void bajaRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmRol.ListadoRol dialog = new FrbaOfertas.AbmRol.ListadoRol(new ListadoBaja(new RolHandler()));
            dialog.ShowDialog(this);
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrbaOfertas.ConectorDB.FuncionesRol.ObtenerEstadoRol(2))
            {
                FrbaOfertas.AbmCliente.AltaCliente dialog = new FrbaOfertas.AbmCliente.AltaCliente(new Modelo.GuardarDB.AbmAltaGuardar());
                dialog.ShowDialog(this);
            }
            else MessageBox.Show("El Rol cliente se encuentra dado de baja, no esta permitido dar de alta clientes", "Error alta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
        }

        private void bajaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmCliente.ListadoCliente dialog = new FrbaOfertas.AbmCliente.ListadoCliente(new ListadoBaja(new ClienteHandler()));
            dialog.ShowDialog(this);
        }

        private void listadoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmCliente.ListadoCliente dialog = new FrbaOfertas.AbmCliente.ListadoCliente(new ListadoModificar(new ClienteHandler()));
            dialog.ShowDialog(this);
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrbaOfertas.DatosPersonales.Usuarios.DatosPersonalesUsuario dialog = new FrbaOfertas.DatosPersonales.Usuarios.DatosPersonalesUsuario();
            dialog.ShowDialog(this);
        }

        private void altaProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrbaOfertas.ConectorDB.FuncionesRol.ObtenerEstadoRol(3))
            {
                FrbaOfertas.AbmProveedor.AltaProveedor dialog = new FrbaOfertas.AbmProveedor.AltaProveedor(new Modelo.GuardarDB.AbmAltaGuardar());
                dialog.ShowDialog(this);
            }
            else MessageBox.Show("El Rol proveedor se encuentra dado de baja, no esta permitido dar de alta proveedores", "Error alta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
        }

        private void listadoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmProveedor.ListadoProveedor dialog = new FrbaOfertas.AbmProveedor.ListadoProveedor(new ListadoNormal());
            dialog.ShowDialog(this);
        }

        private void listadoProveedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmProveedor.ListadoProveedor dialog = new FrbaOfertas.AbmProveedor.ListadoProveedor(new ListadoModificar(new ProveedorHandle()));
            dialog.ShowDialog(this);
        }

        private void bajaProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmProveedor.ListadoProveedor dialog = new FrbaOfertas.AbmProveedor.ListadoProveedor(new ListadoBaja(new ProveedorHandle()));
            dialog.ShowDialog(this);
        }

        private void LISTADOESTADISTICO_Click(object sender, EventArgs e)
        {
            FrbaOfertas.ListadoEstadistico.ListadoEstadistico dialog = new FrbaOfertas.ListadoEstadistico.ListadoEstadistico();
            dialog.ShowDialog(this);
        }

        private void CARGADECREDITO_Click(object sender, EventArgs e)
        {
            if (FrbaOfertas.ConectorDB.FuncionesCliente.ConseguirMontoActual() != -1)
            {
                FrbaOfertas.CargaCredito.CargarCredito dialog = new FrbaOfertas.CargaCredito.CargarCredito();
                dialog.ShowDialog(this);
            }
            else{
                List<String> roles = FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id);
                if (roles.Contains("Administrador General")) { 
                FrbaOfertas.CargaCredito.CargarCredito dialogCargas = new FrbaOfertas.CargaCredito.CargarCredito();
                MessageBox.Show("Elija el cliente sobre el que desea realizar la carga", "CARGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrbaOfertas.AbmCliente.ListadoCliente dialog = new FrbaOfertas.AbmCliente.ListadoCliente(new ListadoSeleccion(new ClienteHandler(),dialogCargas)) ;
                dialog.ShowDialog(this);
                dialog.Close();
                FrbaOfertas.Utils.Validador.resetUser();
                }else
                MessageBox.Show("El rol actual no puede cargar credito, no posee un monto", "ERROR CARGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CONFECCIÓNYPUBLICACIONDEOFERTAS_Click(object sender, EventArgs e)
        {
            List<String> roles = FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id);
            if (roles.Contains("Administrador General"))
            {

                FrbaOfertas.CrearOferta.CrearOfertaAdministrador dialog = new FrbaOfertas.CrearOferta.CrearOfertaAdministrador();
                dialog.ShowDialog(this);
            }
            else if (roles.Contains("Proveedor"))
            {
                FrbaOfertas.CrearOferta.CrearOfertaProveedor dialog = new FrbaOfertas.CrearOferta.CrearOfertaProveedor();
                dialog.ShowDialog(this);

            }
            else MessageBox.Show("Su rol no puede acceder a esta funcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void COMPRAROFERTA_Click(object sender, EventArgs e)
        {
            if (FrbaOfertas.ConectorDB.FuncionesCliente.ConseguirMontoActual() != -1)
            {
                FrbaOfertas.ComprarOferta.ComprarOferta dialog = new FrbaOfertas.ComprarOferta.ComprarOferta();
                dialog.ShowDialog(this);
            }
            else
            {
                List<String> roles = FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id);
                if (roles.Contains("Administrador General"))
                {
                    FrbaOfertas.ComprarOferta.ComprarOferta dialogCompras = new FrbaOfertas.ComprarOferta.ComprarOferta();
                    MessageBox.Show("Elija el cliente sobre el que desea realizar la compra", "COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrbaOfertas.AbmCliente.ListadoCliente dialog = new FrbaOfertas.AbmCliente.ListadoCliente(new ListadoSeleccion(new ClienteHandler(), dialogCompras));
                    dialog.ShowDialog(this);
                    FrbaOfertas.Utils.Validador.resetUser();
                }
                else
                    MessageBox.Show("El rol actual no puede crear ofertas", "ERROR CONFECCION OFERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FACTURACIONPROVEDOR_Click(object sender, EventArgs e)
        {

            List<String> roles = FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id);
            if (roles.Contains("Administrador General"))
            {
                FrbaOfertas.Facturar.FacturarProveedor dialog = new FrbaOfertas.Facturar.FacturarProveedor();
                //FrbaOfertas.F .CrearOfertaAdministrador dialog = new FrbaOfertas.CrearOferta.CrearOfertaAdministrador();
                dialog.ShowDialog(this);

            }
            else MessageBox.Show("Su rol no puede acceder a esta funcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ENTREGACONSUMODEOFERTA_Click(object sender, EventArgs e)
        {
            List<String> roles = FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id);
            if (roles.Contains("Proveedor"))
            {
                FrbaOfertas.EntregarOferta.EntregarOferta dialog = new FrbaOfertas.EntregarOferta.EntregarOferta();
                //FrbaOfertas.F .CrearOfertaAdministrador dialog = new FrbaOfertas.CrearOferta.CrearOfertaAdministrador();
                dialog.ShowDialog(this);
            }
            else
            {
                if (roles.Contains("Administrador General"))
                {
                    FrbaOfertas.EntregarOferta.EntregarOferta dialogEntrega = new FrbaOfertas.EntregarOferta.EntregarOferta();
                    MessageBox.Show("Elija el proveedor sobre el que desea realizar la entrega", "CONSUMO OFERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrbaOfertas.AbmProveedor.ListadoProveedor dialog = new FrbaOfertas.AbmProveedor.ListadoProveedor(new ListadoSeleccion(new ProveedorHandle(), dialogEntrega));
                    dialog.ShowDialog(this);
                    FrbaOfertas.Utils.Validador.resetUser();
                }
                else
                    MessageBox.Show("El rol actual no puede canjear Cupones", "ERROR CONSUMO COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmCliente.ModificacionCliente dialog = new FrbaOfertas.AbmCliente.ModificacionCliente(FrbaOfertas.ConectorDB.FuncionesCliente.Get_Cliente_id(FrbaOfertas.Modelo.Usuario.id));
            dialog.ShowDialog();
        }

        private void proveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrbaOfertas.AbmProveedor.ModificacionProveedor dialog = new FrbaOfertas.AbmProveedor.ModificacionProveedor(FrbaOfertas.ConectorDB.FuncionesProveedor.Get_Proveedor_id(FrbaOfertas.Modelo.Usuario.id));
            dialog.ShowDialog();
        }

        private void ABMDEROL_Click(object sender, EventArgs e)
        {

        }

    }
}
