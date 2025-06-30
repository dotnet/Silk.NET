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
    public partial struct Vector4D<T>
    {
        // Casts

        /// <summary>Explicitly casts a System.Numerics.Vector4 to a Vector4D.</summary>
        public static explicit operator Vector4D<T>(System.Numerics.Vector4 v) =>
            new Vector4D<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)), (T)Convert.ChangeType(v.Z, typeof(T)), (T)Convert.ChangeType(v.W, typeof(T)));

        /// <summary>Explicitly casts a Vector4D to System.Numerics.Vector4.</summary>
        public static explicit operator System.Numerics.Vector4(Vector4D<T> v) =>
            new System.Numerics.Vector4(Convert.ToSingle(v.X), Convert.ToSingle(v.Y), Convert.ToSingle(v.Z), Convert.ToSingle(v.W));

        public static (Vector4D<T> Quotient, Vector4D<T> Remainder) DivRem(Vector4D<T> left, Vector4D<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            var (qW, rW) = T.DivRem(left.W, right.W);
            return (new Vector4D<T>(qX, qY, qZ, qW), new Vector4D<T>(rX, rY, rZ, rW));
        }
    }
}
