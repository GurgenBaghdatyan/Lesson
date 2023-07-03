using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Counter
    {
        public int Value { get; set; }
        public static Counter operator  +(Counter a, Counter b)
        {
            return new Counter { Value = a.Value + b.Value, };
        }
        public static Counter operator -(Counter a, Counter b)
        {
            return new Counter { Value = a.Value - b.Value, };
        }
    }
}
