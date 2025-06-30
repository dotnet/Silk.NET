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
    public partial struct Vector3D<T>
    {
        /// <summary> Computes the cross product of this vector with another vector. </summary>
        public Vector3D<T> Cross(Vector3D<T> other) =>
            new Vector3D<T>(
                (Y * other.Z) - (Z * other.Y),
                (Z * other.X) - (X * other.Z),
                (X * other.Y) - (Y * other.X)
            );

        /// <summary> Computes the cross product of two vectors. </summary>
        public static Vector3D<T> Cross(Vector3D<T> left, Vector3D<T> right) =>
            new Vector3D<T>(
                (left.Y * right.Z) - (left.Z * right.Y),
                (left.Z * right.X) - (left.X * right.Z),
                (left.X * right.Y) - (left.Y * right.X)
            );

        // Casts

        /// <summary>Explicitly casts a <see cref="System.Numerics.Vector3"/> to a <see cref="Vector3D{T}"/>.</summary>
        public static explicit operator Vector3D<T>(System.Numerics.Vector3 v) =>
            new Vector3D<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)), (T)Convert.ChangeType(v.Z, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector3D{T}"/> to <see cref="System.Numerics.Vector3"/>.</summary>
        public static explicit operator System.Numerics.Vector3(Vector3D<T> v) =>
            new System.Numerics.Vector3(Convert.ToSingle(v.X), Convert.ToSingle(v.Y), Convert.ToSingle(v.Z));

        public static (Vector3D<T> Quotient, Vector3D<T> Remainder) DivRem(Vector3D<T> left, Vector3D<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            return (new Vector3D<T>(qX, qY, qZ), new Vector3D<T>(rX, rY, rZ));
        }
    }
}
