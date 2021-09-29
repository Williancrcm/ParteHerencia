using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTarea
{
    class Product
    {
        //propiedades de la clase padre
        public double productPrice { get; set; }

        public int productID { get; set; }

        public string productBrand { get; set; }

        public string productModel { get; set; }


        public string getInfo()
        {
            return "prueba";
        }

        public string product(string garantia, string estado)
        {
            return "El producto tiene" + garantia + "esta en buen " + estado;
        }




    }
}
