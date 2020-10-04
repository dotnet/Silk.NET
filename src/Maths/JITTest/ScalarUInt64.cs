using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarUInt64
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
        private static ulong Atan(ulong value) => Scalar.Atan(value);

        [M(N)]
        private static ulong Atan2(ulong left, ulong right) => Scalar.Atan2(left, right);

        [M(N)]
        private static ulong Cos(ulong value) => Scalar.Cos(value);

        [M(N)]
        private static ulong Cosh(ulong value) => Scalar.Cosh(value);

        [M(N)]
        private static ulong One() => Scalar.One<ulong>();

        [M(N)]
        private static ulong Two() => Scalar.Two<ulong>();

        [M(N)]
        private static bool IsNormal(ulong value) => Scalar.IsNormal(value);

        [M(N)]
        private static ulong Pi() => Scalar.Pi<ulong>();

        [M(N)]
        private static ulong Tau() => Scalar.Tau<ulong>();

        [M(N)]
        private static ulong HalfPi() => Scalar.HalfPi<ulong>();

        [M(N)]
        private static ulong PositiveInfinity() => Scalar.PositiveInfinity<ulong>();

        [M(N)]
        private static ulong NegativeInfinity() => Scalar.NegativeInfinity<ulong>();

        [M(N)]
        private static ulong As(double value) => Scalar.As<ulong>(value);

        [M(N)]
        private static ulong SquareRoot(ulong value) => Scalar.SquareRoot(value);

        [M(N)]
        private static ulong Add(ulong left, ulong right) => Scalar.Add(left, right);

        [M(N)]
        private static ulong Mod(ulong left, ulong right) => Scalar.Mod(left, right);

        [M(N)]
        private static ulong Subtract(ulong left, ulong right) => Scalar.Subtract(left, right);

        [M(N)]
        private static ulong Multiply(ulong left, ulong right) => Scalar.Multiply(left, right);

        [M(N)]
        private static ulong Divide(ulong left, ulong right) => Scalar.Divide(left, right);

        [M(N)]
        private static ulong Min(ulong left, ulong right) => Scalar.Min(left, right);

        [M(N)]
        private static ulong Max(ulong left, ulong right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(ulong left, ulong right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(ulong left, ulong right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(ulong left, ulong right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(ulong left, ulong right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static ulong Clamp(ulong value, ulong min, ulong max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static ulong Negate(ulong value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(ulong left, ulong right) => Scalar.Equal(left, right);

        [M(N)]
        private static ulong Acos(ulong value) => Scalar.Acos(value);

        [M(N)]
        private static ulong Abs(ulong value) => Scalar.Abs(value);

        [M(N)]
        private static ulong Sin(ulong value) => Scalar.Sin(value);

        [M(N)]
        private static ulong Sinh(ulong value) => Scalar.Sinh(value);

        [M(N)]
        private static ulong Asin(ulong value) => Scalar.Asin(value);
    }
}