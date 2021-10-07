using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaApp
{
    class Local : Inmueble
    {
        //Atributos
        int nroVentanas;

        public int NroVentanas { get => nroVentanas; set => nroVentanas = value; }

    }
}
