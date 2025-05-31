// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 4D integer vector.</summary>
    internal partial struct Vector4I<T>
    {
        /// <summary> Initializes the vector using a Vector2I for X and Y, and a separate value for Z and W. </summary>
        // TODO: Make sure lower dimensional constructors arent meant to zero-out the higher dimensions
        public Vector4I(Vector2I<T> xy, T z, T w) => (X, Y, Z, W) = (xy.X, xy.Y, z, w);

        /// <summary> Initializes the vector using a Vector3I for X, Y and Z, and a separate value for W. </summary>
        public Vector4I(Vector3I<T> xyz, T w) => (X, Y, Z, W) = (xyz.X, xyz.Y, xyz.Z, w);

        /// <summary>Gets the squared length of the vector (dot product with itself).</summary>
        public T LengthSquared => (X * X) + (Y * Y) + (Z * Z) + (W * W);

        /// <summary> Computes the dot product of this vector with another vector. </summary>
        public T Dot(Vector4I<T> other) => (X * other.X) + (Y * other.Y) + (Z * other.Z) + (W * other.W);

        /// <summary> Computes the dot product of two vectors. </summary>
        public static T Dot(Vector4I<T> left, Vector4I<T> right) => (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z) + (left.W * right.W);

        /// <summary>Returns a vector with the component-wise maximum of this and another vector.</summary>
        public Vector4I<T> Max(Vector4I<T> other) =>
            new Vector4I<T>(T.Max(X, other.X), T.Max(Y, other.Y), T.Max(Z, other.Z), T.Max(W, other.W));

        /// <summary>Returns a vector with the component-wise maximum of two vectors.</summary>
        public static Vector4I<T> Max(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(T.Max(left.X, right.X), T.Max(left.Y, right.Y), T.Max(left.Z, right.Z), T.Max(left.W, right.W));

        /// <summary>Returns a vector with the component-wise maximum of this vector and a scalar.</summary>
        public Vector4I<T> Max(T scalar) =>
            new Vector4I<T>(T.Max(X, scalar), T.Max(Y, scalar), T.Max(Z, scalar), T.Max(W, scalar));

        /// <summary>Returns a vector with the component-wise maximum of a vector and a scalar.</summary>
        public static Vector4I<T> Max(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(T.Max(vector.X, scalar), T.Max(vector.Y, scalar), T.Max(vector.Z, scalar), T.Max(vector.W, scalar));

        /// <summary>Returns a vector with the component-wise minimum of this and another vector.</summary>
        public Vector4I<T> Min(Vector4I<T> other) =>
            new Vector4I<T>(T.Min(X, other.X), T.Min(Y, other.Y), T.Min(Z, other.Z), T.Min(W, other.W));

        /// <summary>Returns a vector with the component-wise minimum of two vectors.</summary>
        public static Vector4I<T> Min(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(T.Min(left.X, right.X), T.Min(left.Y, right.Y), T.Min(left.Z, right.Z), T.Min(left.W, right.W));

        /// <summary>Returns a vector with the component-wise minimum of this vector and a scalar.</summary>
        public Vector4I<T> Min(T scalar) =>
            new Vector4I<T>(T.Min(X, scalar), T.Min(Y, scalar), T.Min(Z, scalar), T.Min(W, scalar));

        /// <summary>Returns a vector with the component-wise minimum of a vector and a scalar.</summary>
        public static Vector4I<T> Min(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(T.Min(vector.X, scalar), T.Min(vector.Y, scalar), T.Min(vector.Z, scalar), T.Min(vector.W, scalar));

        /// <summary>Clamps this vector's components between the corresponding Min and Max vectors.</summary>
        public Vector4I<T> Clamp(Vector4I<T> min, Vector4I<T> max) =>
            new Vector4I<T>(
                T.Clamp(X, min.X, max.X),
                T.Clamp(Y, min.Y, max.Y),
                T.Clamp(Z, min.Z, max.Z),
                T.Clamp(W, min.W, max.W)
            );

        /// <summary>Clamps the components of a vector between the corresponding Min and Max vectors.</summary>
        public static Vector4I<T> Clamp(Vector4I<T> vector, Vector4I<T> min, Vector4I<T> max) =>
            new Vector4I<T>(
                T.Clamp(vector.X, min.X, max.X),
                T.Clamp(vector.Y, min.Y, max.Y),
                T.Clamp(vector.Z, min.Z, max.Z),
                T.Clamp(vector.W, min.W, max.W)
            );

        /// <summary>Clamps this vector's components between the Min and Max scalar values.</summary>
        public Vector4I<T> Clamp(T min, T max) =>
            new Vector4I<T>(
                T.Clamp(X, min, max),
                T.Clamp(Y, min, max),
                T.Clamp(Z, min, max),
                T.Clamp(W, min, max)
            );

        /// <summary>Clamps the components of a vector between the Min and Max scalar values.</summary>
        public static Vector4I<T> Clamp(Vector4I<T> vector, T min, T max) =>
            new Vector4I<T>(
                T.Clamp(vector.X, min, max),
                T.Clamp(vector.Y, min, max),
                T.Clamp(vector.Z, min, max),
                T.Clamp(vector.W, min, max)
            );

        /// <summary>Returns a vector with the absolute value of each component of this vector.</summary>
        public Vector4I<T> Abs() => new Vector4I<T>(T.Abs(X), T.Abs(Y), T.Abs(Z), T.Abs(W));

        /// <summary>Returns a vector with the absolute value of each component of the specified vector.</summary>
        public static Vector4I<T> Abs(Vector4I<T> vector) =>
            new Vector4I<T>(T.Abs(vector.X), T.Abs(vector.Y), T.Abs(vector.Z), T.Abs(vector.W));

        /// <summary>Returns a vector where each component is the sign of the original vector's component.</summary>
        public Vector4I<T> Sign() =>
            new Vector4I<T>(T.CreateChecked(T.Sign(X)), T.CreateChecked(T.Sign(Y)), T.CreateChecked(T.Sign(Z)), T.CreateChecked(T.Sign(W)));

        /// <summary>Returns a vector where each component is the sign of the input vector's component.</summary>
        public static Vector4I<T> Sign(Vector4I<T> vector) =>
            new Vector4I<T>(T.CreateChecked(T.Sign(vector.X)), T.CreateChecked(T.Sign(vector.Y)), T.CreateChecked(T.Sign(vector.Z)), T.CreateChecked(T.Sign(vector.W)));

        /// <summary>Copies the sign of each component from another vector to this vector's components.</summary>
        public Vector4I<T> CopySign(Vector4I<T> signSource) =>
            new Vector4I<T>(T.CopySign(X, signSource.X), T.CopySign(Y, signSource.Y), T.CopySign(Z, signSource.Z), T.CopySign(W, signSource.W));

        /// <summary>Copies the sign of each component from another vector to a new vector.</summary>
        public static Vector4I<T> CopySign(Vector4I<T> value, Vector4I<T> signSource) =>
            new Vector4I<T>(T.CopySign(value.X, signSource.X), T.CopySign(value.Y, signSource.Y), T.CopySign(value.Z, signSource.Z), T.CopySign(value.W, signSource.W));

        /// <summary>Copies the sign of a scalar onto each component of this vector.</summary>
        public Vector4I<T> CopySign(T signScalar) =>
            new Vector4I<T>(T.CopySign(X, signScalar), T.CopySign(Y, signScalar), T.CopySign(Z, signScalar), T.CopySign(W, signScalar));

        /// <summary>Copies the sign of a scalar onto each component of a new vector.</summary>
        public static Vector4I<T> CopySign(Vector4I<T> value, T signScalar) =>
            new Vector4I<T>(T.CopySign(value.X, signScalar), T.CopySign(value.Y, signScalar), T.CopySign(value.Z, signScalar), T.CopySign(value.W, signScalar));

        // Casts

        /// <summary>Explicitly casts a System.Numerics.Vector4 to a Vector4I.</summary>
        public static explicit operator Vector4I<T>(System.Numerics.Vector4 v) =>
            new Vector4I<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)), (T)Convert.ChangeType(v.Z, typeof(T)), (T)Convert.ChangeType(v.W, typeof(T)));

        /// <summary>Explicitly casts a Vector4I to System.Numerics.Vector4.</summary>
        public static explicit operator System.Numerics.Vector4(Vector4I<T> v) =>
            new System.Numerics.Vector4(Convert.ToSingle(v.X), Convert.ToSingle(v.Y), Convert.ToSingle(v.Z), Convert.ToSingle(v.W));

        // IBinaryInteger
        public static Vector4I<T> Log2(Vector4I<T> x) =>
            new Vector4I<T>(T.Log2(x.X), T.Log2(x.Y), T.Log2(x.Z), T.Log2(x.W));

        public static (Vector4I<T> Quotient, Vector4I<T> Remainder) DivRem(Vector4I<T> left, Vector4I<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            var (qW, rW) = T.DivRem(left.W, right.W);
            return (new Vector4I<T>(qX, qY, qZ, qW), new Vector4I<T>(rX, rY, rZ, rW));
        }

        public static Vector4I<T> PopCount(Vector4I<T> x) =>
            new Vector4I<T>(T.PopCount(x.X), T.PopCount(x.Y), T.PopCount(x.Z), T.PopCount(x.W));
    }
}
