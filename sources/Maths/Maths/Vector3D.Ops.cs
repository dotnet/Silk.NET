// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    public static partial class Vector3D
    {
        /// <summary> Computes the cross product of two vectors. </summary>
        public static Vector3D<T> Cross<T>(Vector3D<T> left, Vector3D<T> right)
            where T : INumberBase<T> =>
            new Vector3D<T>(
                (left.Y * right.Z) - (left.Z * right.Y),
                (left.Z * right.X) - (left.X * right.Z),
                (left.X * right.Y) - (left.Y * right.X));
    }
}
