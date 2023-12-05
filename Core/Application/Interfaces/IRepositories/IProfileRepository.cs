using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Application.Interfaces.IRepositories
{
    public interface IProfileRepository
    {
        void Create(Profile profile);
        Profile Get(string email);
        List<Profile> GetAll();
    }
}
