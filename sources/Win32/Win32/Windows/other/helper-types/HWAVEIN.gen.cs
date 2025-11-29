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

public readonly unsafe partial struct Hwavein
    : IComparable,
        IComparable<Hwavein>,
        IEquatable<Hwavein>,
        IFormattable
{
    public readonly void* Value;

    public Hwavein(void* value)
    {
        Value = value;
    }

    public static Hwavein INVALID_VALUE => new Hwavein((void*)(-1));
    public static Hwavein NULL => new Hwavein(null);

    public static bool operator ==(Hwavein left, Hwavein right) => left.Value == right.Value;

    public static bool operator !=(Hwavein left, Hwavein right) => left.Value != right.Value;

    public static bool operator <(Hwavein left, Hwavein right) => left.Value < right.Value;

    public static bool operator <=(Hwavein left, Hwavein right) => left.Value <= right.Value;

    public static bool operator >(Hwavein left, Hwavein right) => left.Value > right.Value;

    public static bool operator >=(Hwavein left, Hwavein right) => left.Value >= right.Value;

    public static explicit operator Hwavein(void* value) => new Hwavein(value);

    public static implicit operator void*(Hwavein value) => value.Value;

    public static explicit operator Hwavein(Handle value) => new Hwavein(value);

    public static implicit operator Handle(Hwavein value) => new Handle(value.Value);

    public static explicit operator Hwavein(byte value) => new Hwavein(unchecked((void*)(value)));

    public static explicit operator byte(Hwavein value) => (byte)(value.Value);

    public static explicit operator Hwavein(short value) => new Hwavein(unchecked((void*)(value)));

    public static explicit operator short(Hwavein value) => (short)(value.Value);

    public static explicit operator Hwavein(int value) => new Hwavein(unchecked((void*)(value)));

    public static explicit operator int(Hwavein value) => (int)(value.Value);

    public static explicit operator Hwavein(long value) => new Hwavein(unchecked((void*)(value)));

    public static explicit operator long(Hwavein value) => (long)(value.Value);

    public static explicit operator Hwavein(nint value) => new Hwavein(unchecked((void*)(value)));

    public static implicit operator nint(Hwavein value) => (nint)(value.Value);

    public static explicit operator Hwavein(sbyte value) => new Hwavein(unchecked((void*)(value)));

    public static explicit operator sbyte(Hwavein value) => (sbyte)(value.Value);

    public static explicit operator Hwavein(ushort value) => new Hwavein(unchecked((void*)(value)));

    public static explicit operator ushort(Hwavein value) => (ushort)(value.Value);

    public static explicit operator Hwavein(uint value) => new Hwavein(unchecked((void*)(value)));

    public static explicit operator uint(Hwavein value) => (uint)(value.Value);

    public static explicit operator Hwavein(ulong value) => new Hwavein(unchecked((void*)(value)));

    public static explicit operator ulong(Hwavein value) => (ulong)(value.Value);

    public static explicit operator Hwavein(nuint value) => new Hwavein(unchecked((void*)(value)));

    public static implicit operator nuint(Hwavein value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hwavein other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HWAVEIN.");
    }

    public int CompareTo(Hwavein other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hwavein other) && Equals(other);

    public bool Equals(Hwavein other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
