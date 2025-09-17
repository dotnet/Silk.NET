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

public readonly unsafe partial struct Hglrc
    : IComparable,
        IComparable<Hglrc>,
        IEquatable<Hglrc>,
        IFormattable
{
    public readonly void* Value;

    public Hglrc(void* value)
    {
        Value = value;
    }

    public static Hglrc INVALID_VALUE => new Hglrc((void*)(-1));
    public static Hglrc NULL => new Hglrc(null);

    public static bool operator ==(Hglrc left, Hglrc right) => left.Value == right.Value;

    public static bool operator !=(Hglrc left, Hglrc right) => left.Value != right.Value;

    public static bool operator <(Hglrc left, Hglrc right) => left.Value < right.Value;

    public static bool operator <=(Hglrc left, Hglrc right) => left.Value <= right.Value;

    public static bool operator >(Hglrc left, Hglrc right) => left.Value > right.Value;

    public static bool operator >=(Hglrc left, Hglrc right) => left.Value >= right.Value;

    public static explicit operator Hglrc(void* value) => new Hglrc(value);

    public static implicit operator void*(Hglrc value) => value.Value;

    public static explicit operator Hglrc(Handle value) => new Hglrc(value);

    public static implicit operator Handle(Hglrc value) => new Handle(value.Value);

    public static explicit operator Hglrc(byte value) => new Hglrc(unchecked((void*)(value)));

    public static explicit operator byte(Hglrc value) => (byte)(value.Value);

    public static explicit operator Hglrc(short value) => new Hglrc(unchecked((void*)(value)));

    public static explicit operator short(Hglrc value) => (short)(value.Value);

    public static explicit operator Hglrc(int value) => new Hglrc(unchecked((void*)(value)));

    public static explicit operator int(Hglrc value) => (int)(value.Value);

    public static explicit operator Hglrc(long value) => new Hglrc(unchecked((void*)(value)));

    public static explicit operator long(Hglrc value) => (long)(value.Value);

    public static explicit operator Hglrc(nint value) => new Hglrc(unchecked((void*)(value)));

    public static implicit operator nint(Hglrc value) => (nint)(value.Value);

    public static explicit operator Hglrc(sbyte value) => new Hglrc(unchecked((void*)(value)));

    public static explicit operator sbyte(Hglrc value) => (sbyte)(value.Value);

    public static explicit operator Hglrc(ushort value) => new Hglrc(unchecked((void*)(value)));

    public static explicit operator ushort(Hglrc value) => (ushort)(value.Value);

    public static explicit operator Hglrc(uint value) => new Hglrc(unchecked((void*)(value)));

    public static explicit operator uint(Hglrc value) => (uint)(value.Value);

    public static explicit operator Hglrc(ulong value) => new Hglrc(unchecked((void*)(value)));

    public static explicit operator ulong(Hglrc value) => (ulong)(value.Value);

    public static explicit operator Hglrc(nuint value) => new Hglrc(unchecked((void*)(value)));

    public static implicit operator nuint(Hglrc value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hglrc other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HGLRC.");
    }

    public int CompareTo(Hglrc other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hglrc other) && Equals(other);

    public bool Equals(Hglrc other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
