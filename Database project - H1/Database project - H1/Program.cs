using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Database_project___H1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SQL Server Console Manager");
            Console.WriteLine("Press enter to create a new database");
            Console.ReadKey();
            Console.Write("Enter database (no special chars): ");
            string? database = Console.ReadLine();
            Console.WriteLine($"Creating database {database}");
            database.Execute($"CREATE DATABASE { database}")

        }

        

    }
}
