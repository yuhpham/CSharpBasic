using CSharpBasic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.SQLApdapter
{
    internal class CartSQLAdapter : ISQLAdapter<Cart>
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TableName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Cart Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetData()
        {
            throw new NotImplementedException();
        }

        public int Insert(Cart item)
        {
            throw new NotImplementedException();
        }

        public int Update(Cart item)
        {
            throw new NotImplementedException();
        }
    }
}
