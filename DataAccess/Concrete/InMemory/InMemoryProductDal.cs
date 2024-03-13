using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {

            new Product {ProductID=1,CategoryID=1,ProductName="Bardak ",UnitPrice=15,UnitsInStock=15 },
            new Product {ProductID=2,CategoryID=1,ProductName="klavye ",UnitPrice=500,UnitsInStock=15 },
            new Product {ProductID=3,CategoryID=2,ProductName="Kamera ",UnitPrice=1500,UnitsInStock=3 },
            new Product {ProductID=4,CategoryID=2,ProductName="Telefon ",UnitPrice=150,UnitsInStock=2 },
            new Product {ProductID=5,CategoryID=2,ProductName="Fare ",UnitPrice=85,UnitsInStock=15 },
            new Product {ProductID=6,CategoryID=2,ProductName="Flash Bellek ",UnitPrice=800,UnitsInStock=5}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        
        
        }

        public void Delete(Product product)
        {
            Product productToDelete=null;
            productToDelete = _products.SingleOrDefault(p=>p.ProductID==product.ProductID);
                }

        public List<Product> GetAll()
        {
            return _products;
                
                }

        public List<Product> GetByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
                
                }

        public void Update(Product product)
        {
            Product productToUpdate = null;
            productToUpdate= _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName= product.ProductName;
            productToUpdate.CategoryID= product.CategoryID;
            productToUpdate.ProductID= product.ProductID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock=product.UnitsInStock;

        }
    }
}
