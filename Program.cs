using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fib = Fibonachi(new List<int>(new int[] { 1, 1 }));

            foreach (int num in fib)
                Console.Write(num + "\t");

            int? index = Search(fib, 17711);
            //610 сразу при 30 числах!
            Console.WriteLine(new string('-',70)); 
            Console.WriteLine(index.ToString());

            int? Search(List<int> numbers, int found, int? mid = null, int? right = null, int? left = null)
            {
                if (right == null && left == null && mid == null)
                {
                    right = fib.Count - 1; left = 0; mid = (numbers.Count - 1) / 2;
                }
                else
                {
                    mid = (left + right) / 2;
                }
                if (fib[(int)mid] != found && fib[(int)mid] > found)
                    right = (int)mid;
                else if (fib[(int)mid] != found && fib[(int)mid] < found)
                    left  = (int)mid;
                else if (left == right)
                    return null;
                else if (fib[(int)mid] == found)
                    return mid;
                return Search(numbers, found, mid, right, left);
            }
            Console.ReadKey();
        }

        private static List<int> Fibonachi(List<int> numbers)
        {
            numbers.Add(numbers[numbers.Count - 1] + numbers[numbers.Count - 2]);
            if (numbers.Count < 30)
                return Fibonachi(numbers);
            else
                return numbers;
        }
    }
}
