// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Silk.NET.Assimp
{
    partial struct AssimpString : IEquatable<AssimpString>, IEquatable<string>
    {
        public unsafe AssimpString(string from)
        {
            var bytes = Encoding.UTF8.GetBytes(from);
            if (bytes.Length > 1024)
            {
                throw new ArgumentException("String too long, maximum length is 1024 UTF-8 bytes.", nameof(from));
            }

            Length = (uint)bytes.Length;
            for (var i = 0; i < bytes.Length; i++)
            {
                Data[i] = bytes[i];
            }
        }

        public unsafe string AsString => Encoding.UTF8.GetString((byte*) Unsafe.AsPointer(ref Data[0]), (int) Length);
        public static implicit operator string(AssimpString val) => val.ToString();
        public static implicit operator AssimpString(string val) => new AssimpString(val);
        public static bool operator ==(AssimpString left, AssimpString right) => left.AsString.Equals(right.AsString);
        public static bool operator !=(AssimpString left, AssimpString right) => !left.AsString.Equals(right.AsString);
        public static bool operator ==(AssimpString left, string right) => left.AsString.Equals(right);
        public static bool operator !=(AssimpString left, string right) => !left.AsString.Equals(right);
        public bool Equals(AssimpString other) => other.AsString == AsString;
        public bool Equals(string other) => other == AsString;
        public override string ToString() => AsString;
    }
}
