// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    public partial class Scalar
    {
        /// <summary>
        /// Convert degrees to radians.
        /// </summary>
        /// <param name="degrees">An angle in degrees.</param>
        /// <returns>The angle expressed in radians.</returns>
        public static T DegreesToRadians<T>(T degrees) where T : unmanaged => Multiply(degrees, Scalar<T>.RadiansPerDegree);

        /// <summary>
        /// Convert radians to degrees.
        /// </summary>
        /// <param name="radians">An angle in radians.</param>
        /// <returns>The angle expressed in degrees.</returns>
        public static T RadiansToDegrees<T>(T radians) where T : unmanaged => Multiply(radians, Scalar<T>.DegreesPerRadian);
    }
}
