using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Application.Interfaces.IRepositories
{
    public interface IRoomRepository
    {
        void Create(Room room);
        Room Get(string name);
        List<Room> GetAll();
        List<Room> GetByCategory(string category);
    }
}
