// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS1591, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

public readonly partial struct Bool : IComparable, IComparable<Bool>, IEquatable<Bool>, IFormattable
{
    public readonly int Value;

    public Bool(int value)
    {
        Value = value;
    }

    public static Bool FALSE => new Bool(0);
    public static Bool TRUE => new Bool(1);

    public static bool operator ==(Bool left, Bool right) => left.Value == right.Value;

    public static bool operator !=(Bool left, Bool right) => left.Value != right.Value;

    public static bool operator <(Bool left, Bool right) => left.Value < right.Value;

    public static bool operator <=(Bool left, Bool right) => left.Value <= right.Value;

    public static bool operator >(Bool left, Bool right) => left.Value > right.Value;

    public static bool operator >=(Bool left, Bool right) => left.Value >= right.Value;

    public static implicit operator bool(Bool value) => value.Value != 0;

    public static implicit operator Bool(bool value) => new Bool(value ? 1 : 0);

    public static bool operator false(Bool value) => value.Value == 0;

    public static bool operator true(Bool value) => value.Value != 0;

    public static implicit operator Bool(byte value) => new Bool(value);

    public static explicit operator byte(Bool value) => (byte)(value.Value);

    public static implicit operator Bool(short value) => new Bool(value);

    public static explicit operator short(Bool value) => (short)(value.Value);

    public static implicit operator Bool(int value) => new Bool(value);

    public static implicit operator int(Bool value) => value.Value;

    public static explicit operator Bool(long value) => new Bool(unchecked((int)(value)));

    public static implicit operator long(Bool value) => value.Value;

    public static explicit operator Bool(nint value) => new Bool(unchecked((int)(value)));

    public static implicit operator nint(Bool value) => value.Value;

    public static implicit operator Bool(sbyte value) => new Bool(value);

    public static explicit operator sbyte(Bool value) => (sbyte)(value.Value);

    public static implicit operator Bool(ushort value) => new Bool(value);

    public static explicit operator ushort(Bool value) => (ushort)(value.Value);

    public static explicit operator Bool(uint value) => new Bool(unchecked((int)(value)));

    public static explicit operator uint(Bool value) => (uint)(value.Value);

    public static explicit operator Bool(ulong value) => new Bool(unchecked((int)(value)));

    public static explicit operator ulong(Bool value) => (ulong)(value.Value);

    public static explicit operator Bool(nuint value) => new Bool(unchecked((int)(value)));

    public static explicit operator nuint(Bool value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Bool other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of BOOL.");
    }

    public int CompareTo(Bool other) => Value.CompareTo(other.Value);

    [Transformed]
    public int CompareTo(MaybeBool<Bool> other) => (int)CompareTo((Bool)other);

    public override bool Equals(object? obj) => (obj is Bool other) && Equals(other);

    public bool Equals(Bool other) => Value.Equals(other.Value);

    [Transformed]
    public bool Equals(MaybeBool<Bool> other) => (bool)Equals((Bool)other);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
