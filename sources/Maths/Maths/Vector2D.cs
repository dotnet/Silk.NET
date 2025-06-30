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
    public partial struct Vector2D<T>
    {
        /// <summary> Computes the cross product of this vector with another vector. </summary>
        public T Cross(Vector2D<T> other) => (X * other.Y) - (Y * other.X);

        /// <summary> Computes the cross product of two vectors. </summary>
        public static T Cross(Vector2D<T> left, Vector2D<T> right) => (left.X * right.Y) - (left.Y * right.X);

        // Casts

        /// <summary>Explicitly casts a <see cref="System.Numerics.Vector2"/> to a <see cref="Vector2D{T}"/>.</summary>
        public static explicit operator Vector2D<T>(System.Numerics.Vector2 v) =>
            new Vector2D<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector2D{T}"/> to <see cref="System.Numerics.Vector2"/>.</summary>
        public static explicit operator System.Numerics.Vector2(Vector2D<T> v) =>
            new System.Numerics.Vector2(Convert.ToSingle(v.X), Convert.ToSingle(v.Y));

        public static (Vector2D<T> Quotient, Vector2D<T> Remainder) DivRem(Vector2D<T> left, Vector2D<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            return (new Vector2D<T>(qX, qY), new Vector2D<T>(rX, rY));
        }

        /// <summary>Linearly interpolates between two vectors using a scalar t-value (clamped between 0 and 1).</summary>
        public static Vector2D<T> LerpClamped(Vector2D<T> a, Vector2D<T> b, T t) =>
            Vector2D.Lerp(a, b, T.Clamp(t, T.Zero, T.One));

        /// <summary>Linearly interpolates between two vectors using a vector t-value (clamped between 0 and 1).</summary>
        public static Vector2D<T> LerpClamped(Vector2D<T> a, Vector2D<T> b, Vector2D<T> t) =>
            new(
                a.X + (b.X - a.X) * T.Clamp(t.X, T.Zero, T.One),
                a.Y + (b.Y - a.Y) * T.Clamp(t.Y, T.Zero, T.One)
            );

        // IFloatingPointIeee754

        public static (Vector2D<T> Sin, Vector2D<T> Cos) SinCos(Vector2D<T> x) =>
            (new(T.Sin(x.X), T.Sin(x.Y)), new(T.Cos(x.X), T.Cos(x.Y)));

        public static (Vector2D<T> SinPi, Vector2D<T> CosPi) SinCosPi(Vector2D<T> x) =>
            (new(T.SinPi(x.X), T.SinPi(x.Y)), new(T.CosPi(x.X), T.CosPi(x.Y)));

        public static Vector2D<T> FusedMultiplyAdd(Vector2D<T> left, Vector2D<T> right, Vector2D<T> addend) =>
            new(T.FusedMultiplyAdd(left.X, right.X, addend.X), T.FusedMultiplyAdd(left.Y, right.Y, addend.Y));

        public static Vector2D<T> FusedMultiplyAdd(Vector2D<T> left, Vector2D<T> right, T addend) =>
            new(T.FusedMultiplyAdd(left.X, right.X, addend), T.FusedMultiplyAdd(left.Y, right.Y, addend));

        public static Vector2D<T> FusedMultiplyAdd(Vector2D<T> left, T right, Vector2D<T> addend) =>
            new(T.FusedMultiplyAdd(left.X, right, addend.X), T.FusedMultiplyAdd(left.Y, right, addend.Y));

        public static Vector2D<T> FusedMultiplyAdd(Vector2D<T> left, T right, T addend) =>
            new(T.FusedMultiplyAdd(left.X, right, addend), T.FusedMultiplyAdd(left.Y, right, addend));
    }

    public static partial class Vector2D
    {
        /// <summary> Computes the cross product of two vectors.</summary>
        public static T Cross<T>(this Vector2D<T> left, Vector2D<T> right)
            where T : IFloatingPointIeee754<T> => (left.X * right.Y) - (left.Y * right.X);
    }
}
