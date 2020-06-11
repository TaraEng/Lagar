using System;
using System.Collections.Generic;
using System.Text;

namespace TaraProduct
{
    public class Manufacturar
    {

        public double price { get; set; }
        public string productName { get; set; }
        public string StoreName { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public Manufacturar manufacture { get; set; }
        public List<product> products { get; set; }

        public Manufacturar()
        { }
        public Manufacturar(string name, int id, List<product> products)

        {
            price = price;
           productName=  productName;
            StoreName = StoreName;
            City = City;
            Adress = Adress;
            Manufacturar manufacturar = manufacture;
           
           
        }

   
    }
}

