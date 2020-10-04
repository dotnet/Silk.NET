using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarHalf
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
        private static Half Atan(Half value) => Scalar.Atan(value);

        [M(N)]
        private static Half Atan2(Half left, Half right) => Scalar.Atan2(left, right);

        [M(N)]
        private static Half Cos(Half value) => Scalar.Cos(value);

        [M(N)]
        private static Half Cosh(Half value) => Scalar.Cosh(value);

        [M(N)]
        private static Half One() => Scalar.One<Half>();

        [M(N)]
        private static Half Two() => Scalar.Two<Half>();

        [M(N)]
        private static bool IsNormal(Half value) => Scalar.IsNormal(value);

        [M(N)]
        private static Half Pi() => Scalar.Pi<Half>();

        [M(N)]
        private static Half Tau() => Scalar.Tau<Half>();

        [M(N)]
        private static Half HalfPi() => Scalar.HalfPi<Half>();

        [M(N)]
        private static Half PositiveInfinity() => Scalar.PositiveInfinity<Half>();

        [M(N)]
        private static Half NegativeInfinity() => Scalar.NegativeInfinity<Half>();

        [M(N)]
        private static Half As(double value) => Scalar.As<Half>(value);

        [M(N)]
        private static Half SquareRoot(Half value) => Scalar.SquareRoot(value);

        [M(N)]
        private static Half Add(Half left, Half right) => Scalar.Add(left, right);

        [M(N)]
        private static Half Mod(Half left, Half right) => Scalar.Mod(left, right);

        [M(N)]
        private static Half Subtract(Half left, Half right) => Scalar.Subtract(left, right);

        [M(N)]
        private static Half Multiply(Half left, Half right) => Scalar.Multiply(left, right);

        [M(N)]
        private static Half Divide(Half left, Half right) => Scalar.Divide(left, right);

        [M(N)]
        private static Half Min(Half left, Half right) => Scalar.Min(left, right);

        [M(N)]
        private static Half Max(Half left, Half right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(Half left, Half right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(Half left, Half right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(Half left, Half right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(Half left, Half right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static Half Clamp(Half value, Half min, Half max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static Half Negate(Half value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(Half left, Half right) => Scalar.Equal(left, right);

        [M(N)]
        private static Half Acos(Half value) => Scalar.Acos(value);

        [M(N)]
        private static Half Abs(Half value) => Scalar.Abs(value);

        [M(N)]
        private static Half Sin(Half value) => Scalar.Sin(value);

        [M(N)]
        private static Half Sinh(Half value) => Scalar.Sinh(value);

        [M(N)]
        private static Half Asin(Half value) => Scalar.Asin(value);
    }
}