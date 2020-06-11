﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaraProduct
{
    public interface IManufacturarRepository
    {
        string JsonPath { get; }
        IEnumerable<product> GetAll();
        product GetById(int Id);
        void Insert(string name, double price);
        void Update(product product);
        void Delete(product product);
        void SearchProduct(string product);
        void Load(product product);
        void Save(string filePath, IEnumerable<product> records);
    }
}
