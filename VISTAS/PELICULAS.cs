using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisneyFinal.LISTASDOBLE;
namespace DisneyFinal.VISTAS
{
    public partial class PELICULAS : Form
    {
        public ListaPelicula Listado_Peliculas = new ListaPelicula();
        public PELICULAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Holis","holis");
            dataGridView2.Columns.Add("Holis", "holis");
            dataGridView3.Columns.Add("Holis", "holis");
            dataGridView4.Columns.Add("Holis", "holis");
            dataGridView5.Columns.Add("Holis", "holis");
            dataGridView6.Columns.Add("Holis", "holis");
            string txt = "";
            txt = comboBox1.Text;
            dataGridView1.Rows.Add(Listado_Peliculas.MostrarPeliculas());
            
        }
        public void CargarCategorias()
        {
            comboBox1.Items.Add("DISNEY");
            comboBox1.Items.Add("PIXAR");
            comboBox1.Items.Add("MARVEL");
            comboBox1.Items.Add("STAR WARS");
            comboBox1.Items.Add("NATIONAL");
        }

    }
}
