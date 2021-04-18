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
    public partial class PERFILES : Form
    {
        public static string Usuario;
        public ListaDoblePerfil lista_perfiles = new ListaDoblePerfil();
        public PERFILES()
        {
            InitializeComponent();
        }
        public void obtenerUsuario(string usuario)
        {
            Usuario = usuario;
            label1.Text = usuario;
        }

        private void btnCrearFormulario_Click(object sender, EventArgs e)
        {
            btnCrearPerfil.Visible = true;
            txtNombre.Visible = true;
        }

        private void btnCrearPerfil_Click(object sender, EventArgs e)
        {
            lista_perfiles.Crear_Perfil(txtNombre.Text, label1.Text);
            //lista_perfiles.Datos_Modificados();
            btnCrearPerfil.Visible = false;
            txtNombre.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 frmPrincipal = new Form1();
            frmPrincipal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                comboBox1.Items.Add(lista_perfiles.Mostrar_Perfiles());
            
        }
    }
}
