using CSharpBasic.Business;
using CSharpBasic.SQLApdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Service
{
    internal class UserService : UserSQLAdapter
    {
        private UserSQLAdapter user = new UserSQLAdapter();

        public List<User> GET_DATA_USER()
        {

            List<User> users = GetData();

            if (users != null)
            {
                foreach (User user in users)
                {
                    Console.WriteLine($"ID: {user.UserID}, Name: {user.Name}, Email: {user.Email}");
                }
            }
            else
            {
                Console.WriteLine("No data found or an error occurred.");
            }
            return user.GetData();

        }
    }
}
            
        
          
        
       
       

        
      

        



    
