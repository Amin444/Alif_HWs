using System;
using System.Threading;
using System.Collections.Generic;

namespace Treads
{
    class Program
    {
           public static List<Client> clientList = new List<Client>();
              
            
        static void Main(string[] args)
        {
                clientList.Add(new Client() {id=1,Balance=645});

            Thread ThreadInsert = new Thread(new ThreadStart(Insert));
            ThreadInsert.Start();
            Thread ThreadUpdate = new Thread(new ThreadStart(Update));
            ThreadUpdate.Start();
            Thread ThreadDelete = new Thread(new ThreadStart(Delete));
            ThreadDelete.Start();
            Thread ThreadSelect = new Thread(new ThreadStart(Select));
            ThreadSelect.Start();

        }
        public static void Insert()
        {
            System.Console.Write("Enter the id : ");
            int id = int.Parse(Console.ReadLine());
            System.Console.Write("Enter the Balance : ");
            int Balance = int.Parse(Console.ReadLine());
                 clientList.Add(new Client() {id=id,Balance=Balance});
        }
        public static void Update()
        {
                
        }
        public static void Delete()
        {
                System.Console.WriteLine("3");
        }
        public static void Select()
        {    
                System.Console.WriteLine("4");
        }

    }

    class Client
    {
         public  static List<Client> clientList = new List<Client>()
            {
              
            };
        public int id { get; set; }
        public decimal Balance { get; set; }

        
    }
}
