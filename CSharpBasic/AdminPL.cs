using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class AdminPL
    {
        public static bool Login
        {
            get
            {
                Console.WriteLine("Admin -- Login");
                Console.WriteLine("Email: "); String email = Console.ReadLine() ?? "";
                Console.WriteLine("Password: "); string password = Console.ReadLine() ?? "";
             }
            set { Console.WriteLine(value); }
        }
    }
}
