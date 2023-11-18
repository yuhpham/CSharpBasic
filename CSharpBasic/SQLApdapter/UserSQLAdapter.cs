using CSharpBasic.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CSharpBasic.SQLApdapter
{
    public class UserSQLAdapter : ISQLAdapter<User> // ke thua interface
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TableName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetData()
        {
            try
            {
                List<User> UserList = new List<User>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Users"; // lay du lieu tu bang User

                    using (SqlCommand command = new SqlCommand(query, connection)) //khoi tao ten bien cho ham
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) // su dung thu vien sqldatareader
                        {
                            while (reader.Read()) //tao vong lap White
                            {
                                User user = new User(); //khoi tao bien
                                {
                                    user.UserID = Guid.Parse(reader["UserID"].ToString());
                                    user.Name = reader["Name"].ToString();
                                    user.Email = reader["Email"].ToString();
                                    user.Password = reader["password"].ToString();
                                };

                                UserList.Add(user);
                            }
                        }
                    }
                }
                return UserList; // gia tri tra ve
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
              
            }
            return null;        }

        public int Insert(User item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO User (Name, Email, Password)  VALUES (@Name, @Email, @Password)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Name", item.Name);
                    command.Parameters.AddWithValue("@Email", item.Email);
                    command.Parameters.AddWithValue("@Password", item.Password);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return 1;
        }


        public int Update(User item)
        {   
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UPDATE User SET Email = @Email WHERE UserID = @id", connection);

                    command.Parameters.AddWithValue("@Email", item.Email);
                    command.Parameters.AddWithValue("@id", item.UserID);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 1;
        }

        internal List<User> Update()
        {
            throw new NotImplementedException();
        }
    }
}