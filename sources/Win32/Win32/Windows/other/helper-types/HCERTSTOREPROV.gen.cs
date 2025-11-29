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

public readonly unsafe partial struct Hcertstoreprov
    : IComparable,
        IComparable<Hcertstoreprov>,
        IEquatable<Hcertstoreprov>,
        IFormattable
{
    public readonly void* Value;

    public Hcertstoreprov(void* value)
    {
        Value = value;
    }

    public static Hcertstoreprov INVALID_VALUE => new Hcertstoreprov((void*)(-1));
    public static Hcertstoreprov NULL => new Hcertstoreprov(null);

    public static bool operator ==(Hcertstoreprov left, Hcertstoreprov right) =>
        left.Value == right.Value;

    public static bool operator !=(Hcertstoreprov left, Hcertstoreprov right) =>
        left.Value != right.Value;

    public static bool operator <(Hcertstoreprov left, Hcertstoreprov right) =>
        left.Value < right.Value;

    public static bool operator <=(Hcertstoreprov left, Hcertstoreprov right) =>
        left.Value <= right.Value;

    public static bool operator >(Hcertstoreprov left, Hcertstoreprov right) =>
        left.Value > right.Value;

    public static bool operator >=(Hcertstoreprov left, Hcertstoreprov right) =>
        left.Value >= right.Value;

    public static explicit operator Hcertstoreprov(void* value) => new Hcertstoreprov(value);

    public static implicit operator void*(Hcertstoreprov value) => value.Value;

    public static explicit operator Hcertstoreprov(Handle value) => new Hcertstoreprov(value);

    public static implicit operator Handle(Hcertstoreprov value) => new Handle(value.Value);

    public static explicit operator Hcertstoreprov(byte value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static explicit operator byte(Hcertstoreprov value) => (byte)(value.Value);

    public static explicit operator Hcertstoreprov(short value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static explicit operator short(Hcertstoreprov value) => (short)(value.Value);

    public static explicit operator Hcertstoreprov(int value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static explicit operator int(Hcertstoreprov value) => (int)(value.Value);

    public static explicit operator Hcertstoreprov(long value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static explicit operator long(Hcertstoreprov value) => (long)(value.Value);

    public static explicit operator Hcertstoreprov(nint value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static implicit operator nint(Hcertstoreprov value) => (nint)(value.Value);

    public static explicit operator Hcertstoreprov(sbyte value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcertstoreprov value) => (sbyte)(value.Value);

    public static explicit operator Hcertstoreprov(ushort value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static explicit operator ushort(Hcertstoreprov value) => (ushort)(value.Value);

    public static explicit operator Hcertstoreprov(uint value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static explicit operator uint(Hcertstoreprov value) => (uint)(value.Value);

    public static explicit operator Hcertstoreprov(ulong value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static explicit operator ulong(Hcertstoreprov value) => (ulong)(value.Value);

    public static explicit operator Hcertstoreprov(nuint value) =>
        new Hcertstoreprov(unchecked((void*)(value)));

    public static implicit operator nuint(Hcertstoreprov value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcertstoreprov other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCERTSTOREPROV.");
    }

    public int CompareTo(Hcertstoreprov other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcertstoreprov other) && Equals(other);

    public bool Equals(Hcertstoreprov other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
