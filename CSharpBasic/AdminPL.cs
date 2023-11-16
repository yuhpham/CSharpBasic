using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class AdminPL
    {
        public void Login() 
        {
            Console.WriteLine("Admin -- Login");
            Console.WriteLine("Email: "); String email = Console.ReadLine();
            Console.WriteLine("Password: "); string password = Console.ReadLine();

            AdminPL adminPL = new AdminPL();

            bool isDone = adminPL.Login(email,password)
                {



            }
        }

    }
}
