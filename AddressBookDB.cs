using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDataBase
{
    public class AddressBookDB
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void AddressBookDBConnection()
        {
            try
            {
                using (this.connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spRetriveAllData", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Contact contacts = new Contact();
                            contacts.First_Name = dr.GetString(0);
                            contacts.Last_Name = dr.GetString(1);
                            contacts.Address = dr.GetString(2);
                            contacts.City = dr.GetString(3);
                            contacts.State = dr.GetString(4);
                            contacts.Zip = dr.GetString(5);
                            contacts.Phone_Number = dr.GetString(6);
                            contacts.E_mail_Id = dr.GetString(7);

                            Console.WriteLine(contacts.First_Name);
                            Console.WriteLine(contacts.Last_Name);
                            Console.WriteLine(contacts.Address);
                            Console.WriteLine(contacts.City);
                            Console.WriteLine(contacts.State);
                            Console.WriteLine(contacts.Zip);
                            Console.WriteLine(contacts.Phone_Number);
                            Console.WriteLine(contacts.E_mail_Id);
                            Console.WriteLine("------------------------------------------------");
                        }
                        connection.Close();
                    }
                    else
                    {
                        Console.WriteLine("no data found");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally { connection.Close(); }
        }
    }
}
