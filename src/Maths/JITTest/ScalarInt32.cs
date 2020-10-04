using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarInt32
    {
        [M(N)]
        public static void EntryPoint()
        {
            try {Atan(default);} catch { }
            try {Atan2(default,default);} catch { }
            try {Cos(default);} catch { }
            try {Cosh(default);} catch { }
            try {One();} catch { }
            try {Two();} catch { }
            try {IsNormal(default);} catch { }
            try {Pi();} catch { }
            try {Tau();} catch { }
            try {HalfPi();} catch { }
            try {PositiveInfinity();} catch { }
            try {NegativeInfinity();} catch { }
            try {As(default);} catch { }
            try {SquareRoot(default);} catch { }
            try {Add(default,default);} catch { }
            try {Mod(default,default);} catch { }
            try {Subtract(default,default);} catch { }
            try {Multiply(default,default);} catch { }
            try {Divide(default,default);} catch { }
            try {Min(default,default);} catch { }
            try {Max(default,default);} catch { }
            try {Larger(default,default);} catch { }
            try {Smaller(default,default);} catch { }
            try {LargerEquals(default,default);} catch { }
            try {SmallerEquals(default,default);} catch { }
            try {Clamp(default,default,default);} catch { }
            try {Negate(default);} catch { }
            try {Equal(default,default);} catch { }
            try {Acos(default);} catch { }
            try {Abs(default);} catch { }
            try {Sin(default);} catch { }
            try {Sinh(default);} catch { }
            try {Asin(default);} catch { }
        }

        private const MethodImplOptions N = MethodImplOptions.NoInlining;

        [M(N)]
        private static int Atan(int value) => Scalar.Atan(value);

        [M(N)]
        private static int Atan2(int left, int right) => Scalar.Atan2(left, right);

        [M(N)]
        private static int Cos(int value) => Scalar.Cos(value);

        [M(N)]
        private static int Cosh(int value) => Scalar.Cosh(value);

        [M(N)]
        private static int One() => Scalar.One<int>();

        [M(N)]
        private static int Two() => Scalar.Two<int>();

        [M(N)]
        private static bool IsNormal(int value) => Scalar.IsNormal(value);

        [M(N)]
        private static int Pi() => Scalar.Pi<int>();

        [M(N)]
        private static int Tau() => Scalar.Tau<int>();

        [M(N)]
        private static int HalfPi() => Scalar.HalfPi<int>();

        [M(N)]
        private static int PositiveInfinity() => Scalar.PositiveInfinity<int>();

        [M(N)]
        private static int NegativeInfinity() => Scalar.NegativeInfinity<int>();

        [M(N)]
        private static int As(double value) => Scalar.As<int>(value);

        [M(N)]
        private static int SquareRoot(int value) => Scalar.SquareRoot(value);

        [M(N)]
        private static int Add(int left, int right) => Scalar.Add(left, right);

        [M(N)]
        private static int Mod(int left, int right) => Scalar.Mod(left, right);

        [M(N)]
        private static int Subtract(int left, int right) => Scalar.Subtract(left, right);

        [M(N)]
        private static int Multiply(int left, int right) => Scalar.Multiply(left, right);

        [M(N)]
        private static int Divide(int left, int right) => Scalar.Divide(left, right);

        [M(N)]
        private static int Min(int left, int right) => Scalar.Min(left, right);

        [M(N)]
        private static int Max(int left, int right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(int left, int right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(int left, int right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(int left, int right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(int left, int right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static int Clamp(int value, int min, int max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static int Negate(int value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(int left, int right) => Scalar.Equal(left, right);

        [M(N)]
        private static int Acos(int value) => Scalar.Acos(value);

        [M(N)]
        private static int Abs(int value) => Scalar.Abs(value);

        [M(N)]
        private static int Sin(int value) => Scalar.Sin(value);

        [M(N)]
        private static int Sinh(int value) => Scalar.Sinh(value);

        [M(N)]
        private static int Asin(int value) => Scalar.Asin(value);
    }
}