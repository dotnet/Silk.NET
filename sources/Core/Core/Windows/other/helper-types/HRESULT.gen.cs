// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Core;
#pragma warning disable CS1589, CS1591, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

public readonly unsafe partial struct HResult
    : IComparable,
        IComparable<HResult>,
        IEquatable<HResult>,
        IFormattable
{
    public readonly int Value;

    public HResult(int value)
    {
        Value = value;
    }

    public static bool operator ==(HResult left, HResult right) => left.Value == right.Value;

    public static bool operator !=(HResult left, HResult right) => left.Value != right.Value;

    public static bool operator <(HResult left, HResult right) => left.Value < right.Value;

    public static bool operator <=(HResult left, HResult right) => left.Value <= right.Value;

    public static bool operator >(HResult left, HResult right) => left.Value > right.Value;

    public static bool operator >=(HResult left, HResult right) => left.Value >= right.Value;

    public static implicit operator HResult(byte value) => new HResult(value);

    public static explicit operator byte(HResult value) => (byte)(value.Value);

    public static implicit operator HResult(short value) => new HResult(value);

    public static explicit operator short(HResult value) => (short)(value.Value);

    public static implicit operator HResult(int value) => new HResult(value);

    public static implicit operator int(HResult value) => value.Value;

    public static explicit operator HResult(long value) => new HResult(unchecked((int)(value)));

    public static implicit operator long(HResult value) => value.Value;

    public static explicit operator HResult(nint value) => new HResult(unchecked((int)(value)));

    public static implicit operator nint(HResult value) => value.Value;

    public static implicit operator HResult(sbyte value) => new HResult(value);

    public static explicit operator sbyte(HResult value) => (sbyte)(value.Value);

    public static implicit operator HResult(ushort value) => new HResult(value);

    public static explicit operator ushort(HResult value) => (ushort)(value.Value);

    public static explicit operator HResult(uint value) => new HResult(unchecked((int)(value)));

    public static explicit operator uint(HResult value) => (uint)(value.Value);

    public static explicit operator HResult(ulong value) => new HResult(unchecked((int)(value)));

    public static explicit operator ulong(HResult value) => (ulong)(value.Value);

    public static explicit operator HResult(nuint value) => new HResult(unchecked((int)(value)));

    public static explicit operator nuint(HResult value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HResult other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HRESULT.");
    }

    public int CompareTo(HResult other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HResult other) && Equals(other);

    public bool Equals(HResult other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString("X8");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
