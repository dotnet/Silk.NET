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

public readonly unsafe partial struct Hcertchainengine
    : IComparable,
        IComparable<Hcertchainengine>,
        IEquatable<Hcertchainengine>,
        IFormattable
{
    public readonly void* Value;

    public Hcertchainengine(void* value)
    {
        Value = value;
    }

    public static Hcertchainengine INVALID_VALUE => new Hcertchainengine((void*)(-1));
    public static Hcertchainengine NULL => new Hcertchainengine(null);

    public static bool operator ==(Hcertchainengine left, Hcertchainengine right) =>
        left.Value == right.Value;

    public static bool operator !=(Hcertchainengine left, Hcertchainengine right) =>
        left.Value != right.Value;

    public static bool operator <(Hcertchainengine left, Hcertchainengine right) =>
        left.Value < right.Value;

    public static bool operator <=(Hcertchainengine left, Hcertchainengine right) =>
        left.Value <= right.Value;

    public static bool operator >(Hcertchainengine left, Hcertchainengine right) =>
        left.Value > right.Value;

    public static bool operator >=(Hcertchainengine left, Hcertchainengine right) =>
        left.Value >= right.Value;

    public static explicit operator Hcertchainengine(void* value) => new Hcertchainengine(value);

    public static implicit operator void*(Hcertchainengine value) => value.Value;

    public static explicit operator Hcertchainengine(Handle value) => new Hcertchainengine(value);

    public static implicit operator Handle(Hcertchainengine value) => new Handle(value.Value);

    public static explicit operator Hcertchainengine(byte value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static explicit operator byte(Hcertchainengine value) => (byte)(value.Value);

    public static explicit operator Hcertchainengine(short value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static explicit operator short(Hcertchainengine value) => (short)(value.Value);

    public static explicit operator Hcertchainengine(int value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static explicit operator int(Hcertchainengine value) => (int)(value.Value);

    public static explicit operator Hcertchainengine(long value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static explicit operator long(Hcertchainengine value) => (long)(value.Value);

    public static explicit operator Hcertchainengine(nint value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static implicit operator nint(Hcertchainengine value) => (nint)(value.Value);

    public static explicit operator Hcertchainengine(sbyte value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcertchainengine value) => (sbyte)(value.Value);

    public static explicit operator Hcertchainengine(ushort value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static explicit operator ushort(Hcertchainengine value) => (ushort)(value.Value);

    public static explicit operator Hcertchainengine(uint value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static explicit operator uint(Hcertchainengine value) => (uint)(value.Value);

    public static explicit operator Hcertchainengine(ulong value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static explicit operator ulong(Hcertchainengine value) => (ulong)(value.Value);

    public static explicit operator Hcertchainengine(nuint value) =>
        new Hcertchainengine(unchecked((void*)(value)));

    public static implicit operator nuint(Hcertchainengine value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcertchainengine other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCERTCHAINENGINE.");
    }

    public int CompareTo(Hcertchainengine other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcertchainengine other) && Equals(other);

    public bool Equals(Hcertchainengine other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
