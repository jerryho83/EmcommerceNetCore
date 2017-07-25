using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headwear.Models;
namespace Headwear.Services.Infastructure
{
    interface IPicture
    {
        IEnumerable<Picture> GetAll();
        Picture GetById(int id);
        void Insert(Picture picture);
        void Update(Picture picture);
        void Delete(int id);
        void Save();
    }
}
