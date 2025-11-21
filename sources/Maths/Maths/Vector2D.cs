// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 2D integer vector.</summary>
    public partial struct Vector2D<T>
    {
        /// <summary>Explicitly casts a <see cref="Vector2"/> to a <see cref="Vector2D{T}"/>.</summary>
        public static explicit operator Vector2D<T>(Vector2 v) =>
            new Vector2D<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector2D{T}"/> to <see cref="Vector2"/>.</summary>
        public static explicit operator Vector2(Vector2D<T> v) =>
            new Vector2(Convert.ToSingle(v.X), Convert.ToSingle(v.Y));
    }

    public static partial class Vector2D
    {
        /// <summary> Computes the cross product of two vectors.</summary>
        public static T Cross<T>(this Vector2D<T> left, Vector2D<T> right)
            where T : INumberBase<T> =>
            (left.X * right.Y) - (left.Y * right.X);
    }
}
