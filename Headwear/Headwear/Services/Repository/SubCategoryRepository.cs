using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headwear.DataContext;
using Headwear.Models;
using Headwear.Services.Infastructure;
namespace Headwear.Services.Repository
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly HeadwearContext _db;
        public SubCategoryRepository(HeadwearContext db)
        {
            this._db = db;
        }
        public int Count()
        {
            return _db.SubCategory.Count();
        }

        public void Delete(int id)
        {
            var subCategory = GetById(id);
            if (subCategory != null)
            {
                _db.Remove(subCategory);
            }
        }

        public IEnumerable<SubCategory> GetAll()
        {
            return _db.SubCategory.Select(s => s);
        }

        public SubCategory GetById(int id)
        {
            return _db.SubCategory.FirstOrDefault(s => s.SubCategoryId == id);
        }

        public void Insert(SubCategory subCategory)
        {
            _db.SubCategory.Add(subCategory);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(SubCategory subCategory)
        {
            _db.Update(subCategory);
        }
    }
}
