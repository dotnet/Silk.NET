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

public readonly unsafe partial struct Hrsrc
    : IComparable,
        IComparable<Hrsrc>,
        IEquatable<Hrsrc>,
        IFormattable
{
    public readonly void* Value;

    public Hrsrc(void* value)
    {
        Value = value;
    }

    public static Hrsrc INVALID_VALUE => new Hrsrc((void*)(-1));
    public static Hrsrc NULL => new Hrsrc(null);

    public static bool operator ==(Hrsrc left, Hrsrc right) => left.Value == right.Value;

    public static bool operator !=(Hrsrc left, Hrsrc right) => left.Value != right.Value;

    public static bool operator <(Hrsrc left, Hrsrc right) => left.Value < right.Value;

    public static bool operator <=(Hrsrc left, Hrsrc right) => left.Value <= right.Value;

    public static bool operator >(Hrsrc left, Hrsrc right) => left.Value > right.Value;

    public static bool operator >=(Hrsrc left, Hrsrc right) => left.Value >= right.Value;

    public static explicit operator Hrsrc(void* value) => new Hrsrc(value);

    public static implicit operator void*(Hrsrc value) => value.Value;

    public static explicit operator Hrsrc(Handle value) => new Hrsrc(value);

    public static implicit operator Handle(Hrsrc value) => new Handle(value.Value);

    public static explicit operator Hrsrc(byte value) => new Hrsrc(unchecked((void*)(value)));

    public static explicit operator byte(Hrsrc value) => (byte)(value.Value);

    public static explicit operator Hrsrc(short value) => new Hrsrc(unchecked((void*)(value)));

    public static explicit operator short(Hrsrc value) => (short)(value.Value);

    public static explicit operator Hrsrc(int value) => new Hrsrc(unchecked((void*)(value)));

    public static explicit operator int(Hrsrc value) => (int)(value.Value);

    public static explicit operator Hrsrc(long value) => new Hrsrc(unchecked((void*)(value)));

    public static explicit operator long(Hrsrc value) => (long)(value.Value);

    public static explicit operator Hrsrc(nint value) => new Hrsrc(unchecked((void*)(value)));

    public static implicit operator nint(Hrsrc value) => (nint)(value.Value);

    public static explicit operator Hrsrc(sbyte value) => new Hrsrc(unchecked((void*)(value)));

    public static explicit operator sbyte(Hrsrc value) => (sbyte)(value.Value);

    public static explicit operator Hrsrc(ushort value) => new Hrsrc(unchecked((void*)(value)));

    public static explicit operator ushort(Hrsrc value) => (ushort)(value.Value);

    public static explicit operator Hrsrc(uint value) => new Hrsrc(unchecked((void*)(value)));

    public static explicit operator uint(Hrsrc value) => (uint)(value.Value);

    public static explicit operator Hrsrc(ulong value) => new Hrsrc(unchecked((void*)(value)));

    public static explicit operator ulong(Hrsrc value) => (ulong)(value.Value);

    public static explicit operator Hrsrc(nuint value) => new Hrsrc(unchecked((void*)(value)));

    public static implicit operator nuint(Hrsrc value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hrsrc other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HRSRC.");
    }

    public int CompareTo(Hrsrc other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hrsrc other) && Equals(other);

    public bool Equals(Hrsrc other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
