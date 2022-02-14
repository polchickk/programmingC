using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    class Program
    {
        static void Main(string[] args)
        {
            var george = new User();
            george.Login = "George032";

            var kate = new User("Kate");

            var john = new Class1("John","qwerty","john@yandex.ru");

            var paul = new VipUser("Paul123", "456789", "paul@gmail.com", 2400001267907643);

            var admin = new Admin("Sergey", "eryvgeu", "sergey@mail,ru", 2);

            var users = new[] { george, kate, john,paul };

            foreach (var user in users)
                user.PrintInfo();

            Console.ReadKey();
        }
    }
}
