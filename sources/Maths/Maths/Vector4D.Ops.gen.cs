// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    using System.Numerics;

    /// <summary>
    /// Methods for working with <see cref="Vector4D{T}"/>.
    /// </summary>
    public static partial class Vector4D
    {
        /// <summary>Extensions for vectors with elements implementing <see cref="IRootFunctions{TSelf}"/>.</summary>
        extension<T>(Vector4D<T> vector)
            where T : IRootFunctions<T>
        {
            /// <summary>Gets the length of the vector.</summary>
            public T Length => T.Sqrt(vector.LengthSquared);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="INumberBase{TSelf}"/>.</summary>
        extension<T>(Vector4D<T> vector)
            where T : INumberBase<T>
        {
            /// <summary>Gets the length squared of the vector.</summary>
            public T LengthSquared => Vector4D.Dot(vector, vector);
        }

        /// <summary>Desconstructs a vector into its components.</summary>
        /// <param name="vector">The vector to deconstruct.</param>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public static void Deconstruct<T>(this Vector4D<T> vector, out T x, out T y, out T z, out T w)
            where T : INumberBase<T>
        {
            x = vector.X;
            y = vector.Y;
            z = vector.Z;
            w = vector.W;
        }

        /// <summary>Computes the dot product of two vectors.</summary>
        public static T Dot<T>(Vector4D<T> left, Vector4D<T> right)
            where T : INumberBase<T> =>
            left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;

        /// <summary>Reflects a vector over a normal vector.</summary>
        public static Vector4D<T> Reflect<T>(Vector4D<T> vector, Vector4D<T> normal)
            where T : INumberBase<T>
        {
            T dot = Dot(vector, normal);
            return vector - (normal * (dot + dot));
        }

        /// <summary>Normalizes a vector.</summary>
        public static Vector4D<T> Normalize<T>(this Vector4D<T> vector)
            where T : IRootFunctions<T>
        {
            T length = vector.Length;
            return length != T.Zero ? vector / length : Vector4D<T>.Zero;
        }

        /// <summary>Returns the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        public static T Distance<T>(Vector4D<T> value1, Vector4D<T> value2)
            where T : IRootFunctions<T> =>
            T.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        public static T DistanceSquared<T>(Vector4D<T> value1, Vector4D<T> value2)
            where T : INumberBase<T>
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Linearly interpolates between two vectors using a scalar t-value (clamped between 0 and 1).</summary>
        public static Vector4D<T> LerpClamped<T>(Vector4D<T> a, Vector4D<T> b, T amount)
            where T : IFloatingPointIeee754<T> =>
            Lerp(a, b, T.Clamp(amount, T.Zero, T.One));

        /// <summary>Linearly interpolates between two vectors using a vector t-value (clamped between 0 and 1).</summary>
        public static Vector4D<T> LerpClamped<T>(Vector4D<T> a, Vector4D<T> b, Vector4D<T> amount)
            where T : IFloatingPointIeee754<T> =>
            new(T.Lerp(a.X, b.X, T.Clamp(amount.X, T.Zero, T.One)),
                T.Lerp(a.Y, b.Y, T.Clamp(amount.Y, T.Zero, T.One)),
                T.Lerp(a.Z, b.Z, T.Clamp(amount.Z, T.Zero, T.One)),
                T.Lerp(a.W, b.W, T.Clamp(amount.W, T.Zero, T.One)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector4D<T> Sin, Vector4D<T> Cos) SinCos<T>(Vector4D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.Sin(x.X), T.Sin(x.Y), T.Sin(x.Z), T.Sin(x.W)), new(T.Cos(x.X), T.Cos(x.Y), T.Cos(x.Z), T.Cos(x.W)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector4D<T> SinPi, Vector4D<T> CosPi) SinCosPi<T>(Vector4D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.SinPi(x.X), T.SinPi(x.Y), T.SinPi(x.Z), T.SinPi(x.W)), new(T.CosPi(x.X), T.CosPi(x.Y), T.CosPi(x.Z), T.CosPi(x.W)));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.DivRem(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static (Vector4D<T> Quotient, Vector4D<T> Remainder) DivRem<T>(Vector4D<T> left, Vector4D<T> right)
            where T : IBinaryInteger<T>
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            var (qW, rW) = T.DivRem(left.W, right.W);
            return (new Vector4D<T>(qX, qY, qZ, qW), new Vector4D<T>(rX, rY, rZ, rW));
        }

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector4D<T> Multiply<T>(Vector4D<T> left, T right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector4D<T> Multiply<T>(T left, Vector4D<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Applies <see cref="INumber{TSelf}.Sign(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector4D<int> Sign<TSelf>(Vector4D<TSelf> value)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Sign(value.X), TSelf.Sign(value.Y), TSelf.Sign(value.Z), TSelf.Sign(value.W));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Max<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y.X), TSelf.Max(x.Y, y.Y), TSelf.Max(x.Z, y.Z), TSelf.Max(x.W, y.W));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Max<TSelf>(Vector4D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y), TSelf.Max(x.Y, y), TSelf.Max(x.Z, y), TSelf.Max(x.W, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MaxNumber<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y.X), TSelf.MaxNumber(x.Y, y.Y), TSelf.MaxNumber(x.Z, y.Z), TSelf.MaxNumber(x.W, y.W));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MaxNumber<TSelf>(Vector4D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y), TSelf.MaxNumber(x.Y, y), TSelf.MaxNumber(x.Z, y), TSelf.MaxNumber(x.W, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Min<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y.X), TSelf.Min(x.Y, y.Y), TSelf.Min(x.Z, y.Z), TSelf.Min(x.W, y.W));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Min<TSelf>(Vector4D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y), TSelf.Min(x.Y, y), TSelf.Min(x.Z, y), TSelf.Min(x.W, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MinNumber<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y.X), TSelf.MinNumber(x.Y, y.Y), TSelf.MinNumber(x.Z, y.Z), TSelf.MinNumber(x.W, y.W));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MinNumber<TSelf>(Vector4D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y), TSelf.MinNumber(x.Y, y), TSelf.MinNumber(x.Z, y), TSelf.MinNumber(x.W, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A vector whose members will be provided for <parameref name="min"/>.</param>
        /// <param name="max">A vector whose members will be provided for <parameref name="max"/>.</param>
        public static Vector4D<TSelf> Clamp<TSelf>(Vector4D<TSelf> value, Vector4D<TSelf> min, Vector4D<TSelf> max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min.X, max.X), TSelf.Clamp(value.Y, min.Y, max.Y), TSelf.Clamp(value.Z, min.Z, max.Z), TSelf.Clamp(value.W, min.W, max.W));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A single value provided for <parameref name="min"/>.</param>
        /// <param name="max">A single value provided for <parameref name="max"/>.</param>
        public static Vector4D<TSelf> Clamp<TSelf>(Vector4D<TSelf> value, TSelf min, TSelf max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min, max), TSelf.Clamp(value.Y, min, max), TSelf.Clamp(value.Z, min, max), TSelf.Clamp(value.W, min, max));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A vector whose members will be provided for <parameref name="sign"/>.</param>
        public static Vector4D<TSelf> CopySign<TSelf>(Vector4D<TSelf> value, Vector4D<TSelf> sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign.X), TSelf.CopySign(value.Y, sign.Y), TSelf.CopySign(value.Z, sign.Z), TSelf.CopySign(value.W, sign.W));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A single value provided for <parameref name="sign"/>.</param>
        public static Vector4D<TSelf> CopySign<TSelf>(Vector4D<TSelf> value, TSelf sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign), TSelf.CopySign(value.Y, sign), TSelf.CopySign(value.Z, sign), TSelf.CopySign(value.W, sign));

        /// <summary>Applies <see cref="INumberBase{TSelf}.Abs(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector4D<TSelf> Abs<TSelf>(Vector4D<TSelf> value)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.Abs(value.X), TSelf.Abs(value.Y), TSelf.Abs(value.Z), TSelf.Abs(value.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MaxMagnitude<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitude(x.X, y.X), TSelf.MaxMagnitude(x.Y, y.Y), TSelf.MaxMagnitude(x.Z, y.Z), TSelf.MaxMagnitude(x.W, y.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MaxMagnitudeNumber<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitudeNumber(x.X, y.X), TSelf.MaxMagnitudeNumber(x.Y, y.Y), TSelf.MaxMagnitudeNumber(x.Z, y.Z), TSelf.MaxMagnitudeNumber(x.W, y.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MinMagnitude<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitude(x.X, y.X), TSelf.MinMagnitude(x.Y, y.Y), TSelf.MinMagnitude(x.Z, y.Z), TSelf.MinMagnitude(x.W, y.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MinMagnitudeNumber<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitudeNumber(x.X, y.X), TSelf.MinMagnitudeNumber(x.Y, y.Y), TSelf.MinMagnitudeNumber(x.Z, y.Z), TSelf.MinMagnitudeNumber(x.W, y.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> MultiplyAddEstimate<TSelf>(Vector4D<TSelf> left, Vector4D<TSelf> right, Vector4D<TSelf> addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right.X, addend.X), TSelf.MultiplyAddEstimate(left.Y, right.Y, addend.Y), TSelf.MultiplyAddEstimate(left.Z, right.Z, addend.Z), TSelf.MultiplyAddEstimate(left.W, right.W, addend.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> MultiplyAddEstimate<TSelf>(Vector4D<TSelf> left, Vector4D<TSelf> right, TSelf addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right.X, addend), TSelf.MultiplyAddEstimate(left.Y, right.Y, addend), TSelf.MultiplyAddEstimate(left.Z, right.Z, addend), TSelf.MultiplyAddEstimate(left.W, right.W, addend));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> MultiplyAddEstimate<TSelf>(Vector4D<TSelf> left, TSelf right, Vector4D<TSelf> addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right, addend.X), TSelf.MultiplyAddEstimate(left.Y, right, addend.Y), TSelf.MultiplyAddEstimate(left.Z, right, addend.Z), TSelf.MultiplyAddEstimate(left.W, right, addend.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> MultiplyAddEstimate<TSelf>(Vector4D<TSelf> left, TSelf right, TSelf addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right, addend), TSelf.MultiplyAddEstimate(left.Y, right, addend), TSelf.MultiplyAddEstimate(left.Z, right, addend), TSelf.MultiplyAddEstimate(left.W, right, addend));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.PopCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector4D<TSelf> PopCount<TSelf>(Vector4D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.PopCount(value.X), TSelf.PopCount(value.Y), TSelf.PopCount(value.Z), TSelf.PopCount(value.W));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.TrailingZeroCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector4D<TSelf> TrailingZeroCount<TSelf>(Vector4D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.TrailingZeroCount(value.X), TSelf.TrailingZeroCount(value.Y), TSelf.TrailingZeroCount(value.Z), TSelf.TrailingZeroCount(value.W));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Ceiling(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Ceiling<TSelf>(Vector4D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Ceiling(x.X), TSelf.Ceiling(x.Y), TSelf.Ceiling(x.Z), TSelf.Ceiling(x.W));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Floor(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Floor<TSelf>(Vector4D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Floor(x.X), TSelf.Floor(x.Y), TSelf.Floor(x.Z), TSelf.Floor(x.W));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Round<TSelf>(Vector4D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X), TSelf.Round(x.Y), TSelf.Round(x.Z), TSelf.Round(x.W));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="digits">A single value provided for <parameref name="digits"/>.</param>
        public static Vector4D<TSelf> Round<TSelf>(Vector4D<TSelf> x, int digits)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, digits), TSelf.Round(x.Y, digits), TSelf.Round(x.Z, digits), TSelf.Round(x.W, digits));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, MidpointRounding)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="mode">A single value provided for <parameref name="mode"/>.</param>
        public static Vector4D<TSelf> Round<TSelf>(Vector4D<TSelf> x, MidpointRounding mode)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, mode), TSelf.Round(x.Y, mode), TSelf.Round(x.Z, mode), TSelf.Round(x.W, mode));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, int, MidpointRounding)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="digits">A single value provided for <parameref name="digits"/>.</param>
        /// <param name="mode">A single value provided for <parameref name="mode"/>.</param>
        public static Vector4D<TSelf> Round<TSelf>(Vector4D<TSelf> x, int digits, MidpointRounding mode)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, digits, mode), TSelf.Round(x.Y, digits, mode), TSelf.Round(x.Z, digits, mode), TSelf.Round(x.W, digits, mode));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Truncate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Truncate<TSelf>(Vector4D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Truncate(x.X), TSelf.Truncate(x.Y), TSelf.Truncate(x.Z), TSelf.Truncate(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Atan2<TSelf>(Vector4D<TSelf> y, Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2(y.X, x.X), TSelf.Atan2(y.Y, x.Y), TSelf.Atan2(y.Z, x.Z), TSelf.Atan2(y.W, x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2Pi(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Atan2Pi<TSelf>(Vector4D<TSelf> y, Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2Pi(y.X, x.X), TSelf.Atan2Pi(y.Y, x.Y), TSelf.Atan2Pi(y.Z, x.Z), TSelf.Atan2Pi(y.W, x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Lerp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value1">A vector whose members will be provided for <parameref name="value1"/>.</param>
        /// <param name="value2">A vector whose members will be provided for <parameref name="value2"/>.</param>
        /// <param name="amount">A single value provided for <parameref name="amount"/>.</param>
        public static Vector4D<TSelf> Lerp<TSelf>(Vector4D<TSelf> value1, Vector4D<TSelf> value2, TSelf amount)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Lerp(value1.X, value2.X, amount), TSelf.Lerp(value1.Y, value2.Y, amount), TSelf.Lerp(value1.Z, value2.Z, amount), TSelf.Lerp(value1.W, value2.W, amount));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitDecrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> BitDecrement<TSelf>(Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitDecrement(x.X), TSelf.BitDecrement(x.Y), TSelf.BitDecrement(x.Z), TSelf.BitDecrement(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitIncrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> BitIncrement<TSelf>(Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitIncrement(x.X), TSelf.BitIncrement(x.Y), TSelf.BitIncrement(x.Z), TSelf.BitIncrement(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> FusedMultiplyAdd<TSelf>(Vector4D<TSelf> left, Vector4D<TSelf> right, Vector4D<TSelf> addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right.X, addend.X), TSelf.FusedMultiplyAdd(left.Y, right.Y, addend.Y), TSelf.FusedMultiplyAdd(left.Z, right.Z, addend.Z), TSelf.FusedMultiplyAdd(left.W, right.W, addend.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> FusedMultiplyAdd<TSelf>(Vector4D<TSelf> left, Vector4D<TSelf> right, TSelf addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right.X, addend), TSelf.FusedMultiplyAdd(left.Y, right.Y, addend), TSelf.FusedMultiplyAdd(left.Z, right.Z, addend), TSelf.FusedMultiplyAdd(left.W, right.W, addend));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> FusedMultiplyAdd<TSelf>(Vector4D<TSelf> left, TSelf right, Vector4D<TSelf> addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right, addend.X), TSelf.FusedMultiplyAdd(left.Y, right, addend.Y), TSelf.FusedMultiplyAdd(left.Z, right, addend.Z), TSelf.FusedMultiplyAdd(left.W, right, addend.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> FusedMultiplyAdd<TSelf>(Vector4D<TSelf> left, TSelf right, TSelf addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right, addend), TSelf.FusedMultiplyAdd(left.Y, right, addend), TSelf.FusedMultiplyAdd(left.Z, right, addend), TSelf.FusedMultiplyAdd(left.W, right, addend));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static Vector4D<TSelf> Ieee754Remainder<TSelf>(Vector4D<TSelf> left, Vector4D<TSelf> right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right.X), TSelf.Ieee754Remainder(left.Y, right.Y), TSelf.Ieee754Remainder(left.Z, right.Z), TSelf.Ieee754Remainder(left.W, right.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        public static Vector4D<TSelf> Ieee754Remainder<TSelf>(Vector4D<TSelf> left, TSelf right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right), TSelf.Ieee754Remainder(left.Y, right), TSelf.Ieee754Remainder(left.Z, right), TSelf.Ieee754Remainder(left.W, right));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ILogB(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<int> ILogB<TSelf>(Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ILogB(x.X), TSelf.ILogB(x.Y), TSelf.ILogB(x.Z), TSelf.ILogB(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> ReciprocalEstimate<TSelf>(Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalEstimate(x.X), TSelf.ReciprocalEstimate(x.Y), TSelf.ReciprocalEstimate(x.Z), TSelf.ReciprocalEstimate(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalSqrtEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> ReciprocalSqrtEstimate<TSelf>(Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalSqrtEstimate(x.X), TSelf.ReciprocalSqrtEstimate(x.Y), TSelf.ReciprocalSqrtEstimate(x.Z), TSelf.ReciprocalSqrtEstimate(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector4D<TSelf> ScaleB<TSelf>(Vector4D<TSelf> x, Vector4D<int> n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n.X), TSelf.ScaleB(x.Y, n.Y), TSelf.ScaleB(x.Z, n.Z), TSelf.ScaleB(x.W, n.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector4D<TSelf> ScaleB<TSelf>(Vector4D<TSelf> x, int n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n), TSelf.ScaleB(x.Y, n), TSelf.ScaleB(x.Z, n), TSelf.ScaleB(x.W, n));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Pow<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y.X), TSelf.Pow(x.Y, y.Y), TSelf.Pow(x.Z, y.Z), TSelf.Pow(x.W, y.W));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Pow<TSelf>(Vector4D<TSelf> x, TSelf y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y), TSelf.Pow(x.Y, y), TSelf.Pow(x.Z, y), TSelf.Pow(x.W, y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Cbrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Cbrt<TSelf>(Vector4D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Cbrt(x.X), TSelf.Cbrt(x.Y), TSelf.Cbrt(x.Z), TSelf.Cbrt(x.W));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Sqrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Sqrt<TSelf>(Vector4D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Sqrt(x.X), TSelf.Sqrt(x.Y), TSelf.Sqrt(x.Z), TSelf.Sqrt(x.W));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector4D<TSelf> RootN<TSelf>(Vector4D<TSelf> x, int n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n), TSelf.RootN(x.Y, n), TSelf.RootN(x.Z, n), TSelf.RootN(x.W, n));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector4D<TSelf> RootN<TSelf>(Vector4D<TSelf> x, Vector4D<int> n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n.X), TSelf.RootN(x.Y, n.Y), TSelf.RootN(x.Z, n.Z), TSelf.RootN(x.W, n.W));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Hypot(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Hypot<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Hypot(x.X, y.X), TSelf.Hypot(x.Y, y.Y), TSelf.Hypot(x.Z, y.Z), TSelf.Hypot(x.W, y.W));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Hypot(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Hypot<TSelf>(Vector4D<TSelf> x, TSelf y)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Hypot(x.X, y), TSelf.Hypot(x.Y, y), TSelf.Hypot(x.Z, y), TSelf.Hypot(x.W, y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log<TSelf>(Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y), TSelf.Log(x.Z), TSelf.Log(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="newBase">A vector whose members will be provided for <parameref name="newBase"/>.</param>
        public static Vector4D<TSelf> Log<TSelf>(Vector4D<TSelf> x, Vector4D<TSelf> newBase)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase.X), TSelf.Log(x.Y, newBase.Y), TSelf.Log(x.Z, newBase.Z), TSelf.Log(x.W, newBase.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="newBase">A single value provided for <parameref name="newBase"/>.</param>
        public static Vector4D<TSelf> Log<TSelf>(Vector4D<TSelf> x, TSelf newBase)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase), TSelf.Log(x.Y, newBase), TSelf.Log(x.Z, newBase), TSelf.Log(x.W, newBase));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.LogP1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> LogP1<TSelf>(Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y), TSelf.LogP1(x.Z), TSelf.LogP1(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log2<TSelf>(Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y), TSelf.Log2(x.Z), TSelf.Log2(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log2P1<TSelf>(Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y), TSelf.Log2P1(x.Z), TSelf.Log2P1(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log10<TSelf>(Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y), TSelf.Log10(x.Z), TSelf.Log10(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log10P1<TSelf>(Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y), TSelf.Log10P1(x.Z), TSelf.Log10P1(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp<TSelf>(Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y), TSelf.Exp(x.Z), TSelf.Exp(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.ExpM1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> ExpM1<TSelf>(Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y), TSelf.ExpM1(x.Z), TSelf.ExpM1(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp2<TSelf>(Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y), TSelf.Exp2(x.Z), TSelf.Exp2(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp2M1<TSelf>(Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y), TSelf.Exp2M1(x.Z), TSelf.Exp2M1(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp10<TSelf>(Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y), TSelf.Exp10(x.Z), TSelf.Exp10(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp10M1<TSelf>(Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y), TSelf.Exp10M1(x.Z), TSelf.Exp10M1(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Acos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Acos<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Acos(x.X), TSelf.Acos(x.Y), TSelf.Acos(x.Z), TSelf.Acos(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AcosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> AcosPi<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AcosPi(x.X), TSelf.AcosPi(x.Y), TSelf.AcosPi(x.Z), TSelf.AcosPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Asin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Asin<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Asin(x.X), TSelf.Asin(x.Y), TSelf.Asin(x.Z), TSelf.Asin(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AsinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> AsinPi<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AsinPi(x.X), TSelf.AsinPi(x.Y), TSelf.AsinPi(x.Z), TSelf.AsinPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Atan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Atan<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Atan(x.X), TSelf.Atan(x.Y), TSelf.Atan(x.Z), TSelf.Atan(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AtanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> AtanPi<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AtanPi(x.X), TSelf.AtanPi(x.Y), TSelf.AtanPi(x.Z), TSelf.AtanPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Cos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Cos<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Cos(x.X), TSelf.Cos(x.Y), TSelf.Cos(x.Z), TSelf.Cos(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.CosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> CosPi<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.CosPi(x.X), TSelf.CosPi(x.Y), TSelf.CosPi(x.Z), TSelf.CosPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Sin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Sin<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Sin(x.X), TSelf.Sin(x.Y), TSelf.Sin(x.Z), TSelf.Sin(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> SinPi<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.SinPi(x.X), TSelf.SinPi(x.Y), TSelf.SinPi(x.Z), TSelf.SinPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Tan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Tan<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Tan(x.X), TSelf.Tan(x.Y), TSelf.Tan(x.Z), TSelf.Tan(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.TanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> TanPi<TSelf>(Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.TanPi(x.X), TSelf.TanPi(x.Y), TSelf.TanPi(x.Z), TSelf.TanPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.DegreesToRadians(TSelf)"/> to the provided arguments.</summary>
        /// <param name="degrees">A vector whose members will be provided for <parameref name="degrees"/>.</param>
        public static Vector4D<TSelf> DegreesToRadians<TSelf>(Vector4D<TSelf> degrees)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.DegreesToRadians(degrees.X), TSelf.DegreesToRadians(degrees.Y), TSelf.DegreesToRadians(degrees.Z), TSelf.DegreesToRadians(degrees.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.RadiansToDegrees(TSelf)"/> to the provided arguments.</summary>
        /// <param name="radians">A vector whose members will be provided for <parameref name="radians"/>.</param>
        public static Vector4D<TSelf> RadiansToDegrees<TSelf>(Vector4D<TSelf> radians)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.RadiansToDegrees(radians.X), TSelf.RadiansToDegrees(radians.Y), TSelf.RadiansToDegrees(radians.Z), TSelf.RadiansToDegrees(radians.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Acosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Acosh<TSelf>(Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Acosh(x.X), TSelf.Acosh(x.Y), TSelf.Acosh(x.Z), TSelf.Acosh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Asinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Asinh<TSelf>(Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Asinh(x.X), TSelf.Asinh(x.Y), TSelf.Asinh(x.Z), TSelf.Asinh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Atanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Atanh<TSelf>(Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Atanh(x.X), TSelf.Atanh(x.Y), TSelf.Atanh(x.Z), TSelf.Atanh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Cosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Cosh<TSelf>(Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Cosh(x.X), TSelf.Cosh(x.Y), TSelf.Cosh(x.Z), TSelf.Cosh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Sinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Sinh<TSelf>(Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Sinh(x.X), TSelf.Sinh(x.Y), TSelf.Sinh(x.Z), TSelf.Sinh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Tanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Tanh<TSelf>(Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Tanh(x.X), TSelf.Tanh(x.Y), TSelf.Tanh(x.Z), TSelf.Tanh(x.W));
    }
}
