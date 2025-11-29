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

public readonly unsafe partial struct Msihandle
    : IComparable,
        IComparable<Msihandle>,
        IEquatable<Msihandle>,
        IFormattable
{
    public readonly uint Value;

    public Msihandle(uint value)
    {
        Value = value;
    }

    public static bool operator ==(Msihandle left, Msihandle right) => left.Value == right.Value;

    public static bool operator !=(Msihandle left, Msihandle right) => left.Value != right.Value;

    public static bool operator <(Msihandle left, Msihandle right) => left.Value < right.Value;

    public static bool operator <=(Msihandle left, Msihandle right) => left.Value <= right.Value;

    public static bool operator >(Msihandle left, Msihandle right) => left.Value > right.Value;

    public static bool operator >=(Msihandle left, Msihandle right) => left.Value >= right.Value;

    public static implicit operator Msihandle(byte value) => new Msihandle(value);

    public static explicit operator byte(Msihandle value) => (byte)(value.Value);

    public static explicit operator Msihandle(short value) =>
        new Msihandle(unchecked((uint)(value)));

    public static explicit operator short(Msihandle value) => (short)(value.Value);

    public static explicit operator Msihandle(int value) => new Msihandle(unchecked((uint)(value)));

    public static explicit operator int(Msihandle value) => (int)(value.Value);

    public static explicit operator Msihandle(long value) =>
        new Msihandle(unchecked((uint)(value)));

    public static implicit operator long(Msihandle value) => value.Value;

    public static explicit operator Msihandle(nint value) =>
        new Msihandle(unchecked((uint)(value)));

    public static explicit operator nint(Msihandle value) => (nint)(value.Value);

    public static explicit operator Msihandle(sbyte value) =>
        new Msihandle(unchecked((uint)(value)));

    public static explicit operator sbyte(Msihandle value) => (sbyte)(value.Value);

    public static implicit operator Msihandle(ushort value) => new Msihandle(value);

    public static explicit operator ushort(Msihandle value) => (ushort)(value.Value);

    public static implicit operator Msihandle(uint value) => new Msihandle(value);

    public static implicit operator uint(Msihandle value) => value.Value;

    public static explicit operator Msihandle(ulong value) =>
        new Msihandle(unchecked((uint)(value)));

    public static implicit operator ulong(Msihandle value) => value.Value;

    public static explicit operator Msihandle(nuint value) =>
        new Msihandle(unchecked((uint)(value)));

    public static implicit operator nuint(Msihandle value) => value.Value;

    public int CompareTo(object? obj)
    {
        if (obj is Msihandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of MSIHANDLE.");
    }

    public int CompareTo(Msihandle other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is Msihandle other) && Equals(other);

    public bool Equals(Msihandle other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString("X8");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
