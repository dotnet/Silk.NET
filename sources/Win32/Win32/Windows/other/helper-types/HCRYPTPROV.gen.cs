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

public readonly unsafe partial struct Hcryptprov
    : IComparable,
        IComparable<Hcryptprov>,
        IEquatable<Hcryptprov>,
        IFormattable
{
    public readonly void* Value;

    public Hcryptprov(void* value)
    {
        Value = value;
    }

    public static Hcryptprov INVALID_VALUE => new Hcryptprov((void*)(-1));
    public static Hcryptprov NULL => new Hcryptprov(null);

    public static bool operator ==(Hcryptprov left, Hcryptprov right) => left.Value == right.Value;

    public static bool operator !=(Hcryptprov left, Hcryptprov right) => left.Value != right.Value;

    public static bool operator <(Hcryptprov left, Hcryptprov right) => left.Value < right.Value;

    public static bool operator <=(Hcryptprov left, Hcryptprov right) => left.Value <= right.Value;

    public static bool operator >(Hcryptprov left, Hcryptprov right) => left.Value > right.Value;

    public static bool operator >=(Hcryptprov left, Hcryptprov right) => left.Value >= right.Value;

    public static explicit operator Hcryptprov(void* value) => new Hcryptprov(value);

    public static implicit operator void*(Hcryptprov value) => value.Value;

    public static explicit operator Hcryptprov(Handle value) => new Hcryptprov(value);

    public static implicit operator Handle(Hcryptprov value) => new Handle(value.Value);

    public static explicit operator Hcryptprov(byte value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static explicit operator byte(Hcryptprov value) => (byte)(value.Value);

    public static explicit operator Hcryptprov(short value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static explicit operator short(Hcryptprov value) => (short)(value.Value);

    public static explicit operator Hcryptprov(int value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static explicit operator int(Hcryptprov value) => (int)(value.Value);

    public static explicit operator Hcryptprov(long value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static explicit operator long(Hcryptprov value) => (long)(value.Value);

    public static explicit operator Hcryptprov(nint value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static implicit operator nint(Hcryptprov value) => (nint)(value.Value);

    public static explicit operator Hcryptprov(sbyte value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcryptprov value) => (sbyte)(value.Value);

    public static explicit operator Hcryptprov(ushort value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static explicit operator ushort(Hcryptprov value) => (ushort)(value.Value);

    public static explicit operator Hcryptprov(uint value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static explicit operator uint(Hcryptprov value) => (uint)(value.Value);

    public static explicit operator Hcryptprov(ulong value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static explicit operator ulong(Hcryptprov value) => (ulong)(value.Value);

    public static explicit operator Hcryptprov(nuint value) =>
        new Hcryptprov(unchecked((void*)(value)));

    public static implicit operator nuint(Hcryptprov value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcryptprov other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTPROV.");
    }

    public int CompareTo(Hcryptprov other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcryptprov other) && Equals(other);

    public bool Equals(Hcryptprov other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
