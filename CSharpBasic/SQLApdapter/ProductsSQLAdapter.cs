using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.SQLApdapter
{
    internal class ProductsSQLAdapter : ISQLAdapter<ProductsSQLAdapter>
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TableName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ProductsSQLAdapter Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ProductsSQLAdapter> GetData()
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductsSQLAdapter item)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductsSQLAdapter item)
        {
            throw new NotImplementedException();
        }
    }



}
