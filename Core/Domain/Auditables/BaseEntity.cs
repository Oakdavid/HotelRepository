using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Domain.Auditables
{
    public abstract class BaseEntity
    {
        public string Id {get;set;} = Guid.NewGuid().ToString().Substring(0,4);
        public bool IsDeleted { get; set; } = false;
    }
}
