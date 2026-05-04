// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    public partial struct Matrix4X3<T> :
        IEquatable<Matrix4X3<T>>
        where T : INumberBase<T>
    {
        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix4X3<T> Identity { get; } = new
        (
            T.One, T.Zero, T.Zero,
            T.Zero, T.One, T.Zero,
            T.Zero, T.Zero, T.One,
            T.Zero, T.Zero, T.Zero
        );

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;
    }
}
