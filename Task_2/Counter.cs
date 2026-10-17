using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public static class Counter
    {
        public  static int Count { get; set;}
        public static int IncreaseCount()
        {
            return ++Count;
        }
    }
}
