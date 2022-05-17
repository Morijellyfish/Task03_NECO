using System;
using System.Linq;
using System.Collections.Generic;

namespace Task03_NECO
{
    class Program
    {
        static void Main(string[] args)
        {
            Task02();
        }
        static void Task01()
        {
            //input
            int[] array;
            var list = new List<int>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "0")
                {
                    break;
                }
                else
                {
                    list.Add(int.Parse(line));
                }
            }
            array = list.ToArray();

            //output
            foreach (int i in array)
            {
                int a = 1000 - i;
                Console.WriteLine(
                    (a / 500) + (a % 500 / 100) + (a % 100 / 50) + (a % 50 / 10) + (a % 10 / 5) + (a % 5)
                    );
            }
        }
        static void Task02()
        {
            //
            string[] linestr = Console.ReadLine().Split(' ');
            int n = int.Parse(linestr[0]);
            int m = int.Parse(linestr[1]) - 1;
            int[] coins = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //
            int[] mins = new int[n + 1];
            for (int i = 0; i < mins.Length; i++)
            {
                mins[i] = 99999;
            }

            foreach (int c in coins)
            {
                if (c <= n)
                {
                    mins[c] = 1;
                }
            }

            int min;
            for (int i = 0; i <= n; i++)
            {
                min = n + 1;
                foreach (int c in coins)
                {
                    if (i - c >= 0)
                    {
                        mins[i] = Math.Min(mins[i], mins[i - c] + 1);
                    }

                }
            }
            Console.WriteLine(mins[n]);
        }

    }
}
