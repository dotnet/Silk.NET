// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix2X3{T}"/>
    /// </summary>
    public static partial class Matrix2X2
    {
        /// <summary>Attempts to calculate the inverse of the given matrix. If successful, result will contain the inverted matrix.</summary>
        /// <param name="matrix">The source matrix to invert.</param>
        /// <param name="result">If successful, contains the inverted matrix.</param>
        /// <returns><c>true</c> if the source matrix could be inverted; <c>false</c> otherwise.</returns>
        ///
        [MethodImpl((MethodImplOptions)768)]
        public static bool Invert<T>(Matrix2X2<T> matrix, out Matrix2X2<T> result)
            where T : IFloatingPointIeee754<T>
        {
            T a = matrix.M11, b = matrix.M12;
            T c = matrix.M21, d = matrix.M22;

            T det = (a * d) - (b * c);

            if (!(T.Abs(det) >= T.Epsilon))
            {
                result = default;
                return false;
            }

            T invDet = T.One / det;

            result = default;

            result.M11 = d * invDet;
            result.M21 = -(c * invDet);

            result.M12 = -(b * invDet);
            result.M22 = a * invDet;

            return true;
        }
    }
}
