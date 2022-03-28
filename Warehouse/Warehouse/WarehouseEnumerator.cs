using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class WarehouseEnumerator : IEnumerator<Product>
    {
        WareHouse warehouse;
        int currentIndex;
        public Product Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public WarehouseEnumerator(WareHouse warehouse)
        {
            this.
        }
        public void Dispose() {}

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
