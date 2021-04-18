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
    public partial class LOGIN : Form
    {
        ListaSimpleCuentas lista_Cuenta = new ListaSimpleCuentas();
        public LOGIN()
        {
            lista_Cuenta.Cargar_Datos();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lista_Cuenta.AUTENTICAR(txtCorreo.Text, txtContraseña.Text) == true)
            {
                PERFILES perfil = new PERFILES();
                this.Hide();
                perfil.Show();
                perfil.obtenerUsuario(txtCorreo.Text);
                //MessageBox.Show("BIEVENIDO" + txtCorreo.Text) ;
            }
            else {
                MessageBox.Show("USUARIO/CONTRASEÑA EQUIVOCADOS");
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 frmPricipal = new Form1();
            this.Visible = false;
            frmPricipal.Show();
        }
    }
}
