using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignment
{
    class UC4_GenericsAssignment

    {

 
        public class UC4_Generics<T> where T : IComparable
        {
            public T[] value;
            public UC4_Generics(T[] value)
            {
                this.value = value;
            }
            public static T MaxNum(T Num1, T Num2, T Num3)
            {
                if ((Num1).CompareTo(Num2) > 0 && (Num1).CompareTo(Num3) > 0 ||
                    (Num1).CompareTo(Num2) >= 0 && (Num1).CompareTo(Num3) > 0 ||
                    (Num1).CompareTo(Num2) > 0 && (Num1).CompareTo(Num3) >= 0)
                {
                    return Num1;
                }
                if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0 ||
                    Num2.CompareTo(Num1) >= 0 && Num2.CompareTo(Num3) > 0 ||
                    Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) >= 0)
                {
                    return Num2;
                }
                if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0 ||
                    Num3.CompareTo(Num1) >= 0 && Num3.CompareTo(Num2) > 0 ||
                    Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) >= 0)
                {
                    return Num3;
                }
                return Num1;
            }
            public T[] Sort(T[] value)
            {
                Array.Sort(value);
                return value;
            }
            public T MaxValue(params T[] value)
            {
                var sorted_value = Sort(value);
                return sorted_value[sorted_value.Length - 1];
            }
            public T MaxMethod()
            {
                var max = MaxValue(value);
                return max;
            }
        }
    }
}
