using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTarea
{
    class Processor:Product 
    {
        //propiedades de la clase hija
        public double  frecuency { get; set; }

        //metodos
        public string  processor()
        {
            return "procesador de alta velocidad";
        }



    }
}
