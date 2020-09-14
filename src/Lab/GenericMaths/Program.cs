using System;
using System.Diagnostics;

namespace GenericMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new Matrix4x4<int>(
                1, 0, 0, 9,
                0, 1, 5, 0,
                0, 0, 1, 12,
                0, 0, 5, 1);
            var result = matrix * Matrix4x4<int>.Identity;
            var det = result.GetDeterminant();
            Debug.Assert(matrix == result);
            Console.WriteLine(matrix);
            Console.WriteLine(result);
            Console.WriteLine(det);
            Console.WriteLine(new System.Numerics.Matrix4x4(1, 0, 0, 9,
                0, 1, 5, 0,
                0, 0, 1, 12,
                0, 0, 5, 1).GetDeterminant());
        }
    }
}
