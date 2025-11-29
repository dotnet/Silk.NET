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
namespace Silk.NET.WinRT;

public readonly unsafe partial struct HstringBuffer
    : IComparable,
        IComparable<HstringBuffer>,
        IEquatable<HstringBuffer>,
        IFormattable
{
    public readonly void* Value;

    public HstringBuffer(void* value)
    {
        Value = value;
    }

    public static HstringBuffer INVALID_VALUE => new HstringBuffer((void*)(-1));
    public static HstringBuffer NULL => new HstringBuffer(null);

    public static bool operator ==(HstringBuffer left, HstringBuffer right) =>
        left.Value == right.Value;

    public static bool operator !=(HstringBuffer left, HstringBuffer right) =>
        left.Value != right.Value;

    public static bool operator <(HstringBuffer left, HstringBuffer right) =>
        left.Value < right.Value;

    public static bool operator <=(HstringBuffer left, HstringBuffer right) =>
        left.Value <= right.Value;

    public static bool operator >(HstringBuffer left, HstringBuffer right) =>
        left.Value > right.Value;

    public static bool operator >=(HstringBuffer left, HstringBuffer right) =>
        left.Value >= right.Value;

    public static explicit operator HstringBuffer(void* value) => new HstringBuffer(value);

    public static implicit operator void*(HstringBuffer value) => value.Value;

    public static explicit operator HstringBuffer(Handle value) => new HstringBuffer(value);

    public static implicit operator Handle(HstringBuffer value) => new Handle(value.Value);

    public static explicit operator HstringBuffer(byte value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static explicit operator byte(HstringBuffer value) => (byte)(value.Value);

    public static explicit operator HstringBuffer(short value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static explicit operator short(HstringBuffer value) => (short)(value.Value);

    public static explicit operator HstringBuffer(int value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static explicit operator int(HstringBuffer value) => (int)(value.Value);

    public static explicit operator HstringBuffer(long value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static explicit operator long(HstringBuffer value) => (long)(value.Value);

    public static explicit operator HstringBuffer(nint value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static implicit operator nint(HstringBuffer value) => (nint)(value.Value);

    public static explicit operator HstringBuffer(sbyte value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static explicit operator sbyte(HstringBuffer value) => (sbyte)(value.Value);

    public static explicit operator HstringBuffer(ushort value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static explicit operator ushort(HstringBuffer value) => (ushort)(value.Value);

    public static explicit operator HstringBuffer(uint value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static explicit operator uint(HstringBuffer value) => (uint)(value.Value);

    public static explicit operator HstringBuffer(ulong value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static explicit operator ulong(HstringBuffer value) => (ulong)(value.Value);

    public static explicit operator HstringBuffer(nuint value) =>
        new HstringBuffer(unchecked((void*)(value)));

    public static implicit operator nuint(HstringBuffer value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HstringBuffer other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSTRING_BUFFER.");
    }

    public int CompareTo(HstringBuffer other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HstringBuffer other) && Equals(other);

    public bool Equals(HstringBuffer other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
