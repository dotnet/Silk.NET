using System;
using System.Diagnostics;

namespace GenericMaths
{
    partial class Program
    {
        static void Main(string[] args)
        {
        }

        [GenericMaths]
        public float Test(float p)
        {
            float a = p * (5f + -5f);
            float b = p * (5f + 12f);
            float c = p * (5f + 95f);
            float d = p * (5f + +9f);
            return a + b + c + d;
        }
    }

    [GenericMaths]
    public partial struct Test
    {
        public float M(float p)
        {
            return 5 + p;
        }
    }
}
