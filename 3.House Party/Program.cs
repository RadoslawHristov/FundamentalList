using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<string> nameOfParty = new List<string>();
            string nameisd = String.Empty;
            for(int i=0; i < input; i++)
            {
                string[] people = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (people[2] == "not")
                {
                    if (nameOfParty.Contains(people[0]))
                    {
                        nameOfParty.Remove(people[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{people[0]} is not in the list!");
                        
                    }
                }
                else if(people[2]=="going!")
                {
                    if (nameOfParty.Contains(people[0]))
                    {
                        Console.WriteLine($"{people[0]} is already in the list!");
                    }
                    else
                    {
                        nameOfParty.Add(people[0]);
                    }
                }
            }
            
            Console.WriteLine(string.Join("\n", nameOfParty));
        }
    }
}
