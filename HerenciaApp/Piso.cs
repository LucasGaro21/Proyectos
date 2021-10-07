using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaApp
{
    class Piso : Inmueble
    {
        //Atributos
        int nroPiso;


        public int NroPiso { get => nroPiso; set => nroPiso = value; }
    }
}
