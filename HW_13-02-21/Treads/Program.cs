using System;
using System.Threading;
using System.Collections.Generic;

namespace Treads
{
   class Program
    {
        static public List<Client> clients = new List<Client>();
        static int id = 0;
        static void Main(string[] args)
        {
            TimerCallback timer = new TimerCallback(CheckB);
            Timer time = new Timer(timer, clients, 0, 1000);
            Thread func = new Thread(Functions);
            func.Start();
        }

        public static void CheckB(object o)
        {
            int i = 0;
            foreach (var x in clients)
            {
                if (x.Balance > x.LastBalance)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{x.Id} {x.Balance} > {x.LastBalance} [+]");
                    Console.ForegroundColor = ConsoleColor.Black;
                    clients[i].LastBalance = clients[i].Balance;
                }
                else if (x.Balance < x.LastBalance)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{x.Id} {x.Balance} < {x.LastBalance} [-]");
                    Console.ForegroundColor = ConsoleColor.Black;
                    clients[i].LastBalance = clients[i].Balance;
                }
                i++;
            }
        }

        static void Functions()
        {
            bool start = true;
            while (start)
            {
                Thread.Sleep(1000);
                Thread selectAll = new Thread(() => SelectAll(clients));
                selectAll.Start();
                Console.WriteLine("1-for select one.\n2-for insert one");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter client Id from upper:");
                            id = int.Parse(Console.ReadLine());
                            bool z = true;
                            foreach (var x in clients)
                            {
                                if (x.Id == id)
                                {
                                    z = false;
                                }
                            }
                            if (z)
                            {
                                break;
                            }
                            Console.WriteLine("1-for delete\n2- for update\n3-to go to the main menu");
                            int chs = int.Parse(Console.ReadLine());
                            switch (chs)
                            {
                                case 1:
                                    {
                                        Thread delete = new Thread(new ThreadStart(Delete));
                                        delete.Start();
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Reenter FirstName:");
                                        string firstName = Console.ReadLine();
                                        Console.WriteLine("Reenter LastName:");
                                        string lastName = Console.ReadLine();
                                        Console.WriteLine("Reenter Age:");
                                        int age = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Reenter Balance:");
                                        decimal balance = decimal.Parse(Console.ReadLine());
                                        Thread update = new Thread(() => Update(new Client() { Age = age, Balance = balance, FirstName = firstName, LastName = lastName }));
                                        update.Start();
                                    }
                                    break;
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter FirstName:");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter LastName:");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("Enter Age:");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Balance:");
                            decimal balance = decimal.Parse(Console.ReadLine());
                            Thread insert = new Thread(() => Insert(new Client() { Age = age, Balance = balance, FirstName = firstName, LastName = lastName }));
                            insert.Start();
                        }
                        break;
                }
            }
        }

        static void Delete()
        {
            List<Client> li = new List<Client>();
            foreach (var client in clients)
            {
                if (client.Id != id)
                {
                    li.Add(client);
                }
            }
            clients = li;
        }

        static void SelectAll(List<Client> cln)
        {
            Console.WriteLine("Id FirstName LastName Age Balance");
            foreach (var client in cln)
            {
                Console.WriteLine($"{client.Id} {client.FirstName} {client.LastName} {client.Age} {client.Balance}");
            }
        }
        static void Update(Client client)
        {
            int i = 0;
            foreach (var clien in clients)
            {
                if (clien.Id == id)
                {
                    break;
                }
                i++;
            }
            clients[i].FirstName = client.FirstName;
            clients[i].LastName = client.LastName;
            clients[i].LastBalance = clients[i].Balance;
            clients[i].Age = client.Age;
            clients[i].Balance = client.Balance;
        }
        static void Insert(Client client)
        {

            int id = CheckId();
            clients.Add(new Client()
            {
                Id = id,
                Age = client.Age,
                Balance = client.Balance,
                FirstName = client.FirstName,
                LastName = client.LastName,
                LastBalance = client.Balance,
            });
        }
        static int CheckId()
        {
            int id = 1;
            try
            {
                id = clients[clients.Count - 1].Id + 1;
            }
            catch (Exception ex)
            {
                    System.Console.WriteLine($"Error - {ex.Message}");
                    
            }
            return id;
        }
    }
     public class Client
    {
        public int Id { get; set; } 
        public decimal Balance { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal LastBalance { get; set; }
    }
}
