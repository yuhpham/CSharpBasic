using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Business
{
    [Table("User")]
    public class User
    { public Guid UserID { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Password { get; set; }
        public User() {
        this.UserID = Guid.NewGuid();
        this.Name = string.Empty;
        this.Email = string.Empty;
        this.Password = string.Empty;
          
        
        }
            

     



    }
}
