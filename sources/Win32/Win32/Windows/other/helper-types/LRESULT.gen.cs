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

public readonly partial struct Lresult
    : IComparable,
        IComparable<Lresult>,
        IEquatable<Lresult>,
        IFormattable
{
    public readonly nint Value;

    public Lresult(nint value)
    {
        Value = value;
    }

    public static bool operator ==(Lresult left, Lresult right) => left.Value == right.Value;

    public static bool operator !=(Lresult left, Lresult right) => left.Value != right.Value;

    public static bool operator <(Lresult left, Lresult right) => left.Value < right.Value;

    public static bool operator <=(Lresult left, Lresult right) => left.Value <= right.Value;

    public static bool operator >(Lresult left, Lresult right) => left.Value > right.Value;

    public static bool operator >=(Lresult left, Lresult right) => left.Value >= right.Value;

    public static implicit operator Lresult(byte value) => new Lresult(value);

    public static explicit operator byte(Lresult value) => (byte)(value.Value);

    public static implicit operator Lresult(short value) => new Lresult(value);

    public static explicit operator short(Lresult value) => (short)(value.Value);

    public static implicit operator Lresult(int value) => new Lresult(value);

    public static explicit operator int(Lresult value) => (int)(value.Value);

    public static explicit operator Lresult(long value) => new Lresult(unchecked((nint)(value)));

    public static implicit operator long(Lresult value) => value.Value;

    public static implicit operator Lresult(nint value) => new Lresult(value);

    public static implicit operator nint(Lresult value) => value.Value;

    public static implicit operator Lresult(sbyte value) => new Lresult(value);

    public static explicit operator sbyte(Lresult value) => (sbyte)(value.Value);

    public static implicit operator Lresult(ushort value) => new Lresult(value);

    public static explicit operator ushort(Lresult value) => (ushort)(value.Value);

    public static explicit operator Lresult(uint value) => new Lresult(unchecked((nint)(value)));

    public static explicit operator uint(Lresult value) => (uint)(value.Value);

    public static explicit operator Lresult(ulong value) => new Lresult(unchecked((nint)(value)));

    public static explicit operator ulong(Lresult value) => (ulong)(value.Value);

    public static explicit operator Lresult(nuint value) => new Lresult(unchecked((nint)(value)));

    public static explicit operator nuint(Lresult value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Lresult other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of LRESULT.");
    }

    public int CompareTo(Lresult other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is Lresult other) && Equals(other);

    public bool Equals(Lresult other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
