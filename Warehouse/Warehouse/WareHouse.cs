using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class WareHouse:IEnumerable<Product>
    {
        private Product[] storage;
        public int Count { get; private set; }
        public int Capacity => storage.Length;
        //{ 
        //    get 
        //    { 
        //        return storage.Length; 
        //    }
        //}

        public WareHouse(int capacity)
        {
            storage = new Product[capacity];
            Count = 0;
        }

        public bool Add(Product product)
        {
            if (Count == Capacity) return false;

            storage[Count++] = product;
            return true;
        }
    }
}
