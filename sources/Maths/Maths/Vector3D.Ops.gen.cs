// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    using System.Numerics;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Methods for working with <see cref="Vector3D{T}"/>.
    /// </summary>
    public static partial class Vector3D
    {
        /// <summary>Extensions for vectors with elements implementing <see cref="IRootFunctions{TSelf}"/>.</summary>
        extension<TSelf>(Vector3D<TSelf> vector)
            where TSelf : IRootFunctions<TSelf>
        {
            /// <summary>Gets the length of the vector.</summary>
            public TSelf Length => TSelf.Sqrt(vector.LengthSquared);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="INumberBase{TSelf}"/>.</summary>
        extension<TSelf>(Vector3D<TSelf> vector)
            where TSelf : INumberBase<TSelf>
        {
            /// <summary>Gets the length squared of the vector.</summary>
            public TSelf LengthSquared => Vector3D.Dot(vector, vector);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="IBinaryNumber{TSelf}"/>.</summary>
        extension<TSelf>(Vector3D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, IBinaryNumber<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="IBinaryNumber{TSelf}.AllBitsSet"/>.</summary>
            public static Vector3D<TSelf> AllBitsSet => new(TSelf.AllBitsSet);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="IFloatingPointConstants{TSelf}"/>.</summary>
        extension<TSelf>(Vector3D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, IFloatingPointConstants<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointConstants{TSelf}.E"/>.</summary>
            public static Vector3D<TSelf> E => new(TSelf.E);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointConstants{TSelf}.Pi"/>.</summary>
            public static Vector3D<TSelf> Pi => new(TSelf.Pi);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointConstants{TSelf}.Tau"/>.</summary>
            public static Vector3D<TSelf> Tau => new(TSelf.Tau);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="IFloatingPointIeee754{TSelf}"/>.</summary>
        extension<TSelf>(Vector3D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, IFloatingPointIeee754<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.Epsilon"/>.</summary>
            public static Vector3D<TSelf> Epsilon => new(TSelf.Epsilon);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.</summary>
            public static Vector3D<TSelf> NaN => new(TSelf.NaN);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.NegativeInfinity"/>.</summary>
            public static Vector3D<TSelf> NegativeInfinity => new(TSelf.NegativeInfinity);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/>.</summary>
            public static Vector3D<TSelf> NegativeZero => new(TSelf.NegativeZero);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.PositiveInfinity"/>.</summary>
            public static Vector3D<TSelf> PositiveInfinity => new(TSelf.PositiveInfinity);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="IMinMaxValue{TSelf}"/>.</summary>
        extension<TSelf>(Vector3D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, IMinMaxValue<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="IMinMaxValue{TSelf}.MinValue"/>.</summary>
            public static Vector3D<TSelf> MinValue => new(TSelf.MinValue);

            /// <summary>Gets a vector with all components set to <see cref="IMinMaxValue{TSelf}.MaxValue"/>.</summary>
            public static Vector3D<TSelf> MaxValue => new(TSelf.MaxValue);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="ISignedNumber{TSelf}"/>.</summary>
        extension<TSelf>(Vector3D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, ISignedNumber<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="ISignedNumber{TSelf}.NegativeOne"/>.</summary>
            public static Vector3D<TSelf> NegativeOne => new(TSelf.NegativeOne);
        }

        /// <summary>Desconstructs a vector into its components.</summary>
        /// <param name="vector">The vector to deconstruct.</param>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public static void Deconstruct<T>(this Vector3D<T> vector, out T x, out T y, out T z)
            where T : INumberBase<T>
        {
            x = vector.X;
            y = vector.Y;
            z = vector.Z;
        }

        /// <summary>Computes the dot product of two vectors.</summary>
        public static T Dot<T>(Vector3D<T> left, Vector3D<T> right)
            where T : INumberBase<T> =>
            left.X * right.X + left.Y * right.Y + left.Z * right.Z;

        /// <summary>Reflects a vector over a normal vector.</summary>
        public static Vector3D<T> Reflect<T>(Vector3D<T> vector, Vector3D<T> normal)
            where T : INumberBase<T>
        {
            T dot = Dot(vector, normal);
            return vector - (normal * (dot + dot));
        }

        /// <summary>Normalizes a vector.</summary>
        public static Vector3D<T> Normalize<T>(this Vector3D<T> vector)
            where T : IRootFunctions<T>
            => vector / vector.Length;

        /// <summary>Returns the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        public static T Distance<T>(Vector3D<T> value1, Vector3D<T> value2)
            where T : IRootFunctions<T> =>
            T.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        public static T DistanceSquared<T>(Vector3D<T> value1, Vector3D<T> value2)
            where T : INumberBase<T>
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf)"/> to each member of the vector and converts to integer.</summary>
        public static Vector3D<int> RoundToInt<T>(Vector3D<T> vector)
            where T : IFloatingPoint<T> =>
            Vector3D.Round(vector).AsChecked<int>();

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Floor(TSelf)"/> to each member of the vector and converts to integer.</summary>
        public static Vector3D<int> FloorToInt<T>(Vector3D<T> vector)
            where T : IFloatingPoint<T> =>
            Vector3D.Floor(vector).AsChecked<int>();

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Ceiling(TSelf)"/> to each member of the vector and converts to integer.</summary>
        public static Vector3D<int> CeilingToInt<T>(Vector3D<T> vector)
            where T : IFloatingPoint<T> =>
            Vector3D.Ceiling(vector).AsChecked<int>();

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<float> ToVector128(Vector3D<float> vector)
            => Vector128.Create(vector.X, vector.Y, vector.Z, (float)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<float> ToVector256(Vector3D<float> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (float)0, (float)0, (float)0, (float)0, (float)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<float> ToVector512(Vector3D<float> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<double> ToVector256(Vector3D<double> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (double)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<double> ToVector512(Vector3D<double> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (double)0, (double)0, (double)0, (double)0, (double)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<byte> ToVector64(Vector3D<byte> vector)
            => Vector64.Create(vector.X, vector.Y, vector.Z, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<byte> ToVector128(Vector3D<byte> vector)
            => Vector128.Create(vector.X, vector.Y, vector.Z, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<byte> ToVector256(Vector3D<byte> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<byte> ToVector512(Vector3D<byte> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<short> ToVector64(Vector3D<short> vector)
            => Vector64.Create(vector.X, vector.Y, vector.Z, (short)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<short> ToVector128(Vector3D<short> vector)
            => Vector128.Create(vector.X, vector.Y, vector.Z, (short)0, (short)0, (short)0, (short)0, (short)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<short> ToVector256(Vector3D<short> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<short> ToVector512(Vector3D<short> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<int> ToVector128(Vector3D<int> vector)
            => Vector128.Create(vector.X, vector.Y, vector.Z, (int)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<int> ToVector256(Vector3D<int> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (int)0, (int)0, (int)0, (int)0, (int)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<int> ToVector512(Vector3D<int> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<long> ToVector256(Vector3D<long> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (long)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<long> ToVector512(Vector3D<long> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (long)0, (long)0, (long)0, (long)0, (long)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<sbyte> ToVector64(Vector3D<sbyte> vector)
            => Vector64.Create(vector.X, vector.Y, vector.Z, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<sbyte> ToVector128(Vector3D<sbyte> vector)
            => Vector128.Create(vector.X, vector.Y, vector.Z, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<sbyte> ToVector256(Vector3D<sbyte> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<sbyte> ToVector512(Vector3D<sbyte> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<ushort> ToVector64(Vector3D<ushort> vector)
            => Vector64.Create(vector.X, vector.Y, vector.Z, (ushort)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<ushort> ToVector128(Vector3D<ushort> vector)
            => Vector128.Create(vector.X, vector.Y, vector.Z, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<ushort> ToVector256(Vector3D<ushort> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<ushort> ToVector512(Vector3D<ushort> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<uint> ToVector128(Vector3D<uint> vector)
            => Vector128.Create(vector.X, vector.Y, vector.Z, (uint)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<uint> ToVector256(Vector3D<uint> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<uint> ToVector512(Vector3D<uint> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<ulong> ToVector256(Vector3D<ulong> vector)
            => Vector256.Create(vector.X, vector.Y, vector.Z, (ulong)0);

        /// <summary>Converts a <see cref="Vector3D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<ulong> ToVector512(Vector3D<ulong> vector)
            => Vector512.Create(vector.X, vector.Y, vector.Z, (ulong)0, (ulong)0, (ulong)0, (ulong)0, (ulong)0);

        /// <summary>Linearly interpolates between two vectors using a scalar t-value (clamped between 0 and 1).</summary>
        public static Vector3D<T> LerpClamped<T>(Vector3D<T> a, Vector3D<T> b, T amount)
            where T : IFloatingPointIeee754<T> =>
            Lerp(a, b, T.Clamp(amount, T.Zero, T.One));

        /// <summary>Linearly interpolates between two vectors using a vector t-value (clamped between 0 and 1).</summary>
        public static Vector3D<T> LerpClamped<T>(Vector3D<T> a, Vector3D<T> b, Vector3D<T> amount)
            where T : IFloatingPointIeee754<T> =>
            new(T.Lerp(a.X, b.X, T.Clamp(amount.X, T.Zero, T.One)),
                T.Lerp(a.Y, b.Y, T.Clamp(amount.Y, T.Zero, T.One)),
                T.Lerp(a.Z, b.Z, T.Clamp(amount.Z, T.Zero, T.One)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector3D<T> Sin, Vector3D<T> Cos) SinCos<T>(Vector3D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.Sin(x.X), T.Sin(x.Y), T.Sin(x.Z)), new(T.Cos(x.X), T.Cos(x.Y), T.Cos(x.Z)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector3D<T> SinPi, Vector3D<T> CosPi) SinCosPi<T>(Vector3D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.SinPi(x.X), T.SinPi(x.Y), T.SinPi(x.Z)), new(T.CosPi(x.X), T.CosPi(x.Y), T.CosPi(x.Z)));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.DivRem(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static (Vector3D<T> Quotient, Vector3D<T> Remainder) DivRem<T>(Vector3D<T> left, Vector3D<T> right)
            where T : IBinaryInteger<T>
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            return (new Vector3D<T>(qX, qY, qZ), new Vector3D<T>(rX, rY, rZ));
        }

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector3D<T> Multiply<T>(Vector3D<T> left, T right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector3D<T> Multiply<T>(T left, Vector3D<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Applies <see cref="INumber{TSelf}.Sign(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector3D<int> Sign<TSelf>(Vector3D<TSelf> value)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Sign(value.X), TSelf.Sign(value.Y), TSelf.Sign(value.Z));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> Max<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y.X), TSelf.Max(x.Y, y.Y), TSelf.Max(x.Z, y.Z));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> Max<TSelf>(Vector3D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y), TSelf.Max(x.Y, y), TSelf.Max(x.Z, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> MaxNumber<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y.X), TSelf.MaxNumber(x.Y, y.Y), TSelf.MaxNumber(x.Z, y.Z));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> MaxNumber<TSelf>(Vector3D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y), TSelf.MaxNumber(x.Y, y), TSelf.MaxNumber(x.Z, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> Min<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y.X), TSelf.Min(x.Y, y.Y), TSelf.Min(x.Z, y.Z));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> Min<TSelf>(Vector3D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y), TSelf.Min(x.Y, y), TSelf.Min(x.Z, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> MinNumber<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y.X), TSelf.MinNumber(x.Y, y.Y), TSelf.MinNumber(x.Z, y.Z));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> MinNumber<TSelf>(Vector3D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y), TSelf.MinNumber(x.Y, y), TSelf.MinNumber(x.Z, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A vector whose members will be provided for <parameref name="min"/>.</param>
        /// <param name="max">A vector whose members will be provided for <parameref name="max"/>.</param>
        public static Vector3D<TSelf> Clamp<TSelf>(Vector3D<TSelf> value, Vector3D<TSelf> min, Vector3D<TSelf> max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min.X, max.X), TSelf.Clamp(value.Y, min.Y, max.Y), TSelf.Clamp(value.Z, min.Z, max.Z));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A single value provided for <parameref name="min"/>.</param>
        /// <param name="max">A single value provided for <parameref name="max"/>.</param>
        public static Vector3D<TSelf> Clamp<TSelf>(Vector3D<TSelf> value, TSelf min, TSelf max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min, max), TSelf.Clamp(value.Y, min, max), TSelf.Clamp(value.Z, min, max));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A vector whose members will be provided for <parameref name="sign"/>.</param>
        public static Vector3D<TSelf> CopySign<TSelf>(Vector3D<TSelf> value, Vector3D<TSelf> sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign.X), TSelf.CopySign(value.Y, sign.Y), TSelf.CopySign(value.Z, sign.Z));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A single value provided for <parameref name="sign"/>.</param>
        public static Vector3D<TSelf> CopySign<TSelf>(Vector3D<TSelf> value, TSelf sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign), TSelf.CopySign(value.Y, sign), TSelf.CopySign(value.Z, sign));

        /// <summary>Applies <see cref="INumberBase{TSelf}.Abs(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector3D<TSelf> Abs<TSelf>(Vector3D<TSelf> value)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.Abs(value.X), TSelf.Abs(value.Y), TSelf.Abs(value.Z));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> MaxMagnitude<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitude(x.X, y.X), TSelf.MaxMagnitude(x.Y, y.Y), TSelf.MaxMagnitude(x.Z, y.Z));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> MaxMagnitudeNumber<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitudeNumber(x.X, y.X), TSelf.MaxMagnitudeNumber(x.Y, y.Y), TSelf.MaxMagnitudeNumber(x.Z, y.Z));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> MinMagnitude<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitude(x.X, y.X), TSelf.MinMagnitude(x.Y, y.Y), TSelf.MinMagnitude(x.Z, y.Z));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> MinMagnitudeNumber<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitudeNumber(x.X, y.X), TSelf.MinMagnitudeNumber(x.Y, y.Y), TSelf.MinMagnitudeNumber(x.Z, y.Z));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector3D<TSelf> MultiplyAddEstimate<TSelf>(Vector3D<TSelf> left, Vector3D<TSelf> right, Vector3D<TSelf> addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right.X, addend.X), TSelf.MultiplyAddEstimate(left.Y, right.Y, addend.Y), TSelf.MultiplyAddEstimate(left.Z, right.Z, addend.Z));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector3D<TSelf> MultiplyAddEstimate<TSelf>(Vector3D<TSelf> left, Vector3D<TSelf> right, TSelf addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right.X, addend), TSelf.MultiplyAddEstimate(left.Y, right.Y, addend), TSelf.MultiplyAddEstimate(left.Z, right.Z, addend));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector3D<TSelf> MultiplyAddEstimate<TSelf>(Vector3D<TSelf> left, TSelf right, Vector3D<TSelf> addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right, addend.X), TSelf.MultiplyAddEstimate(left.Y, right, addend.Y), TSelf.MultiplyAddEstimate(left.Z, right, addend.Z));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector3D<TSelf> MultiplyAddEstimate<TSelf>(Vector3D<TSelf> left, TSelf right, TSelf addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right, addend), TSelf.MultiplyAddEstimate(left.Y, right, addend), TSelf.MultiplyAddEstimate(left.Z, right, addend));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.PopCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector3D<TSelf> PopCount<TSelf>(Vector3D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.PopCount(value.X), TSelf.PopCount(value.Y), TSelf.PopCount(value.Z));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.TrailingZeroCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector3D<TSelf> TrailingZeroCount<TSelf>(Vector3D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.TrailingZeroCount(value.X), TSelf.TrailingZeroCount(value.Y), TSelf.TrailingZeroCount(value.Z));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Ceiling(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Ceiling<TSelf>(Vector3D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Ceiling(x.X), TSelf.Ceiling(x.Y), TSelf.Ceiling(x.Z));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Floor(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Floor<TSelf>(Vector3D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Floor(x.X), TSelf.Floor(x.Y), TSelf.Floor(x.Z));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Round<TSelf>(Vector3D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X), TSelf.Round(x.Y), TSelf.Round(x.Z));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="digits">A single value provided for <parameref name="digits"/>.</param>
        public static Vector3D<TSelf> Round<TSelf>(Vector3D<TSelf> x, int digits)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, digits), TSelf.Round(x.Y, digits), TSelf.Round(x.Z, digits));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, MidpointRounding)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="mode">A single value provided for <parameref name="mode"/>.</param>
        public static Vector3D<TSelf> Round<TSelf>(Vector3D<TSelf> x, MidpointRounding mode)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, mode), TSelf.Round(x.Y, mode), TSelf.Round(x.Z, mode));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, int, MidpointRounding)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="digits">A single value provided for <parameref name="digits"/>.</param>
        /// <param name="mode">A single value provided for <parameref name="mode"/>.</param>
        public static Vector3D<TSelf> Round<TSelf>(Vector3D<TSelf> x, int digits, MidpointRounding mode)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, digits, mode), TSelf.Round(x.Y, digits, mode), TSelf.Round(x.Z, digits, mode));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Truncate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Truncate<TSelf>(Vector3D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Truncate(x.X), TSelf.Truncate(x.Y), TSelf.Truncate(x.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Atan2<TSelf>(Vector3D<TSelf> y, Vector3D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2(y.X, x.X), TSelf.Atan2(y.Y, x.Y), TSelf.Atan2(y.Z, x.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2Pi(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Atan2Pi<TSelf>(Vector3D<TSelf> y, Vector3D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2Pi(y.X, x.X), TSelf.Atan2Pi(y.Y, x.Y), TSelf.Atan2Pi(y.Z, x.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Lerp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value1">A vector whose members will be provided for <parameref name="value1"/>.</param>
        /// <param name="value2">A vector whose members will be provided for <parameref name="value2"/>.</param>
        /// <param name="amount">A single value provided for <parameref name="amount"/>.</param>
        public static Vector3D<TSelf> Lerp<TSelf>(Vector3D<TSelf> value1, Vector3D<TSelf> value2, TSelf amount)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Lerp(value1.X, value2.X, amount), TSelf.Lerp(value1.Y, value2.Y, amount), TSelf.Lerp(value1.Z, value2.Z, amount));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitDecrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> BitDecrement<TSelf>(Vector3D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitDecrement(x.X), TSelf.BitDecrement(x.Y), TSelf.BitDecrement(x.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitIncrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> BitIncrement<TSelf>(Vector3D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitIncrement(x.X), TSelf.BitIncrement(x.Y), TSelf.BitIncrement(x.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector3D<TSelf> FusedMultiplyAdd<TSelf>(Vector3D<TSelf> left, Vector3D<TSelf> right, Vector3D<TSelf> addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right.X, addend.X), TSelf.FusedMultiplyAdd(left.Y, right.Y, addend.Y), TSelf.FusedMultiplyAdd(left.Z, right.Z, addend.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector3D<TSelf> FusedMultiplyAdd<TSelf>(Vector3D<TSelf> left, Vector3D<TSelf> right, TSelf addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right.X, addend), TSelf.FusedMultiplyAdd(left.Y, right.Y, addend), TSelf.FusedMultiplyAdd(left.Z, right.Z, addend));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector3D<TSelf> FusedMultiplyAdd<TSelf>(Vector3D<TSelf> left, TSelf right, Vector3D<TSelf> addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right, addend.X), TSelf.FusedMultiplyAdd(left.Y, right, addend.Y), TSelf.FusedMultiplyAdd(left.Z, right, addend.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector3D<TSelf> FusedMultiplyAdd<TSelf>(Vector3D<TSelf> left, TSelf right, TSelf addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right, addend), TSelf.FusedMultiplyAdd(left.Y, right, addend), TSelf.FusedMultiplyAdd(left.Z, right, addend));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static Vector3D<TSelf> Ieee754Remainder<TSelf>(Vector3D<TSelf> left, Vector3D<TSelf> right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right.X), TSelf.Ieee754Remainder(left.Y, right.Y), TSelf.Ieee754Remainder(left.Z, right.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        public static Vector3D<TSelf> Ieee754Remainder<TSelf>(Vector3D<TSelf> left, TSelf right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right), TSelf.Ieee754Remainder(left.Y, right), TSelf.Ieee754Remainder(left.Z, right));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ILogB(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<int> ILogB<TSelf>(Vector3D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ILogB(x.X), TSelf.ILogB(x.Y), TSelf.ILogB(x.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> ReciprocalEstimate<TSelf>(Vector3D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalEstimate(x.X), TSelf.ReciprocalEstimate(x.Y), TSelf.ReciprocalEstimate(x.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalSqrtEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> ReciprocalSqrtEstimate<TSelf>(Vector3D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalSqrtEstimate(x.X), TSelf.ReciprocalSqrtEstimate(x.Y), TSelf.ReciprocalSqrtEstimate(x.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector3D<TSelf> ScaleB<TSelf>(Vector3D<TSelf> x, Vector3D<int> n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n.X), TSelf.ScaleB(x.Y, n.Y), TSelf.ScaleB(x.Z, n.Z));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector3D<TSelf> ScaleB<TSelf>(Vector3D<TSelf> x, int n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n), TSelf.ScaleB(x.Y, n), TSelf.ScaleB(x.Z, n));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> Pow<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y.X), TSelf.Pow(x.Y, y.Y), TSelf.Pow(x.Z, y.Z));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> Pow<TSelf>(Vector3D<TSelf> x, TSelf y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y), TSelf.Pow(x.Y, y), TSelf.Pow(x.Z, y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Cbrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Cbrt<TSelf>(Vector3D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Cbrt(x.X), TSelf.Cbrt(x.Y), TSelf.Cbrt(x.Z));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Sqrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Sqrt<TSelf>(Vector3D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Sqrt(x.X), TSelf.Sqrt(x.Y), TSelf.Sqrt(x.Z));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector3D<TSelf> RootN<TSelf>(Vector3D<TSelf> x, int n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n), TSelf.RootN(x.Y, n), TSelf.RootN(x.Z, n));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector3D<TSelf> RootN<TSelf>(Vector3D<TSelf> x, Vector3D<int> n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n.X), TSelf.RootN(x.Y, n.Y), TSelf.RootN(x.Z, n.Z));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Hypot(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> Hypot<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> y)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Hypot(x.X, y.X), TSelf.Hypot(x.Y, y.Y), TSelf.Hypot(x.Z, y.Z));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Hypot(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector3D<TSelf> Hypot<TSelf>(Vector3D<TSelf> x, TSelf y)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Hypot(x.X, y), TSelf.Hypot(x.Y, y), TSelf.Hypot(x.Z, y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Log<TSelf>(Vector3D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y), TSelf.Log(x.Z));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="newBase">A vector whose members will be provided for <parameref name="newBase"/>.</param>
        public static Vector3D<TSelf> Log<TSelf>(Vector3D<TSelf> x, Vector3D<TSelf> newBase)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase.X), TSelf.Log(x.Y, newBase.Y), TSelf.Log(x.Z, newBase.Z));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="newBase">A single value provided for <parameref name="newBase"/>.</param>
        public static Vector3D<TSelf> Log<TSelf>(Vector3D<TSelf> x, TSelf newBase)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase), TSelf.Log(x.Y, newBase), TSelf.Log(x.Z, newBase));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.LogP1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> LogP1<TSelf>(Vector3D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y), TSelf.LogP1(x.Z));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Log2<TSelf>(Vector3D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y), TSelf.Log2(x.Z));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Log2P1<TSelf>(Vector3D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y), TSelf.Log2P1(x.Z));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Log10<TSelf>(Vector3D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y), TSelf.Log10(x.Z));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Log10P1<TSelf>(Vector3D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y), TSelf.Log10P1(x.Z));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Exp<TSelf>(Vector3D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y), TSelf.Exp(x.Z));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.ExpM1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> ExpM1<TSelf>(Vector3D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y), TSelf.ExpM1(x.Z));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Exp2<TSelf>(Vector3D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y), TSelf.Exp2(x.Z));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Exp2M1<TSelf>(Vector3D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y), TSelf.Exp2M1(x.Z));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Exp10<TSelf>(Vector3D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y), TSelf.Exp10(x.Z));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Exp10M1<TSelf>(Vector3D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y), TSelf.Exp10M1(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Acos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Acos<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Acos(x.X), TSelf.Acos(x.Y), TSelf.Acos(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AcosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> AcosPi<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AcosPi(x.X), TSelf.AcosPi(x.Y), TSelf.AcosPi(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Asin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Asin<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Asin(x.X), TSelf.Asin(x.Y), TSelf.Asin(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AsinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> AsinPi<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AsinPi(x.X), TSelf.AsinPi(x.Y), TSelf.AsinPi(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Atan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Atan<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Atan(x.X), TSelf.Atan(x.Y), TSelf.Atan(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AtanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> AtanPi<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AtanPi(x.X), TSelf.AtanPi(x.Y), TSelf.AtanPi(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Cos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Cos<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Cos(x.X), TSelf.Cos(x.Y), TSelf.Cos(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.CosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> CosPi<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.CosPi(x.X), TSelf.CosPi(x.Y), TSelf.CosPi(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Sin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Sin<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Sin(x.X), TSelf.Sin(x.Y), TSelf.Sin(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> SinPi<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.SinPi(x.X), TSelf.SinPi(x.Y), TSelf.SinPi(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Tan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Tan<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Tan(x.X), TSelf.Tan(x.Y), TSelf.Tan(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.TanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> TanPi<TSelf>(Vector3D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.TanPi(x.X), TSelf.TanPi(x.Y), TSelf.TanPi(x.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.DegreesToRadians(TSelf)"/> to the provided arguments.</summary>
        /// <param name="degrees">A vector whose members will be provided for <parameref name="degrees"/>.</param>
        public static Vector3D<TSelf> DegreesToRadians<TSelf>(Vector3D<TSelf> degrees)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.DegreesToRadians(degrees.X), TSelf.DegreesToRadians(degrees.Y), TSelf.DegreesToRadians(degrees.Z));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.RadiansToDegrees(TSelf)"/> to the provided arguments.</summary>
        /// <param name="radians">A vector whose members will be provided for <parameref name="radians"/>.</param>
        public static Vector3D<TSelf> RadiansToDegrees<TSelf>(Vector3D<TSelf> radians)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.RadiansToDegrees(radians.X), TSelf.RadiansToDegrees(radians.Y), TSelf.RadiansToDegrees(radians.Z));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Acosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Acosh<TSelf>(Vector3D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Acosh(x.X), TSelf.Acosh(x.Y), TSelf.Acosh(x.Z));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Asinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Asinh<TSelf>(Vector3D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Asinh(x.X), TSelf.Asinh(x.Y), TSelf.Asinh(x.Z));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Atanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Atanh<TSelf>(Vector3D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Atanh(x.X), TSelf.Atanh(x.Y), TSelf.Atanh(x.Z));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Cosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Cosh<TSelf>(Vector3D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Cosh(x.X), TSelf.Cosh(x.Y), TSelf.Cosh(x.Z));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Sinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Sinh<TSelf>(Vector3D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Sinh(x.X), TSelf.Sinh(x.Y), TSelf.Sinh(x.Z));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Tanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector3D<TSelf> Tanh<TSelf>(Vector3D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Tanh(x.X), TSelf.Tanh(x.Y), TSelf.Tanh(x.Z));

        /// <summary>Transforms the given vector by the specified Quaternion.</summary>
        public static Vector3D<T> Transform<T>(Vector2D<T> vector, Quaternion<T> quaternion)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var x2 = quaternion.X + quaternion.X;
            var y2 = quaternion.Y + quaternion.Y;
            var z2 = quaternion.Z + quaternion.Z;

            var wx2 = quaternion.W * x2;
            var wy2 = quaternion.W * y2;
            var wz2 = quaternion.W * z2;
            var xx2 = quaternion.X * x2;
            var xy2 = quaternion.X * y2;
            var xz2 = quaternion.X * z2;
            var yy2 = quaternion.Y * y2;
            var yz2 = quaternion.Y * z2;
            var zz2 = quaternion.Z * z2;

            return new(
                (vector.X * (T.One - yy2 - zz2)) + (vector.Y * (xy2 - wz2)),
                (vector.X * (xy2 + wz2)) + (vector.Y * (T.One - xx2 - zz2)),
                (vector.X * (xz2 - wy2)) + (vector.Y * (yz2 + wx2)));
        }

        /// <summary>Transforms the given vector by the specified Quaternion.</summary>
        public static Vector3D<T> Transform<T>(Vector3D<T> vector, Quaternion<T> quaternion)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var x2 = quaternion.X + quaternion.X;
            var y2 = quaternion.Y + quaternion.Y;
            var z2 = quaternion.Z + quaternion.Z;

            var wx2 = quaternion.W * x2;
            var wy2 = quaternion.W * y2;
            var wz2 = quaternion.W * z2;
            var xx2 = quaternion.X * x2;
            var xy2 = quaternion.X * y2;
            var xz2 = quaternion.X * z2;
            var yy2 = quaternion.Y * y2;
            var yz2 = quaternion.Y * z2;
            var zz2 = quaternion.Z * z2;

            return new(
                (vector.X * (T.One - yy2 - zz2)) + (vector.Y * (xy2 - wz2)) + (vector.Z * (xz2 + wy2)),
                (vector.X * (xy2 + wz2)) + (vector.Y * (T.One - xx2 - zz2)) + (vector.Z * (yz2 - wx2)),
                (vector.X * (xz2 - wy2)) + (vector.Y * (yz2 + wx2)) + (vector.Z * (T.One - xx2 - yy2)));
        }

        /// <summary>Transforms the given vector by the specified Quaternion.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector2D<T> vector, Quaternion<T> quaternion)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var x2 = quaternion.X + quaternion.X;
            var y2 = quaternion.Y + quaternion.Y;
            var z2 = quaternion.Z + quaternion.Z;

            var wx2 = quaternion.W * x2;
            var wy2 = quaternion.W * y2;
            var wz2 = quaternion.W * z2;
            var xx2 = quaternion.X * x2;
            var xy2 = quaternion.X * y2;
            var xz2 = quaternion.X * z2;
            var yy2 = quaternion.Y * y2;
            var yz2 = quaternion.Y * z2;
            var zz2 = quaternion.Z * z2;

            return new(
                (vector.X * (T.One - yy2 - zz2)) + (vector.Y * (xy2 - wz2)),
                (vector.X * (xy2 + wz2)) + (vector.Y * (T.One - xx2 - zz2)),
                (vector.X * (xz2 - wy2)) + (vector.Y * (yz2 + wx2)));
        }

        /// <summary>Transforms the given vector by the specified Quaternion.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector3D<T> vector, Quaternion<T> quaternion)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var x2 = quaternion.X + quaternion.X;
            var y2 = quaternion.Y + quaternion.Y;
            var z2 = quaternion.Z + quaternion.Z;

            var wx2 = quaternion.W * x2;
            var wy2 = quaternion.W * y2;
            var wz2 = quaternion.W * z2;
            var xx2 = quaternion.X * x2;
            var xy2 = quaternion.X * y2;
            var xz2 = quaternion.X * z2;
            var yy2 = quaternion.Y * y2;
            var yz2 = quaternion.Y * z2;
            var zz2 = quaternion.Z * z2;

            return new(
                (vector.X * (T.One - yy2 - zz2)) + (vector.Y * (xy2 - wz2)) + (vector.Z * (xz2 + wy2)),
                (vector.X * (xy2 + wz2)) + (vector.Y * (T.One - xx2 - zz2)) + (vector.Z * (yz2 - wx2)),
                (vector.X * (xz2 - wy2)) + (vector.Y * (yz2 + wx2)) + (vector.Z * (T.One - xx2 - yy2)));
        }

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector2D<T> vector, Matrix2X3<T> matrix)
            where T : INumberBase<T>
            => vector * matrix;

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector3D<T> vector, Matrix2X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector2D<T> vector, Matrix2X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector3D<T> vector, Matrix2X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector2D<T> vector, Matrix3X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M31,
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M32,
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + matrix.M33);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector3D<T> vector, Matrix3X3<T> matrix)
            where T : INumberBase<T>
            => vector * matrix;

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector2D<T> vector, Matrix3X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M31,
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M32,
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + matrix.M33);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector3D<T> vector, Matrix3X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + (vector.Z * matrix.M31),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + (vector.Z * matrix.M32),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + (vector.Z * matrix.M33));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector2D<T> vector, Matrix4X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M41,
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M42,
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + matrix.M43);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector3D<T> vector, Matrix4X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + (vector.Z * matrix.M31) + matrix.M41,
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + (vector.Z * matrix.M32) + matrix.M42,
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + (vector.Z * matrix.M33) + matrix.M43);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector2D<T> vector, Matrix4X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M41,
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M42,
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + matrix.M43);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector3D<T> vector, Matrix4X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + (vector.Z * matrix.M31) + matrix.M41,
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + (vector.Z * matrix.M32) + matrix.M42,
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + (vector.Z * matrix.M33) + matrix.M43);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector2D<T> vector, Matrix5X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M51,
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M52,
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + matrix.M53);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> Transform<T>(Vector3D<T> vector, Matrix5X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + (vector.Z * matrix.M31) + matrix.M51,
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + (vector.Z * matrix.M32) + matrix.M52,
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + (vector.Z * matrix.M33) + matrix.M53);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector2D<T> vector, Matrix2X3<T> matrix)
            where T : INumberBase<T>
            => vector * matrix;

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector3D<T> vector, Matrix2X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector2D<T> vector, Matrix2X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector3D<T> vector, Matrix2X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector2D<T> vector, Matrix3X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector3D<T> vector, Matrix3X3<T> matrix)
            where T : INumberBase<T>
            => vector * matrix;

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector2D<T> vector, Matrix3X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector3D<T> vector, Matrix3X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + (vector.Z * matrix.M31),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + (vector.Z * matrix.M32),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + (vector.Z * matrix.M33));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector2D<T> vector, Matrix4X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector3D<T> vector, Matrix4X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + (vector.Z * matrix.M31),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + (vector.Z * matrix.M32),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + (vector.Z * matrix.M33));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector2D<T> vector, Matrix4X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector3D<T> vector, Matrix4X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + (vector.Z * matrix.M31),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + (vector.Z * matrix.M32),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + (vector.Z * matrix.M33));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector2D<T> vector, Matrix5X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector3D<T> TransformNormal<T>(Vector3D<T> vector, Matrix5X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + (vector.Z * matrix.M31),
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + (vector.Z * matrix.M32),
                (vector.X * matrix.M13) + (vector.Y * matrix.M23) + (vector.Z * matrix.M33));
    }
}
