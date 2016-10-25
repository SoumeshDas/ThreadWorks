using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwaitExample.Abstraction
{
    public interface IBlobContainer<T,S> where T : ICollection<S> 
    {
        void Add();
    }
}
