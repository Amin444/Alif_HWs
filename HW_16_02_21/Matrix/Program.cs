using System;

namespace Matrix
{
   class Program
    {

        static Random rand = new Random();

        static char AsciiCharacter
        {
            get
            {
                int t = rand.Next(10);
                if (t <= 2)
                    return (char)('0' + rand.Next(10));
               
                    return (char)(rand.Next(0, 50));
            }
        }

        static void Main()
        {
           geen();
        
            Console.CursorVisible = false;

            int width, height;
            int[] y;

            Initialize(out width, out height, out y);


            while (true)
                    NewStrings(width, height, y);
        }


        private static void NewStrings(int width, int height, int[] y)
        {
            int x;

            for (x = 0; x < width; ++x)
            {
               white();
                Console.SetCursorPosition(x, y[x]);
                Console.Write(AsciiCharacter);

               DarkGreen();
                int temp = y[x] - 2;
                Console.SetCursorPosition(x, inScreenYPosition(temp, height));
                Console.Write(AsciiCharacter);

                int temp1 = y[x] - 20;
                Console.SetCursorPosition(x, inScreenYPosition(temp1, height));
                Console.Write(' ');

                y[x] = inScreenYPosition(y[x] + 1, height);
            }

            if (Console.KeyAvailable)
            {
                if (Console.ReadKey().Key == ConsoleKey.F5)
                    Initialize(out width, out height, out y);
                if (Console.ReadKey().Key == ConsoleKey.F11)
                    System.Threading.Thread.Sleep(1);
            }

        }

        public static int inScreenYPosition(int yPosition, int height)
        {
            if (yPosition < 0)
                return yPosition + height;
            else if (yPosition < height)
                return yPosition;
            else
                return 0;
        }

        private static void Initialize(out int width, out int height, out int[] y)
        {
            height = Console.WindowHeight;
            width = Console.WindowWidth - 1;

            y = new int[width];

            Console.Clear();
            for (int x = 0; x < width; ++x)
            {
                y[x] = rand.Next(height);
            }
        }

            public static void geen(){var green = Console.ForegroundColor=ConsoleColor.Green;}
            public static void white(){var white = Console.ForegroundColor=ConsoleColor.White;}
            public static void DarkGreen(){var white = Console.ForegroundColor=ConsoleColor.DarkGreen;}
                
              
          


    }
}
