using System;
using System.Linq;
using Silk.NET.Maths;

namespace JITTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ScalarByte.EntryPoint();
            ScalarSByte.EntryPoint();
            ScalarUShort.EntryPoint();
            ScalarShort.EntryPoint();
            ScalarUInt32.EntryPoint();
            ScalarInt32.EntryPoint();
            ScalarUInt64.EntryPoint();
            ScalarInt64.EntryPoint();
            ScalarHalf.EntryPoint();
            ScalarFloat.EntryPoint();
            ScalarDouble.EntryPoint();
        }
    }
}
