using System;

namespace HW_26_01021
{
    class Program
    {
        static void Main(string[] args)
        {
            // HW 1  //task1 
         /*   System.Console.Write("Enter the side1 and side2 : ");
            var rec =new Rectangle(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
           System.Console.WriteLine($"Area : {rec.AreaCalculator()}");
           System.Console.WriteLine($"Perimeter {rec.PerimeterCalculator()}");*/
           /////////////////////////////////////////////////////////////////////////////////////

                 //task 2
            
                    var b = new BooK();
                    b.shows();
                    
           

            /////////////////////////////////////////////////////////////////////////////////////////////////

                //task 3
                 /*     System.Console.WriteLine("=========================================================");
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
                   converter.Convertations(); */

                    /////////////////////////////////////////////////////////////////////////////////////////////

                    // task 2

                   //  var em =new Employee();
                   //  em.Allsalery();
                       
                   
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
           public void shows()
           {
             var T =new Title();
             var A =new Author();
             var C =new Content();
          
           T.show();
           A.show();
           C.show();
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
                    Console.ForegroundColor=ConsoleColor.White;

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
                    Console.ForegroundColor=ConsoleColor.White;
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
                     Console.ForegroundColor=ConsoleColor.White;
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

      public class Converter
       {
               
                double usd,eur,rub,som;

                public Converter(double eur, double rub, double usd , double som){
                    this.eur=eur;
                    this.rub=rub;
                    this.som=som;
                    this.usd=usd;
                }
                public Converter(){}
                public double result { get; init; }
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
                           
                           System.Console.Write("Enter the amount usd :");
                           double sum =double.Parse(Console.ReadLine());
                            Console.ForegroundColor =ConsoleColor.Yellow;
                           System.Console.Write("what currency do you want to convert : if eur write => e or rub => r or som => s :");
                           Console.ForegroundColor =ConsoleColor.White;
                           string q =Console.ReadLine();
                           if(q.ToLower().Equals("e")){eur =0.8238*sum; System.Console.WriteLine($"Your amount in eur : {eur}");}
                           if(q.ToLower().Equals("r")){rub =75.81*sum; System.Console.WriteLine($"Your amount in rub : {rub}");}
                           if(q.ToLower().Equals("s")){som =11.38*sum; System.Console.WriteLine($"Your amount in som : {som}");}
                        
                       }break;

                       case "eur":
                       {
                           
                           System.Console.Write("Enter the amount eur :");
                           double sum =double.Parse(Console.ReadLine());
                            Console.ForegroundColor =ConsoleColor.Yellow;
                           System.Console.Write("what currency do you want to convert : if usd write => u or rub => r or som => s :");
                           Console.ForegroundColor =ConsoleColor.White;
                           string q =Console.ReadLine();
                           if(q.ToLower().Equals("u")){usd =1.21*sum; System.Console.WriteLine($"Your amount in usd : {usd}");}
                           if(q.ToLower().Equals("r")){rub =92.03*sum; System.Console.WriteLine($"Your amount in rub : {rub}");}
                           if(q.ToLower().Equals("s")){som =13.82*sum; System.Console.WriteLine($"Your amount in som : {som}");}
                       
                       }break;

                       case "rub":
                       {
                            
                           System.Console.Write("Enter the amount rub :");
                           double sum =double.Parse(Console.ReadLine());
                             Console.ForegroundColor =ConsoleColor.Yellow;
                           System.Console.Write("what currency do you want to convert : if usd write => u or eur => e or som => s :");
                            Console.ForegroundColor =ConsoleColor.White;
                           string q =Console.ReadLine();
                           if(q.ToLower().Equals("u")){usd =0.013*sum; System.Console.WriteLine($"Your amount in usd : {usd}");}
                           if(q.ToLower().Equals("e")){eur =0.011*sum; System.Console.WriteLine($"Your amount in rub : {eur}");}
                           if(q.ToLower().Equals("s")){som =0.15*sum; System.Console.WriteLine($"Your amount in som : {som}");}
                           
                       }break;

                       case "som":
                       {
                             
                           System.Console.Write("Enter the amount som :");
                           double sum =double.Parse(Console.ReadLine());
                            Console.ForegroundColor =ConsoleColor.Yellow;
                           System.Console.Write("what currency do you want to convert : if usd write => u or rub => r or eur => e :");
                            Console.ForegroundColor =ConsoleColor.White;
                           string q =Console.ReadLine();
                           if(q.ToLower().Equals("u")){usd =0.088*sum; System.Console.WriteLine($"Your amount in usd : {usd}");}
                           if(q.ToLower().Equals("r")){rub =6.66*sum; System.Console.WriteLine($"Your amount in rub : {rub}");}
                           if(q.ToLower().Equals("e")){eur =0.072*sum; System.Console.WriteLine($"Your amount in som : {eur}");}
                           
                       }break;

                       case "exit":{dsd =false;}break;
                       default:
                       {System.Console.WriteLine("Error! try again");}break;
                   }
                   }
                 
                }

        }
                class Employee
                {
                    public string Name { get; set; }
                    public string LastName { get; set; }
                    public string position { get; set; }
                    public int Salary { get; set; }

                    public Employee(string Name, string LastName, string position,int Salary)
                    {
                            this.Name =Name;
                            this.LastName=LastName;
                            this.position =position;
                            this.Salary=Salary;
                    }
                    public Employee(){}

                    public void Allsalery()
                    {
                       Name = "Amin"; LastName ="Mirzoev";position ="programmer";Salary =20000;
                        System.Console.WriteLine($" Name of Employee : { Name} ");
                        System.Console.WriteLine($" LastName of Employee : { LastName}");
                        System.Console.WriteLine($" position of Employee : { position }");
                        System.Console.WriteLine($" Salery of Employee : { Salary }");
                         double res =Salary * 0.14;
                         System.Console.WriteLine($"Your taxes : {res}");
                    }
                }

       
             

