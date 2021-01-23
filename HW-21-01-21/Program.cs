using System;

namespace HW_21_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //HW 1
            //task 1
         //  int a =54, b =54;

         // if (a>b) {b=a; System.Console.WriteLine($"A : {a} B : {b}");}
         // else if(b>a){a=b; System.Console.WriteLine($"A : {a} B : {b}");}
         // else if (a==b) {b=0; a=0; System.Console.WriteLine($"A : {a} B : {b}");}

         ////////////////////////////////////////////////////////////////////////////////////// 

            //task 2
          /*  bool sd=true;
            while(sd)
            {
            System.Console.Write("Please enter the first number: ");
            double operand1=double.Parse(Console.ReadLine());
            System.Console.Write("Switch the funcshions: ");
                char sign =char.Parse(Console.ReadLine());
                System.Console.Write("Enter the second number: ");
             double operand2 =double.Parse(Console.ReadLine());
             double res =0;
            switch (sign)
            {
                case '+':{res =operand1+operand2; System.Console.WriteLine($"Your result: {res}");}break;
                case'-':{res =operand1-operand2; System.Console.WriteLine($"Your result: {res}");}break;
                case'*':{res =operand1*operand2; System.Console.WriteLine($"Your result: {res}");}break;
                case'/':{if(operand1!=0 && operand2!=0){res =operand1/operand2; System.Console.WriteLine($"Your result: {res}");}
               
                else{System.Console.WriteLine("Error! Cannot be divided into zero! try again please");}
                }break;
               
                default: {System.Console.WriteLine("Error! maybe you make mistake check your data");}break;

            }
            System.Console.WriteLine("=================================================================");
            System.Console.WriteLine("If you want to exit from this app enter the 'y' or not 'n'!");
            char exit =char.Parse(Console.ReadLine());
                switch(exit)
                {
                    case'y':{sd=true;}break;
                    case'Y':{sd=true;}break;
                    case'n':{sd=false;}break;
                    case'N':{sd=false;}break;
                }
            }*/

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //task 4
           
            
          //  System.Console.Write("Please enter the number [0-100]: ");
          //  int n =int.Parse(Console.ReadLine());

          //  if(n>=0&&n<=14){System.Console.WriteLine("[0-14]");}  
          // else if(n>=15&&n<=35){System.Console.WriteLine("[15-35]");}  
          // else if(n>=36&&n<=50){System.Console.WriteLine("[36-50]");}  
          // else if(n>=50&&n<=100){System.Console.WriteLine("[50-100]");}  

          //  else{System.Console.WriteLine("Sory but you enter number not in range [0-100]");}

         ////////////////////////////////////////////////////////////////////////////////////////////////////////// 
                //HW 2
                //task 1

              //  double n =double.Parse(Console.ReadLine());
              //  double res =0;
              //  double count =0;
              //  if(n>500&& n<1000){res=n/100; res=res*3;  count =n -res; System.Console.WriteLine($"Сумма скидки в 3%: {count}");}
              // else if(n>1000){res=n/100; res=res*5; count =n -res; System.Console.WriteLine($"Сумма скидки в 5%: {count}");}

              // else{System.Console.WriteLine($"Вы ввели сумму меньше 500 сом поэтому не получаете скидку( : {n}");}

                //task 2

             //   int a =1,b=1, c =1, d =1;
             //   int res =0;
             //   if(a>b||b>c||c>d){
             //       if (a<b&&a<c&&a<d){System.Console.WriteLine(a);}
             //      else if (b<a&&b<c&&b<d){System.Console.WriteLine(b);}
             //      else if (c<a&&c<b&&c<d){System.Console.WriteLine(c);}
             //      else if (d<b&&d<c&&d<a){System.Console.WriteLine(d);}
             //   }

             // else if (a==b&&b==c&&c==d) {res = a*b*c*d;System.Console.WriteLine(res);}
             //  else {System.Console.WriteLine("Числа расположены по возрастанию.");}


                //task 3

                 double a =double.Parse(Console.ReadLine());
                 double b =double.Parse(Console.ReadLine());
                 double c =double.Parse(Console.ReadLine());

                 if (!(a>=b&&b>=c))
                 {
                     a=a+b+c; b=b+c;  System.Console.WriteLine($"{a}, {b}, {c}");
                 }
                 else
                 {
                     System.Console.WriteLine($"{a}, {b} , {c}");
                 }
        }
    }
}
