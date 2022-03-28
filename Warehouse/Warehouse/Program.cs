using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var warehouse = new WareHouse(10);

            var tv = new Product(1, "lejfv", 40800);
            warehouse.Add(tv);

            var freezer = new Product(2, "arg", 34763);
            warehouse.Add(freezer);

            var oven = new Product(3, "esyg",51651 );
            warehouse.Add(oven);

            foreach (var product in warehouse)
                PrintProduct(product);

            Console.ReadKey();
        }

        static void PrintProduct(Product p)
        {
            Console.WriteLine($"{p.Name}. Цена: {p.Price: F2}руб. Артикул {p.ID}.");
        }
    }
}
