
using ConsoleApp;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        //// Build configuration
        //IConfiguration configuration = new ConfigurationBuilder()
        //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Set the base path for the appsettings.json file
        //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true) // Add appsettings.json as a configuration source
        //    .Build();

        //// Get the connection string from configuration
        //var connectionString = configuration.GetConnectionString("ArunSir");

        //    //GetConnectionString("ArunSir");
        //try { 
        //if (TestConnection(connectionString))
        //{
        //    Console.WriteLine("Connection successful!");
        //}
        ////else
        ////{
        ////    Console.WriteLine("Connection failed!");
        ////}
        //}
        //catch(Exception ex)
        //{
        //    throw ex;
        //}
        //Console.WriteLine("Hello World!");

        //var builder = new ConfigurationBuilder()
        //            .SetBasePath(Directory.GetCurrentDirectory())
        //            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        //IConfiguration _configuration = builder.Build();
        //var myConnectionString1 = _configuration.GetConnectionString("MacConnection");
        //Console.WriteLine(myConnectionString1);

        #region User write console program to Test 'connection stirng' for visual studio 2022 mac to asp.net core 7 in Azure data studio localhost

        //Console.WriteLine("Enter your connection string:");
        //string connectionString = Console.ReadLine();

        //try
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        Console.WriteLine("Connection successful!");
        //    }
        //}
        //catch (SqlException ex)
        //{
        //    for (int i = 0; i < ex.Errors.Count; i++)
        //    {
        //        Console.WriteLine($"Error {i + 1}: {ex.Errors[i].Message}");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Connection failed. Error: {ex.Message}");

        //}
        #endregion

        #region Write the console code for get data from database in C#
        // Replace the connection string with your actual connection string
        string connectionString = "Server=127.0.0.1,1433;Database=DBCS;User Id=sa;Password=Barrett7292%^;TrustServerCertificate=True;";

        // Replace the SQL query with your actual query
        string query = "SELECT * FROM tblEmployee";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if the result set has rows
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Access columns by index or column name
                                int id = reader.GetInt32(reader.GetOrdinal("EmployeeId"));
                                string name = reader.GetString(reader.GetOrdinal("Name"));

                                // Do something with the retrieved data
                                Console.WriteLine($"ID: {id}, Name: {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No rows found.");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        #endregion


    }



    //static bool TestConnection(string? connectionString)
    //{
    //    try
    //    {
    //        if (connectionString == null)
    //        {
    //            Console.WriteLine("Connection string is null.");
    //            return false;
    //        }

    //        // Your DbContext and database connection testing logic here
    //        using (var dbContext = new SampleDbContext(new DbContextOptionsBuilder<SampleDbContext>()
    //           .UseSqlServer(connectionString)
    //           .Options))
    //        {
    //            dbContext.Database.OpenConnection();
    //            dbContext.Database.CloseConnection();
    //        }

    //        return true;


    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"Error: {ex.Message}");
    //        return false;
    //    }
    //}
}

