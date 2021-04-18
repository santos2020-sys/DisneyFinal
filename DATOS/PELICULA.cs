using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyFinal.DATOS
{
    public class PELICULA
    {
        public string Nombre_Pelicula { get; set; }
        public string Categoria { get; set; }
        public string Perfil { get; set; }
        public PELICULA(string nombre_pelicula, string categoria) {
            this.Nombre_Pelicula = nombre_pelicula;
            this.Categoria = categoria;
        }
        /*public PELICULA(string nombre_pelicula, string categoria, string perfil) {
            this.Nombre_Pelicula = nombre_pelicula;
            this.Categoria = categoria;
            this.Perfil = perfil;
        }*/

    }
}
