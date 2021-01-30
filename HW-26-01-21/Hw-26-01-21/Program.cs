using System;

namespace HW_26_01021
{
    class Program
    {
        static void Main(string[] args)
        {
            // HW 1  //task1 
            System.Console.Write("Enter the side1 and side2 : ");
            var rec =new Rectangle(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
           System.Console.WriteLine($"Area : {rec.AreaCalculator()}");
           System.Console.WriteLine($"Perimeter {rec.PerimeterCalculator()}");
           /////////////////////////////////////////////////////////////////////////////////////

            //task 2

             var T =new Title();
             var A =new Author();
             var C =new Content();
          
           T.show();
           Console.ForegroundColor=ConsoleColor.White;
           A.show();
           Console.ForegroundColor=ConsoleColor.White;
           C.show();
           Console.ForegroundColor=ConsoleColor.White;
           

            /////////////////////////////////////////////////////////////////////////////////////////////////

                //task 3
                      System.Console.WriteLine("=========================================================");
                      System.Console.WriteLine("if you want to know that can Phone write 'S' ");
                    string st =Console.ReadLine();
                    if(st.ToUpper().Equals("S"))
                    {
                   var S = new Phone();
                   S.Acall();
                   S.listenAudio();
                   S.showVideo();
                   ///////////////////////////////////////////////////////////////////////////////////////////////

                   //Hw 2

                   //task 1
                   Converter converter=new Converter();
                   converter.Convertations();
        }

                    
                

        }
    }
   
       class Rectangle
       {
           
           double side1, side2;
          
            public double Area { get; private set; }
            public double Perimeter { get; private set; }

            public Rectangle(double side1, double side2)
            {
                    this.side1=side1;
                    this.side2 =side2;
            }
            public double  AreaCalculator()
            {

                    return Area= side1 * side2;
            }
            public double PerimeterCalculator()
            {
                    return Perimeter= (side1+side2)*2 ;
            }
       }

       class BooK
       {
            public static void AllShow()
            {
          
           
            }
       }

       
           class Title
           {
                string bigWords;
               public void show()
               {
                   System.Console.Write("Enter the Title please : ");
                    bigWords =Console.ReadLine();  
                   Console.ForegroundColor =ConsoleColor.Green;
                   System.Console.WriteLine($"Title : {bigWords}");

               }


           }
           class Author
           {
                string who;
                public void show(){
                System.Console.Write("Enter the Author please : ");

                   who =Console.ReadLine();
                   Console.ForegroundColor =ConsoleColor.Yellow;
                   System.Console.WriteLine($"Author : {who}");
                }
           }
           class Content
           {
               string what;
               public void show(){
                 System.Console.Write("Enter the Content please : ");

                   what =Console.ReadLine();
                   Console.ForegroundColor =ConsoleColor.Blue;
                    System.Console.WriteLine($"Content : {what}");
                }
           }


            class Phone
            {
                

                public void Acall()
                {
                    System.Console.WriteLine("Phone can call!");
                }

                public void showVideo()
                {
                    System.Console.WriteLine("Phone can show the Video! ");
                }

                public void listenAudio()
                {
                    System.Console.WriteLine("Phone can play audio tracks!");
                }
                
                
            }




       class Employee
       {
           string Name , FirstName;
          
          

            public Employee(string Name , string FirstName)
            {
                this.Name =Name;
                this.FirstName =FirstName;
               
              
            }
            public void salary(string Name , string FirstName){
                        
            }
       }

       class Converter
       {
           
                           public void Convertations()
                {
                    Console.ForegroundColor =ConsoleColor.Red;
                        System.Console.WriteLine("Wellcome to currency conveter! if you want to exit from this programm write 'exit' ");
                         Console.ForegroundColor =ConsoleColor.White;
                        bool dsd =true;
                        while(dsd){
                             Console.ForegroundColor =ConsoleColor.Green;
                        System.Console.Write("Choose what currency do you want to convet. you must write usd or eur or som : ");
                         Console.ForegroundColor =ConsoleColor.White;
                    string conv =Console.ReadLine();
                   switch(conv)
                   {
                       case "usd":
                       {
                           double res =0;
                           System.Console.Write("Enter the amount usd :");
                           double sum =double.Parse(Console.ReadLine());
                            Console.ForegroundColor =ConsoleColor.Yellow;
                           System.Console.Write("what currency do you want to convert : if eur write => e or rub => r or som => s :");
                           Console.ForegroundColor =ConsoleColor.White;
                           string q =Console.ReadLine();
                           if(q.ToLower().Equals("e")){res =0.8238*sum; System.Console.WriteLine($"Your amount in eur : {res}");}
                           if(q.ToLower().Equals("r")){res =75.81*sum; System.Console.WriteLine($"Your amount in rub : {res}");}
                           if(q.ToLower().Equals("s")){res =11.38*sum; System.Console.WriteLine($"Your amount in som : {res}");}
                       }break;

                       case "eur":
                       {
                           double res =0;
                           System.Console.Write("Enter the amount eur :");
                           double sum =double.Parse(Console.ReadLine());
                            Console.ForegroundColor =ConsoleColor.Yellow;
                           System.Console.Write("what currency do you want to convert : if usd write => u or rub => r or som => s :");
                           Console.ForegroundColor =ConsoleColor.White;
                           string q =Console.ReadLine();
                           if(q.ToLower().Equals("u")){res =1.21*sum; System.Console.WriteLine($"Your amount in usd : {res}");}
                           if(q.ToLower().Equals("r")){res =92.03*sum; System.Console.WriteLine($"Your amount in rub : {res}");}
                           if(q.ToLower().Equals("s")){res =13.82*sum; System.Console.WriteLine($"Your amount in som : {res}");}
                       }break;

                       case "rub":
                       {
                            double res =0;
                           System.Console.Write("Enter the amount eur :");
                           double sum =double.Parse(Console.ReadLine());
                             Console.ForegroundColor =ConsoleColor.Yellow;
                           System.Console.Write("what currency do you want to convert : if usd write => u or eur => e or som => s :");
                            Console.ForegroundColor =ConsoleColor.White;
                           string q =Console.ReadLine();
                           if(q.ToLower().Equals("u")){res =0.013*sum; System.Console.WriteLine($"Your amount in usd : {res}");}
                           if(q.ToLower().Equals("e")){res =0.011*sum; System.Console.WriteLine($"Your amount in rub : {res}");}
                           if(q.ToLower().Equals("s")){res =0.15*sum; System.Console.WriteLine($"Your amount in som : {res}");}

                       }break;

                       case "som":
                       {
                             double res =0;
                           System.Console.Write("Enter the amount som :");
                           double sum =double.Parse(Console.ReadLine());
                            Console.ForegroundColor =ConsoleColor.Yellow;
                           System.Console.Write("what currency do you want to convert : if usd write => u or rub => r or eur => e :");
                            Console.ForegroundColor =ConsoleColor.White;
                           string q =Console.ReadLine();
                           if(q.ToLower().Equals("u")){res =0.088*sum; System.Console.WriteLine($"Your amount in usd : {res}");}
                           if(q.ToLower().Equals("r")){res =6.66*sum; System.Console.WriteLine($"Your amount in rub : {res}");}
                           if(q.ToLower().Equals("e")){res =0.072*sum; System.Console.WriteLine($"Your amount in som : {res}");}
                       }break;

                       case "exit":{dsd =false;}break;
                       default:
                       {System.Console.WriteLine("Error! try again");}break;
                   }
                   }
                }
       }
    
}
