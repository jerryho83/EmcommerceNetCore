using Headwear.Services.Infastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headwear.Models;
using Headwear.DataContext;
namespace Headwear.Services.Repository
{
    public class ProductRository : IProduct
    {
        private readonly HeadwearContext _db;
        public ProductRository(HeadwearContext db)
        {
            this._db = db;
        }
        public int Count()
        {
            return _db.Products.Count();
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _db.Remove(product);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products.Select(p => p);
        }

        public Product GetById(int id)
        {
            return _db.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public void Insert(Product product)
        {
            _db.Products.Add(product);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product product)
        {
            _db.Update(product);
        }
    }
}
