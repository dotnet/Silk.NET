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
    /// <summary>A structure representing a 3D integer vector.</summary>
    internal partial struct Vector3I<T>
    {
        /// <summary> Initializes the vector using a Vector2I for X and Y, and a separate value for Z. </summary>
        // TODO: Make sure lower dimensional constructors arent meant to zero-out the higher dimensions
        public Vector3I(Vector2I<T> xy, T z) => (X, Y, Z) = (xy.X, xy.Y, z);

        /// <summary>Gets the squared length of the vector (dot product with itself).</summary>
        public T LengthSquared => (X * X) + (Y * Y) + (Z * Z);

        /// <summary> Computes the dot product of this vector with another vector. </summary>
        public T Dot(Vector3I<T> other) => (X * other.X) + (Y * other.Y) + (Z * other.Z);

        /// <summary> Computes the dot product of two vectors. </summary>
        public static T Dot(Vector3I<T> left, Vector3I<T> right) => (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z);

        /// <summary> Computes the cross product of this vector with another vector. </summary>
        public Vector3I<T> Cross(Vector3I<T> other) =>
            new Vector3I<T>(
                (Y * other.Z) - (Z * other.Y),
                (Z * other.X) - (X * other.Z),
                (X * other.Y) - (Y * other.X)
            );

        /// <summary> Computes the cross product of two vectors. </summary>
        public static Vector3I<T> Cross(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(
                (left.Y * right.Z) - (left.Z * right.Y),
                (left.Z * right.X) - (left.X * right.Z),
                (left.X * right.Y) - (left.Y * right.X)
            );

        /// <summary>Returns a vector with the component-wise maximum of this and another vector.</summary>
        public Vector3I<T> Max(Vector3I<T> other) =>
            new Vector3I<T>(T.Max(X, other.X), T.Max(Y, other.Y), T.Max(Z, other.Z));

        /// <summary>Returns a vector with the component-wise maximum of two vectors.</summary>
        public static Vector3I<T> Max(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(T.Max(left.X, right.X), T.Max(left.Y, right.Y), T.Max(left.Z, right.Z));

        /// <summary>Returns a vector with the component-wise maximum of this vector and a scalar.</summary>
        public Vector3I<T> Max(T scalar) =>
            new Vector3I<T>(T.Max(X, scalar), T.Max(Y, scalar), T.Max(Z, scalar));

        /// <summary>Returns a vector with the component-wise maximum of a vector and a scalar.</summary>
        public static Vector3I<T> Max(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(T.Max(vector.X, scalar), T.Max(vector.Y, scalar), T.Max(vector.Z, scalar));

        /// <summary>Returns a vector with the component-wise minimum of this and another vector.</summary>
        public Vector3I<T> Min(Vector3I<T> other) =>
            new Vector3I<T>(T.Min(X, other.X), T.Min(Y, other.Y), T.Min(Z, other.Z));

        /// <summary>Returns a vector with the component-wise minimum of two vectors.</summary>
        public static Vector3I<T> Min(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(T.Min(left.X, right.X), T.Min(left.Y, right.Y), T.Min(left.Z, right.Z));

        /// <summary>Returns a vector with the component-wise minimum of this vector and a scalar.</summary>
        public Vector3I<T> Min(T scalar) =>
            new Vector3I<T>(T.Min(X, scalar), T.Min(Y, scalar), T.Min(Z, scalar));

        /// <summary>Returns a vector with the component-wise minimum of a vector and a scalar.</summary>
        public static Vector3I<T> Min(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(T.Min(vector.X, scalar), T.Min(vector.Y, scalar), T.Min(vector.Z, scalar));

        /// <summary>Clamps this vector's components between the corresponding Min and Max vectors.</summary>
        public Vector3I<T> Clamp(Vector3I<T> min, Vector3I<T> max) =>
            new Vector3I<T>(
                T.Clamp(X, min.X, max.X),
                T.Clamp(Y, min.Y, max.Y),
                T.Clamp(Z, min.Z, max.Z)
            );

        /// <summary>Clamps the components of a vector between the corresponding Min and Max vectors.</summary>
        public static Vector3I<T> Clamp(Vector3I<T> vector, Vector3I<T> min, Vector3I<T> max) =>
            new Vector3I<T>(
                T.Clamp(vector.X, min.X, max.X),
                T.Clamp(vector.Y, min.Y, max.Y),
                T.Clamp(vector.Z, min.Z, max.Z)
            );

        /// <summary>Clamps this vector's components between the Min and Max scalar values.</summary>
        public Vector3I<T> Clamp(T min, T max) =>
            new Vector3I<T>(
                T.Clamp(X, min, max),
                T.Clamp(Y, min, max),
                T.Clamp(Z, min, max)
            );

        /// <summary>Clamps the components of a vector between the Min and Max scalar values.</summary>
        public static Vector3I<T> Clamp(Vector3I<T> vector, T min, T max) =>
            new Vector3I<T>(
                T.Clamp(vector.X, min, max),
                T.Clamp(vector.Y, min, max),
                T.Clamp(vector.Z, min, max)
            );

        /// <summary>Returns a vector with the absolute value of each component of this vector.</summary>
        public Vector3I<T> Abs() => new Vector3I<T>(T.Abs(X), T.Abs(Y), T.Abs(Z));

        /// <summary>Returns a vector with the absolute value of each component of the specified vector.</summary>
        public static Vector3I<T> Abs(Vector3I<T> vector) =>
            new Vector3I<T>(T.Abs(vector.X), T.Abs(vector.Y), T.Abs(vector.Z));

        /// <summary>Returns a vector where each component is the sign of the original vector's component.</summary>
        public Vector3I<T> Sign() =>
            new Vector3I<T>(T.CreateChecked(T.Sign(X)), T.CreateChecked(T.Sign(Y)), T.CreateChecked(T.Sign(Z)));

        /// <summary>Returns a vector where each component is the sign of the input vector's component.</summary>
        public static Vector3I<T> Sign(Vector3I<T> vector) =>
            new Vector3I<T>(T.CreateChecked(T.Sign(vector.X)), T.CreateChecked(T.Sign(vector.Y)), T.CreateChecked(T.Sign(vector.Z)));

        /// <summary>Copies the sign of each component from another vector to this vector's components.</summary>
        public Vector3I<T> CopySign(Vector3I<T> signSource) =>
            new Vector3I<T>(T.CopySign(X, signSource.X), T.CopySign(Y, signSource.Y), T.CopySign(Z, signSource.Z));

        /// <summary>Copies the sign of each component from another vector to a new vector.</summary>
        public static Vector3I<T> CopySign(Vector3I<T> value, Vector3I<T> signSource) =>
            new Vector3I<T>(T.CopySign(value.X, signSource.X), T.CopySign(value.Y, signSource.Y), T.CopySign(value.Z, signSource.Z));

        /// <summary>Copies the sign of a scalar onto each component of this vector.</summary>
        public Vector3I<T> CopySign(T signScalar) =>
            new Vector3I<T>(T.CopySign(X, signScalar), T.CopySign(Y, signScalar), T.CopySign(Z, signScalar));

        /// <summary>Copies the sign of a scalar onto each component of a new vector.</summary>
        public static Vector3I<T> CopySign(Vector3I<T> value, T signScalar) =>
            new Vector3I<T>(T.CopySign(value.X, signScalar), T.CopySign(value.Y, signScalar), T.CopySign(value.Z, signScalar));

        // Casts

        /// <summary>Explicitly casts a <see cref="System.Numerics.Vector3"/> to a <see cref="Vector3I{T}"/>.</summary>
        public static explicit operator Vector3I<T>(System.Numerics.Vector3 v) =>
            new Vector3I<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)), (T)Convert.ChangeType(v.Z, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector3I{T}"/> to <see cref="System.Numerics.Vector3"/>.</summary>
        public static explicit operator System.Numerics.Vector3(Vector3I<T> v) =>
            new System.Numerics.Vector3(Convert.ToSingle(v.X), Convert.ToSingle(v.Y), Convert.ToSingle(v.Z));

        // IBinaryInteger
        public static Vector3I<T> Log2(Vector3I<T> x) =>
            new Vector3I<T>(T.Log2(x.X), T.Log2(x.Y), T.Log2(x.Z));

        public static (Vector3I<T> Quotient, Vector3I<T> Remainder) DivRem(Vector3I<T> left, Vector3I<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            return (new Vector3I<T>(qX, qY, qZ), new Vector3I<T>(rX, rY, rZ));
        }

        public static Vector3I<T> PopCount(Vector3I<T> x) =>
            new Vector3I<T>(T.PopCount(x.X), T.PopCount(x.Y), T.PopCount(x.Z));
    }
}
