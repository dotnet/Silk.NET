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

public readonly unsafe partial struct Hsyntheticpointerdevice
    : IComparable,
        IComparable<Hsyntheticpointerdevice>,
        IEquatable<Hsyntheticpointerdevice>,
        IFormattable
{
    public readonly void* Value;

    public Hsyntheticpointerdevice(void* value)
    {
        Value = value;
    }

    public static Hsyntheticpointerdevice INVALID_VALUE => new Hsyntheticpointerdevice((void*)(-1));
    public static Hsyntheticpointerdevice NULL => new Hsyntheticpointerdevice(null);

    public static bool operator ==(Hsyntheticpointerdevice left, Hsyntheticpointerdevice right) =>
        left.Value == right.Value;

    public static bool operator !=(Hsyntheticpointerdevice left, Hsyntheticpointerdevice right) =>
        left.Value != right.Value;

    public static bool operator <(Hsyntheticpointerdevice left, Hsyntheticpointerdevice right) =>
        left.Value < right.Value;

    public static bool operator <=(Hsyntheticpointerdevice left, Hsyntheticpointerdevice right) =>
        left.Value <= right.Value;

    public static bool operator >(Hsyntheticpointerdevice left, Hsyntheticpointerdevice right) =>
        left.Value > right.Value;

    public static bool operator >=(Hsyntheticpointerdevice left, Hsyntheticpointerdevice right) =>
        left.Value >= right.Value;

    public static explicit operator Hsyntheticpointerdevice(void* value) =>
        new Hsyntheticpointerdevice(value);

    public static implicit operator void*(Hsyntheticpointerdevice value) => value.Value;

    public static explicit operator Hsyntheticpointerdevice(Handle value) =>
        new Hsyntheticpointerdevice(value);

    public static implicit operator Handle(Hsyntheticpointerdevice value) =>
        new Handle(value.Value);

    public static explicit operator Hsyntheticpointerdevice(byte value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static explicit operator byte(Hsyntheticpointerdevice value) => (byte)(value.Value);

    public static explicit operator Hsyntheticpointerdevice(short value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static explicit operator short(Hsyntheticpointerdevice value) => (short)(value.Value);

    public static explicit operator Hsyntheticpointerdevice(int value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static explicit operator int(Hsyntheticpointerdevice value) => (int)(value.Value);

    public static explicit operator Hsyntheticpointerdevice(long value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static explicit operator long(Hsyntheticpointerdevice value) => (long)(value.Value);

    public static explicit operator Hsyntheticpointerdevice(nint value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static implicit operator nint(Hsyntheticpointerdevice value) => (nint)(value.Value);

    public static explicit operator Hsyntheticpointerdevice(sbyte value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static explicit operator sbyte(Hsyntheticpointerdevice value) => (sbyte)(value.Value);

    public static explicit operator Hsyntheticpointerdevice(ushort value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static explicit operator ushort(Hsyntheticpointerdevice value) => (ushort)(value.Value);

    public static explicit operator Hsyntheticpointerdevice(uint value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static explicit operator uint(Hsyntheticpointerdevice value) => (uint)(value.Value);

    public static explicit operator Hsyntheticpointerdevice(ulong value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static explicit operator ulong(Hsyntheticpointerdevice value) => (ulong)(value.Value);

    public static explicit operator Hsyntheticpointerdevice(nuint value) =>
        new Hsyntheticpointerdevice(unchecked((void*)(value)));

    public static implicit operator nuint(Hsyntheticpointerdevice value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hsyntheticpointerdevice other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSYNTHETICPOINTERDEVICE.");
    }

    public int CompareTo(Hsyntheticpointerdevice other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is Hsyntheticpointerdevice other) && Equals(other);

    public bool Equals(Hsyntheticpointerdevice other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
