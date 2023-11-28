using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasic.Model;

namespace CSharpBasic.SQLApdapter
{
    internal class ProductsSQLAdapter : ISQLAdapter<Products>
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TableName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        public Products Get(Guid id)
        {
            throw new NotImplementedException();
        }


        public List<Products> GetData()
        {
            List<Products> ProductsList = new List<Products>();
            try
            {


                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {

                    connection.Open();

                    string query = "SELECT * FROM Products"; // lay du lieu tu bang User

                    using (SqlCommand command = new SqlCommand(query, connection)) //khoi tao ten bien cho ham
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) // su dung thu vien sqldatareader
                        {
                            while (reader.Read()) //tao vong lap White
                            {
                                Products products = new Products(); //khoi tao bien
                                {
                                    products.ProductID = Guid.Parse(reader["ProductID"].ToString());
                                    products.ProductName = reader["ProductName"].ToString();
                                    products.Price = decimal.Parse(reader["Price"].ToString());
                                    products.Inventory = int.Parse(reader["Inventory"].ToString());
                                    products.Category = reader["ProductName"].ToString();

                                };

                                ProductsList.Add(products);
                            }
                        }
                    }
                }
                return ProductsList;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return ProductsList;
        }

        public int Insert(Products item)
        {
            throw new NotImplementedException();
        }

        public int Update(Products item)
        {
            throw new NotImplementedException();
        }
        public int Delete(Guid id)
        {
            throw new NotImplementedException();

        }
    }



}
