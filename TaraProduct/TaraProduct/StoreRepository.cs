using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace TaraProduct
{
    class StoreRepository:IStoreRepository
    {
        public List<product> products = new List<product>();
        public string JsonPath => throw new NotImplementedException();
        public void Delete(product product)
        {
            products.Remove(product);
        }
        public void insert(product product)
        {
            products.Add(product);
        }
        public void insert(string name, double price)
        {
            throw new NotImplementedException();
        }
        public void Save(string filePath, IEnumerable<product> records)
        {
            var products = new List<product>() 
           
            
            {
               //new product(){price=3000,productName="Tv" ,StoreName="LG",City="Flower",Adress="Kalmar"},
               //new product(){ price = 4000,  productName = "Computer",   StoreName = "Samsung",  City = "Storå",  Adress = "Göteborg", }
            

        };
            //var path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            //var programPath = path.Combine(path, " TaraProduct ");
            //var jsonPath = path.Combine(programPath, "products.json");

        }
        public IEnumerable<product> GetAll()
        {
            throw new NotImplementedException();
        }

        public product GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(string name, double price)
        {
            throw new NotImplementedException();
        }

        public void Update(product product)
        {
            throw new NotImplementedException();
        }

        public void SearchProduct(string product)
        {
            throw new NotImplementedException();
        }

        public void Load(product product)
        {
            throw new NotImplementedException();
        }
    }
}
