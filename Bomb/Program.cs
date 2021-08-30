using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombnumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int indexBomb = bombnumber[0];
            int demage = bombnumber[1];

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i]==indexBomb)
                {
                    for (int j = i-demage; j <=i+demage; j++)
                    {
                        if (j < 0 || j >=number.Count)
                        {
                            continue;
                        }

                        number[j] = 0;
                    }
                }
            }

            Console.WriteLine(number.Sum());
        }
    }
}
