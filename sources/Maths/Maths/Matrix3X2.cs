// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    public partial struct Matrix3X2<T>
    {
        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix3X2<T> Identity { get; } = new(
            T.One, T.Zero,
            T.Zero, T.One,
            T.Zero, T.Zero
        );

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Calculates the determinant for this matrix.
        /// The determinant is calculated by expanding the matrix with a third column whose values are (0,0,1).</summary>
        /// <returns>The determinant.</returns>
        public readonly T GetDeterminant()
        {
            // There isn't actually any such thing as a determinant for a non-square matrix,
            // but this 3x2 type is really just an optimization of a 3x3 where we happen to
            // know the rightmost column is always (0, 0, 1). So we expand to 3x3 format:
            //
            //  [ M11, M12, 0 ]
            //  [ M21, M22, 0 ]
            //  [ M31, M32, 1 ]
            //
            // Sum the diagonal products:
            //  (M11 * M22 * 1) + (M12 * 0 * M31) + (0 * M21 * M32)
            //
            // Subtract the opposite diagonal products:
            //  (M31 * M22 * 0) + (M32 * 0 * M11) + (1 * M21 * M12)
            //
            // Collapse out the constants and oh look, this is just a 2x2 determinant!

            return (Row1.X * Row2.Y) - (Row2.X * Row1.Y);
        }
    }
}
