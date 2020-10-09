using System;
using System.Diagnostics;

namespace GenericMaths
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test<byte>(byte.MaxValue));
            Console.WriteLine(Test<double>(3));
            var a = new TypeSpecialization<double>();
            a.Field = 5.0;
            a.Property = 9.0;
            Console.WriteLine(a.Method());
            var b = new TypeSpecialization2_UShort();
            b.Field = 5;
            b.Property = ushort.MaxValue;
            Console.WriteLine(b.Method());
        }

        [GenericMaths(GenerateSpecialized = false, GenerateGeneric = true /* these are the defaults, just to demonstrate usage. */)]
        protected static float Test(float t) => t + 5;
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
    
    [GenericMaths(GenerateSpecialized = true, GenerateGeneric = false)]
    public struct TypeSpecialization2
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
