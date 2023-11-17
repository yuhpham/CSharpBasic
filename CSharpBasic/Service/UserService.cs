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
            return user.GetData();



}




    }
}
