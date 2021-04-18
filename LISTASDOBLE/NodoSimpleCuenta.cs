using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisneyFinal.DATOS;
namespace DisneyFinal.LISTADOBLE
{
    public class NodoSimpleCuenta
    {
        public CUENTA_PRINCIPAL Dato;
        public NodoSimpleCuenta Siguiente;
        public NodoSimpleCuenta() {
            Siguiente = null;
            Dato = null;
        }
        public NodoSimpleCuenta(string Correo, string Contraseña)
        {
            Siguiente = null;
            Dato.Correo = Correo;
            Dato.Contraseña = Contraseña;
        }
    }
}
