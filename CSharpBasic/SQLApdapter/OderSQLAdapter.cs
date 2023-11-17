using CSharpBasic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.SQLApdapter
{
    internal class OderSQLAdapter : ISQLAdapter<Oder>
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TableName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Oder Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Oder> GetData()
        {
            throw new NotImplementedException();
        }

        public int Insert(Oder item)
        {
            throw new NotImplementedException();
        }

        public int Update(Oder item)
        {
            throw new NotImplementedException();
        }
    }
}
