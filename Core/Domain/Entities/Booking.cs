using Hotel.Core.Domain.Auditables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Domain.Entities
{
    public class Booking : BaseEntity
    {
        public string RefNumber { get; set; } = default!;
        public string UserEmail { get; set; } = default!;
        public string RoomName { get; set; } = default!;
    }
}
