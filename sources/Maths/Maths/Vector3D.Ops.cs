// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    public static partial class Vector3D
    {
        /// <summary>Computes the cross product of two vectors.</summary>
        public static Vector3D<T> Cross<T>(Vector3D<T> left, Vector3D<T> right)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Vector3, Vector3D<T>>(Vector3.Cross(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(left),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(right)
                ));
            }

            return new Vector3D<T>(
                (left.Y * right.Z) - (left.Z * right.Y),
                (left.Z * right.X) - (left.X * right.Z),
                (left.X * right.Y) - (left.Y * right.X));
        }
    }
}
