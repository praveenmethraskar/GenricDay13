using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDay13
{
    public class FindMax
    {
        public T FindMaxValue<T>(T num1, T num2, T num3) where T : IComparable
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
            return default;
        }

        

    }
}
