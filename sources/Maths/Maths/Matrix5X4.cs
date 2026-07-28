// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    public partial struct Matrix5X4<T>
    {
        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix5X4<T> Identity { get; } = new
        (
            T.One, T.Zero, T.Zero, T.Zero,
            T.Zero, T.One, T.Zero, T.Zero,
            T.Zero, T.Zero, T.One, T.Zero,
            T.Zero, T.Zero, T.Zero, T.One,
            T.Zero, T.Zero, T.Zero, T.Zero
        );

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="left">The vector.</param>
        /// <param name="right">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Vector4D<T> operator *(Vector4D<T> left, Matrix5X4<T> right) =>
            (left.X * right.Row1) +
            (left.Y * right.Row2) +
            (left.Z * right.Row3) +
            (left.W * right.Row4) +
            right.Row5;
    }
}
