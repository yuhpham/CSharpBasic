using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Model
{
    public class Cart 
    { public Guid IdCart { get; set; }
        public Guid UserID { get; set; }
        public Guid ProductID { get; set; }
        public decimal Price { get; set; }
        public decimal PriceTotal { get; set;}
        public Cart() {

            IdCart = Guid.NewGuid();
            Price = decimal.Zero;
            PriceTotal = decimal.Zero;
                    
        }


    }
}
