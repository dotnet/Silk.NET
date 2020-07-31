using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarInt64
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
        private static long Atan(long value) => Scalar.Atan(value);

        [M(N)]
        private static long Atan2(long left, long right) => Scalar.Atan2(left, right);

        [M(N)]
        private static long Cos(long value) => Scalar.Cos(value);

        [M(N)]
        private static long Cosh(long value) => Scalar.Cosh(value);

        [M(N)]
        private static long One() => Scalar.One<long>();

        [M(N)]
        private static long Two() => Scalar.Two<long>();

        [M(N)]
        private static bool IsNormal(long value) => Scalar.IsNormal(value);

        [M(N)]
        private static long Pi() => Scalar.Pi<long>();

        [M(N)]
        private static long Tau() => Scalar.Tau<long>();

        [M(N)]
        private static long HalfPi() => Scalar.HalfPi<long>();

        [M(N)]
        private static long PositiveInfinity() => Scalar.PositiveInfinity<long>();

        [M(N)]
        private static long NegativeInfinity() => Scalar.NegativeInfinity<long>();

        [M(N)]
        private static long As(double value) => Scalar.As<long>(value);

        [M(N)]
        private static long SquareRoot(long value) => Scalar.SquareRoot(value);

        [M(N)]
        private static long Add(long left, long right) => Scalar.Add(left, right);

        [M(N)]
        private static long Mod(long left, long right) => Scalar.Mod(left, right);

        [M(N)]
        private static long Subtract(long left, long right) => Scalar.Subtract(left, right);

        [M(N)]
        private static long Multiply(long left, long right) => Scalar.Multiply(left, right);

        [M(N)]
        private static long Divide(long left, long right) => Scalar.Divide(left, right);

        [M(N)]
        private static long Min(long left, long right) => Scalar.Min(left, right);

        [M(N)]
        private static long Max(long left, long right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(long left, long right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(long left, long right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(long left, long right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(long left, long right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static long Clamp(long value, long min, long max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static long Negate(long value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(long left, long right) => Scalar.Equal(left, right);

        [M(N)]
        private static long Acos(long value) => Scalar.Acos(value);

        [M(N)]
        private static long Abs(long value) => Scalar.Abs(value);

        [M(N)]
        private static long Sin(long value) => Scalar.Sin(value);

        [M(N)]
        private static long Sinh(long value) => Scalar.Sinh(value);

        [M(N)]
        private static long Asin(long value) => Scalar.Asin(value);
    }
}