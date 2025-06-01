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
        /// <summary>Returns a vector with the component-wise maximum of this and another vector.</summary>
        public Vector2F<T> Max(Vector2F<T> other) =>
            new(T.Max(X, other.X), T.Max(Y, other.Y));

        /// <summary>Returns a vector with the component-wise maximum of two vectors.</summary>
        public static Vector2F<T> Max(Vector2F<T> left, Vector2F<T> right) =>
            new(T.Max(left.X, right.X), T.Max(left.Y, right.Y));

        /// <summary>Returns a vector with the component-wise maximum of this vector and a scalar.</summary>
        public Vector2F<T> Max(T scalar) =>
            new(T.Max(X, scalar), T.Max(Y, scalar));

        /// <summary>Returns a vector with the component-wise maximum of a vector and a scalar.</summary>
        public static Vector2F<T> Max(Vector2F<T> vector, T scalar) =>
            new(T.Max(vector.X, scalar), T.Max(vector.Y, scalar));

        /// <summary>Returns a vector with the component-wise minimum of this and another vector.</summary>
        public Vector2F<T> Min(Vector2F<T> other) =>
            new(T.Min(X, other.X), T.Min(Y, other.Y));

        /// <summary>Returns a vector with the component-wise minimum of two vectors.</summary>
        public static Vector2F<T> Min(Vector2F<T> left, Vector2F<T> right) =>
            new(T.Min(left.X, right.X), T.Min(left.Y, right.Y));

        /// <summary>Returns a vector with the component-wise minimum of this vector and a scalar.</summary>
        public Vector2F<T> Min(T scalar) =>
            new(T.Min(X, scalar), T.Min(Y, scalar));

        /// <summary>Returns a vector with the component-wise minimum of a vector and a scalar.</summary>
        public static Vector2F<T> Min(Vector2F<T> vector, T scalar) =>
            new(T.Min(vector.X, scalar), T.Min(vector.Y, scalar));

        /// <summary>Clamps this vector's components between the corresponding Min and Max vectors.</summary>
        public Vector2F<T> Clamp(Vector2F<T> min, Vector2F<T> max) =>
            new(T.Clamp(X, min.X, max.X), T.Clamp(Y, min.Y, max.Y));

        /// <summary>Clamps the components of a vector between the corresponding Min and Max vectors.</summary>
        public static Vector2F<T> Clamp(Vector2F<T> vector, Vector2F<T> min, Vector2F<T> max) =>
            new(T.Clamp(vector.X, min.X, max.X), T.Clamp(vector.Y, min.Y, max.Y));

        /// <summary>Clamps this vector's components between the Min and Max scalar values.</summary>
        public Vector2F<T> Clamp(T min, T max) =>
            new(T.Clamp(X, min, max), T.Clamp(Y, min, max));

        /// <summary>Clamps the components of a vector between the Min and Max scalar values.</summary>
        public static Vector2F<T> Clamp(Vector2F<T> vector, T min, T max) =>
            new(T.Clamp(vector.X, min, max), T.Clamp(vector.Y, min, max));

        /// <summary>Returns a vector with the absolute value of each component of this vector.</summary>
        public Vector2F<T> Abs() => new(T.Abs(X), T.Abs(Y));

        /// <summary>Returns a vector with the absolute value of each component of the specified vector.</summary>
        public static Vector2F<T> Abs(Vector2F<T> vector) =>
            new(T.Abs(vector.X), T.Abs(vector.Y));

        /// <summary>Linearly interpolates between two vectors using a scalar t-value.</summary>
        public static Vector2F<T> Lerp(Vector2F<T> a, Vector2F<T> b, T t) =>
            new(a.X + (b.X - a.X) * t, a.Y + (b.Y - a.Y) * t);

        /// <summary>Linearly interpolates between two vectors using a vector t-value.</summary>
        public static Vector2F<T> Lerp(Vector2F<T> a, Vector2F<T> b, Vector2F<T> t) =>
            new(a.X + (b.X - a.X) * t.X, a.Y + (b.Y - a.Y) * t.Y);

        /// <summary>Linearly interpolates between two vectors using a scalar t-value (clamped between 0 and 1).</summary>
        public static Vector2F<T> LerpClamped(Vector2F<T> a, Vector2F<T> b, T t) =>
            Lerp(a, b, T.Clamp(t, T.Zero, T.One));

        /// <summary>Linearly interpolates between two vectors using a vector t-value (clamped between 0 and 1).</summary>
        public static Vector2F<T> LerpClamped(Vector2F<T> a, Vector2F<T> b, Vector2F<T> t) =>
            new(
                a.X + (b.X - a.X) * T.Clamp(t.X, T.Zero, T.One),
                a.Y + (b.Y - a.Y) * T.Clamp(t.Y, T.Zero, T.One)
            );

        /// <summary>Returns a vector where each component is the sign of the original vector's component.</summary>
        public Vector2F<T> Sign() => new(T.CreateChecked(T.Sign(X)), T.CreateChecked(T.Sign(Y)));

        /// <summary>Returns a vector where each component is the sign of the input vector's component.</summary>
        public static Vector2F<T> Sign(Vector2F<T> vector) =>
            new(T.CreateChecked(T.Sign(vector.X)), T.CreateChecked(T.Sign(vector.Y)));

        /// <summary>Copies the sign of each component from another vector to this vector's components.</summary>
        public Vector2F<T> CopySign(Vector2F<T> signSource) =>
            new(T.CopySign(X, signSource.X), T.CopySign(Y, signSource.Y));

        /// <summary>Copies the sign of each component from another vector to a new vector.</summary>
        public static Vector2F<T> CopySign(Vector2F<T> value, Vector2F<T> signSource) =>
            new(T.CopySign(value.X, signSource.X), T.CopySign(value.Y, signSource.Y));

        /// <summary>Copies the sign of a scalar onto each component of this vector.</summary>
        public Vector2F<T> CopySign(T signScalar) =>
            new(T.CopySign(X, signScalar), T.CopySign(Y, signScalar));

        /// <summary>Copies the sign of a scalar onto each component of a new vector.</summary>
        public static Vector2F<T> CopySign(Vector2F<T> value, T signScalar) =>
            new(T.CopySign(value.X, signScalar), T.CopySign(value.Y, signScalar));

        // Casts

        /// <summary>Explicitly casts a <see cref="System.Numerics.Vector2"/> to a <see cref="Vector2F{T}"/>.</summary>
        public static explicit operator Vector2F<T>(System.Numerics.Vector2 v) =>
            new((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector2F{T}"/> to <see cref="System.Numerics.Vector2"/>.</summary>
        public static explicit operator System.Numerics.Vector2(Vector2F<T> v) =>
            new(Convert.ToSingle(v.X), Convert.ToSingle(v.Y));

        // IFloatingPointIeee754
        public static Vector2F<T> Sqrt(Vector2F<T> x) =>
            new(T.Sqrt(x.X), T.Sqrt(x.Y));

        public static Vector2F<T> Acosh(Vector2F<T> x) =>
            new(T.Acosh(x.X), T.Acosh(x.Y));

        public static Vector2F<T> Asinh(Vector2F<T> x) =>
            new(T.Asinh(x.X), T.Asinh(x.Y));

        public static Vector2F<T> Atanh(Vector2F<T> x) =>
            new(T.Atanh(x.X), T.Atanh(x.Y));

        public static Vector2F<T> Cosh(Vector2F<T> x) =>
            new(T.Cosh(x.X), T.Cosh(x.Y));

        public static Vector2F<T> Sinh(Vector2F<T> x) =>
            new(T.Sinh(x.X), T.Sinh(x.Y));

        public static Vector2F<T> Tanh(Vector2F<T> x) =>
            new(T.Tanh(x.X), T.Tanh(x.Y));

        public static Vector2F<T> Acos(Vector2F<T> x) =>
            new(T.Acos(x.X), T.Acos(x.Y));

        public static Vector2F<T> AcosPi(Vector2F<T> x) =>
            new(T.AcosPi(x.X), T.AcosPi(x.Y));

        public static Vector2F<T> Asin(Vector2F<T> x) =>
            new(T.Asin(x.X), T.Asin(x.Y));

        public static Vector2F<T> AsinPi(Vector2F<T> x) =>
            new(T.AsinPi(x.X), T.AsinPi(x.Y));

        public static Vector2F<T> Atan(Vector2F<T> x) =>
            new(T.Atan(x.X), T.Atan(x.Y));

        public static Vector2F<T> AtanPi(Vector2F<T> x) =>
            new(T.AtanPi(x.X), T.AtanPi(x.Y));

        public static Vector2F<T> Cos(Vector2F<T> x) =>
            new(T.Cos(x.X), T.Cos(x.Y));

        public static Vector2F<T> CosPi(Vector2F<T> x) =>
            new(T.CosPi(x.X), T.CosPi(x.Y));

        public static Vector2F<T> Sin(Vector2F<T> x) =>
            new(T.Sin(x.X), T.Sin(x.Y));

        public static Vector2F<T> SinPi(Vector2F<T> x) =>
            new(T.SinPi(x.X), T.SinPi(x.Y));

        public static Vector2F<T> Tan(Vector2F<T> x) =>
            new(T.Tan(x.X), T.Tan(x.Y));

        public static Vector2F<T> TanPi(Vector2F<T> x) =>
            new(T.TanPi(x.X), T.TanPi(x.Y));

        public static Vector2F<T> DegreesToRadians(Vector2F<T> degrees) =>
            new(T.DegreesToRadians(degrees.X), T.DegreesToRadians(degrees.Y));

        public static Vector2F<T> RadiansToDegrees(Vector2F<T> radians) =>
            new(T.RadiansToDegrees(radians.X), T.RadiansToDegrees(radians.Y));

        public static (Vector2F<T> Sin, Vector2F<T> Cos) SinCos(Vector2F<T> x) =>
            (new(T.Sin(x.X), T.Sin(x.Y)), new(T.Cos(x.X), T.Cos(x.Y)));

        public static (Vector2F<T> SinPi, Vector2F<T> CosPi) SinCosPi(Vector2F<T> x) =>
            (new(T.SinPi(x.X), T.SinPi(x.Y)), new(T.CosPi(x.X), T.CosPi(x.Y)));

        public static Vector2F<T> Log(Vector2F<T> x) =>
            new(T.Log(x.X), T.Log(x.Y));

        public static Vector2F<T> Log(Vector2F<T> x, Vector2F<T> newBase) =>
            new(T.Log(x.X, newBase.X), T.Log(x.Y, newBase.Y));

        public static Vector2F<T> Log(Vector2F<T> x, T newBase) =>
            new(T.Log(x.X, newBase), T.Log(x.Y, newBase));

        public static Vector2F<T> LogP1(Vector2F<T> x) =>
            new(T.LogP1(x.X), T.LogP1(x.Y));

        // TODO: Static Log2

        public static Vector2F<T> Log2P1(Vector2F<T> x) =>
            new(T.Log2P1(x.X), T.Log2P1(x.Y));

        public static Vector2F<T> Log10(Vector2F<T> x) =>
            new(T.Log10(x.X), T.Log10(x.Y));

        public static Vector2F<T> Log10P1(Vector2F<T> x) =>
            new(T.Log10P1(x.X), T.Log10P1(x.Y));

        public static Vector2F<T> Exp(Vector2F<T> x) =>
            new(T.Exp(x.X), T.Exp(x.Y));

        public static Vector2F<T> ExpM1(Vector2F<T> x) =>
            new(T.ExpM1(x.X), T.ExpM1(x.Y));

        public static Vector2F<T> Exp2(Vector2F<T> x) =>
            new(T.Exp2(x.X), T.Exp2(x.Y));

        public static Vector2F<T> Exp2M1(Vector2F<T> x) =>
            new(T.Exp2M1(x.X), T.Exp2M1(x.Y));

        public static Vector2F<T> Exp10(Vector2F<T> x) =>
            new(T.Exp10(x.X), T.Exp10(x.Y));

        public static Vector2F<T> Exp10M1(Vector2F<T> x) =>
            new(T.Exp10M1(x.X), T.Exp10M1(x.Y));

        public static Vector2F<T> Pow(Vector2F<T> x, Vector2F<T> y) =>
            new(T.Pow(x.X, y.X), T.Pow(x.Y, y.Y));

        public static Vector2F<T> Pow(Vector2F<T> x, T y) =>
            new(T.Pow(x.X, y), T.Pow(x.Y, y));

        public static Vector2F<T> Cbrt(Vector2F<T> x) =>
            new(T.Cbrt(x.X), T.Cbrt(x.Y));

        public static Vector2F<T> Hypot(Vector2F<T> x, Vector2F<T> y) =>
            new(T.Hypot(x.X, y.X), T.Hypot(x.Y, y.Y));

        public static Vector2F<T> Hypot(Vector2F<T> x, T y) =>
            new(T.Hypot(x.X, y), T.Hypot(x.Y, y));

        public static Vector2F<T> RootN(Vector2F<T> x, int n) =>
            new(T.RootN(x.X, n), T.RootN(x.Y, n));

        public static Vector2F<T> Round(Vector2F<T> x) =>
            new(T.Round(x.X), T.Round(x.Y));

        public static Vector2F<T> Round(Vector2F<T> x, int digits) =>
            new(T.Round(x.X, digits), T.Round(x.Y, digits));

        public static Vector2F<T> Round(Vector2F<T> x, MidpointRounding mode) =>
            new(T.Round(x.X, mode), T.Round(x.Y, mode));

        public static Vector2F<T> Round(Vector2F<T> x, int digits, MidpointRounding mode) =>
            new(T.Round(x.X, digits, mode), T.Round(x.Y, digits, mode));

        public static Vector2F<T> Truncate(Vector2F<T> x) =>
            new(T.Truncate(x.X), T.Truncate(x.Y));

        public static Vector2F<T> Atan2(Vector2F<T> y, Vector2F<T> x) =>
            new(T.Atan2(y.X, x.X), T.Atan2(y.Y, x.Y));

        public static Vector2F<T> Atan2Pi(Vector2F<T> y, Vector2F<T> x) =>
            new(T.Atan2Pi(y.X, x.X), T.Atan2Pi(y.Y, x.Y));

        public static Vector2F<T> Atan2(Vector2F<T> y, T x) =>
            new(T.Atan2(y.X, x), T.Atan2(y.Y, x));

        public static Vector2F<T> Atan2Pi(Vector2F<T> y, T x) =>
            new(T.Atan2Pi(y.X, x), T.Atan2Pi(y.Y, x));

        public static Vector2F<T> BitDecrement(Vector2F<T> x) =>
            new(T.BitDecrement(x.X), T.BitDecrement(x.Y));

        public static Vector2F<T> BitIncrement(Vector2F<T> x) =>
            new(T.BitIncrement(x.X), T.BitIncrement(x.Y));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, Vector2F<T> right, Vector2F<T> addend) =>
            new(T.FusedMultiplyAdd(left.X, right.X, addend.X), T.FusedMultiplyAdd(left.Y, right.Y, addend.Y));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, Vector2F<T> right, T addend) =>
            new(T.FusedMultiplyAdd(left.X, right.X, addend), T.FusedMultiplyAdd(left.Y, right.Y, addend));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, T right, Vector2F<T> addend) =>
            new(T.FusedMultiplyAdd(left.X, right, addend.X), T.FusedMultiplyAdd(left.Y, right, addend.Y));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, T right, T addend) =>
            new(T.FusedMultiplyAdd(left.X, right, addend), T.FusedMultiplyAdd(left.Y, right, addend));

        public static Vector2F<T> ReciprocalEstimate(Vector2F<T> x) =>
            new(T.ReciprocalEstimate(x.X), T.ReciprocalEstimate(x.Y));

        public static Vector2F<T> ReciprocalSqrtEstimate(Vector2F<T> x) =>
            new(T.ReciprocalSqrtEstimate(x.X), T.ReciprocalSqrtEstimate(x.Y));

        public static Vector2I<int> ILogB(Vector2F<T> x) =>
            new(T.ILogB(x.X), T.ILogB(x.Y));

        public static Vector2F<T> ScaleB(Vector2F<T> x, Vector2I<int> n) =>
            new(T.ScaleB(x.X, n.X), T.ScaleB(x.Y, n.Y));

        public static Vector2F<T> ScaleB(Vector2F<T> x, int n) =>
            new(T.ScaleB(x.X, n), T.ScaleB(x.Y, n));
    }

    static partial class Vector2F
    {
        /// <summary> Computes the cross product of two vectors.</summary>
        public static T Cross<T>(this Vector2F<T> left, Vector2F<T> right)
            where T : IFloatingPointIeee754<T> => (left.X * right.Y) - (left.Y * right.X);
    }
}
