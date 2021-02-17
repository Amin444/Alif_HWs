using System;
using System.Collections.Generic;
using System.Threading;
namespace Threads
{
    class Program
    {
         public static List<Client> lastclient = new List<Client>();
        public static List<Client> listclient = new List<Client>()
        {
            new Client(){
                id=1,
                Balance=124
            },
            new Client(){
                id=2,
                Balance=12.44m
            },
            new Client(){
                id=3,
                Balance=124.423m
            },
            new Client(){
                id=4,
                Balance=194.4m
            },
            new Client(){
                id=5,
                Balance=1.24m
            },
            new Client(){
                id=6,
                Balance=53.534m
            }
        };
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число: ");
            string choose =Console.ReadLine();
            switch(choose)
            {
                case "1":{Thread threadINsert = new Thread(new ThreadStart(Insert( id:n,  Balance: 533m)));  threadINsert.Start();}  break;
                case "2":{Thread threadSelect = new Thread(new ThreadStart(Select));  threadSelect.Start();} break;
            }
            
        }

        public static void Insert(int id , decimal Balance)
        
        {
           System.Console.Write("Enter the id : ");
           int nId =int.Parse(Console.ReadLine());
           Console.Write("Enter the Balance :");
           decimal nBalance =decimal.Parse(Console.ReadLine());
           lastclient.Add(new Client(){id=nId, Balance=nBalance});

                if(nId>0 && nBalance>0)
                {
                    System.Console.WriteLine("Add Succesfuly");
                }
            
        }
        public static void Update()
        {
            var cId =int.Parse(Console.ReadLine());
            listclient.FindAll(s=>s.id==cId);
            var nBalance=decimal.Parse(Console.ReadLine());
            listclient.ForEach(x=>x.id=cId);
            lastclient.ForEach(x=>x.Balance=nBalance);
        }
        public static void Delete()
        {

        }
        public static void Select()
        {
                      foreach (var item in lastclient)
            {
                System.Console.WriteLine($"id : {item.id}, Balance : {item.Balance}");
            }
        }

    }
    class Client
    {
        public int id { get; set; }
        public decimal Balance { get; set; }
    }
}
