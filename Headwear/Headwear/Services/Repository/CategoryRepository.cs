using Headwear.Services.Infastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headwear.DataContext;
using Headwear.Models;

namespace Headwear.Services.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly HeadwearContext _db;
        public CategoryRepository(HeadwearContext db)
        {
            this._db = db;
        }

        public int Count()
        {
            return _db.Category.Count();
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            if (category != null)
            {
                _db.Remove(category);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Category.Select(c => c);
        }

        public Category GetById(int id)
        {
            return _db.Category.FirstOrDefault(c => c.CategoryId == id);
        }

        public void Insert(Category category)
        {
            _db.Category.Add(category);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            _db.Update(category);
        }
    }
}
