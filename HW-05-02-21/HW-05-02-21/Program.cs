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
                    var sa =true;
                    while(sa)
                    {
                 System.Console.WriteLine("Enter the options C->insert R->SelectAll U->Update D->delete S-selectbyId  ex->exit from this program");
                    var choose =Console.ReadLine().ToUpper();
                    switch (choose)
                    {
                        case "C":{Insert();}break;
                        case "R":{SelectAll();}break;
                        case "U":{Update();}break;
                        case "D":{Delete();}break;
                        case "S":{SelectById();}break;
                        case "ex":{sa=false;}break;
                    }
                    }
                    connection.Close();
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
                    System.Console.Write("Enter the FirstName :");
                    var FirstName = Console.ReadLine();
                    System.Console.Write("Enter the LastName :");
                    var LastName = Console.ReadLine();
                    System.Console.Write("Enter the MiddleName :");
                    var MiddleName = Console.ReadLine();
                    System.Console.Write("Enter the BirthDay :");
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
                    System.Console.Write("Enter the FirstName :");
                         var LastName = Console.ReadLine();
                         System.Console.Write("Enter the FirstName :");
                         var FirstName = Console.ReadLine();
                         System.Console.Write("Enter the LastName :");
                         var MiddleName = Console.ReadLine();
                         System.Console.Write("Enter the MiddleName :");
                         var BithDate = Console.ReadLine();
                         System.Console.Write("Enter the BirhtDay :");
                        var id =int.Parse(Console.ReadLine());

                     SqlCommand command = connection.CreateCommand();
                     command.CommandText = $"UPDATE Persons SET LastName='{LastName}',"+
                       $"FirstName ='{FirstName}',"+
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

            public static void Delete()
            {
                   string ConnString = @"Data source=MACHINE-PGO7H84\SQL2017; initial catalog=People; integrated security=true;";
                    SqlConnection connection = new SqlConnection(ConnString);
                    connection.Open();
                    System.Console.Write("Enter the Id that Person of delete :");
                    var id =int.Parse(Console.ReadLine());
                    SqlCommand command = connection.CreateCommand();
                     command.CommandText = $"DELETE from Persons where id ={id};";

                    var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    System.Console.WriteLine("deleteing was successfuly!");
                }
                else{System.Console.WriteLine("Maybe you enter the not correctly id! Please try again");}
            }

    
                public static void SelectById()
              {
                    string ConnString = @"Data source=MACHINE-PGO7H84\SQL2017; initial catalog=People; integrated security=true;";
                    SqlConnection connection = new SqlConnection(ConnString);
                    connection.Open();
                    System.Console.Write("Enter the Id that show info :");
                      var id =int.Parse(Console.ReadLine());
                     SqlCommand command = connection.CreateCommand();
                     command.CommandText = $"SELECT * from Persons where id ={id};";
                        var res = command.ExecuteNonQuery();
                        if(res>0)
                        {
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
                        else{System.Console.WriteLine("Maybe you enter the not correctly id! Please try again");}
                }
    
    }
} 
      


