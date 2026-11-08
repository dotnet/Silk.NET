// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    public partial struct Matrix2X2<T>
    {
        /// <summary>Calculates the determinant of the matrix.</summary>
        /// <returns>The determinant of the matrix.</returns>
        public readonly T GetDeterminant()
        {
            //   | a b |
            //   | c d | = ad - bc

            T a = Row1.X, b = Row1.Y;
            T d = Row2.X, c = Row1.Y;

            return (a * d) - (b * c);
        }
    }
}
