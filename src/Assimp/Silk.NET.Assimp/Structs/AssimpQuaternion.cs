// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Silk.NET.Assimp
{
    public partial struct AssimpQuaternion : IEquatable<AssimpQuaternion>, IEquatable<Quaternion>
    {
        public unsafe AssimpQuaternion(Quaternion from) => (W, X, Y, Z) = (from.W, from.X, from.Y, from.Z);

        public float W;
        public float X;
        public float Y;
        public float Z;

        public unsafe Quaternion AsQuaternion => new(X, Y, Z, W);
        public static implicit operator Quaternion(AssimpQuaternion val) => val.AsQuaternion;
        public static implicit operator AssimpQuaternion(Quaternion val) => new(val);
        public static bool operator ==(AssimpQuaternion left, AssimpQuaternion right)
            => left.AsQuaternion.Equals(right.AsQuaternion);
        public static bool operator !=(AssimpQuaternion left, AssimpQuaternion right)
            => !left.AsQuaternion.Equals(right.AsQuaternion);
        public static bool operator ==(AssimpQuaternion left, Quaternion right)
            => left.AsQuaternion.Equals(right);
        public static bool operator !=(AssimpQuaternion left, Quaternion right)
            => !left.AsQuaternion.Equals(right);
        public bool Equals(AssimpQuaternion other) => other.AsQuaternion == AsQuaternion;
        public bool Equals(Quaternion other) => other == AsQuaternion;
        public override string ToString() => AsQuaternion.ToString();
    }
}
