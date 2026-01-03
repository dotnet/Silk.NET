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

public readonly unsafe partial struct Hbrush
    : IComparable,
        IComparable<Hbrush>,
        IEquatable<Hbrush>,
        IFormattable
{
    public readonly void* Value;

    public Hbrush(void* value)
    {
        Value = value;
    }

    public static Hbrush INVALID_VALUE => new Hbrush((void*)(-1));
    public static Hbrush NULL => new Hbrush(null);

    public static bool operator ==(Hbrush left, Hbrush right) => left.Value == right.Value;

    public static bool operator !=(Hbrush left, Hbrush right) => left.Value != right.Value;

    public static bool operator <(Hbrush left, Hbrush right) => left.Value < right.Value;

    public static bool operator <=(Hbrush left, Hbrush right) => left.Value <= right.Value;

    public static bool operator >(Hbrush left, Hbrush right) => left.Value > right.Value;

    public static bool operator >=(Hbrush left, Hbrush right) => left.Value >= right.Value;

    public static explicit operator Hbrush(void* value) => new Hbrush(value);

    public static implicit operator void*(Hbrush value) => value.Value;

    public static explicit operator Hbrush(Handle value) => new Hbrush(value);

    public static implicit operator Handle(Hbrush value) => new Handle(value.Value);

    public static explicit operator Hbrush(byte value) => new Hbrush(unchecked((void*)(value)));

    public static explicit operator byte(Hbrush value) => (byte)(value.Value);

    public static explicit operator Hbrush(short value) => new Hbrush(unchecked((void*)(value)));

    public static explicit operator short(Hbrush value) => (short)(value.Value);

    public static explicit operator Hbrush(int value) => new Hbrush(unchecked((void*)(value)));

    public static explicit operator int(Hbrush value) => (int)(value.Value);

    public static explicit operator Hbrush(long value) => new Hbrush(unchecked((void*)(value)));

    public static explicit operator long(Hbrush value) => (long)(value.Value);

    public static explicit operator Hbrush(nint value) => new Hbrush(unchecked((void*)(value)));

    public static implicit operator nint(Hbrush value) => (nint)(value.Value);

    public static explicit operator Hbrush(sbyte value) => new Hbrush(unchecked((void*)(value)));

    public static explicit operator sbyte(Hbrush value) => (sbyte)(value.Value);

    public static explicit operator Hbrush(ushort value) => new Hbrush(unchecked((void*)(value)));

    public static explicit operator ushort(Hbrush value) => (ushort)(value.Value);

    public static explicit operator Hbrush(uint value) => new Hbrush(unchecked((void*)(value)));

    public static explicit operator uint(Hbrush value) => (uint)(value.Value);

    public static explicit operator Hbrush(ulong value) => new Hbrush(unchecked((void*)(value)));

    public static explicit operator ulong(Hbrush value) => (ulong)(value.Value);

    public static explicit operator Hbrush(nuint value) => new Hbrush(unchecked((void*)(value)));

    public static implicit operator nuint(Hbrush value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hbrush other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HBRUSH.");
    }

    public int CompareTo(Hbrush other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hbrush other) && Equals(other);

    public bool Equals(Hbrush other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
