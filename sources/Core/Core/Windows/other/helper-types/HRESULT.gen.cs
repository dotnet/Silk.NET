// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS1591, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

public readonly unsafe partial struct HRESULT
    : IComparable,
        IComparable<HRESULT>,
        IEquatable<HRESULT>,
        IFormattable
{
    public readonly int Value;

    public HRESULT(int value)
    {
        Value = value;
    }

    public static bool operator ==(HRESULT left, HRESULT right) => left.Value == right.Value;

    public static bool operator !=(HRESULT left, HRESULT right) => left.Value != right.Value;

    public static bool operator <(HRESULT left, HRESULT right) => left.Value < right.Value;

    public static bool operator <=(HRESULT left, HRESULT right) => left.Value <= right.Value;

    public static bool operator >(HRESULT left, HRESULT right) => left.Value > right.Value;

    public static bool operator >=(HRESULT left, HRESULT right) => left.Value >= right.Value;

    public static implicit operator HRESULT(byte value) => new HRESULT(value);

    public static explicit operator byte(HRESULT value) => (byte)(value.Value);

    public static implicit operator HRESULT(short value) => new HRESULT(value);

    public static explicit operator short(HRESULT value) => (short)(value.Value);

    public static implicit operator HRESULT(int value) => new HRESULT(value);

    public static implicit operator int(HRESULT value) => value.Value;

    public static explicit operator HRESULT(long value) => new HRESULT(unchecked((int)(value)));

    public static implicit operator long(HRESULT value) => value.Value;

    public static explicit operator HRESULT(nint value) => new HRESULT(unchecked((int)(value)));

    public static implicit operator nint(HRESULT value) => value.Value;

    public static implicit operator HRESULT(sbyte value) => new HRESULT(value);

    public static explicit operator sbyte(HRESULT value) => (sbyte)(value.Value);

    public static implicit operator HRESULT(ushort value) => new HRESULT(value);

    public static explicit operator ushort(HRESULT value) => (ushort)(value.Value);

    public static explicit operator HRESULT(uint value) => new HRESULT(unchecked((int)(value)));

    public static explicit operator uint(HRESULT value) => (uint)(value.Value);

    public static explicit operator HRESULT(ulong value) => new HRESULT(unchecked((int)(value)));

    public static explicit operator ulong(HRESULT value) => (ulong)(value.Value);

    public static explicit operator HRESULT(nuint value) => new HRESULT(unchecked((int)(value)));

    public static explicit operator nuint(HRESULT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HRESULT other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HRESULT.");
    }

    public int CompareTo(HRESULT other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HRESULT other) && Equals(other);

    public bool Equals(HRESULT other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString("X8");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
