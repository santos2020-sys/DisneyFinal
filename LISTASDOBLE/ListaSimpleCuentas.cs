using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DisneyFinal.DATOS;
namespace DisneyFinal.LISTADOBLE
{

    public class ListaSimpleCuentas
    {
        
        
        NodoSimpleCuenta Primero;
        string Lectura;
        public ListaSimpleCuentas() {
            Primero = null;
        }
        public void Crear_Cuentas(string Correo, string Contraseña) {
            NodoSimpleCuenta nuevoDato = new NodoSimpleCuenta();
            
            
                if (Correo == "" & Contraseña == "")
                {
                }
                else
                {
                    nuevoDato.Dato = new CUENTA_PRINCIPAL(Correo, Contraseña);
                    nuevoDato.Siguiente = Primero;
                    Primero = nuevoDato;
                }
            
        }
        public void Cargar_Datos() {
            
            /*var archivo = new StreamReader(File.OpenRead(@"C:\Temp\CUENTA_PERFIL.txt"));

            while (!archivo.EndOfStream)
            {
                var Line = archivo.ReadLine();
                var Datos = Line.Split(',');
                foreach (var Lista in Datos) {
                    Crear_Cuentas(Datos[0], Datos[1]);
                }
            }*/
            string[] Lineas = File.ReadAllLines(@"C:\Temp\CUENTA_PERFIL.txt");
            foreach (var Linea in Lineas) {
                var valores = Linea.Split(',');
                Crear_Cuentas(valores[0], valores[0]);
            }
        }
        public void DUPLICADO(string Correo) { 
            
        }
        public bool AUTENTICAR(string correo, string contraseña) {
            NodoSimpleCuenta autenticar = new NodoSimpleCuenta();
            autenticar = Primero;
            
            while (autenticar != null) {
                if (autenticar.Dato.Correo == correo && autenticar.Dato.Contraseña == contraseña)
                {
                    
                    return true;
                }
                autenticar = autenticar.Siguiente;
            }
            return false;
        }
        public void Datos_Modificados() {
            NodoSimpleCuenta MostrarDatos = new NodoSimpleCuenta();
            string mail = "";
            string password = "";
            MostrarDatos = Primero;
            StreamWriter Archivo = new StreamWriter(@"C:\Temp\CUENTA_PERFIL.txt");
            while (MostrarDatos != null) {
                mail = MostrarDatos.Dato.Correo;
                password = MostrarDatos.Dato.Contraseña;
                Archivo.WriteLine(mail + "," + password);
                MostrarDatos = MostrarDatos.Siguiente;
            }
            Archivo.Close();

        }
        public void Mostrar_Cuentas() {
            NodoSimpleCuenta MostrarDatos = new NodoSimpleCuenta();
            while(MostrarDatos != null)
            {
                MostrarDatos = Primero;
                Console.WriteLine(MostrarDatos.Dato.Correo + "" + MostrarDatos.Dato.Contraseña);
                MostrarDatos = MostrarDatos.Siguiente;
            }
        }
        public bool BuscarDatos(string correo) {
            NodoSimpleCuenta BuscarDatos = new NodoSimpleCuenta();
            BuscarDatos = Primero;
            while(BuscarDatos != null)
            {
                if (BuscarDatos.Dato.Correo == correo) {
                    return false;
                }
                BuscarDatos = BuscarDatos.Siguiente;
            }
            return true;
        }
    }
}
