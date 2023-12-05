using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Application.Dtos
{
    public class RoomDto
    {
        public string CategoryName { get; set; } = default!;
        public string Name { get; set; } = default!;
        public bool IsAvailable { get; set; } = default!;
    }
    public class CreateRoomRequestModel
    {
        public string CategoryName { get; set; } = default!;
        public string Name { get; set; } = default!;
    }
}
