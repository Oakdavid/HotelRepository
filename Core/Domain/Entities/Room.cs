using Hotel.Core.Domain.Auditables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Domain.Entities
{
    public class Room : BaseEntity
    {
        public string CategoryName { get; set; } = default!;
        public string Name { get; set; } = default!;
        public bool IsAvailable { get; set; } = default!;
    }
}
