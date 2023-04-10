using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace ITP1_7_B
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string[] Input = Console.ReadLine().Split(' ');
                var n = int.Parse(Input[0]);
                var x = int.Parse(Input[1]);

                List<int> Num = new();

                if (n == 0 && x == 0) break;

                for (int i = 0; i < n; i++)
                {
                    Num.Add(i + 1);
                }
                var Result = 0;
                var Count = 0;
                Num.ToArray();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 1 + i; j < n; j++)
                    {
                        if (j == n - 2) Count++;
                        for (int k = 2 + j; k < n; k++)
                        {
                            if (Num[Count] + Num[j] + Num[k] == x) Result++;
                        }
                    }
                }
                Console.WriteLine(Result);
            }
        }
    }
}