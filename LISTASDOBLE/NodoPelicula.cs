using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisneyFinal.DATOS;
namespace DisneyFinal.LISTASDOBLE
{
    public class NodoPelicula
    {
        public PELICULA Dato;
        public NodoPelicula Siguiente;

        public NodoPelicula()
        {
            Siguiente = null;
            Dato = null;
        }
        public NodoPelicula(string Nombre_Pelicula, string Categoria) {
            Siguiente = null;
            Dato.Nombre_Pelicula = Nombre_Pelicula;
            Dato.Categoria = Categoria;
        }
        public NodoPelicula(string Nombre_Pelicula,string Categoria,string Perfil)
        {
            Siguiente = null;
            Dato.Nombre_Pelicula = Nombre_Pelicula;
            Dato.Categoria = Categoria;
            Dato.Perfil = Perfil;
        }
    }
}
