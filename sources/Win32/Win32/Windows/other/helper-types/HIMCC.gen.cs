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

public readonly unsafe partial struct Himcc
    : IComparable,
        IComparable<Himcc>,
        IEquatable<Himcc>,
        IFormattable
{
    public readonly void* Value;

    public Himcc(void* value)
    {
        Value = value;
    }

    public static Himcc INVALID_VALUE => new Himcc((void*)(-1));
    public static Himcc NULL => new Himcc(null);

    public static bool operator ==(Himcc left, Himcc right) => left.Value == right.Value;

    public static bool operator !=(Himcc left, Himcc right) => left.Value != right.Value;

    public static bool operator <(Himcc left, Himcc right) => left.Value < right.Value;

    public static bool operator <=(Himcc left, Himcc right) => left.Value <= right.Value;

    public static bool operator >(Himcc left, Himcc right) => left.Value > right.Value;

    public static bool operator >=(Himcc left, Himcc right) => left.Value >= right.Value;

    public static explicit operator Himcc(void* value) => new Himcc(value);

    public static implicit operator void*(Himcc value) => value.Value;

    public static explicit operator Himcc(Handle value) => new Himcc(value);

    public static implicit operator Handle(Himcc value) => new Handle(value.Value);

    public static explicit operator Himcc(byte value) => new Himcc(unchecked((void*)(value)));

    public static explicit operator byte(Himcc value) => (byte)(value.Value);

    public static explicit operator Himcc(short value) => new Himcc(unchecked((void*)(value)));

    public static explicit operator short(Himcc value) => (short)(value.Value);

    public static explicit operator Himcc(int value) => new Himcc(unchecked((void*)(value)));

    public static explicit operator int(Himcc value) => (int)(value.Value);

    public static explicit operator Himcc(long value) => new Himcc(unchecked((void*)(value)));

    public static explicit operator long(Himcc value) => (long)(value.Value);

    public static explicit operator Himcc(nint value) => new Himcc(unchecked((void*)(value)));

    public static implicit operator nint(Himcc value) => (nint)(value.Value);

    public static explicit operator Himcc(sbyte value) => new Himcc(unchecked((void*)(value)));

    public static explicit operator sbyte(Himcc value) => (sbyte)(value.Value);

    public static explicit operator Himcc(ushort value) => new Himcc(unchecked((void*)(value)));

    public static explicit operator ushort(Himcc value) => (ushort)(value.Value);

    public static explicit operator Himcc(uint value) => new Himcc(unchecked((void*)(value)));

    public static explicit operator uint(Himcc value) => (uint)(value.Value);

    public static explicit operator Himcc(ulong value) => new Himcc(unchecked((void*)(value)));

    public static explicit operator ulong(Himcc value) => (ulong)(value.Value);

    public static explicit operator Himcc(nuint value) => new Himcc(unchecked((void*)(value)));

    public static implicit operator nuint(Himcc value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Himcc other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HIMCC.");
    }

    public int CompareTo(Himcc other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Himcc other) && Equals(other);

    public bool Equals(Himcc other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
