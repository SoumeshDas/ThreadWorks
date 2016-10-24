using AsyncAndAwaitExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwaitExample.Implementation
{
    class INStockPrice : IPrice
    {
        public decimal NegotiatePrice()
        {
            throw new NotImplementedException();
        }

        public int MyProperty { get; set; }

    }
}
