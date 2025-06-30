// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 2D integer vector.</summary>
    internal partial struct Vector2I<T>
    {
        /// <summary> Computes the cross product of this vector with another vector. </summary>
        public T Cross(Vector2I<T> other) => (X * other.Y) - (Y * other.X);

        /// <summary> Computes the cross product of two vectors. </summary>
        public static T Cross(Vector2I<T> left, Vector2I<T> right) => (left.X * right.Y) - (left.Y * right.X);

        // Casts

        /// <summary>Explicitly casts a <see cref="System.Numerics.Vector2"/> to a <see cref="Vector2I{T}"/>.</summary>
        public static explicit operator Vector2I<T>(System.Numerics.Vector2 v) =>
            new Vector2I<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector2I{T}"/> to <see cref="System.Numerics.Vector2"/>.</summary>
        public static explicit operator System.Numerics.Vector2(Vector2I<T> v) =>
            new System.Numerics.Vector2(Convert.ToSingle(v.X), Convert.ToSingle(v.Y));

        public static (Vector2I<T> Quotient, Vector2I<T> Remainder) DivRem(Vector2I<T> left, Vector2I<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            return (new Vector2I<T>(qX, qY), new Vector2I<T>(rX, rY));
        }
    }
}
