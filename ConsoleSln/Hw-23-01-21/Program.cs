using System;

namespace Hw_23_01_21
{
    class Program
    {
        static void Main(string[] args)
        {

            //task 1

         /*  int a =int.Parse(Console.ReadLine());
           int b =int.Parse(Console.ReadLine());
            int res =0;
            if(a<b){
            while(a<b){
                 a++;   res+=a; System.Console.WriteLine($"Сумма всех чисел от A до B : {res}");
                 if(a%2!=0){System.Console.WriteLine($"Не четные числа : {a}");}
            }}
            else{System.Console.WriteLine("Вы ввели не верное значения!");}*/

          //////////////////////////////////////////////////////////////////////////////////////////////

              //task 3

            /*bool sa =true;
            while(sa){
            int s =1000;
            int res =0;
            System.Console.WriteLine($"Your begin capital : {s}");
            System.Console.Write("Enter the procent whitch more than 0 but littele than 25 : ");
            int p =int.Parse(Console.ReadLine());
              if(0<p&&25>p)
                {
                for (int i = 1; i < s; i++)
                {
                  res =(s/100) *p; s =res +s;
                   if(s>1100){System.Console.WriteLine($"Count month : {i}"); 
                      System.Console.WriteLine($"Final contribution : {s}");
                }
                      System.Console.Write("If you want to exit from this programe write 'e' : ");
                      string exit =Console.ReadLine();
                      if(exit.Equals("e")){sa =false;} break; }
              }
              else{System.Console.WriteLine("Some mistake! Don't worry try again");}
            }*/
        
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

                  //task 2
                  //Прямоугольник
               /* for (int i = 0; i <= 10; i++)
                {
                    for (int g = 0; g < 18; g++)
                    {
                        System.Console.Write( "* " );
                    }
                  System.Console.WriteLine();
                }*/

                //Прямоугольный треугольник

                 /* for (int i = 0; i < 10; i++)
                  {
                    for (int g = 0; g < i; g++)
                    {
                        System.Console.Write("* ");
                    }
                        
                    System.Console.WriteLine("");
                  } */

                  //Равнобедреный треугольник

                 int wq =8, sd=0;
                  for (int i = wq; i > 0; i--)
                  {
                      sd++;
                      for (int j = wq; j >= 0; j++)
                      {
                      System.Console.Write(" ");
                          
                      }
                      wq--;
                      for (int z = 0; z < sd; z++)
                      {
                          System.Console.Write("* ");
                      }
                      System.Console.WriteLine();
                  }

                  // Ромб

                /*   int   g = 6;
                   int  q = 0;
            for (int i = g; i >= 0; i--)
            {
                q++;
                for (int x = g; x >= 0; x--)
                {
                    Console.Write(" ");
                }
                g--;
                 for (int y = 0; y < q; y++)
                {
                    Console.Write("* ");
                 }
                 System.Console.WriteLine();
            }
            g = 6;
            q = 0;
             for (int i = 0; i <= 5; i++)
             {
                 q++;
                 for (int x = 0; x <= q; x++)
                {
                     Console.Write(" ");
                 }
                 g--;
                 for (int y = g; y >= 0; y--)
                 {
                    Console.Write("* ");
                }
                 System.Console.WriteLine();
              }*/

                ////////////////////////////////////////////////////////////////////////////////////////////////////////
         
                //HW 2

                //task 1

               /* int N =int.Parse(Console.ReadLine());
                int[] arrN = new int[N];
                var ran = new Random();
                double max =0,min=1000000, TotAmount=0, mid =0, nech=0, counter=0;
                for (int i = 0; i < arrN.Length; i++)
                {
                   
                  arrN[i] = ran.Next(1000);
                  System.Console.WriteLine(arrN[i]);
                    if(max<arrN[i]){max =arrN[i];}
                    if(min>arrN[i]){min=arrN[i];}
                    if(true){TotAmount= TotAmount +arrN[i]; }
                    if(arrN[i]%2!=0){nech =arrN[i];System.Console.WriteLine($"ne chetnie : {nech}");}

                }
                System.Console.WriteLine($"max : {max}");
                System.Console.WriteLine($"min : {min}");
                System.Console.WriteLine($"Total amount : {TotAmount}");
                System.Console.WriteLine($"Mid : {TotAmount/arrN.Length}"); */

                //task 2

              /*  int[] n = new int[7] {4,52,6,31,74,31,56};
                for (int i = n.Length-1; i > 0; i--)
                {
                    System.Console.WriteLine(n[i]);
                }*/

                ///////////////////////////////////////////////////////////////////////

                //task 3
              /*  int g=0;
                System.Console.Write("Enter the number : ");
                int num =int.Parse(Console.ReadLine());
                int[] arrNum = new int[num];
                  var ran = new Random();
                for (int i = 0; i < arrNum.Length; i++)
                {
                   arrNum[i]= ran.Next(1000);
                    System.Console.WriteLine(arrNum[i]);
                }
                System.Console.Write("Enter the index : ");
                int index =int.Parse(Console.ReadLine());
                System.Console.Write("Enter the Count : ");
                int count = int.Parse(Console.ReadLine());
                int[] arrCount = new int[count];
               for (int i = index; i < count +  index; i++)
               {
                      if(i <=arrNum.Length-1){arrCount[g]=arrNum[i];g++;}
                      else{arrCount[g]=1; }
               }

               foreach (var item in arrCount)
               {
                   System.Console.WriteLine(item);
               } */
        }
    }
}


