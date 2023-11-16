using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.SQLApdapter
{
    public interface ISQLAdapter<T> where T : class, new()
    {
        /// <summary>
        /// Connection string
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// TableName
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Get list
        /// </summary>
        /// <returns></returns>
        List<T> GetData();

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(Guid id);

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        int Insert(T item);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        int Update(T item);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(Guid id);
    }
}
