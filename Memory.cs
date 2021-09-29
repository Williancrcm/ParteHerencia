using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTarea
{
    class Memory:Product 
    {
        //propiedades de la clase hija
       public int frecuency { get; set; }
       
       public string mathchedPair { get; set; }

       public string capacity { get; set; }


        //metodo

        public string GetMemory()
        {
            return "Memoria de alta capacidad";
        }
    }
}
