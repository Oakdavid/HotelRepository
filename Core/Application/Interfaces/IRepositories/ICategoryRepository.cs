using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Application.Interfaces.IRepositories
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        Category Get(string Name);
        List<Category> GetAll();
    }
}
