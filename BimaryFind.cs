using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFind
{
   public static class Binary
    {
        public static int? Find(List<int> numbers, int found, int? mid = null, int? right = null, int? left = null)
        {
            if (right == null && left == null && mid == null)
            {
                right = numbers.Count - 1; left = 0; mid = (numbers.Count - 1) / 2;
            }
            else
                mid = (left + right) / 2;
            if (numbers[(int)mid] != found && numbers[(int)mid] > found)
                right = right == mid ? --right : (int)mid;
            else if (numbers[(int)mid] != found && numbers[(int)mid] < found)
            {
                left = left == mid ? ++left : (int)mid;
            }
            else if (numbers[(int)mid] == found)
                return mid;
            else if (left >= right)
                return null;
            return Find(numbers, found, mid, right, left);
        }
    }
}
