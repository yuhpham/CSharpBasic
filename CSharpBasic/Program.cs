

using CSharpBasic.Service;
using MyApp;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;



/*
 * Create 4 objects: user, product, cart, order - database schema 
 * Create SQL Adappter: AppDbAdapter - insert, update, delete, select
 * Create cart service: add product to user's cart
 * Create order service: create user order - add products from user's cart to order; delete products in cart
 */



namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public static void Main(string[] args)
        {
            UserService service = new UserService();
            service.GET_DATA_USER();


        }


    }
}

           /* bool logloop = true; //tao bien vong lap while
            while (logloop)
            {   //xuat ra man hinh cac tuy chon
                Console.WriteLine("Hello");
                Console.WriteLine("1. login to admin");
                Console.WriteLine("2.login to user");
                Console.WriteLine("3. exist ");
                Console.WriteLine("Your choose : ");
                // nhap thong tin tu man hinh
                string choose = Console.ReadLine() ?? "";
                // switch case
                switch (choose)
                {
                    case "1":

                        Console.WriteLine("admin");
                        break;
                    case "2":

                        Console.WriteLine("user");
                        break;
                    case "3":
                        Console.WriteLine("exist");
                        break;
                    default:
                        Console.WriteLine("input erro");
                        break;
                }
            }
        }*/
    

