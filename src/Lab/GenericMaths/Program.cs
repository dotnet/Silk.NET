using System;
using System.Diagnostics;

namespace GenericMaths
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [GenericMaths]
    public struct TypeSpecialization
    {
        public float Field;
        public float Property { get; set; }

        public float Method()
        {
            var a = Field + Property;
            var b = 5 + 5;
            var c = a + b;
            return c * c;
        }
    }
}
