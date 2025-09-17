// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 3D integer vector.</summary>
    public partial struct Vector3D<T>
    {
        /// <summary>Explicitly casts a <see cref="Vector3"/> to a <see cref="Vector3D{T}"/>.</summary>
        public static explicit operator Vector3D<T>(Vector3 v) =>
            new Vector3D<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)), (T)Convert.ChangeType(v.Z, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector3D{T}"/> to <see cref="Vector3"/>.</summary>
        public static explicit operator Vector3(Vector3D<T> v) =>
            new Vector3(Convert.ToSingle(v.X), Convert.ToSingle(v.Y), Convert.ToSingle(v.Z));
    }

    public static partial class Vector3D
    {
        /// <summary> Computes the cross product of two vectors. </summary>
        public static Vector3D<T> Cross<T>(this Vector3D<T> left, Vector3D<T> right)
            where T : INumberBase<T> =>
            new Vector3D<T>(
                (left.Y * right.Z) - (left.Z * right.Y),
                (left.Z * right.X) - (left.X * right.Z),
                (left.X * right.Y) - (left.Y * right.X));
    }
}
