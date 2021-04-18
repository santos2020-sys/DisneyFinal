using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisneyFinal.VISTAS;
using DisneyFinal.LISTADOBLE;
namespace DisneyFinal
{
    public partial class Form1 : Form
    {
        ListaSimpleCuentas lista_cuentas = new ListaSimpleCuentas();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LOGIN Log = new LOGIN();
            Log.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            REGISTRO frmRegistro = new REGISTRO();
            frmRegistro.Show();
        }
    }
}
