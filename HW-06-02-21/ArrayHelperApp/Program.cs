using System;

namespace ArrayHelperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a={"wc","fvd","g","r","a"};
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
           
            ArrayHelper<string> arrhp = new ArrayHelper<string>();
            arrhp.Pop(ref a);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            ///////////////////////////////////////////////////////////////
            
             string[] numbers = { "1", "2", "3", "4", "5",  };
            foreach (var y in numbers) 
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("------------------------------");

            ArrayHelper<string> ar = new ArrayHelper<string>();
            ar.Push(ref numbers, "6");
            foreach (var y in numbers)
            {
                Console.WriteLine(y);
            }
          //  \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

                 string[] ns = { "1", "2", "3", "4", "5",  };
            foreach (var y in ns) 
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("------------------------------");
            ArrayHelper<string> rr = new ArrayHelper<string>();
            ar.Shift(ref ns); 
            
            foreach (var y in ns)
            {
                Console.WriteLine(y);
            }

                  string[] sd = { "1", "2", "3", "4", "5",  };
            foreach (var y in sd) 
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("------------------------------");
             ArrayHelper<string> er = new ArrayHelper<string>();
             er.UnShift(ref sd, "0");
            foreach (var y in sd)
            {
                Console.WriteLine(y);
            }   

            string[] Words = { "ant","bee","Cat","Duck","Egle","Fly","Gun","Hot"};
            ArrayHelper<string> irt = new ArrayHelper<string>();
            //irt.Slice(ref Words, 3);
             irt.Slice(ref Words, 1, -5);
                Console.ReadKey();
        }
    }

    }
         class ArrayHelper<T>
    {
        public T Pop(ref T[] we)
        {
                  T[] arr = new T[we.Length - 1];
            for (int i = 0; i < we.Length - 1; i++)
            {
                arr[i] = we[i];

            }
            T a = we[we.Length - 1];
            we = arr;
            return a;
        }
         public void Push(ref T[] we,T ff)
        {

            T[] arr = new T[we.Length + 1];
            for (int i = 0; i < we.Length; i++)
            {
                arr[i] = we[i];

            }
            arr[arr.Length - 1] = ff;
            we = arr;
        }
        public  T Shift(ref T[] rr)
        {

            T[] arr = new T[rr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rr[i+1];

            }
            T s = rr[0];
            rr = arr;
            return s;
        }
        public  void UnShift(ref T[] tt, T ff)
        {
            T[] arr = new T[tt.Length + 1];
            arr[0] = ff;
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i+1] = tt[i];
            }
            tt = arr;
        }
        public T[] Slice(ref T[] sl, int num, int v)
        {
             if (num < 0)
        {
            T[] Arr = new T[Math.Abs(num)];
            int cn = 0;
            bool ch = true;
            for (int i = sl.Length - 1; ch; i--)
            {
                ch = !(cn == Math.Abs(num) - 1);
                Arr[cn] = sl[i];
                cn++;
            }
            return Arr;
        }
        else if (num > 0)
        {
            T[] Arr = new T[sl.Length - num + 1];
            int cn = 0;
            for (int i = 0; i <= num; i++)
            {
                Arr[cn] = sl[i];
                cn++;
            }
            return Arr;
        }
        else
        {
            return sl;
        }
        }
    }

