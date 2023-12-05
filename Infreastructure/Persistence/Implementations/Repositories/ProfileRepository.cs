using Hotel.Core.Application.Interfaces.IRepositories;
using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infreastructure.Persistence.Implementations.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        public void Create(Profile profile)
        {
            throw new NotImplementedException();
        }

        public Profile Get(string email)
        {
            throw new NotImplementedException();
        }

        public List<Profile> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
