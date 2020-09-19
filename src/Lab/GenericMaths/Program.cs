using System;
using System.Diagnostics;

namespace GenericMaths
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [GenericMaths.GenericMaths]
        public float Test(float p)
        {
            float a = p * 5f + 2f;
            return a;
        }
    }
}
