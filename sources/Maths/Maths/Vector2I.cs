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
        /// <summary>Gets the squared length of the vector (dot product with itself).</summary>
        public T LengthSquared => (X * X) + (Y * Y);

        /// <summary> Computes the dot product of this vector with another vector. </summary>
        public T Dot(Vector2I<T> other) => (X * other.X) + (Y * other.Y);

        /// <summary> Computes the dot product of two vectors. </summary>
        public static T Dot(Vector2I<T> left, Vector2I<T> right) => (left.X * right.X) + (left.Y * right.Y);

        /// <summary> Computes the cross product of this vector with another vector. </summary>
        public T Cross(Vector2I<T> other) => (X * other.Y) - (Y * other.X);

        /// <summary> Computes the cross product of two vectors. </summary>
        public static T Cross(Vector2I<T> left, Vector2I<T> right) => (left.X * right.Y) - (left.Y * right.X);

        /// <summary>Returns a vector with the component-wise maximum of this and another vector.</summary>
        public Vector2I<T> Max(Vector2I<T> other) =>
            new Vector2I<T>(T.Max(X, other.X), T.Max(Y, other.Y));

        /// <summary>Returns a vector with the component-wise maximum of two vectors.</summary>
        public static Vector2I<T> Max(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(T.Max(left.X, right.X), T.Max(left.Y, right.Y));

        /// <summary>Returns a vector with the component-wise maximum of this vector and a scalar.</summary>
        public Vector2I<T> Max(T scalar) =>
            new Vector2I<T>(T.Max(X, scalar), T.Max(Y, scalar));

        /// <summary>Returns a vector with the component-wise maximum of a vector and a scalar.</summary>
        public static Vector2I<T> Max(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(T.Max(vector.X, scalar), T.Max(vector.Y, scalar));

        /// <summary>Returns a vector with the component-wise minimum of this and another vector.</summary>
        public Vector2I<T> Min(Vector2I<T> other) =>
            new Vector2I<T>(T.Min(X, other.X), T.Min(Y, other.Y));

        /// <summary>Returns a vector with the component-wise minimum of two vectors.</summary>
        public static Vector2I<T> Min(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(T.Min(left.X, right.X), T.Min(left.Y, right.Y));

        /// <summary>Returns a vector with the component-wise minimum of this vector and a scalar.</summary>
        public Vector2I<T> Min(T scalar) =>
            new Vector2I<T>(T.Min(X, scalar), T.Min(Y, scalar));

        /// <summary>Returns a vector with the component-wise minimum of a vector and a scalar.</summary>
        public static Vector2I<T> Min(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(T.Min(vector.X, scalar), T.Min(vector.Y, scalar));

        /// <summary>Clamps this vector's components between the corresponding Min and Max vectors.</summary>
        public Vector2I<T> Clamp(Vector2I<T> min, Vector2I<T> max) =>
            new Vector2I<T>(T.Clamp(X, min.X, max.X), T.Clamp(Y, min.Y, max.Y));

        /// <summary>Clamps the components of a vector between the corresponding Min and Max vectors.</summary>
        public static Vector2I<T> Clamp(Vector2I<T> vector, Vector2I<T> min, Vector2I<T> max) =>
            new Vector2I<T>(T.Clamp(vector.X, min.X, max.X), T.Clamp(vector.Y, min.Y, max.Y));

        /// <summary>Clamps this vector's components between the Min and Max scalar values.</summary>
        public Vector2I<T> Clamp(T min, T max) =>
            new Vector2I<T>(T.Clamp(X, min, max), T.Clamp(Y, min, max));

        /// <summary>Clamps the components of a vector between the Min and Max scalar values.</summary>
        public static Vector2I<T> Clamp(Vector2I<T> vector, T min, T max) =>
            new Vector2I<T>(T.Clamp(vector.X, min, max), T.Clamp(vector.Y, min, max));

        /// <summary>Returns a vector with the absolute value of each component of this vector.</summary>
        public Vector2I<T> Abs() => new Vector2I<T>(T.Abs(X), T.Abs(Y));

        /// <summary>Returns a vector with the absolute value of each component of the specified vector.</summary>
        public static Vector2I<T> Abs(Vector2I<T> vector) =>
            new Vector2I<T>(T.Abs(vector.X), T.Abs(vector.Y));

        /// <summary>Returns a vector where each component is the sign of the original vector's component.</summary>
        public Vector2I<T> Sign() => new Vector2I<T>(T.CreateChecked(T.Sign(X)), T.CreateChecked(T.Sign(Y)));

        /// <summary>Returns a vector where each component is the sign of the input vector's component.</summary>
        public static Vector2I<T> Sign(Vector2I<T> vector) =>
            new Vector2I<T>(T.CreateChecked(T.Sign(vector.X)), T.CreateChecked(T.Sign(vector.Y)));

        /// <summary>Copies the sign of each component from another vector to this vector's components.</summary>
        public Vector2I<T> CopySign(Vector2I<T> signSource) =>
            new Vector2I<T>(T.CopySign(X, signSource.X), T.CopySign(Y, signSource.Y));

        /// <summary>Copies the sign of each component from another vector to a new vector.</summary>
        public static Vector2I<T> CopySign(Vector2I<T> value, Vector2I<T> signSource) =>
            new Vector2I<T>(T.CopySign(value.X, signSource.X), T.CopySign(value.Y, signSource.Y));

        /// <summary>Copies the sign of a scalar onto each component of this vector.</summary>
        public Vector2I<T> CopySign(T signScalar) =>
            new Vector2I<T>(T.CopySign(X, signScalar), T.CopySign(Y, signScalar));

        /// <summary>Copies the sign of a scalar onto each component of a new vector.</summary>
        public static Vector2I<T> CopySign(Vector2I<T> value, T signScalar) =>
            new Vector2I<T>(T.CopySign(value.X, signScalar), T.CopySign(value.Y, signScalar));

        // Casts

        /// <summary>Explicitly casts a <see cref="System.Numerics.Vector2"/> to a <see cref="Vector2I{T}"/>.</summary>
        public static explicit operator Vector2I<T>(System.Numerics.Vector2 v) =>
            new Vector2I<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector2I{T}"/> to <see cref="System.Numerics.Vector2"/>.</summary>
        public static explicit operator System.Numerics.Vector2(Vector2I<T> v) =>
            new System.Numerics.Vector2(Convert.ToSingle(v.X), Convert.ToSingle(v.Y));

        // IBinaryInteger
        // TODO: Verify these are actually correct

        public static Vector2I<T> Log2(Vector2I<T> x) =>
            new Vector2I<T>(T.Log2(x.X), T.Log2(x.Y));

        public static (Vector2I<T> Quotient, Vector2I<T> Remainder) DivRem(Vector2I<T> left, Vector2I<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            return (new Vector2I<T>(qX, qY), new Vector2I<T>(rX, rY));
        }

        public static Vector2I<T> PopCount(Vector2I<T> x) =>
            new Vector2I<T>(T.PopCount(x.X), T.PopCount(x.Y));
    }
}
