using System;

namespace Anonim_Metod_21._02._2023HM
{
   delegate void Mydeleg1(int[]arr);
    delegate void MyDelegat2(int[] mass);

    class Class
    {

        static void Main(string[] args)
        {
            

            Console.ForegroundColor = ConsoleColor.DarkRed;
            int[] arr = new int[8];
            Random rand = new Random();
            Mydeleg1 obj = (int[] arr) =>
            {
                int Count = 0;
                for (int i = 0; i<arr.Length; i++)
                {
                    arr[i] = rand.Next(1,20);
                    Console.Write(arr[i]+"\t");
                    if (arr[i]%7==0)
                    {
                        Count++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("\n");
                Console.WriteLine("Количество чисел которые кратные 7 -------> "+Count);
            };
            obj(arr);
            Console.WriteLine("\n");


            int[] mass = new int[6] { -1, 3, -6, 23, 3, 3 };
            MyDelegat2 obj1 = (int[] mass) =>
            {
                int Counter = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                   
                    Console.Write(mass[i] + "\t");
                    if (mass[i]>0)
                    {
                        Counter++;
                    }
                   
                }
                Console.WriteLine("Количесвто положительных чисел ------> " + Counter);
                Console.WriteLine();
            };
            obj1(mass);

            Console.WriteLine("\n");
            MyDelegat2 obj2 = (int[] mass) =>
            {
                int Count = 0;
                for (int i = 0; i < mass.Length; i++)
                {

                    Console.Write(mass[i] + "\t");
                    if (mass[i]<0)
                    {
                        Count++;
                    }
                }
                Console.WriteLine("Количесвто отрицательных чисел ------> " + Count);
                Console.WriteLine();
            };
            obj2(mass);

            Console.WriteLine("\n");
            Console.WriteLine("Введите число");
            int A = Convert.ToInt32(Console.ReadLine());
            Mydeleg1 obj3 = (int[] arr) =>
            {
               
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 20);
                    Console.Write(arr[i] + "\t");
                    if (A == arr[i])
                    {
                        Console.WriteLine("Ваше число равно чеслу массива");

                    }
                    else
                    {
                        Console.WriteLine("Ваше число не равно чеслу массива");
                    }
                }
               
                Console.WriteLine();
                Console.WriteLine("\n");
                
            };
            obj3(arr);



        }
    }
}
