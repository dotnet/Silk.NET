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
        // Casts

        /// <summary>Explicitly casts a System.Numerics.Vector4 to a Vector4I.</summary>
        public static explicit operator Vector4I<T>(System.Numerics.Vector4 v) =>
            new Vector4I<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)), (T)Convert.ChangeType(v.Z, typeof(T)), (T)Convert.ChangeType(v.W, typeof(T)));

        /// <summary>Explicitly casts a Vector4I to System.Numerics.Vector4.</summary>
        public static explicit operator System.Numerics.Vector4(Vector4I<T> v) =>
            new System.Numerics.Vector4(Convert.ToSingle(v.X), Convert.ToSingle(v.Y), Convert.ToSingle(v.Z), Convert.ToSingle(v.W));

        public static (Vector4I<T> Quotient, Vector4I<T> Remainder) DivRem(Vector4I<T> left, Vector4I<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            var (qW, rW) = T.DivRem(left.W, right.W);
            return (new Vector4I<T>(qX, qY, qZ, qW), new Vector4I<T>(rX, rY, rZ, rW));
        }
    }
}
