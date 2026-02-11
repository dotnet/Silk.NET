// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Represents a vector that is used to encode three-dimensional physical rotations.
    /// </summary>
    /// <typeparam name="T">The type used to store values.</typeparam>
    [Serializable]
    [DataContract]
    public partial struct Quaternion<T>
    {
        /// <summary>
        /// Converts a <see cref="Quaternion{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Quaternion<Half>(Quaternion<T> from)
            => new(Half.CreateTruncating(from.X), Half.CreateTruncating(from.Y), Half.CreateTruncating(from.Z),
                Half.CreateTruncating(from.W));

        /// <summary>
        /// Converts a <see cref="Quaternion{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Quaternion<float>(Quaternion<T> from)
            => new(float.CreateTruncating(from.X), float.CreateTruncating(from.Y), float.CreateTruncating(from.Z),
                float.CreateTruncating(from.W));

        /// <summary>
        /// Converts a <see cref="Quaternion{T}"/> into <see cref="Quaternion"/>
        /// </summary>
        /// <param name="from">The source quaternion</param>
        /// <returns>The <see cref="System.Numerics"/> quaternion</returns>
        public static explicit operator Quaternion(Quaternion<T> from)
            => new(float.CreateTruncating(from.X), float.CreateTruncating(from.Y), float.CreateTruncating(from.Z),
                float.CreateTruncating(from.W));

        /// <summary>
        /// Converts a <see cref="Quaternion{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Quaternion<double>(Quaternion<T> from)
            => new(double.CreateTruncating(from.X), double.CreateTruncating(from.Y), double.CreateTruncating(from.Z),
                double.CreateTruncating(from.W));

        /// <summary>
        /// Returns this quaternion casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted quaternion</returns>
        public Quaternion<TOther> As<TOther>()
            where TOther : INumber<TOther>, IRootFunctions<TOther>, ITrigonometricFunctions<TOther>
        {
            return new(TOther.CreateTruncating(X), TOther.CreateTruncating(Y), TOther.CreateTruncating(Z), TOther.CreateTruncating(W));
        }
    }
}
