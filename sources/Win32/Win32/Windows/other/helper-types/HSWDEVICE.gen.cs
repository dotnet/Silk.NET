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

public readonly unsafe partial struct Hswdevice
    : IComparable,
        IComparable<Hswdevice>,
        IEquatable<Hswdevice>,
        IFormattable
{
    public readonly void* Value;

    public Hswdevice(void* value)
    {
        Value = value;
    }

    public static Hswdevice INVALID_VALUE => new Hswdevice((void*)(-1));
    public static Hswdevice NULL => new Hswdevice(null);

    public static bool operator ==(Hswdevice left, Hswdevice right) => left.Value == right.Value;

    public static bool operator !=(Hswdevice left, Hswdevice right) => left.Value != right.Value;

    public static bool operator <(Hswdevice left, Hswdevice right) => left.Value < right.Value;

    public static bool operator <=(Hswdevice left, Hswdevice right) => left.Value <= right.Value;

    public static bool operator >(Hswdevice left, Hswdevice right) => left.Value > right.Value;

    public static bool operator >=(Hswdevice left, Hswdevice right) => left.Value >= right.Value;

    public static explicit operator Hswdevice(void* value) => new Hswdevice(value);

    public static implicit operator void*(Hswdevice value) => value.Value;

    public static explicit operator Hswdevice(Handle value) => new Hswdevice(value);

    public static implicit operator Handle(Hswdevice value) => new Handle(value.Value);

    public static explicit operator Hswdevice(byte value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static explicit operator byte(Hswdevice value) => (byte)(value.Value);

    public static explicit operator Hswdevice(short value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static explicit operator short(Hswdevice value) => (short)(value.Value);

    public static explicit operator Hswdevice(int value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static explicit operator int(Hswdevice value) => (int)(value.Value);

    public static explicit operator Hswdevice(long value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static explicit operator long(Hswdevice value) => (long)(value.Value);

    public static explicit operator Hswdevice(nint value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static implicit operator nint(Hswdevice value) => (nint)(value.Value);

    public static explicit operator Hswdevice(sbyte value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static explicit operator sbyte(Hswdevice value) => (sbyte)(value.Value);

    public static explicit operator Hswdevice(ushort value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static explicit operator ushort(Hswdevice value) => (ushort)(value.Value);

    public static explicit operator Hswdevice(uint value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static explicit operator uint(Hswdevice value) => (uint)(value.Value);

    public static explicit operator Hswdevice(ulong value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static explicit operator ulong(Hswdevice value) => (ulong)(value.Value);

    public static explicit operator Hswdevice(nuint value) =>
        new Hswdevice(unchecked((void*)(value)));

    public static implicit operator nuint(Hswdevice value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hswdevice other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSWDEVICE.");
    }

    public int CompareTo(Hswdevice other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hswdevice other) && Equals(other);

    public bool Equals(Hswdevice other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
