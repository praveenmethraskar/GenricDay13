using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDay13
{
    public class FindMax
    {
        public int FindMaxInteger(int num1, int num2, int num3)
        {
            if(num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if(num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else if(num3.CompareTo(num1) > 0 && num3.CompareTo(num1) > 0)
            {
                return num3;
            }
            return 0;
        }

        public float FindMaxString(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            return 0;
        }
    }
}
