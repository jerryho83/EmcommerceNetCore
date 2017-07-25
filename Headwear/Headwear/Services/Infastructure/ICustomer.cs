using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headwear.Models;
namespace Headwear.Services.Infastructure
{
    interface ICustomer
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        void Save();
    }
}
