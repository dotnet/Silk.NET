// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 4D integer vector.</summary>
    public partial struct Vector4D<T>
    {
        /// <summary>Explicitly casts a <see cref="Vector4"/> to a <see cref="Vector4D{T}"/>.</summary>
        public static explicit operator Vector4D<T>(Vector4 v) =>
            new Vector4D<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)), (T)Convert.ChangeType(v.Z, typeof(T)), (T)Convert.ChangeType(v.W, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector4D{T}"/> to <see cref="Vector4"/>.</summary>
        public static explicit operator Vector4(Vector4D<T> v) =>
            new Vector4(Convert.ToSingle(v.X), Convert.ToSingle(v.Y), Convert.ToSingle(v.Z), Convert.ToSingle(v.W));
    }
}
