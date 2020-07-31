using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarDouble
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
        private static double Atan(double value) => Scalar.Atan(value);

        [M(N)]
        private static double Atan2(double left, double right) => Scalar.Atan2(left, right);

        [M(N)]
        private static double Cos(double value) => Scalar.Cos(value);

        [M(N)]
        private static double Cosh(double value) => Scalar.Cosh(value);

        [M(N)]
        private static double One() => Scalar.One<double>();

        [M(N)]
        private static double Two() => Scalar.Two<double>();

        [M(N)]
        private static bool IsNormal(double value) => Scalar.IsNormal(value);

        [M(N)]
        private static double Pi() => Scalar.Pi<double>();

        [M(N)]
        private static double Tau() => Scalar.Tau<double>();

        [M(N)]
        private static double HalfPi() => Scalar.HalfPi<double>();

        [M(N)]
        private static double PositiveInfinity() => Scalar.PositiveInfinity<double>();

        [M(N)]
        private static double NegativeInfinity() => Scalar.NegativeInfinity<double>();

        [M(N)]
        private static double As(double value) => Scalar.As<double>(value);

        [M(N)]
        private static double SquareRoot(double value) => Scalar.SquareRoot(value);

        [M(N)]
        private static double Add(double left, double right) => Scalar.Add(left, right);

        [M(N)]
        private static double Mod(double left, double right) => Scalar.Mod(left, right);

        [M(N)]
        private static double Subtract(double left, double right) => Scalar.Subtract(left, right);

        [M(N)]
        private static double Multiply(double left, double right) => Scalar.Multiply(left, right);

        [M(N)]
        private static double Divide(double left, double right) => Scalar.Divide(left, right);

        [M(N)]
        private static double Min(double left, double right) => Scalar.Min(left, right);

        [M(N)]
        private static double Max(double left, double right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(double left, double right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(double left, double right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(double left, double right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(double left, double right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static double Clamp(double value, double min, double max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static double Negate(double value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(double left, double right) => Scalar.Equal(left, right);

        [M(N)]
        private static double Acos(double value) => Scalar.Acos(value);

        [M(N)]
        private static double Abs(double value) => Scalar.Abs(value);

        [M(N)]
        private static double Sin(double value) => Scalar.Sin(value);

        [M(N)]
        private static double Sinh(double value) => Scalar.Sinh(value);

        [M(N)]
        private static double Asin(double value) => Scalar.Asin(value);
    }
}