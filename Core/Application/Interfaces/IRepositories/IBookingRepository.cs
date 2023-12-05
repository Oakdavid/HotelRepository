using Hotel.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Application.Interfaces.IRepositories
{
    public interface IBookingRepository
    {
        void Create(Booking booking);
        Booking Get(string refNumber);
        Booking GetByEmail(string email);
        List<Booking> GetAll(); 
    }
}
