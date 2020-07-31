using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarSByte
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
        private static sbyte Atan(sbyte value) => Scalar.Atan(value);

        [M(N)]
        private static sbyte Atan2(sbyte left, sbyte right) => Scalar.Atan2(left, right);

        [M(N)]
        private static sbyte Cos(sbyte value) => Scalar.Cos(value);

        [M(N)]
        private static sbyte Cosh(sbyte value) => Scalar.Cosh(value);

        [M(N)]
        private static sbyte One() => Scalar.One<sbyte>();

        [M(N)]
        private static sbyte Two() => Scalar.Two<sbyte>();

        [M(N)]
        private static bool IsNormal(sbyte value) => Scalar.IsNormal(value);

        [M(N)]
        private static sbyte Pi() => Scalar.Pi<sbyte>();

        [M(N)]
        private static sbyte Tau() => Scalar.Tau<sbyte>();

        [M(N)]
        private static sbyte HalfPi() => Scalar.HalfPi<sbyte>();

        [M(N)]
        private static sbyte PositiveInfinity() => Scalar.PositiveInfinity<sbyte>();

        [M(N)]
        private static sbyte NegativeInfinity() => Scalar.NegativeInfinity<sbyte>();

        [M(N)]
        private static sbyte As(double value) => Scalar.As<sbyte>(value);

        [M(N)]
        private static sbyte SquareRoot(sbyte value) => Scalar.SquareRoot(value);

        [M(N)]
        private static sbyte Add(sbyte left, sbyte right) => Scalar.Add(left, right);

        [M(N)]
        private static sbyte Mod(sbyte left, sbyte right) => Scalar.Mod(left, right);

        [M(N)]
        private static sbyte Subtract(sbyte left, sbyte right) => Scalar.Subtract(left, right);

        [M(N)]
        private static sbyte Multiply(sbyte left, sbyte right) => Scalar.Multiply(left, right);

        [M(N)]
        private static sbyte Divide(sbyte left, sbyte right) => Scalar.Divide(left, right);

        [M(N)]
        private static sbyte Min(sbyte left, sbyte right) => Scalar.Min(left, right);

        [M(N)]
        private static sbyte Max(sbyte left, sbyte right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(sbyte left, sbyte right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(sbyte left, sbyte right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(sbyte left, sbyte right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(sbyte left, sbyte right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static sbyte Clamp(sbyte value, sbyte min, sbyte max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static sbyte Negate(sbyte value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(sbyte left, sbyte right) => Scalar.Equal(left, right);

        [M(N)]
        private static sbyte Acos(sbyte value) => Scalar.Acos(value);

        [M(N)]
        private static sbyte Abs(sbyte value) => Scalar.Abs(value);

        [M(N)]
        private static sbyte Sin(sbyte value) => Scalar.Sin(value);

        [M(N)]
        private static sbyte Sinh(sbyte value) => Scalar.Sinh(value);

        [M(N)]
        private static sbyte Asin(sbyte value) => Scalar.Asin(value);
    }
}