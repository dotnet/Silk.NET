// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    public partial struct Matrix3X3<T>
    {
        /// <summary>Calculates the determinant of the matrix.</summary>
        /// <returns>The determinant of the matrix.</returns>
        public readonly T GetDeterminant()
        {
            //   | a b c |
            //   | d e f | = ( a ( ei - fh ) - b ( di - fg ) + c ( dh - eg ) )
            //   | g h i |

            T a = Row1.X, b = Row1.Y, c = Row1.Z;
            T d = Row2.X, e = Row2.Y, f = Row2.Z;
            T g = Row3.X, h = Row3.Y, i = Row3.Z;

            return (a * ((e * i) - (f * h))) - (b * ((d * i) - (f * g))) + (c * ((d * h) - (e * g)));
        }
    }
}
