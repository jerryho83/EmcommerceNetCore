using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headwear.Models;
namespace Headwear.Services.Infastructure
{
    interface ICategory
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        void Insert(Category category);
        void Update(Category category);
        void Delete(int id);
        int Count();
        void Save();
    }
}
