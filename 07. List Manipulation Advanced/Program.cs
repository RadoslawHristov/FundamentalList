using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int count = 0;
            string input = Console.ReadLine();
            while (input != "end")
            {

                string[] target = input.Split();

                string comand = target[0];

                switch (comand)
                {
                    case "Add":
                        count++;
                        int indexofAdd = int.Parse(target[1]);
                        numbers.Add(indexofAdd);
                        break;
                    case "Remove":
                        count++;
                        int index = int.Parse(target[1]);
                        numbers.Remove(index);
                        break;
                    case "RemoveAt":
                        count++;
                        int indexRemAt = int.Parse(target[1]);
                        numbers.RemoveAt(indexRemAt);
                        break;
                    case "Insert":
                        count++;
                        int numInsert = int.Parse(target[1]);
                        int indexOfInsert = int.Parse(target[2]);
                        numbers.Insert(indexOfInsert, numInsert);
                        break;
                    case "Contains":
                        int Containsnum = int.Parse(target[1]);
                        if (numbers.Contains(Containsnum))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        break;
                        Console.WriteLine();
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        break;
                        Console.WriteLine();
                    case "GetSum":
                        int sumOfList = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sumOfList += numbers[i];
                        }
                        Console.Write(sumOfList + " ");
                        break;
                        Console.WriteLine();
                    case "Filter":
                        string post = target[1];
                        int filter = int.Parse(target[2]);
                        if (post == "<")
                        {
                            Console.WriteLine();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < filter)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                        }
                        else if (post == ">")
                        {
                            Console.WriteLine();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > filter)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }


                        }
                        else if (post == "<=")
                        {
                            Console.WriteLine();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= filter)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                        }
                        else if (post == ">=")
                        {
                            Console.WriteLine();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= filter)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            if (input == "end" && count > 0)
            {
                Console.Write(string.Join(" ", numbers));
            }

        }
    }
}
