// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    public static partial class Vector2D
    {
        /// <summary>Computes the cross product of two vectors.</summary>
        public static T Cross<T>(Vector2D<T> left, Vector2D<T> right)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<float, T>(Vector2.Cross(
                    Unsafe.BitCast<Vector2D<T>, Vector2>(left),
                    Unsafe.BitCast<Vector2D<T>, Vector2>(right)
                ));
            }

            return (left.X * right.Y) - (left.Y * right.X);
        }
    }
}
