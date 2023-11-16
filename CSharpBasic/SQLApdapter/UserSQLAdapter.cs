using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.SQLApdapter
{
    public class UserSQLAdapter : ISQLAdapter<User>
    {
        public string ConnectionString { get; set; }
        public string TableName { get; set; }

        public UserSQLAdapter(string connectionString)
        {
            this.ConnectionString = connectionString;
            this.TableName = "USER";
        }

        public List<User> GetData()
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public int Insert(User item)
        {
            throw new NotImplementedException();
        }

        public int Update(User item)
        {
            throw new NotImplementedException();
        }

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }


}
