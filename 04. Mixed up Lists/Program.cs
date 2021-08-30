using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> num2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resul1 = new List<int>();
            int start = 0;
            int end = 0;
            for (int i = 0; i < num2.Count; i++)
            {
                start = num1[num1.Count - 1];
                end = num1[num1.Count - 2];
                resul1.Add(num1[i]);
                resul1.Add(num2[num2.Count-1-i]);
                
            }
            resul1.Sort();
            Console.WriteLine(string.Join(" ", resul1.Where(x => x < end).Where(x =>x > start)));
            // 0 / 100
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
// 
//namespace _04.Mixed_up_Lists
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> inputOne = Console.ReadLine().Split().Select(int.Parse).ToList();
//            List<int> inputTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
//            List<int> rule = new List<int>();
//            List<int> maxList = new List<int>();
//            List<int> mixedList = new List<int>();
//            if (inputOne.Count > inputTwo.Count)
//            {
//                maxList = inputOne;
//            }
//            else
//            {
//                maxList = inputTwo;
//                maxList.Reverse();
//            }
//            for (int i = maxList.Count - 2; i < maxList.Count; i++)
//            {
//                rule.Add(maxList[i]);
//            }
//            rule.Sort();
//            if (inputOne.Count > inputTwo.Count)
//            {
//                inputOne.RemoveRange(inputOne.Count - 2, 2);
//                inputTwo.Reverse();
//            }
//            else
//            {
//                inputTwo.RemoveRange(inputTwo.Count - 2, 2);
//                inputTwo.Reverse();
//            }
//            for (int i = 0; i < inputOne.Count; i++)
//            {
//                mixedList.Add(inputOne[i]);
//                mixedList.Add(inputTwo[i]);
//            }
//            List<int> output = mixedList.FindAll(x => x > rule[0] && x < rule[1]);
//            output.Sort();
//            Console.WriteLine(string.Join(" ", output));
               // 100 / 100
//        }
//    }
//}
