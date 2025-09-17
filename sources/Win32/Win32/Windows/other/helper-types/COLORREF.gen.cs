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

public readonly unsafe partial struct Colorref
    : IComparable,
        IComparable<Colorref>,
        IEquatable<Colorref>,
        IFormattable
{
    public readonly uint Value;

    public Colorref(uint value)
    {
        Value = value;
    }

    public static bool operator ==(Colorref left, Colorref right) => left.Value == right.Value;

    public static bool operator !=(Colorref left, Colorref right) => left.Value != right.Value;

    public static bool operator <(Colorref left, Colorref right) => left.Value < right.Value;

    public static bool operator <=(Colorref left, Colorref right) => left.Value <= right.Value;

    public static bool operator >(Colorref left, Colorref right) => left.Value > right.Value;

    public static bool operator >=(Colorref left, Colorref right) => left.Value >= right.Value;

    public static implicit operator Colorref(byte value) => new Colorref(value);

    public static explicit operator byte(Colorref value) => (byte)(value.Value);

    public static explicit operator Colorref(short value) => new Colorref(unchecked((uint)(value)));

    public static explicit operator short(Colorref value) => (short)(value.Value);

    public static explicit operator Colorref(int value) => new Colorref(unchecked((uint)(value)));

    public static explicit operator int(Colorref value) => (int)(value.Value);

    public static explicit operator Colorref(long value) => new Colorref(unchecked((uint)(value)));

    public static implicit operator long(Colorref value) => value.Value;

    public static explicit operator Colorref(nint value) => new Colorref(unchecked((uint)(value)));

    public static explicit operator nint(Colorref value) => (nint)(value.Value);

    public static explicit operator Colorref(sbyte value) => new Colorref(unchecked((uint)(value)));

    public static explicit operator sbyte(Colorref value) => (sbyte)(value.Value);

    public static implicit operator Colorref(ushort value) => new Colorref(value);

    public static explicit operator ushort(Colorref value) => (ushort)(value.Value);

    public static implicit operator Colorref(uint value) => new Colorref(value);

    public static implicit operator uint(Colorref value) => value.Value;

    public static explicit operator Colorref(ulong value) => new Colorref(unchecked((uint)(value)));

    public static implicit operator ulong(Colorref value) => value.Value;

    public static explicit operator Colorref(nuint value) => new Colorref(unchecked((uint)(value)));

    public static implicit operator nuint(Colorref value) => value.Value;

    public int CompareTo(object? obj)
    {
        if (obj is Colorref other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of COLORREF.");
    }

    public int CompareTo(Colorref other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is Colorref other) && Equals(other);

    public bool Equals(Colorref other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString("X8");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
