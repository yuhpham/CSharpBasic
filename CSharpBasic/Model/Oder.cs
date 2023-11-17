using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Model
{
    public class Oder
    { public Guid OderID { get; set; }
        public Guid UserID { get; set; }   
        public Guid ProductID { get; set; }
        public decimal Price { get; set; }
                      
        public Oder()
        {
            OderID = Guid.NewGuid();
            Price = new decimal();        
        
        }
    }
}
