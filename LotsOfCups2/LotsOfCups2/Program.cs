///New console appliction with connection syntax
//need to add connction 
//need to add more using like create a logic libary, infrastructure
using System;
using System.Data.SqlClient;

string connectionString = File.ReadAllText("C:/Users/mkare_wyte20y/Revature/DQL_Database.txt");

using SqlConnection connection = new(connectionString);
connection.Open();

string commandText = "";

using SqlCommand command = new(commandText, connection);

using SqlDataReader reader = command.ExecuteReader();
try 
{
}
catch (System.IO.FileNotFoundException e) 
{
    
}
while (reader.Read())
{
 
    //string title = reader.GetString(0);
 
   // int pages = reader.GetInt32(2); 

    //Console.WriteLine($"\"{title}\" with {pages} pages");
}



connection.Close();

/*namespace LotsOfCups2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product cup = new Product();

            Console.WriteLine("Hello World");
            Console.WriteLine("Welcome to LotsOfCups");
            Console.WriteLine("Please select from the following");//want to try to add an index to select items
            Console.ReadLine();
        }
    }
}*/