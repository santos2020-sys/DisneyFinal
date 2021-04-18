using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisneyFinal.DATOS;
namespace DisneyFinal.LISTADOBLE
{
    public class NodoDoblePerfil
    {
        public CuentaPerfil DatoPerfil;
        public NodoDoblePerfil Siguiente, Anterior;

        public NodoDoblePerfil(CuentaPerfil dato) {
            DatoPerfil = dato;
            Siguiente = null;
            Anterior = null;
        }
        public NodoDoblePerfil(CuentaPerfil dato,NodoDoblePerfil siguiente, NodoDoblePerfil anterior)
        {
            DatoPerfil = dato;
            Siguiente = siguiente;
            Anterior = anterior;
        }
    }
}
