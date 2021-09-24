using System;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vect = new int[10] { 5, 78, -8, 41, 0, 74, 6, 38, -7, -85 };

            Array.Sort(vect);

            Print(vect);
        }

        static void Print (int [] v)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(v[i]);
        }
    }
}
