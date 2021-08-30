using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input !="end")
            {
                input = Console.ReadLine();
                string[] target = input.Split();

                string comand = target[0];

                switch (comand)
                {
                    case "Add":
                        int indexofAdd = int.Parse(target[1]);
                        numbers.Add(indexofAdd);
                        break;
                    case "Remove":
                        int index = int.Parse(target[1]);
                        numbers.Remove(index);
                        break;
                    case "RemoveAt":
                        int indexRemAt = int.Parse(target[1]);
                        numbers.RemoveAt(indexRemAt);
                        break;
                    case "Insert":
                        int numInsert = int.Parse(target[1]);
                        int indexOfInsert = int.Parse(target[2]);
                        numbers.Insert(indexOfInsert,numInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
