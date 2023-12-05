using Hotel.Core.Application.Interfaces.IRepositories;
using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infreastructure.Persistence.Implementations.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        public void Create(Booking booking)
        {
            throw new NotImplementedException();
        }

        public Booking Get(string refNumber)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAll()
        {
            throw new NotImplementedException();
        }

        public Booking GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
