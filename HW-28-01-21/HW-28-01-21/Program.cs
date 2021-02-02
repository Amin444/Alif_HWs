using System;

namespace Hw_28_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
               
                 string[] model ={ "laptop", "smart phone", "TV", "Wi-fi"};
                 System.Console.Write("Array models :");
                 System.Console.WriteLine( ArrayHelper.Pop(ref model));
                 ////////////////////////////////////////////////////////////////////
                 int[] num ={53,35,253,265,242,52,28,6};
                 System.Console.Write("Array numbers :");
                 System.Console.WriteLine( ArrayHelper.Pop(ref num)); 
                 ////////////////////////////////////////////////////////////////////
                 double[] num1 ={65.3,553.44,44.321,7,32,654.5,325,227,53.647};
                 System.Console.Write("Array numbers :");
                 System.Console.WriteLine( ArrayHelper.Pop(ref num1)); 
                 ////////////////////////////////////////////////////////////////////
                 decimal[] num2 ={65.3m,553.44m,44.321m,7m,32m,654.5m,325m,227m};
                 System.Console.Write("Array numbers :");
                 System.Console.WriteLine( ArrayHelper.Pop(ref num2)); 
                 ////////////////////////////////////////////////////////////////////
                 float[] num3 ={65.3f,553.44f,44.321f,7f,32f,654.5f};
                 System.Console.Write("Array numbers :");
                 System.Console.WriteLine( ArrayHelper.Pop(ref num3)); 
                 ////////////////////////////////////////////////////////////////////
        }
    }
    
    static class ArrayHelper
    {
        public static string Pop( ref string[] model )
        {
                foreach (var item in model){
                Console.Write(item + " ");
                }
                System.Console.Write("\nThe last array elaments : ");
                string ml = model[model.Length-1];
                Array.Resize(ref model , model.Length-1); 
                return ml;
        }
          
        public static int Pop( ref int[] num )
        {
                foreach (var item in num){
                Console.Write(item + " ");
                }
                System.Console.Write("\nThe last array elaments : ");
                int n = num[num.Length-1];
                Array.Resize(ref num , num.Length-1);
              
                return n;
        }
         public static double Pop( ref double[] num1 )
        {
                foreach (var item in num1){
                Console.Write(item + " ");
                }
                System.Console.Write("\nThe last array elaments : ");
                double n1 = num1[num1.Length-1];
                Array.Resize(ref num1 , num1.Length-1);
             
                return n1;
        }

         public static decimal Pop( ref decimal[] num2 )
        {
                foreach (var item in num2){
                Console.Write(item + " ");
                }
                System.Console.Write("\nThe last array elaments : ");
                decimal n2 = num2[num2.Length-1];
                Array.Resize(ref num2 , num2.Length-1);
             
                return n2;
        }
         public static float Pop( ref float[] num3 )
        {
                foreach (var item in num3){
                Console.Write(item + " ");
                }
                System.Console.Write("\nThe last array elaments : ");
                float n3 = num3[num3.Length-1];
                Array.Resize(ref num3 , num3.Length-1);
               
                return n3;
        }
    }
}
