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

            object obj = new object();
            //downcast user->registereduser
            //equals сравнение(тип ссылка и тип значение), hash code(словарь), gettype(возвращает тип объекта),tostring(переводит лююой объект в строку,чтобы выводить на консоль)
            //безопасное приведение типов: var newObject = oldObject as NewType;
            //клюючевое IS NewType newObject; if(oldObject is NewType) newObject = (NewType)oldObject; else {...//do smth}/// if(ildObject is NewType) {var newObject =(NewType)oldObject;...}-if(oldObject is NewType newObject){..}

            Class1 regUser = paul as Class1;

            VipUser vip = kate as VipUser;

            foreach (var user in users)
                user.PrintInfo();

            Console.ReadKey();
        }
    }
}
