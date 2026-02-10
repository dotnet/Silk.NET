// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    using System.Numerics;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Methods for working with <see cref="Vector2D{T}"/>.
    /// </summary>
    public static partial class Vector2D
    {
        /// <summary>Extensions for vectors with elements implementing <see cref="IRootFunctions{TSelf}"/>.</summary>
        extension<TSelf>(Vector2D<TSelf> vector)
            where TSelf : IRootFunctions<TSelf>
        {
            /// <summary>Gets the length of the vector.</summary>
            public TSelf Length => TSelf.Sqrt(vector.LengthSquared);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="INumberBase{TSelf}"/>.</summary>
        extension<TSelf>(Vector2D<TSelf> vector)
            where TSelf : INumberBase<TSelf>
        {
            /// <summary>Gets the length squared of the vector.</summary>
            public TSelf LengthSquared => Vector2D.Dot(vector, vector);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="IBitwiseOperators{TSelf, TSelf, TSelf}"/>.</summary>
        extension<TSelf>(Vector2D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, IBitwiseOperators<TSelf, TSelf, TSelf>
        {
            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf,TSelf}.op_OnesComplement"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> OnesComplement(Vector2D<TSelf> value)
                => new(~value.X, ~value.Y);

            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf, TSelf}.op_BitwiseAnd"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> BitwiseAnd(Vector2D<TSelf> left, Vector2D<TSelf> right)
                => new(left.X & right.X, left.Y & right.Y);

            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf, TSelf}.op_BitwiseOr"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> BitwiseOr(Vector2D<TSelf> left, Vector2D<TSelf> right)
                => new(left.X | right.X, left.Y | right.Y);

            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf, TSelf}.op_ExclusiveOr"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> ExclusiveOr(Vector2D<TSelf> left, Vector2D<TSelf> right)
                => new(left.X ^ right.X, left.Y ^ right.Y);

            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf,TSelf}.op_BitwiseAnd"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> BitwiseAnd(Vector2D<TSelf> left, TSelf right)
                => new(left.X & right, left.Y & right);

            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf, TSelf}.op_BitwiseOr"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> BitwiseOr(Vector2D<TSelf> left, TSelf right)
                => new(left.X | right, left.Y | right);

            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf, TSelf}.op_ExclusiveOr"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> ExclusiveOr(Vector2D<TSelf> left, TSelf right)
                => new(left.X ^ right, left.Y ^ right);

            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf, TSelf}.op_BitwiseAnd"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> BitwiseAnd(TSelf left, Vector2D<TSelf> right)
                => new(left & right.X, left & right.Y);

            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf,TSelf}.op_BitwiseOr"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> BitwiseOr(TSelf left, Vector2D<TSelf> right)
                => new(left | right.X, left | right.Y);

            /// <inheritdoc cref="IBitwiseOperators{TSelf, TSelf, TSelf}.op_ExclusiveOr"/>
            /// <remarks>Applied component-wise to the vector.</remarks>
            public static Vector2D<TSelf> ExclusiveOr(TSelf left, Vector2D<TSelf> right)
                => new(left ^ right.X, left ^ right.Y);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="IBinaryNumber{TSelf}"/>.</summary>
        extension<TSelf>(Vector2D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, IBinaryNumber<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="IBinaryNumber{TSelf}.AllBitsSet"/>.</summary>
            public static Vector2D<TSelf> AllBitsSet => new(TSelf.AllBitsSet);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="IFloatingPointConstants{TSelf}"/>.</summary>
        extension<TSelf>(Vector2D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, IFloatingPointConstants<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointConstants{TSelf}.E"/>.</summary>
            public static Vector2D<TSelf> E => new(TSelf.E);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointConstants{TSelf}.Pi"/>.</summary>
            public static Vector2D<TSelf> Pi => new(TSelf.Pi);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointConstants{TSelf}.Tau"/>.</summary>
            public static Vector2D<TSelf> Tau => new(TSelf.Tau);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="IFloatingPointIeee754{TSelf}"/>.</summary>
        extension<TSelf>(Vector2D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, IFloatingPointIeee754<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.Epsilon"/>.</summary>
            public static Vector2D<TSelf> Epsilon => new(TSelf.Epsilon);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.</summary>
            public static Vector2D<TSelf> NaN => new(TSelf.NaN);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.NegativeInfinity"/>.</summary>
            public static Vector2D<TSelf> NegativeInfinity => new(TSelf.NegativeInfinity);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/>.</summary>
            public static Vector2D<TSelf> NegativeZero => new(TSelf.NegativeZero);

            /// <summary>Gets a vector with all components set to <see cref="IFloatingPointIeee754{TSelf}.PositiveInfinity"/>.</summary>
            public static Vector2D<TSelf> PositiveInfinity => new(TSelf.PositiveInfinity);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="IMinMaxValue{TSelf}"/>.</summary>
        extension<TSelf>(Vector2D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, IMinMaxValue<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="IMinMaxValue{TSelf}.MinValue"/>.</summary>
            public static Vector2D<TSelf> MinValue => new(TSelf.MinValue);

            /// <summary>Gets a vector with all components set to <see cref="IMinMaxValue{TSelf}.MaxValue"/>.</summary>
            public static Vector2D<TSelf> MaxValue => new(TSelf.MaxValue);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="ISignedNumber{TSelf}"/>.</summary>
        extension<TSelf>(Vector2D<TSelf> vector)
            where TSelf : INumberBase<TSelf>, ISignedNumber<TSelf>
        {
            /// <summary>Gets a vector with all components set to <see cref="ISignedNumber{TSelf}.NegativeOne"/>.</summary>
            public static Vector2D<TSelf> NegativeOne => new(TSelf.NegativeOne);
        }

        /// <summary>Desconstructs a vector into its components.</summary>
        /// <param name="vector">The vector to deconstruct.</param>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public static void Deconstruct<T>(this Vector2D<T> vector, out T x, out T y)
            where T : INumberBase<T>
        {
            x = vector.X;
            y = vector.Y;
        }

        /// <summary>Computes the dot product of two vectors.</summary>
        public static T Dot<T>(Vector2D<T> left, Vector2D<T> right)
            where T : INumberBase<T> =>
            left.X * right.X + left.Y * right.Y;

        /// <summary>Reflects a vector over a normal vector.</summary>
        public static Vector2D<T> Reflect<T>(Vector2D<T> vector, Vector2D<T> normal)
            where T : INumberBase<T>
        {
            T dot = Dot(vector, normal);
            return vector - (normal * (dot + dot));
        }

        /// <summary>Normalizes a vector.</summary>
        public static Vector2D<T> Normalize<T>(this Vector2D<T> vector)
            where T : IRootFunctions<T>
            => vector / vector.Length;

        /// <summary>Returns the Euclidean distance between the two given points.</summary>
        /// <param name="start">The starting point.</param>
        /// <param name="end">The ending point.</param>
        /// <returns>The distance.</returns>
        public static T Distance<T>(Vector2D<T> start, Vector2D<T> end)
            where T : IRootFunctions<T> =>
            T.Sqrt(DistanceSquared(start, end));

        /// <summary>Returns the Euclidean distance squared between the two given points.</summary>
        /// <param name="start">The starting point.</param>
        /// <param name="end">The ending point.</param>
        /// <returns>The distance squared.</returns>
        public static T DistanceSquared<T>(Vector2D<T> start, Vector2D<T> end)
            where T : INumberBase<T>
        {
            var difference = end - start;
            return Dot(difference, difference);
        }

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf)"/> to each member of the vector and converts to integer.</summary>
        public static Vector2D<int> RoundToInt<T>(Vector2D<T> vector)
            where T : IFloatingPoint<T> =>
            Vector2D.Round(vector).AsChecked<int>();

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Floor(TSelf)"/> to each member of the vector and converts to integer.</summary>
        public static Vector2D<int> FloorToInt<T>(Vector2D<T> vector)
            where T : IFloatingPoint<T> =>
            Vector2D.Floor(vector).AsChecked<int>();

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Ceiling(TSelf)"/> to each member of the vector and converts to integer.</summary>
        public static Vector2D<int> CeilingToInt<T>(Vector2D<T> vector)
            where T : IFloatingPoint<T> =>
            Vector2D.Ceiling(vector).AsChecked<int>();

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<float> ToVector64(Vector2D<float> vector)
            => Vector64.Create(vector.X, vector.Y);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<float> ToVector128(Vector2D<float> vector)
            => Vector128.Create(vector.X, vector.Y, (float)0, (float)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<float> ToVector256(Vector2D<float> vector)
            => Vector256.Create(vector.X, vector.Y, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<float> ToVector512(Vector2D<float> vector)
            => Vector512.Create(vector.X, vector.Y, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0, (float)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<double> ToVector128(Vector2D<double> vector)
            => Vector128.Create(vector.X, vector.Y);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<double> ToVector256(Vector2D<double> vector)
            => Vector256.Create(vector.X, vector.Y, (double)0, (double)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<double> ToVector512(Vector2D<double> vector)
            => Vector512.Create(vector.X, vector.Y, (double)0, (double)0, (double)0, (double)0, (double)0, (double)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<byte> ToVector64(Vector2D<byte> vector)
            => Vector64.Create(vector.X, vector.Y, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<byte> ToVector128(Vector2D<byte> vector)
            => Vector128.Create(vector.X, vector.Y, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<byte> ToVector256(Vector2D<byte> vector)
            => Vector256.Create(vector.X, vector.Y, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<byte> ToVector512(Vector2D<byte> vector)
            => Vector512.Create(vector.X, vector.Y, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<short> ToVector64(Vector2D<short> vector)
            => Vector64.Create(vector.X, vector.Y, (short)0, (short)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<short> ToVector128(Vector2D<short> vector)
            => Vector128.Create(vector.X, vector.Y, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<short> ToVector256(Vector2D<short> vector)
            => Vector256.Create(vector.X, vector.Y, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<short> ToVector512(Vector2D<short> vector)
            => Vector512.Create(vector.X, vector.Y, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0, (short)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<int> ToVector64(Vector2D<int> vector)
            => Vector64.Create(vector.X, vector.Y);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<int> ToVector128(Vector2D<int> vector)
            => Vector128.Create(vector.X, vector.Y, (int)0, (int)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<int> ToVector256(Vector2D<int> vector)
            => Vector256.Create(vector.X, vector.Y, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<int> ToVector512(Vector2D<int> vector)
            => Vector512.Create(vector.X, vector.Y, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0, (int)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<long> ToVector128(Vector2D<long> vector)
            => Vector128.Create(vector.X, vector.Y);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<long> ToVector256(Vector2D<long> vector)
            => Vector256.Create(vector.X, vector.Y, (long)0, (long)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<long> ToVector512(Vector2D<long> vector)
            => Vector512.Create(vector.X, vector.Y, (long)0, (long)0, (long)0, (long)0, (long)0, (long)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<sbyte> ToVector64(Vector2D<sbyte> vector)
            => Vector64.Create(vector.X, vector.Y, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<sbyte> ToVector128(Vector2D<sbyte> vector)
            => Vector128.Create(vector.X, vector.Y, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<sbyte> ToVector256(Vector2D<sbyte> vector)
            => Vector256.Create(vector.X, vector.Y, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<sbyte> ToVector512(Vector2D<sbyte> vector)
            => Vector512.Create(vector.X, vector.Y, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<ushort> ToVector64(Vector2D<ushort> vector)
            => Vector64.Create(vector.X, vector.Y, (ushort)0, (ushort)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<ushort> ToVector128(Vector2D<ushort> vector)
            => Vector128.Create(vector.X, vector.Y, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<ushort> ToVector256(Vector2D<ushort> vector)
            => Vector256.Create(vector.X, vector.Y, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<ushort> ToVector512(Vector2D<ushort> vector)
            => Vector512.Create(vector.X, vector.Y, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0, (ushort)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector64{T}"/>.</summary>
        public static Vector64<uint> ToVector64(Vector2D<uint> vector)
            => Vector64.Create(vector.X, vector.Y);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<uint> ToVector128(Vector2D<uint> vector)
            => Vector128.Create(vector.X, vector.Y, (uint)0, (uint)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<uint> ToVector256(Vector2D<uint> vector)
            => Vector256.Create(vector.X, vector.Y, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<uint> ToVector512(Vector2D<uint> vector)
            => Vector512.Create(vector.X, vector.Y, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0, (uint)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector128{T}"/>.</summary>
        public static Vector128<ulong> ToVector128(Vector2D<ulong> vector)
            => Vector128.Create(vector.X, vector.Y);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector256{T}"/>.</summary>
        public static Vector256<ulong> ToVector256(Vector2D<ulong> vector)
            => Vector256.Create(vector.X, vector.Y, (ulong)0, (ulong)0);

        /// <summary>Converts a <see cref="Vector2D{T}"/> to a <see cref="Vector512{T}"/>.</summary>
        public static Vector512<ulong> ToVector512(Vector2D<ulong> vector)
            => Vector512.Create(vector.X, vector.Y, (ulong)0, (ulong)0, (ulong)0, (ulong)0, (ulong)0, (ulong)0);

        /// <summary>Linearly interpolates between two vectors using a scalar t-value (clamped between 0 and 1).</summary>
        public static Vector2D<T> LerpClamped<T>(Vector2D<T> a, Vector2D<T> b, T amount)
            where T : IFloatingPointIeee754<T> =>
            Lerp(a, b, T.Clamp(amount, T.Zero, T.One));

        /// <summary>Linearly interpolates between two vectors using a vector t-value (clamped between 0 and 1).</summary>
        public static Vector2D<T> LerpClamped<T>(Vector2D<T> a, Vector2D<T> b, Vector2D<T> amount)
            where T : IFloatingPointIeee754<T> =>
            new(T.Lerp(a.X, b.X, T.Clamp(amount.X, T.Zero, T.One)),
                T.Lerp(a.Y, b.Y, T.Clamp(amount.Y, T.Zero, T.One)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector2D<T> Sin, Vector2D<T> Cos) SinCos<T>(Vector2D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.Sin(x.X), T.Sin(x.Y)), new(T.Cos(x.X), T.Cos(x.Y)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector2D<T> SinPi, Vector2D<T> CosPi) SinCosPi<T>(Vector2D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.SinPi(x.X), T.SinPi(x.Y)), new(T.CosPi(x.X), T.CosPi(x.Y)));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.DivRem(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static (Vector2D<T> Quotient, Vector2D<T> Remainder) DivRem<T>(Vector2D<T> left, Vector2D<T> right)
            where T : IBinaryInteger<T>
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            return (new Vector2D<T>(qX, qY), new Vector2D<T>(rX, rY));
        }

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector2D<T> Multiply<T>(Vector2D<T> left, T right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector2D<T> Multiply<T>(T left, Vector2D<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Applies <see cref="INumber{TSelf}.Sign(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector2D<int> Sign<TSelf>(Vector2D<TSelf> value)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Sign(value.X), TSelf.Sign(value.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Max<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y.X), TSelf.Max(x.Y, y.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Max<TSelf>(Vector2D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y), TSelf.Max(x.Y, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MaxNumber<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y.X), TSelf.MaxNumber(x.Y, y.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MaxNumber<TSelf>(Vector2D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y), TSelf.MaxNumber(x.Y, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Min<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y.X), TSelf.Min(x.Y, y.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Min<TSelf>(Vector2D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y), TSelf.Min(x.Y, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MinNumber<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y.X), TSelf.MinNumber(x.Y, y.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MinNumber<TSelf>(Vector2D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y), TSelf.MinNumber(x.Y, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A vector whose members will be provided for <parameref name="min"/>.</param>
        /// <param name="max">A vector whose members will be provided for <parameref name="max"/>.</param>
        public static Vector2D<TSelf> Clamp<TSelf>(Vector2D<TSelf> value, Vector2D<TSelf> min, Vector2D<TSelf> max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min.X, max.X), TSelf.Clamp(value.Y, min.Y, max.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A single value provided for <parameref name="min"/>.</param>
        /// <param name="max">A single value provided for <parameref name="max"/>.</param>
        public static Vector2D<TSelf> Clamp<TSelf>(Vector2D<TSelf> value, TSelf min, TSelf max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min, max), TSelf.Clamp(value.Y, min, max));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A vector whose members will be provided for <parameref name="sign"/>.</param>
        public static Vector2D<TSelf> CopySign<TSelf>(Vector2D<TSelf> value, Vector2D<TSelf> sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign.X), TSelf.CopySign(value.Y, sign.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A single value provided for <parameref name="sign"/>.</param>
        public static Vector2D<TSelf> CopySign<TSelf>(Vector2D<TSelf> value, TSelf sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign), TSelf.CopySign(value.Y, sign));

        /// <summary>Applies <see cref="INumberBase{TSelf}.Abs(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector2D<TSelf> Abs<TSelf>(Vector2D<TSelf> value)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.Abs(value.X), TSelf.Abs(value.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MaxMagnitude<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitude(x.X, y.X), TSelf.MaxMagnitude(x.Y, y.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MaxMagnitudeNumber<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitudeNumber(x.X, y.X), TSelf.MaxMagnitudeNumber(x.Y, y.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MinMagnitude<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitude(x.X, y.X), TSelf.MinMagnitude(x.Y, y.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MinMagnitudeNumber<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitudeNumber(x.X, y.X), TSelf.MinMagnitudeNumber(x.Y, y.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> MultiplyAddEstimate<TSelf>(Vector2D<TSelf> left, Vector2D<TSelf> right, Vector2D<TSelf> addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right.X, addend.X), TSelf.MultiplyAddEstimate(left.Y, right.Y, addend.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> MultiplyAddEstimate<TSelf>(Vector2D<TSelf> left, Vector2D<TSelf> right, TSelf addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right.X, addend), TSelf.MultiplyAddEstimate(left.Y, right.Y, addend));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> MultiplyAddEstimate<TSelf>(Vector2D<TSelf> left, TSelf right, Vector2D<TSelf> addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right, addend.X), TSelf.MultiplyAddEstimate(left.Y, right, addend.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> MultiplyAddEstimate<TSelf>(Vector2D<TSelf> left, TSelf right, TSelf addend)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MultiplyAddEstimate(left.X, right, addend), TSelf.MultiplyAddEstimate(left.Y, right, addend));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.PopCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector2D<TSelf> PopCount<TSelf>(Vector2D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.PopCount(value.X), TSelf.PopCount(value.Y));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.TrailingZeroCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector2D<TSelf> TrailingZeroCount<TSelf>(Vector2D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.TrailingZeroCount(value.X), TSelf.TrailingZeroCount(value.Y));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Ceiling(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Ceiling<TSelf>(Vector2D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Ceiling(x.X), TSelf.Ceiling(x.Y));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Floor(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Floor<TSelf>(Vector2D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Floor(x.X), TSelf.Floor(x.Y));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Round<TSelf>(Vector2D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X), TSelf.Round(x.Y));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="digits">A single value provided for <parameref name="digits"/>.</param>
        public static Vector2D<TSelf> Round<TSelf>(Vector2D<TSelf> x, int digits)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, digits), TSelf.Round(x.Y, digits));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, MidpointRounding)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="mode">A single value provided for <parameref name="mode"/>.</param>
        public static Vector2D<TSelf> Round<TSelf>(Vector2D<TSelf> x, MidpointRounding mode)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, mode), TSelf.Round(x.Y, mode));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, int, MidpointRounding)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="digits">A single value provided for <parameref name="digits"/>.</param>
        /// <param name="mode">A single value provided for <parameref name="mode"/>.</param>
        public static Vector2D<TSelf> Round<TSelf>(Vector2D<TSelf> x, int digits, MidpointRounding mode)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, digits, mode), TSelf.Round(x.Y, digits, mode));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Truncate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Truncate<TSelf>(Vector2D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Truncate(x.X), TSelf.Truncate(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Atan2<TSelf>(Vector2D<TSelf> y, Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2(y.X, x.X), TSelf.Atan2(y.Y, x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2Pi(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Atan2Pi<TSelf>(Vector2D<TSelf> y, Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2Pi(y.X, x.X), TSelf.Atan2Pi(y.Y, x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Lerp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value1">A vector whose members will be provided for <parameref name="value1"/>.</param>
        /// <param name="value2">A vector whose members will be provided for <parameref name="value2"/>.</param>
        /// <param name="amount">A single value provided for <parameref name="amount"/>.</param>
        public static Vector2D<TSelf> Lerp<TSelf>(Vector2D<TSelf> value1, Vector2D<TSelf> value2, TSelf amount)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Lerp(value1.X, value2.X, amount), TSelf.Lerp(value1.Y, value2.Y, amount));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitDecrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> BitDecrement<TSelf>(Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitDecrement(x.X), TSelf.BitDecrement(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitIncrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> BitIncrement<TSelf>(Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitIncrement(x.X), TSelf.BitIncrement(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> FusedMultiplyAdd<TSelf>(Vector2D<TSelf> left, Vector2D<TSelf> right, Vector2D<TSelf> addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right.X, addend.X), TSelf.FusedMultiplyAdd(left.Y, right.Y, addend.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> FusedMultiplyAdd<TSelf>(Vector2D<TSelf> left, Vector2D<TSelf> right, TSelf addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right.X, addend), TSelf.FusedMultiplyAdd(left.Y, right.Y, addend));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> FusedMultiplyAdd<TSelf>(Vector2D<TSelf> left, TSelf right, Vector2D<TSelf> addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right, addend.X), TSelf.FusedMultiplyAdd(left.Y, right, addend.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> FusedMultiplyAdd<TSelf>(Vector2D<TSelf> left, TSelf right, TSelf addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right, addend), TSelf.FusedMultiplyAdd(left.Y, right, addend));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static Vector2D<TSelf> Ieee754Remainder<TSelf>(Vector2D<TSelf> left, Vector2D<TSelf> right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right.X), TSelf.Ieee754Remainder(left.Y, right.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        public static Vector2D<TSelf> Ieee754Remainder<TSelf>(Vector2D<TSelf> left, TSelf right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right), TSelf.Ieee754Remainder(left.Y, right));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ILogB(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<int> ILogB<TSelf>(Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ILogB(x.X), TSelf.ILogB(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> ReciprocalEstimate<TSelf>(Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalEstimate(x.X), TSelf.ReciprocalEstimate(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalSqrtEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> ReciprocalSqrtEstimate<TSelf>(Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalSqrtEstimate(x.X), TSelf.ReciprocalSqrtEstimate(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector2D<TSelf> ScaleB<TSelf>(Vector2D<TSelf> x, Vector2D<int> n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n.X), TSelf.ScaleB(x.Y, n.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector2D<TSelf> ScaleB<TSelf>(Vector2D<TSelf> x, int n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n), TSelf.ScaleB(x.Y, n));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Pow<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y.X), TSelf.Pow(x.Y, y.Y));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Pow<TSelf>(Vector2D<TSelf> x, TSelf y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y), TSelf.Pow(x.Y, y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Cbrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Cbrt<TSelf>(Vector2D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Cbrt(x.X), TSelf.Cbrt(x.Y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Sqrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Sqrt<TSelf>(Vector2D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Sqrt(x.X), TSelf.Sqrt(x.Y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector2D<TSelf> RootN<TSelf>(Vector2D<TSelf> x, int n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n), TSelf.RootN(x.Y, n));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector2D<TSelf> RootN<TSelf>(Vector2D<TSelf> x, Vector2D<int> n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n.X), TSelf.RootN(x.Y, n.Y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Hypot(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Hypot<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Hypot(x.X, y.X), TSelf.Hypot(x.Y, y.Y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Hypot(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Hypot<TSelf>(Vector2D<TSelf> x, TSelf y)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Hypot(x.X, y), TSelf.Hypot(x.Y, y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log<TSelf>(Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="newBase">A vector whose members will be provided for <parameref name="newBase"/>.</param>
        public static Vector2D<TSelf> Log<TSelf>(Vector2D<TSelf> x, Vector2D<TSelf> newBase)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase.X), TSelf.Log(x.Y, newBase.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="newBase">A single value provided for <parameref name="newBase"/>.</param>
        public static Vector2D<TSelf> Log<TSelf>(Vector2D<TSelf> x, TSelf newBase)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase), TSelf.Log(x.Y, newBase));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.LogP1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> LogP1<TSelf>(Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log2<TSelf>(Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log2P1<TSelf>(Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log10<TSelf>(Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log10P1<TSelf>(Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp<TSelf>(Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.ExpM1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> ExpM1<TSelf>(Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp2<TSelf>(Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp2M1<TSelf>(Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp10<TSelf>(Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp10M1<TSelf>(Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Acos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Acos<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Acos(x.X), TSelf.Acos(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AcosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> AcosPi<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AcosPi(x.X), TSelf.AcosPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Asin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Asin<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Asin(x.X), TSelf.Asin(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AsinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> AsinPi<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AsinPi(x.X), TSelf.AsinPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Atan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Atan<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Atan(x.X), TSelf.Atan(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AtanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> AtanPi<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AtanPi(x.X), TSelf.AtanPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Cos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Cos<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Cos(x.X), TSelf.Cos(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.CosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> CosPi<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.CosPi(x.X), TSelf.CosPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Sin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Sin<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Sin(x.X), TSelf.Sin(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> SinPi<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.SinPi(x.X), TSelf.SinPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Tan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Tan<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Tan(x.X), TSelf.Tan(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.TanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> TanPi<TSelf>(Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.TanPi(x.X), TSelf.TanPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.DegreesToRadians(TSelf)"/> to the provided arguments.</summary>
        /// <param name="degrees">A vector whose members will be provided for <parameref name="degrees"/>.</param>
        public static Vector2D<TSelf> DegreesToRadians<TSelf>(Vector2D<TSelf> degrees)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.DegreesToRadians(degrees.X), TSelf.DegreesToRadians(degrees.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.RadiansToDegrees(TSelf)"/> to the provided arguments.</summary>
        /// <param name="radians">A vector whose members will be provided for <parameref name="radians"/>.</param>
        public static Vector2D<TSelf> RadiansToDegrees<TSelf>(Vector2D<TSelf> radians)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.RadiansToDegrees(radians.X), TSelf.RadiansToDegrees(radians.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Acosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Acosh<TSelf>(Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Acosh(x.X), TSelf.Acosh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Asinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Asinh<TSelf>(Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Asinh(x.X), TSelf.Asinh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Atanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Atanh<TSelf>(Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Atanh(x.X), TSelf.Atanh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Cosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Cosh<TSelf>(Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Cosh(x.X), TSelf.Cosh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Sinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Sinh<TSelf>(Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Sinh(x.X), TSelf.Sinh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Tanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Tanh<TSelf>(Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Tanh(x.X), TSelf.Tanh(x.Y));

        /// <summary>Transforms the given vector by the specified Quaternion.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Quaternion<T> quaternion)
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
                (vector.X * (xy2 + wz2)) + (vector.Y * (T.One - xx2 - zz2)));
        }

        /// <summary>Transforms the given vector by the specified Quaternion.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Quaternion<T> quaternion)
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
                (vector.X * (xy2 + wz2)) + (vector.Y * (T.One - xx2 - zz2)));
        }

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix2X2<T> matrix)
            where T : INumberBase<T>
            => vector * matrix;

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix2X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix2X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix3X2<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M31, 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M32);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix3X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M31, 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M32);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix3X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M31, 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M32);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix4X2<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M41, 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M42);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix4X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M41, 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M42);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix4X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M41, 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M42);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> Transform<T>(Vector2D<T> vector, Matrix5X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21) + matrix.M51, 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22) + matrix.M52);

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix2X2<T> matrix)
            where T : INumberBase<T>
            => vector * matrix;

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix2X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix2X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix3X2<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix3X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix3X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix4X2<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix4X3<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix4X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));

        /// <summary>Transforms the given vector by the specified transformation Matrix.</summary>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> vector, Matrix5X4<T> matrix)
            where T : INumberBase<T>
            => new(
                (vector.X * matrix.M11) + (vector.Y * matrix.M21), 
                (vector.X * matrix.M12) + (vector.Y * matrix.M22));
    }
}
