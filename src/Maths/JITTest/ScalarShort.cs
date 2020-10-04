using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarShort
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
        private static short Atan(short value) => Scalar.Atan(value);

        [M(N)]
        private static short Atan2(short left, short right) => Scalar.Atan2(left, right);

        [M(N)]
        private static short Cos(short value) => Scalar.Cos(value);

        [M(N)]
        private static short Cosh(short value) => Scalar.Cosh(value);

        [M(N)]
        private static short One() => Scalar.One<short>();

        [M(N)]
        private static short Two() => Scalar.Two<short>();

        [M(N)]
        private static bool IsNormal(short value) => Scalar.IsNormal(value);

        [M(N)]
        private static short Pi() => Scalar.Pi<short>();

        [M(N)]
        private static short Tau() => Scalar.Tau<short>();

        [M(N)]
        private static short HalfPi() => Scalar.HalfPi<short>();

        [M(N)]
        private static short PositiveInfinity() => Scalar.PositiveInfinity<short>();

        [M(N)]
        private static short NegativeInfinity() => Scalar.NegativeInfinity<short>();

        [M(N)]
        private static short As(double value) => Scalar.As<short>(value);

        [M(N)]
        private static short SquareRoot(short value) => Scalar.SquareRoot(value);

        [M(N)]
        private static short Add(short left, short right) => Scalar.Add(left, right);

        [M(N)]
        private static short Mod(short left, short right) => Scalar.Mod(left, right);

        [M(N)]
        private static short Subtract(short left, short right) => Scalar.Subtract(left, right);

        [M(N)]
        private static short Multiply(short left, short right) => Scalar.Multiply(left, right);

        [M(N)]
        private static short Divide(short left, short right) => Scalar.Divide(left, right);

        [M(N)]
        private static short Min(short left, short right) => Scalar.Min(left, right);

        [M(N)]
        private static short Max(short left, short right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(short left, short right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(short left, short right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(short left, short right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(short left, short right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static short Clamp(short value, short min, short max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static short Negate(short value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(short left, short right) => Scalar.Equal(left, right);

        [M(N)]
        private static short Acos(short value) => Scalar.Acos(value);

        [M(N)]
        private static short Abs(short value) => Scalar.Abs(value);

        [M(N)]
        private static short Sin(short value) => Scalar.Sin(value);

        [M(N)]
        private static short Sinh(short value) => Scalar.Sinh(value);

        [M(N)]
        private static short Asin(short value) => Scalar.Asin(value);
    }
}