using System;
using System.Collections.Generic;

namespace TaraProduct
{
    public class product
    {
      
        public double price { get; set; }
        public string productName { get; set; }
        public string StoreName { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public Manufacturar manufacturar { get; set; }
        public List<String> Store { get; set; }
        public List<string> Product { get; set; }

        public override string ToString()
        {
         return string.Format("Product information:\n\tPrice:{0},\n\t productName:{1},\n\tStoreName:{2},\n\tCity:{3},\n\tAdress:{4},\n\t Manufacturar :{5}" +
            "\n\tStore:{6}", price, productName, StoreName, City, Adress, manufacturar, string.Join(",", Store.ToArray()));
          //  return $"Price:{ price}ProductName:{ productName}StoreName:{StoreName} City:{ City} Adress:{ Adress}" +
            //    $" Stor:{ Store}";

        }
 

   
   
   
  
    

   
 
}
}
    
    

