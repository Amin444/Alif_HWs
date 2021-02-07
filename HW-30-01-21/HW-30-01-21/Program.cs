using System;

namespace HW_30_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
        
          Person<string,int> p =new Person<string,int>
          {
                FisrtName ="jhgfd",
                LastName ="jhgfd",
                Age =43
          };
           
        }
        class Person<T, TA>
        {
            public T FisrtName { get; set; }
            public T LastName { get; set; }
            public TA Age { get; set; }
        }
        
    }
}
