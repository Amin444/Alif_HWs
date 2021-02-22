using System;
using System.Threading.Tasks;


namespace NewMateix
{
     class Program
    {
        static int Counter;
        static Random RanPos = new Random();
        static int FlowSpeed = 100;
        static int FastFlow = FlowSpeed + 30;
        static int TextSpeed = FastFlow + 50;

        static ConsoleColor baseColor = ConsoleColor.DarkGreen;
        static ConsoleColor greenColor = ConsoleColor.Green;
        static ConsoleColor fadedColor = ConsoleColor.White;

     
     

        static char AssciCharacters
        {
            get
            {
                int t = RanPos.Next();
                if (t <= 2)
                    return (char)('0' + RanPos.Next(10));
                else if (t <= 4)
                    return (char)('a' + RanPos.Next(27));
                else if (t <= 6)
                    return (char)('A' + RanPos.Next(27));
                else
                    return (char)(RanPos.Next(32, 255));
            }
        }
        static async Task Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = baseColor;
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Console.SetWindowPosition(0, 0);
            Console.CursorVisible = false;
            int width, height;
            int[] y;
            Initialize(out width, out height, out y);
            while (true)
            {
            
                Counter++;
                Task.Run(() =>
                {
                    ColumnUpdate(width, height, y);
                }).Wait();
                if (Counter > (3 * FlowSpeed))
                    Counter = 0;
            }
        }
        static int YPositionFields(int yPosition, int height)
        {
            if (yPosition < 0) return yPosition + height;
            else if (yPosition < height) return yPosition;
            else return 0;
        }
        private static void Initialize(out int width, out int height, out int[] y)
        {
            height = Console.WindowHeight;
            width = Console.WindowWidth - 1;
            y = new int[width];
            Console.Clear();
            for (int i = 0; i < width; i++)
            {
                y[i] = RanPos.Next(height);
            }
        }
        private static void ColumnUpdate(int width, int height, int[] y)
        {
            int x;
            if (Counter < FlowSpeed)
            {
                for (x = 0; x < width; x++)
                {
                    if (x % 10 == 1) Console.ForegroundColor = fadedColor;
                    else Console.ForegroundColor = baseColor;

                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(AssciCharacters);

                    if (x % 10 == 9) Console.ForegroundColor = fadedColor;
                    else Console.ForegroundColor = baseColor;

                    int temp = y[x] - 2;
                    Console.SetCursorPosition(x, YPositionFields(temp, height));
                    Console.Write(AssciCharacters);

                    int temp2 = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp, height));
                    Console.Write(' ');
                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
            else if (Counter > FlowSpeed && Counter < FastFlow)
            {
                for (x = 0; x < width; x++)
                {
                    Console.SetCursorPosition(x, y[x]);
                    if (x % 10 == 9) Console.ForegroundColor = fadedColor;
                    else Console.ForegroundColor = baseColor;

                    Console.Write(AssciCharacters);

                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
            else if (Counter > FastFlow)
            {
                for (x = 0; x < width; x++)
                {
                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(' ');

                    int temp = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp, height));
                    Console.Write(' ');

                    if (Counter > FastFlow && Counter < TextSpeed)
                    {
                        if (x % 10 == 9) Console.ForegroundColor = fadedColor;
                        else Console.ForegroundColor = baseColor;
                        Console.Write(AssciCharacters);
                    }
                    Console.SetCursorPosition(width / 2, height / 2);
                   
                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
        }
       
        
    }
 }


