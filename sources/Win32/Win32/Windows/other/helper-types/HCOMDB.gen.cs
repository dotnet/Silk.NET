// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct Hcomdb
    : IComparable,
        IComparable<Hcomdb>,
        IEquatable<Hcomdb>,
        IFormattable
{
    public readonly void* Value;

    public Hcomdb(void* value)
    {
        Value = value;
    }

    public static Hcomdb INVALID_VALUE => new Hcomdb((void*)(-1));
    public static Hcomdb NULL => new Hcomdb(null);

    public static bool operator ==(Hcomdb left, Hcomdb right) => left.Value == right.Value;

    public static bool operator !=(Hcomdb left, Hcomdb right) => left.Value != right.Value;

    public static bool operator <(Hcomdb left, Hcomdb right) => left.Value < right.Value;

    public static bool operator <=(Hcomdb left, Hcomdb right) => left.Value <= right.Value;

    public static bool operator >(Hcomdb left, Hcomdb right) => left.Value > right.Value;

    public static bool operator >=(Hcomdb left, Hcomdb right) => left.Value >= right.Value;

    public static explicit operator Hcomdb(void* value) => new Hcomdb(value);

    public static implicit operator void*(Hcomdb value) => value.Value;

    public static explicit operator Hcomdb(Handle value) => new Hcomdb(value);

    public static implicit operator Handle(Hcomdb value) => new Handle(value.Value);

    public static explicit operator Hcomdb(byte value) => new Hcomdb(unchecked((void*)(value)));

    public static explicit operator byte(Hcomdb value) => (byte)(value.Value);

    public static explicit operator Hcomdb(short value) => new Hcomdb(unchecked((void*)(value)));

    public static explicit operator short(Hcomdb value) => (short)(value.Value);

    public static explicit operator Hcomdb(int value) => new Hcomdb(unchecked((void*)(value)));

    public static explicit operator int(Hcomdb value) => (int)(value.Value);

    public static explicit operator Hcomdb(long value) => new Hcomdb(unchecked((void*)(value)));

    public static explicit operator long(Hcomdb value) => (long)(value.Value);

    public static explicit operator Hcomdb(nint value) => new Hcomdb(unchecked((void*)(value)));

    public static implicit operator nint(Hcomdb value) => (nint)(value.Value);

    public static explicit operator Hcomdb(sbyte value) => new Hcomdb(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcomdb value) => (sbyte)(value.Value);

    public static explicit operator Hcomdb(ushort value) => new Hcomdb(unchecked((void*)(value)));

    public static explicit operator ushort(Hcomdb value) => (ushort)(value.Value);

    public static explicit operator Hcomdb(uint value) => new Hcomdb(unchecked((void*)(value)));

    public static explicit operator uint(Hcomdb value) => (uint)(value.Value);

    public static explicit operator Hcomdb(ulong value) => new Hcomdb(unchecked((void*)(value)));

    public static explicit operator ulong(Hcomdb value) => (ulong)(value.Value);

    public static explicit operator Hcomdb(nuint value) => new Hcomdb(unchecked((void*)(value)));

    public static implicit operator nuint(Hcomdb value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcomdb other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCOMDB.");
    }

    public int CompareTo(Hcomdb other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcomdb other) && Equals(other);

    public bool Equals(Hcomdb other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
