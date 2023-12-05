using Hotel.Core.Application.Interfaces.IRepositories;
using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infreastructure.Persistence.Implementations.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Get(string email)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetByTag(string tag)
        {
            throw new NotImplementedException();
        }
    }
}
