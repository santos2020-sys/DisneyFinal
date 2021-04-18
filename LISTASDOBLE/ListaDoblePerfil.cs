using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DisneyFinal.DATOS;
namespace DisneyFinal.LISTADOBLE
{
    public class ListaDoblePerfil
    {
        public NodoDoblePerfil pimero;
        public NodoDoblePerfil ultimo;
       
        public ListaDoblePerfil() {
            pimero = null;
            ultimo = null;
        }

        public Boolean PerfilVacio() {
            return pimero == null;
        }
        public void Crear_Perfil(string Nombre, string Correo) {
            if (!PerfilVacio())
            {
                ultimo = new NodoDoblePerfil(new CuentaPerfil(Nombre, Correo), null, ultimo);
                ultimo.Anterior.Siguiente = ultimo;
            }
            else {
                pimero = ultimo = new NodoDoblePerfil(new CuentaPerfil(Nombre, Correo));
            }
        }
        /*public void Datos_Modificados() {
            NodoDoblePerfil MostrarDatos = new NodoDoblePerfil();
            string Nombre = "";
            string Correo = "";
            MostrarDatos = pimero;
            StreamWriter Archivo = new StreamWriter(@"C:\Temp\DATOS_CUENTA.txt");
            while (MostrarDatos != null)
            {
                Nombre = MostrarDatos.DatoPerfil.Nombre;
                Correo = MostrarDatos.DatoPerfil.Correo;
                Archivo.WriteLine(Nombre + "," + Correo);
                MostrarDatos = MostrarDatos.Siguiente;
            }
            Archivo.Close();
        }*/
        public string Mostrar_Perfiles() {
            /*NodoDoblePerfil Mostrar = new NodoDoblePerfil();
            Mostrar = pimero;
            return Mostrar.DatoPerfil.Nombre;
            Mostrar = Mostrar.Siguiente;*/
            NodoDoblePerfil auxiliar = pimero;
            string Perfil = "";
            while (auxiliar != null) {
                Perfil = auxiliar.DatoPerfil.Nombre;
                auxiliar = auxiliar.Siguiente;
            }
                
                return Perfil;
        }
    }
}
