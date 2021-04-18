using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyFinal.DATOS
{
    public class CuentaPerfil
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public CuentaPerfil() { 
        }
        public CuentaPerfil(string nombre, string correo) {
            this.Nombre = nombre;
            this.Correo = correo;
        }
    }

}
