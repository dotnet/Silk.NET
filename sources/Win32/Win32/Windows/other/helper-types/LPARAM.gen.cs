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

public readonly unsafe partial struct Lparam
    : IComparable,
        IComparable<Lparam>,
        IEquatable<Lparam>,
        IFormattable
{
    public readonly nint Value;

    public Lparam(nint value)
    {
        Value = value;
    }

    public static bool operator ==(Lparam left, Lparam right) => left.Value == right.Value;

    public static bool operator !=(Lparam left, Lparam right) => left.Value != right.Value;

    public static bool operator <(Lparam left, Lparam right) => left.Value < right.Value;

    public static bool operator <=(Lparam left, Lparam right) => left.Value <= right.Value;

    public static bool operator >(Lparam left, Lparam right) => left.Value > right.Value;

    public static bool operator >=(Lparam left, Lparam right) => left.Value >= right.Value;

    public static implicit operator Lparam(byte value) => new Lparam(value);

    public static explicit operator byte(Lparam value) => (byte)(value.Value);

    public static implicit operator Lparam(short value) => new Lparam(value);

    public static explicit operator short(Lparam value) => (short)(value.Value);

    public static implicit operator Lparam(int value) => new Lparam(value);

    public static explicit operator int(Lparam value) => (int)(value.Value);

    public static explicit operator Lparam(long value) => new Lparam(unchecked((nint)(value)));

    public static implicit operator long(Lparam value) => value.Value;

    public static implicit operator Lparam(nint value) => new Lparam(value);

    public static implicit operator nint(Lparam value) => value.Value;

    public static implicit operator Lparam(sbyte value) => new Lparam(value);

    public static explicit operator sbyte(Lparam value) => (sbyte)(value.Value);

    public static implicit operator Lparam(ushort value) => new Lparam(value);

    public static explicit operator ushort(Lparam value) => (ushort)(value.Value);

    public static explicit operator Lparam(uint value) => new Lparam(unchecked((nint)(value)));

    public static explicit operator uint(Lparam value) => (uint)(value.Value);

    public static explicit operator Lparam(ulong value) => new Lparam(unchecked((nint)(value)));

    public static explicit operator ulong(Lparam value) => (ulong)(value.Value);

    public static explicit operator Lparam(nuint value) => new Lparam(unchecked((nint)(value)));

    public static explicit operator nuint(Lparam value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Lparam other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of LPARAM.");
    }

    public int CompareTo(Lparam other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is Lparam other) && Equals(other);

    public bool Equals(Lparam other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
