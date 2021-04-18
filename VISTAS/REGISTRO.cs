using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisneyFinal.LISTADOBLE;
namespace DisneyFinal.VISTAS
{
    public partial class REGISTRO : Form
    {
        public static ListaSimpleCuentas lista = new ListaSimpleCuentas();
        public REGISTRO()
        {
            lista.Cargar_Datos();
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (lista.BuscarDatos(txtCorreo.Text) == true)
            {
                lista.Crear_Cuentas(txtCorreo.Text, txtContraseña.Text);
                lista.Datos_Modificados();
                this.Visible = false;
                LOGIN LOG = new LOGIN();
                LOG.Show();
            }
            else {
                MessageBox.Show("Usuario Duplicado");
                txtCorreo.Text = "";
                txtContraseña.Text = "";
            }
            
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 frmPrincipal = new Form1();
            this.Visible = false;
            frmPrincipal.Show();
        }
    }
}
