// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 2D floating-point vector.</summary>
    internal partial struct Vector2F<T>
    {
        /// <summary>Linearly interpolates between two vectors using a scalar t-value (clamped between 0 and 1).</summary>
        public static Vector2F<T> LerpClamped(Vector2F<T> a, Vector2F<T> b, T t) =>
            Vector2F.Lerp(a, b, T.Clamp(t, T.Zero, T.One));

        /// <summary>Linearly interpolates between two vectors using a vector t-value (clamped between 0 and 1).</summary>
        public static Vector2F<T> LerpClamped(Vector2F<T> a, Vector2F<T> b, Vector2F<T> t) =>
            new(
                a.X + (b.X - a.X) * T.Clamp(t.X, T.Zero, T.One),
                a.Y + (b.Y - a.Y) * T.Clamp(t.Y, T.Zero, T.One)
            );

        // Casts

        /// <summary>Explicitly casts a <see cref="System.Numerics.Vector2"/> to a <see cref="Vector2F{T}"/>.</summary>
        public static explicit operator Vector2F<T>(System.Numerics.Vector2 v) =>
            new((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector2F{T}"/> to <see cref="System.Numerics.Vector2"/>.</summary>
        public static explicit operator System.Numerics.Vector2(Vector2F<T> v) =>
            new(Convert.ToSingle(v.X), Convert.ToSingle(v.Y));

        // IFloatingPointIeee754

        public static (Vector2F<T> Sin, Vector2F<T> Cos) SinCos(Vector2F<T> x) =>
            (new(T.Sin(x.X), T.Sin(x.Y)), new(T.Cos(x.X), T.Cos(x.Y)));

        public static (Vector2F<T> SinPi, Vector2F<T> CosPi) SinCosPi(Vector2F<T> x) =>
            (new(T.SinPi(x.X), T.SinPi(x.Y)), new(T.CosPi(x.X), T.CosPi(x.Y)));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, Vector2F<T> right, Vector2F<T> addend) =>
            new(T.FusedMultiplyAdd(left.X, right.X, addend.X), T.FusedMultiplyAdd(left.Y, right.Y, addend.Y));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, Vector2F<T> right, T addend) =>
            new(T.FusedMultiplyAdd(left.X, right.X, addend), T.FusedMultiplyAdd(left.Y, right.Y, addend));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, T right, Vector2F<T> addend) =>
            new(T.FusedMultiplyAdd(left.X, right, addend.X), T.FusedMultiplyAdd(left.Y, right, addend.Y));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, T right, T addend) =>
            new(T.FusedMultiplyAdd(left.X, right, addend), T.FusedMultiplyAdd(left.Y, right, addend));
    }

    static partial class Vector2F
    {
        /// <summary> Computes the cross product of two vectors.</summary>
        public static T Cross<T>(this Vector2F<T> left, Vector2F<T> right)
            where T : IFloatingPointIeee754<T> => (left.X * right.Y) - (left.Y * right.X);
    }
}
