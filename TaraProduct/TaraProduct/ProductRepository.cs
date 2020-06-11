using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Dynamic;
namespace TaraProduct
{
    public class ProductRepository:IProductRepository
    {
        public ProductRepository()
        { }

        public List<product> products = new List<product>();
        //Create product to the list
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
               new product(){price=3000,productName="Tv" ,StoreName="LG",City="Flower",Adress="Kalmar, "},
               new product(){ price = 4000,  productName = "Computer",   StoreName = "Samsung",  City = "Storå",  Adress = "Göteborg", },
               new product() {  price = 5000, productName = "Oven",    StoreName = "Medieamarkt", City = "angered",  Adress = "Kalmar",  },
               new product() {  price = 200,  productName = "Phoncover",   StoreName = "Smart",   City = "Ebc",   Adress = "kuskap", },
               new product() {price = 10000,  productName = "Frez", StoreName = "Elegatan", City = "angered", Adress = "Göteborg", },
               new product() { price = 790, productName = "Kyboard",StoreName = "Apple",City = "MM", Adress = "Stockhol",    },
                new product() {  price = 456,     productName = "Broom",   StoreName = "Tara", City = "kongelv",  Adress = "Göteborg", },
               new product(){ price = 14000, productName = "Iphon8", StoreName = "Elegatan",City = "ACR",Adress = "Kalmar",
                Store = new List<string>()
                {
                    "Lg","Samsungm","Smart","Apple"
                }

                  }   
           
            };
            var path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var programPath = Path.Combine(path, "TaraProduct");
            var jsonPath = Path .Combine(programPath, "products.json");
        }


        public IEnumerable<product> GetAll()
        {
            throw new NotImplementedException();
        }

        public product  GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(string name, double price)
        {
            throw new NotImplementedException();
        }

        public void Update(product  product)
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
