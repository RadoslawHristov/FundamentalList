using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstplayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondplayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            //for (int i = 0; i < firstplayer.Count; i++)
            //{
            //    for (int j = 0; j < secondplayer.Count; j++)
            //    {
            //        if (firstplayer[i]==secondplayer[j])
            //        {
            //            firstplayer.Remove(firstplayer[i]);
            //            secondplayer.Remove(secondplayer[j]);
            //        }
            //        else if (firstplayer[i] > secondplayer[j] )
            //        {
            //            sumFirst += firstplayer[i] + secondplayer[j];
            //        }
            //        else if (secondplayer[j] > firstplayer[i])
            //        {
            //            sumSec += secondplayer[j] + firstplayer[i];
            //        }
            //    }
            //}

            //Console.WriteLine(String.Join(" ",firstplayer));
            //Console.WriteLine(String.Join(" ",secondplayer));
            while (true)
            {
                if (firstplayer[0] > secondplayer[0])
                {
                    firstplayer.Add(firstplayer[0]);
                    firstplayer.Add(secondplayer[0]);
                }
                else if (secondplayer[0] > firstplayer[0])
                {
                    secondplayer.Add(secondplayer[0]);
                    secondplayer.Add(firstplayer[0]);
                }

                firstplayer.Remove(firstplayer[0]);
                secondplayer.Remove(secondplayer[0]);

                if (firstplayer.Count==0)
                {
                    int sum = secondplayer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondplayer.Count == 0)
                {
                    int sum = firstplayer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}

