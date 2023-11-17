using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Model
{
    public class Products
    {
        public Guid ProductID { get; set; }
        public string ProductName { get; set; } 
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        public string Category { get; set; }
        
    
    public Products()
     {
        ProductID = Guid.NewGuid();
        ProductName = string.Empty;
        Price = 0;
        Inventory = 0;
        Category = string.Empty;
            
     }

     }
}
