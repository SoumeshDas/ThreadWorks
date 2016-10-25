using AsyncAndAwaitExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwaitExample.Implementation
{
    public class EntityBlobContainer<T,S> : IBlobContainer<T,S> where T : ICollection<S>
    {
        private T _items;
        private S _item;

        EntityBlobContainer( T t,S s)
        {
            _items = t;
            _item = s;
        }

        public void Add()
        {
            _items.Add(_item);
        }
        
    }
}
