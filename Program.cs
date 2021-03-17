using System;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Дан массив. Все его элементы:
           а) увеличить в 2 раза;
           б) уменьшить на число а;
           
           г) уменьшить на 20;
           д) умножить на последний элемент;
           е) увеличить на число b.
           */
           

            Console.WriteLine("Size Array");
            int size = int.Parse(Console.ReadLine());
            throw new Exception("Введите число больше или равное 4");

            int [] arr =  new int [size];

            Random r = new Random();

            Console.WriteLine(" Number a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Number b");
            int b = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(); 

                arr[i] = arr[i] * 2;

                arr[i] = arr[i] - a;

                

                arr[i] = arr[i] - 20;

                arr[i] = arr[i] * arr[3];

                arr[i] = arr[i] - b;

                Console.WriteLine(arr[i]);


            }
           
        }
    }
}
