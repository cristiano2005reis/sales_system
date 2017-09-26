using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Operation:Generic
    {
        public long OperationId { get; set; }
        public Int16 OperationNature { get; set; }
        public Decimal Value { get; set; }
        public long Quantity { get; set; }
    }
}
