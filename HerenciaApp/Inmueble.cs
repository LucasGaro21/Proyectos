using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaApp
{
    class Inmueble
    {
        //Atributos
        
        int superficie;
        int antiguedad;
        double precioBase;
        string direccion;

       
        public int Superficie { get => superficie; set => superficie = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Inmueble (int superficie,int antiguedad, double precioBase, string direccion)
        {
            
            this.superficie = superficie;
            this.antiguedad = antiguedad;
            this.precioBase = precioBase;
            this.direccion = direccion;
 

        }
        public Inmueble()
        {

        }
    }

}
