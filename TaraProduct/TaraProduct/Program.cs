
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

namespace TaraProduct.Files
{
   public class JasonFileHandler
   // class Program
    {
            static void Main(string[] args)
        {
            // List<product> product = new List<product>();
            var products = new List<product>()
                   {
              new product() { price = 3000,productName = "Tv", StoreName = "LG", City = "Flower", Adress = "Kalmar,"},
               new product(){ price = 4000, productName = "Computer", StoreName = "Samsung", City = "Storå", Adress = "Göteborg", },
               new product(){ price = 5000, productName = "Oven", StoreName = "Medieamarkt", City = "angered", Adress = "Kalmar", },
               new product() { price = 200, productName = "Phoncover", StoreName = "Smart", City = "Ebc", Adress = "kuskap", },
               new product() { price = 10000, productName = "Frez", StoreName = "Elegatan", City = "angered", Adress = "Göteborg", },
               new product() { price = 790, productName = "Kyboard", StoreName = "Apple", City = "MM", Adress = "Stockhol", },
               new product() {  price = 456,     productName = "Broom",   StoreName = "Tara", City = "kongelv",  Adress = "Göteborg", },
               new product(){ price = 14000, productName = "Iphon8", StoreName = "Elegatan",City = "ACR",Adress = "Kalmar",
                 Store = new List<string>()
                {
                    "Lg","Samsungm","Smart","Apple"
                }
              }
            };
           

            List<product> product = new List<product>();
            Manufacturar manufacturar1 = new Manufacturar("LG", 3, product);
            ProductRepository p = new ProductRepository();
            p.Delete(product[0]);

            FileStream f = new FileStream(@"C:\Users\i\source\repos\TaraProduct\TaraProduct\bin\Debug\netcoreapp3.1 .txt", FileMode.OpenOrCreate);
            Console.WriteLine("Enter the text:");
            String s = Console.ReadLine();
            byte[] ascil = Encoding.ASCII.GetBytes(s);
            foreach (byte item in ascil)
            {
                f.WriteByte(item);
            }

            Console.WriteLine("Data successfully written in file named as jsonfile.txt");
            f.Close();

            var path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            var programPath = Path.Combine(path, " TaraProduct ");

            var jsonPath = Path.Combine(programPath, "Product.json");

            SaveToJson(jsonPath, products);

            var records = LoadJsonProduct<product>(jsonPath);

            foreach (var Product in records)

            {

                Console.WriteLine(Product);

            }
        }
         static IEnumerable<T> LoadJsonProduct<T>(string filePath)
        {

            var jsonString = File.ReadAllText(filePath);
            var records = System.Text.Json.JsonSerializer.Deserialize<List<T>>(jsonString);
            return records;

        }
         static void SaveToJson<T>(string filePath, IEnumerable<T> records)
        {
            var jsonString = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(records);
            File.WriteAllBytes(filePath, jsonString);
            //string strResultJson = JsonConvert.SerializeObject(products);
            //File.WriteAllText(@"Product.json", strResultJson);
            //Console.WriteLine("stored!:");
            //strResultJson = string.Empty;
            //strResultJson = File.ReadAllText(@"Product.json");
            //var resutProduct = JsonConvert.DeserializeObject<product>(strResultJson);
            //Console.WriteLine(resutProduct.ToString());
        }
    }
}


     






