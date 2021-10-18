﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //bellekte bir ürün listesi oluştu(Veri varmış gibi davranıyoruz)
        public InMemoryProductDal()
        {
            //Oracle, Sql Server, Postgres, MongoDb
            // yeni ürün listesi
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare", UnitPrice=85, UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //_products.Remove(product); - bu şekilde silinmez.(referans)
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); //Linq olmazsa listeyi dolaşmak gerekirdi, şartı sağlayanı bulmak için
            _products.Remove(product);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => product.ProductId == p.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
