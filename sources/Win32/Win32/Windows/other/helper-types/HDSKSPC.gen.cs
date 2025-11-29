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

public readonly unsafe partial struct Hdskspc
    : IComparable,
        IComparable<Hdskspc>,
        IEquatable<Hdskspc>,
        IFormattable
{
    public readonly void* Value;

    public Hdskspc(void* value)
    {
        Value = value;
    }

    public static Hdskspc INVALID_VALUE => new Hdskspc((void*)(-1));
    public static Hdskspc NULL => new Hdskspc(null);

    public static bool operator ==(Hdskspc left, Hdskspc right) => left.Value == right.Value;

    public static bool operator !=(Hdskspc left, Hdskspc right) => left.Value != right.Value;

    public static bool operator <(Hdskspc left, Hdskspc right) => left.Value < right.Value;

    public static bool operator <=(Hdskspc left, Hdskspc right) => left.Value <= right.Value;

    public static bool operator >(Hdskspc left, Hdskspc right) => left.Value > right.Value;

    public static bool operator >=(Hdskspc left, Hdskspc right) => left.Value >= right.Value;

    public static explicit operator Hdskspc(void* value) => new Hdskspc(value);

    public static implicit operator void*(Hdskspc value) => value.Value;

    public static explicit operator Hdskspc(Handle value) => new Hdskspc(value);

    public static implicit operator Handle(Hdskspc value) => new Handle(value.Value);

    public static explicit operator Hdskspc(byte value) => new Hdskspc(unchecked((void*)(value)));

    public static explicit operator byte(Hdskspc value) => (byte)(value.Value);

    public static explicit operator Hdskspc(short value) => new Hdskspc(unchecked((void*)(value)));

    public static explicit operator short(Hdskspc value) => (short)(value.Value);

    public static explicit operator Hdskspc(int value) => new Hdskspc(unchecked((void*)(value)));

    public static explicit operator int(Hdskspc value) => (int)(value.Value);

    public static explicit operator Hdskspc(long value) => new Hdskspc(unchecked((void*)(value)));

    public static explicit operator long(Hdskspc value) => (long)(value.Value);

    public static explicit operator Hdskspc(nint value) => new Hdskspc(unchecked((void*)(value)));

    public static implicit operator nint(Hdskspc value) => (nint)(value.Value);

    public static explicit operator Hdskspc(sbyte value) => new Hdskspc(unchecked((void*)(value)));

    public static explicit operator sbyte(Hdskspc value) => (sbyte)(value.Value);

    public static explicit operator Hdskspc(ushort value) => new Hdskspc(unchecked((void*)(value)));

    public static explicit operator ushort(Hdskspc value) => (ushort)(value.Value);

    public static explicit operator Hdskspc(uint value) => new Hdskspc(unchecked((void*)(value)));

    public static explicit operator uint(Hdskspc value) => (uint)(value.Value);

    public static explicit operator Hdskspc(ulong value) => new Hdskspc(unchecked((void*)(value)));

    public static explicit operator ulong(Hdskspc value) => (ulong)(value.Value);

    public static explicit operator Hdskspc(nuint value) => new Hdskspc(unchecked((void*)(value)));

    public static implicit operator nuint(Hdskspc value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hdskspc other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HDSKSPC.");
    }

    public int CompareTo(Hdskspc other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hdskspc other) && Equals(other);

    public bool Equals(Hdskspc other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
