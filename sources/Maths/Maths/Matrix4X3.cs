// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    public partial struct Matrix4X3<T> :
        IEquatable<Matrix4X3<T>>
        where T : INumberBase<T>
    {
        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix4X3<T> Identity { get; } = new
        (
            T.One, T.Zero, T.Zero,
            T.Zero, T.One, T.Zero,
            T.Zero, T.Zero, T.One,
            T.Zero, T.Zero, T.Zero
        );

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Calculates the determinant of the matrix.</summary>
        /// <returns>The determinant of the matrix.</returns>
        public readonly T GetDeterminant()
        {
            // There isn't actually any such thing as a determinant for a non-square matrix,
            // but this 4x3 type is really just an optimization of a 4x4 where we happen to
            // know the rightmost column matches the identity.
            // It collapses into a 3x3 determinant.

            T a = Row1.X, b = Row1.Y, c = Row1.Z;
            T e = Row2.X, f = Row2.Y, g = Row2.Z;
            T i = Row3.X, j = Row3.Y, k = Row3.Z;

            return (a * ((f * k) - (g * j)))
                 - (b * ((e * k) - (g * i)))
                 + (c * ((e * j) - (f * i)));
        }
    }
}
