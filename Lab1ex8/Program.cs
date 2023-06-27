using System;

namespace Lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex8.Scrieti un program care interschimba valoarea a doua variabile intregi.*/
            // Am folosit interentul ca sa reusesc asta si sa inteleg,singur nu am stiut

            int a = 5;
            int b = 10;

            Console.WriteLine("Inainte de interschimbare:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Swap(ref a, ref b);

            Console.WriteLine("Dupa interschimbare:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}