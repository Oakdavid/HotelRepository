using Hotel.Core.Application.Interfaces.IRepositories;
using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infreastructure.Persistence.Implementations.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Create(Category category)
        {
            throw new NotImplementedException();
        }

        public Category Get(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
