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

public readonly unsafe partial struct Hpalette
    : IComparable,
        IComparable<Hpalette>,
        IEquatable<Hpalette>,
        IFormattable
{
    public readonly void* Value;

    public Hpalette(void* value)
    {
        Value = value;
    }

    public static Hpalette INVALID_VALUE => new Hpalette((void*)(-1));
    public static Hpalette NULL => new Hpalette(null);

    public static bool operator ==(Hpalette left, Hpalette right) => left.Value == right.Value;

    public static bool operator !=(Hpalette left, Hpalette right) => left.Value != right.Value;

    public static bool operator <(Hpalette left, Hpalette right) => left.Value < right.Value;

    public static bool operator <=(Hpalette left, Hpalette right) => left.Value <= right.Value;

    public static bool operator >(Hpalette left, Hpalette right) => left.Value > right.Value;

    public static bool operator >=(Hpalette left, Hpalette right) => left.Value >= right.Value;

    public static explicit operator Hpalette(void* value) => new Hpalette(value);

    public static implicit operator void*(Hpalette value) => value.Value;

    public static explicit operator Hpalette(Handle value) => new Hpalette(value);

    public static implicit operator Handle(Hpalette value) => new Handle(value.Value);

    public static explicit operator Hpalette(byte value) => new Hpalette(unchecked((void*)(value)));

    public static explicit operator byte(Hpalette value) => (byte)(value.Value);

    public static explicit operator Hpalette(short value) =>
        new Hpalette(unchecked((void*)(value)));

    public static explicit operator short(Hpalette value) => (short)(value.Value);

    public static explicit operator Hpalette(int value) => new Hpalette(unchecked((void*)(value)));

    public static explicit operator int(Hpalette value) => (int)(value.Value);

    public static explicit operator Hpalette(long value) => new Hpalette(unchecked((void*)(value)));

    public static explicit operator long(Hpalette value) => (long)(value.Value);

    public static explicit operator Hpalette(nint value) => new Hpalette(unchecked((void*)(value)));

    public static implicit operator nint(Hpalette value) => (nint)(value.Value);

    public static explicit operator Hpalette(sbyte value) =>
        new Hpalette(unchecked((void*)(value)));

    public static explicit operator sbyte(Hpalette value) => (sbyte)(value.Value);

    public static explicit operator Hpalette(ushort value) =>
        new Hpalette(unchecked((void*)(value)));

    public static explicit operator ushort(Hpalette value) => (ushort)(value.Value);

    public static explicit operator Hpalette(uint value) => new Hpalette(unchecked((void*)(value)));

    public static explicit operator uint(Hpalette value) => (uint)(value.Value);

    public static explicit operator Hpalette(ulong value) =>
        new Hpalette(unchecked((void*)(value)));

    public static explicit operator ulong(Hpalette value) => (ulong)(value.Value);

    public static explicit operator Hpalette(nuint value) =>
        new Hpalette(unchecked((void*)(value)));

    public static implicit operator nuint(Hpalette value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hpalette other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPALETTE.");
    }

    public int CompareTo(Hpalette other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hpalette other) && Equals(other);

    public bool Equals(Hpalette other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
