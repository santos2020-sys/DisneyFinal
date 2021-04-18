using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisneyFinal.DATOS;
namespace DisneyFinal.LISTASDOBLE
{
    public class ListaPelicula
    {
        NodoPelicula pelicula;
        string Lectura;
        public ListaPelicula() {
            pelicula = null;
        }
        public void Crear_Peliculas(string Nombre, string Categoria)
        {
            NodoPelicula nuevoDato = new NodoPelicula();

            if (Nombre == "" & Categoria == "")
            {
            }
            else
            {
                nuevoDato.Dato = new PELICULA(Nombre,Categoria);
                nuevoDato.Siguiente = pelicula;
                pelicula = nuevoDato;
            }

        }
        public string MostrarPeliculas() {
            NodoPelicula nuevoDato = new NodoPelicula();
            string tv = nuevoDato.Dato.Nombre_Pelicula;
                nuevoDato = pelicula;
                nuevoDato = nuevoDato.Siguiente;
            return tv;
            
        }
       // public string MostrarPeliculas_Por_Categoria(string categoria) { }
    }
}
