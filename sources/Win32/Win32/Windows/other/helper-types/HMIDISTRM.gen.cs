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

public readonly unsafe partial struct Hmidistrm
    : IComparable,
        IComparable<Hmidistrm>,
        IEquatable<Hmidistrm>,
        IFormattable
{
    public readonly void* Value;

    public Hmidistrm(void* value)
    {
        Value = value;
    }

    public static Hmidistrm INVALID_VALUE => new Hmidistrm((void*)(-1));
    public static Hmidistrm NULL => new Hmidistrm(null);

    public static bool operator ==(Hmidistrm left, Hmidistrm right) => left.Value == right.Value;

    public static bool operator !=(Hmidistrm left, Hmidistrm right) => left.Value != right.Value;

    public static bool operator <(Hmidistrm left, Hmidistrm right) => left.Value < right.Value;

    public static bool operator <=(Hmidistrm left, Hmidistrm right) => left.Value <= right.Value;

    public static bool operator >(Hmidistrm left, Hmidistrm right) => left.Value > right.Value;

    public static bool operator >=(Hmidistrm left, Hmidistrm right) => left.Value >= right.Value;

    public static explicit operator Hmidistrm(void* value) => new Hmidistrm(value);

    public static implicit operator void*(Hmidistrm value) => value.Value;

    public static explicit operator Hmidistrm(Handle value) => new Hmidistrm(value);

    public static implicit operator Handle(Hmidistrm value) => new Handle(value.Value);

    public static explicit operator Hmidistrm(byte value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static explicit operator byte(Hmidistrm value) => (byte)(value.Value);

    public static explicit operator Hmidistrm(short value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static explicit operator short(Hmidistrm value) => (short)(value.Value);

    public static explicit operator Hmidistrm(int value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static explicit operator int(Hmidistrm value) => (int)(value.Value);

    public static explicit operator Hmidistrm(long value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static explicit operator long(Hmidistrm value) => (long)(value.Value);

    public static explicit operator Hmidistrm(nint value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static implicit operator nint(Hmidistrm value) => (nint)(value.Value);

    public static explicit operator Hmidistrm(sbyte value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmidistrm value) => (sbyte)(value.Value);

    public static explicit operator Hmidistrm(ushort value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static explicit operator ushort(Hmidistrm value) => (ushort)(value.Value);

    public static explicit operator Hmidistrm(uint value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static explicit operator uint(Hmidistrm value) => (uint)(value.Value);

    public static explicit operator Hmidistrm(ulong value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static explicit operator ulong(Hmidistrm value) => (ulong)(value.Value);

    public static explicit operator Hmidistrm(nuint value) =>
        new Hmidistrm(unchecked((void*)(value)));

    public static implicit operator nuint(Hmidistrm value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmidistrm other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMIDISTRM.");
    }

    public int CompareTo(Hmidistrm other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmidistrm other) && Equals(other);

    public bool Equals(Hmidistrm other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
