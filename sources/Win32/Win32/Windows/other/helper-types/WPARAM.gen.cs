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

public readonly unsafe partial struct Wparam
    : IComparable,
        IComparable<Wparam>,
        IEquatable<Wparam>,
        IFormattable
{
    public readonly nuint Value;

    public Wparam(nuint value)
    {
        Value = value;
    }

    public static bool operator ==(Wparam left, Wparam right) => left.Value == right.Value;

    public static bool operator !=(Wparam left, Wparam right) => left.Value != right.Value;

    public static bool operator <(Wparam left, Wparam right) => left.Value < right.Value;

    public static bool operator <=(Wparam left, Wparam right) => left.Value <= right.Value;

    public static bool operator >(Wparam left, Wparam right) => left.Value > right.Value;

    public static bool operator >=(Wparam left, Wparam right) => left.Value >= right.Value;

    public static implicit operator Wparam(byte value) => new Wparam(value);

    public static explicit operator byte(Wparam value) => (byte)(value.Value);

    public static explicit operator Wparam(short value) => new Wparam(unchecked((nuint)(value)));

    public static explicit operator short(Wparam value) => (short)(value.Value);

    public static explicit operator Wparam(int value) => new Wparam(unchecked((nuint)(value)));

    public static explicit operator int(Wparam value) => (int)(value.Value);

    public static explicit operator Wparam(long value) => new Wparam(unchecked((nuint)(value)));

    public static explicit operator long(Wparam value) => (long)(value.Value);

    public static explicit operator Wparam(nint value) => new Wparam(unchecked((nuint)(value)));

    public static explicit operator nint(Wparam value) => (nint)(value.Value);

    public static explicit operator Wparam(sbyte value) => new Wparam(unchecked((nuint)(value)));

    public static explicit operator sbyte(Wparam value) => (sbyte)(value.Value);

    public static implicit operator Wparam(ushort value) => new Wparam(value);

    public static explicit operator ushort(Wparam value) => (ushort)(value.Value);

    public static implicit operator Wparam(uint value) => new Wparam(value);

    public static explicit operator uint(Wparam value) => (uint)(value.Value);

    public static explicit operator Wparam(ulong value) => new Wparam(unchecked((nuint)(value)));

    public static implicit operator ulong(Wparam value) => value.Value;

    public static implicit operator Wparam(nuint value) => new Wparam(value);

    public static implicit operator nuint(Wparam value) => value.Value;

    public int CompareTo(object? obj)
    {
        if (obj is Wparam other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of WPARAM.");
    }

    public int CompareTo(Wparam other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is Wparam other) && Equals(other);

    public bool Equals(Wparam other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
