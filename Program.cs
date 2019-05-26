using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFind
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fib = Fibonachi(new List<int>(new int[] {0, 1, 1 }));

            foreach (int num in fib)
                Console.Write(num + "\r\n");

            int? index = Binary.Find(fib, 0);
            //610 сразу при 30 числах!
            Console.WriteLine(new string('-',70)); 
            Console.WriteLine(index.ToString());

          
            Console.ReadKey();
        }

        private static List<int> Fibonachi(List<int> numbers)
        {
            numbers.Add(numbers[numbers.Count - 1] + numbers[numbers.Count - 2]);
            if (numbers.Count < 32)
                return Fibonachi(numbers);
            else
                return numbers;
        }
    }
}
