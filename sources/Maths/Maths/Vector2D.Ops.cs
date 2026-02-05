// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    public static partial class Vector2D
    {
        /// <summary>Computes the cross product of two vectors.</summary>
        public static T Cross<T>(this Vector2D<T> left, Vector2D<T> right)
            where T : INumberBase<T> =>
            (left.X * right.Y) - (left.Y * right.X);
    }
}
