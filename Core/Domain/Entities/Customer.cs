using Hotel.Core.Domain.Auditables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string UserEmail { get; set; } = default!;
        public string TagNumber { get; set; } = default!;
        public double Wallet { get; set; } = default!;
    }
}
