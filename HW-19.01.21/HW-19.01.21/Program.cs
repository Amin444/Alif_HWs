﻿using System;

namespace HW_19._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
           /*1. Даны два неотрицательных числа a и b. Найти их среднее геометрическое, то
           есть квадратный корень из их произведения: √a·b.*/

           // double a= 16.8, b = 12.4;

           // double res=Math.Sqrt(a*b);
           // System.Console.WriteLine($"Result: {res}");

           //////////////////////////////////////////////////////////////////

           /*2. Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их сумму*/

           // double a =Math.Abs(1.4),b= Math.Abs(-5.5),c=Math.Abs(0.6);

           // double AC=a-c;
           // double BC=b+c;
           // double Result=AC+BC;
           // System.Console.WriteLine($" AC: {AC} \n BC: {BC} \n Result: {Result}");

           //////////////////////////////////////////////////////////////////////////////

           /*3. Найти расстояние между двумя точками с заданными координатами (x1,y1) и
                (x2,y2) на плоскости. Расстояние вычисляется по формуле √((x2 — x1)2 + (y2 —y1)2)*/

              //  double x1=-6.2, y1=5.2;
              //  double x2=2.1 , y2=9.8;

              //  double x= x2-x1, y= y2-y1;
                
              //  double res=Math.Sqrt(Math.Pow(x, 2)+ Math.Pow(y, 2));
              //  System.Console.WriteLine($" Result: {res}");

            /////////////////////////////////////////////////////////////////////////////////

            /*4. Дано двузначное число. Вывести число, полученное при перестановке цифрисходного числа.*/

               // int num =41;
               // int chen1=num/10, chen2=num%10;

               // System.Console.WriteLine($" Result: {chen2}{chen1}");

            /////////////////////////////////////////////////////////////////////////////////

            /*5. С начала суток прошло N секунд (N — целое). Найти количество полных минут,прошедших с начала суток.*/

           // int n =10985;

           // int res =n/60;

           // System.Console.WriteLine($"Полных мин: {res}");

           /*6. Дни недели пронумерованы следующим образом: 0 — воскресенье, 1 —понедельник, 2 — вторник, …, 6 — суббота. Дано целое число K, лежащее 
           в диапазоне 1–365. Определить номер дня недели для K-го дня года, еслиизвестно, что в этом году 1 января было понедельником.*/

           int k = 202;
           int res=0;
           for (int i = 7; i < k;i +=0)
           {
                res =k-=7;
              
           }
           System.Console.WriteLine($" Result {res}");

        }
    }
}
