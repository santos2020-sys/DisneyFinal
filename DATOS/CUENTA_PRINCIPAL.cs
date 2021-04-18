using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyFinal.DATOS
{
    public class CUENTA_PRINCIPAL
    {
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public CUENTA_PRINCIPAL(string correo, string contraseña) {
            this.Correo = correo;
            this.Contraseña = contraseña;
        }
    }
}
