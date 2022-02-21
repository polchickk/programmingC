using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
   public class Class1 : User
    {
        public string Email;
        protected string password;

        public Class1(string login, string password, string email) : base(login)
        {
            Email = email;
            this.password = password;
        }

        public override void PrintInfo()
        {
            //base.PrintInfo();
            Console.WriteLine($"Пользователь {Login}. E-mail: {Email}");
        }
    }
}
