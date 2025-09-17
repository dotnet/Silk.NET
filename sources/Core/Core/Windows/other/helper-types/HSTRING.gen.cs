// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Core;
#pragma warning disable CS1589, CS1591, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

public readonly unsafe partial struct HString
    : IComparable,
        IComparable<HString>,
        IEquatable<HString>,
        IFormattable
{
    public readonly void* Value;

    public HString(void* value)
    {
        Value = value;
    }

    public static HString INVALID_VALUE => new HString((void*)(-1));
    public static HString NULL => new HString(null);

    public static bool operator ==(HString left, HString right) => left.Value == right.Value;

    public static bool operator !=(HString left, HString right) => left.Value != right.Value;

    public static bool operator <(HString left, HString right) => left.Value < right.Value;

    public static bool operator <=(HString left, HString right) => left.Value <= right.Value;

    public static bool operator >(HString left, HString right) => left.Value > right.Value;

    public static bool operator >=(HString left, HString right) => left.Value >= right.Value;

    public static explicit operator HString(void* value) => new HString(value);

    public static implicit operator void*(HString value) => value.Value;

    public static explicit operator HString(Handle value) => new HString(value);

    public static implicit operator Handle(HString value) => new Handle(value.Value);

    public static explicit operator HString(byte value) => new HString(unchecked((void*)(value)));

    public static explicit operator byte(HString value) => (byte)(value.Value);

    public static explicit operator HString(short value) => new HString(unchecked((void*)(value)));

    public static explicit operator short(HString value) => (short)(value.Value);

    public static explicit operator HString(int value) => new HString(unchecked((void*)(value)));

    public static explicit operator int(HString value) => (int)(value.Value);

    public static explicit operator HString(long value) => new HString(unchecked((void*)(value)));

    public static explicit operator long(HString value) => (long)(value.Value);

    public static explicit operator HString(nint value) => new HString(unchecked((void*)(value)));

    public static implicit operator nint(HString value) => (nint)(value.Value);

    public static explicit operator HString(sbyte value) => new HString(unchecked((void*)(value)));

    public static explicit operator sbyte(HString value) => (sbyte)(value.Value);

    public static explicit operator HString(ushort value) => new HString(unchecked((void*)(value)));

    public static explicit operator ushort(HString value) => (ushort)(value.Value);

    public static explicit operator HString(uint value) => new HString(unchecked((void*)(value)));

    public static explicit operator uint(HString value) => (uint)(value.Value);

    public static explicit operator HString(ulong value) => new HString(unchecked((void*)(value)));

    public static explicit operator ulong(HString value) => (ulong)(value.Value);

    public static explicit operator HString(nuint value) => new HString(unchecked((void*)(value)));

    public static implicit operator nuint(HString value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HString other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSTRING.");
    }

    public int CompareTo(HString other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HString other) && Equals(other);

    public bool Equals(HString other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
