using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
          List<shifts> mylist=new List<shifts>();
            while(true)
            {
                
                Task.Run(
                ()=>
                {
                    for (int i = 0; i < new Random().Next(100, 1000); i++)
                    {
                        mylist.Add(new shifts()
                        {
                            left=new Random().Next(100),
                            Top = new Random().Next(3,8),
                            simvol=letters(),
                        }
                        
                        );
                    }
                }
                ).Wait();

                     Task.Run(() =>
                {
                    lettersRain(mylist);
                    mylist.Clear();

                }).Wait();

            }
        }
         
        public static char[] letters()
        {
            string letters="";
            for (char i = 'A'; i <= 'z'; i++)
            {
             if ((char)new Random().Next(0,4)==1)
             {
                 letters+=i;
             }   
            }
            return letters.ToCharArray();
        }

       public static void lettersRain(List<shifts> Rain)
       {
            int count=0;
            for (int i = 0; i < 10; i++)
            {
                foreach(var A in Rain )
              {
                    Console.CursorTop = i + A.Top;
                foreach (var item in A.simvol)
                {
                    Console.CursorLeft=A.left;
                    if (count==A.simvol.Length-1)
                    {
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                    else if (count==A.simvol.Length-2)
                    {
                     Console.BackgroundColor=ConsoleColor.Green;   
                    }
                    else
                    {
                    Console.BackgroundColor=ConsoleColor.DarkGreen;
                    }
                    System.Console.WriteLine(item);
                    count++;
                }
                count =0;
             }
            }
            Thread.Sleep(1000);
            Console.Clear();
       }
        
    }

    class shifts
     {
         public int left{get;set;}
         public int Top{get;set;} 
         public char[] simvol { get; set; }
     }
}
