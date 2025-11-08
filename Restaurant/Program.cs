using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Restaurant.Data;
using Restaurant.Interface;
using Restaurant.WindowsForms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Restaurant
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        //string ServerName = ".\\MXMSERVER";
        //string DatabaseName = "RESTURANT_DB_4";
        //    using (var connection = new SqlConnection($"Server={ServerName};Database=master;Integrated Security=true;TrustServerCertificate=true;"))
        //    {
        //        connection.Open();
        //        string checkDbQuery = $"SELECT database_id FROM sys.databases WHERE Name = '{DatabaseName}'";
        //        using (var command = new SqlCommand(checkDbQuery, connection))
        //        {
        //            var result = command.ExecuteScalar();
        //            if (result == null)
        //            {
        //                new SqlCommand($"CREATE DATABASE [{DatabaseName}]", connection).ExecuteNonQuery();
        //                using (var context = new ApplicationDbContext())
        //                {
        //                    context.Database.Migrate();
        //                }
        //            }
        //        }
        //    }



    }
}