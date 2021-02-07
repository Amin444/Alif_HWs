using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace HW_05_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
             string ConnString = @"Data source=MACHINE-PGO7H84\SQL2017; initial catalog=People; integrated security=true;";
                    SqlConnection connection = new SqlConnection(ConnString);
                    connection.Open();
                 
                    var choose =Console.ReadLine().ToUpper();
                    switch (choose)
                    {
                        case "R":{SelectAll();}break;
                        case "С":{Insert();}break;
                        case "U":{Update();}break;
                        
                    }
        }
        public static void SelectAll()
        {
                    string ConnString = @"Data source=MACHINE-PGO7H84\SQL2017; initial catalog=People; integrated security=true;";
                    SqlConnection connection = new SqlConnection(ConnString);
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = $" SELECT * FROM Persons";
                     var reader = command.ExecuteReader();
                        while (reader.Read())
                    {
                         Console.WriteLine($"" +
                        $"Id:{reader["Id"]}, \t" +
                        $"FirstName:{reader["FirstName"]}, \t" +
                        $"LastName:{reader["LastName"]}, \t" +
                        $"MiddleName:{reader["MiddleName"]}, \t" +
                        $"BithDate:{reader["BithDate"]}, \t");
                    }
         }

         public static void Insert()
         {
                    string ConnString = @"Data source=MACHINE-PGO7H84\SQL2017; initial catalog=People; integrated security=true;";
                    SqlConnection connection = new SqlConnection(ConnString);
                    connection.Open();

                    var FirstName = Console.ReadLine();
                    var LastName = Console.ReadLine();
                    var MiddleName = Console.ReadLine();
                    var BithDate = Console.ReadLine();

                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "Insert into Persons(" +
                    "FirstName," +
                    "LastName," +
                    "MiddleName," +
                    "BithDate) Values(" +
                    $"'{FirstName}'," +
                    $"'{LastName}'," +
                    $"'{MiddleName}'," +
                    $"'{BithDate}')"
                    ;
                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    System.Console.WriteLine("Editing was coreccly!");
                }
            }

            public static void Update()
            {
                  string ConnString = @"Data source=MACHINE-PGO7H84\SQL2017; initial catalog=People; integrated security=true;";
                    SqlConnection connection = new SqlConnection(ConnString);
                    connection.Open();
                         var LastName = Console.ReadLine();
                         var FirstName = Console.ReadLine();
                         var MiddleName = Console.ReadLine();
                         var BithDate = Console.ReadLine();
                        var id =int.Parse(Console.ReadLine());

                     SqlCommand command = connection.CreateCommand();
                     command.CommandText = $"Update Persons SET LastName='{LastName}',"+
                       $"FisrtName ='{FirstName}',"+
                       $"MiddleName ='{MiddleName}',"+
                       $"BithDate ='{BithDate}' "+
                       $"where id = {id};";

                         var reader = command.ExecuteReader();
                        while (reader.Read())
                    {
                         Console.WriteLine($"" +
                        $"Id:{reader["Id"]}, \t" +
                        $"FirstName:{reader["FirstName"]}, \t" +
                        $"LastName:{reader["LastName"]}, \t" +
                        $"MiddleName:{reader["MiddleName"]}, \t" +
                        $"BithDate:{reader["BithDate"]}, \t");
                    }

            }
    
         
    
    }
}        


