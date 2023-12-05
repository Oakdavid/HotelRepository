using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Application.Interfaces.IRepositories
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
        Customer Get(string email);
        Customer GetByTag(string tag);
        List<Customer> GetAll();
    }
}
