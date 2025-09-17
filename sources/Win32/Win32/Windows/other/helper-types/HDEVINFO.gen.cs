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

public readonly unsafe partial struct Hdevinfo
    : IComparable,
        IComparable<Hdevinfo>,
        IEquatable<Hdevinfo>,
        IFormattable
{
    public readonly void* Value;

    public Hdevinfo(void* value)
    {
        Value = value;
    }

    public static Hdevinfo INVALID_VALUE => new Hdevinfo((void*)(-1));
    public static Hdevinfo NULL => new Hdevinfo(null);

    public static bool operator ==(Hdevinfo left, Hdevinfo right) => left.Value == right.Value;

    public static bool operator !=(Hdevinfo left, Hdevinfo right) => left.Value != right.Value;

    public static bool operator <(Hdevinfo left, Hdevinfo right) => left.Value < right.Value;

    public static bool operator <=(Hdevinfo left, Hdevinfo right) => left.Value <= right.Value;

    public static bool operator >(Hdevinfo left, Hdevinfo right) => left.Value > right.Value;

    public static bool operator >=(Hdevinfo left, Hdevinfo right) => left.Value >= right.Value;

    public static explicit operator Hdevinfo(void* value) => new Hdevinfo(value);

    public static implicit operator void*(Hdevinfo value) => value.Value;

    public static explicit operator Hdevinfo(Handle value) => new Hdevinfo(value);

    public static implicit operator Handle(Hdevinfo value) => new Handle(value.Value);

    public static explicit operator Hdevinfo(byte value) => new Hdevinfo(unchecked((void*)(value)));

    public static explicit operator byte(Hdevinfo value) => (byte)(value.Value);

    public static explicit operator Hdevinfo(short value) =>
        new Hdevinfo(unchecked((void*)(value)));

    public static explicit operator short(Hdevinfo value) => (short)(value.Value);

    public static explicit operator Hdevinfo(int value) => new Hdevinfo(unchecked((void*)(value)));

    public static explicit operator int(Hdevinfo value) => (int)(value.Value);

    public static explicit operator Hdevinfo(long value) => new Hdevinfo(unchecked((void*)(value)));

    public static explicit operator long(Hdevinfo value) => (long)(value.Value);

    public static explicit operator Hdevinfo(nint value) => new Hdevinfo(unchecked((void*)(value)));

    public static implicit operator nint(Hdevinfo value) => (nint)(value.Value);

    public static explicit operator Hdevinfo(sbyte value) =>
        new Hdevinfo(unchecked((void*)(value)));

    public static explicit operator sbyte(Hdevinfo value) => (sbyte)(value.Value);

    public static explicit operator Hdevinfo(ushort value) =>
        new Hdevinfo(unchecked((void*)(value)));

    public static explicit operator ushort(Hdevinfo value) => (ushort)(value.Value);

    public static explicit operator Hdevinfo(uint value) => new Hdevinfo(unchecked((void*)(value)));

    public static explicit operator uint(Hdevinfo value) => (uint)(value.Value);

    public static explicit operator Hdevinfo(ulong value) =>
        new Hdevinfo(unchecked((void*)(value)));

    public static explicit operator ulong(Hdevinfo value) => (ulong)(value.Value);

    public static explicit operator Hdevinfo(nuint value) =>
        new Hdevinfo(unchecked((void*)(value)));

    public static implicit operator nuint(Hdevinfo value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hdevinfo other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HDEVINFO.");
    }

    public int CompareTo(Hdevinfo other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hdevinfo other) && Equals(other);

    public bool Equals(Hdevinfo other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
