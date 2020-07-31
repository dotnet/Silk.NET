using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarUShort
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
        private static ushort Atan(ushort value) => Scalar.Atan(value);

        [M(N)]
        private static ushort Atan2(ushort left, ushort right) => Scalar.Atan2(left, right);

        [M(N)]
        private static ushort Cos(ushort value) => Scalar.Cos(value);

        [M(N)]
        private static ushort Cosh(ushort value) => Scalar.Cosh(value);

        [M(N)]
        private static ushort One() => Scalar.One<ushort>();

        [M(N)]
        private static ushort Two() => Scalar.Two<ushort>();

        [M(N)]
        private static bool IsNormal(ushort value) => Scalar.IsNormal(value);

        [M(N)]
        private static ushort Pi() => Scalar.Pi<ushort>();

        [M(N)]
        private static ushort Tau() => Scalar.Tau<ushort>();

        [M(N)]
        private static ushort HalfPi() => Scalar.HalfPi<ushort>();

        [M(N)]
        private static ushort PositiveInfinity() => Scalar.PositiveInfinity<ushort>();

        [M(N)]
        private static ushort NegativeInfinity() => Scalar.NegativeInfinity<ushort>();

        [M(N)]
        private static ushort As(double value) => Scalar.As<ushort>(value);

        [M(N)]
        private static ushort SquareRoot(ushort value) => Scalar.SquareRoot(value);

        [M(N)]
        private static ushort Add(ushort left, ushort right) => Scalar.Add(left, right);

        [M(N)]
        private static ushort Mod(ushort left, ushort right) => Scalar.Mod(left, right);

        [M(N)]
        private static ushort Subtract(ushort left, ushort right) => Scalar.Subtract(left, right);

        [M(N)]
        private static ushort Multiply(ushort left, ushort right) => Scalar.Multiply(left, right);

        [M(N)]
        private static ushort Divide(ushort left, ushort right) => Scalar.Divide(left, right);

        [M(N)]
        private static ushort Min(ushort left, ushort right) => Scalar.Min(left, right);

        [M(N)]
        private static ushort Max(ushort left, ushort right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(ushort left, ushort right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(ushort left, ushort right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(ushort left, ushort right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(ushort left, ushort right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static ushort Clamp(ushort value, ushort min, ushort max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static ushort Negate(ushort value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(ushort left, ushort right) => Scalar.Equal(left, right);

        [M(N)]
        private static ushort Acos(ushort value) => Scalar.Acos(value);

        [M(N)]
        private static ushort Abs(ushort value) => Scalar.Abs(value);

        [M(N)]
        private static ushort Sin(ushort value) => Scalar.Sin(value);

        [M(N)]
        private static ushort Sinh(ushort value) => Scalar.Sinh(value);

        [M(N)]
        private static ushort Asin(ushort value) => Scalar.Asin(value);
    }
}