using System;

namespace Hw_28_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
               
                /* string[] model ={ "laptop", "smart phone", "TV", "Wi-fi"};
                 foreach (var item in model)
                 {
                     System.Console.Write(item + " ");
                 }
                        
                 System.Console.Write("\nArray models :");
                 System.Console.WriteLine( ArrayHelper.Pop(ref model));
                 System.Console.Write("New array :");
                 foreach (var nmodel in model)
                 {
                     System.Console.Write(nmodel + " ");
                 }*/
                //////////////////////////////////////////////////////////////////////

                 string[] words ={"oil","pictire", "demonstrate", "walk", "approch"};
                 System.Console.WriteLine("\n Words :");
                foreach (var item2 in words)
                {
                    System.Console.Write(item2 + " ");
                }
                
                System.Console.WriteLine(ArrayHelper.Push(ref words));
                System.Console.Write("New array");
                foreach (var d in words)
                {
                    System.Console.WriteLine(d + " ");
                }

        }
    }
    
    static class ArrayHelper
    {
         public static string Pop(ref string[] num)
        {
                string n = num[num.Length-1];
                Array.Resize(ref num , num.Length-1);
              
                return n;
        }
        
           public static int Pop(ref int[] num)
        {
                int n = num[num.Length-1];
                Array.Resize(ref num , num.Length-1);
              
                return n;
        }
        
         public static double Pop(ref double[] num)
        {
                double n = num[num.Length-1];
                Array.Resize(ref num , num.Length-1);
              
                return n;
        }
         public static decimal Pop(ref decimal[] num)
        {
                decimal n = num[num.Length-1];
                Array.Resize(ref num , num.Length-1);
              
                return n;
        }
         public static float Pop(ref float[] num)
        {
                float n = num[num.Length-1];
                Array.Resize(ref num , num.Length-1);
              
                return n;
        }
         public static string Push(ref string[] arrn)
        {
                string n1 = arrn[arrn.Length+1];
                Array.Resize(ref arrn , arrn.Length+1);
              
                return n1;
        }
    }
}
