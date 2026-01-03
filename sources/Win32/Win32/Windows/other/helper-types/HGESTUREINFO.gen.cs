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

public readonly unsafe partial struct Hgestureinfo
    : IComparable,
        IComparable<Hgestureinfo>,
        IEquatable<Hgestureinfo>,
        IFormattable
{
    public readonly void* Value;

    public Hgestureinfo(void* value)
    {
        Value = value;
    }

    public static Hgestureinfo INVALID_VALUE => new Hgestureinfo((void*)(-1));
    public static Hgestureinfo NULL => new Hgestureinfo(null);

    public static bool operator ==(Hgestureinfo left, Hgestureinfo right) =>
        left.Value == right.Value;

    public static bool operator !=(Hgestureinfo left, Hgestureinfo right) =>
        left.Value != right.Value;

    public static bool operator <(Hgestureinfo left, Hgestureinfo right) =>
        left.Value < right.Value;

    public static bool operator <=(Hgestureinfo left, Hgestureinfo right) =>
        left.Value <= right.Value;

    public static bool operator >(Hgestureinfo left, Hgestureinfo right) =>
        left.Value > right.Value;

    public static bool operator >=(Hgestureinfo left, Hgestureinfo right) =>
        left.Value >= right.Value;

    public static explicit operator Hgestureinfo(void* value) => new Hgestureinfo(value);

    public static implicit operator void*(Hgestureinfo value) => value.Value;

    public static explicit operator Hgestureinfo(Handle value) => new Hgestureinfo(value);

    public static implicit operator Handle(Hgestureinfo value) => new Handle(value.Value);

    public static explicit operator Hgestureinfo(byte value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static explicit operator byte(Hgestureinfo value) => (byte)(value.Value);

    public static explicit operator Hgestureinfo(short value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static explicit operator short(Hgestureinfo value) => (short)(value.Value);

    public static explicit operator Hgestureinfo(int value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static explicit operator int(Hgestureinfo value) => (int)(value.Value);

    public static explicit operator Hgestureinfo(long value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static explicit operator long(Hgestureinfo value) => (long)(value.Value);

    public static explicit operator Hgestureinfo(nint value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static implicit operator nint(Hgestureinfo value) => (nint)(value.Value);

    public static explicit operator Hgestureinfo(sbyte value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static explicit operator sbyte(Hgestureinfo value) => (sbyte)(value.Value);

    public static explicit operator Hgestureinfo(ushort value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static explicit operator ushort(Hgestureinfo value) => (ushort)(value.Value);

    public static explicit operator Hgestureinfo(uint value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static explicit operator uint(Hgestureinfo value) => (uint)(value.Value);

    public static explicit operator Hgestureinfo(ulong value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static explicit operator ulong(Hgestureinfo value) => (ulong)(value.Value);

    public static explicit operator Hgestureinfo(nuint value) =>
        new Hgestureinfo(unchecked((void*)(value)));

    public static implicit operator nuint(Hgestureinfo value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hgestureinfo other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HGESTUREINFO.");
    }

    public int CompareTo(Hgestureinfo other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hgestureinfo other) && Equals(other);

    public bool Equals(Hgestureinfo other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
