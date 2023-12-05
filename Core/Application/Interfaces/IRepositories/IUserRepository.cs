using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Application.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        void Create(User user);
        User Get(string email);
        List<User> GetAll();
    }
}
