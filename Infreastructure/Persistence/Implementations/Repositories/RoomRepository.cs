using Hotel.Core.Application.Interfaces.IRepositories;
using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infreastructure.Persistence.Implementations.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        public void Create(Room room)
        {
            throw new NotImplementedException();
        }

        public Room Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Room> GetByCategory(string category)
        {
            throw new NotImplementedException();
        }
    }
}
