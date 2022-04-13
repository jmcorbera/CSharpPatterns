using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPattern.Facade.Entities
{
    public class CreditData
    {
        public int id { get; set; }
      
        public decimal amount { get; set; }

        public int fees { get; set; }

        public decimal feeAmount { get; set; }
   
    }
}
