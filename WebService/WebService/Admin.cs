using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class Admin : Class1
    {
        private int accesssLevel;

        public Admin(string login, string password, string email, int level) : base(login, password, email)
        {
            accesssLevel = level;
        }
    }
}
