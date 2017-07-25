using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headwear.Models;
namespace Headwear.Services.Infastructure
{
    interface IOrder
    {
        IEnumerable<Order> GetAll();
        Order GetById(int id);
       // void Insert(Order order);
        void Update(Order order);
        void Delete(int id);
        int Count();
        void Save();
    }
}
