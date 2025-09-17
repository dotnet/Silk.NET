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

public readonly unsafe partial struct Hwinsta
    : IComparable,
        IComparable<Hwinsta>,
        IEquatable<Hwinsta>,
        IFormattable
{
    public readonly void* Value;

    public Hwinsta(void* value)
    {
        Value = value;
    }

    public static Hwinsta INVALID_VALUE => new Hwinsta((void*)(-1));
    public static Hwinsta NULL => new Hwinsta(null);

    public static bool operator ==(Hwinsta left, Hwinsta right) => left.Value == right.Value;

    public static bool operator !=(Hwinsta left, Hwinsta right) => left.Value != right.Value;

    public static bool operator <(Hwinsta left, Hwinsta right) => left.Value < right.Value;

    public static bool operator <=(Hwinsta left, Hwinsta right) => left.Value <= right.Value;

    public static bool operator >(Hwinsta left, Hwinsta right) => left.Value > right.Value;

    public static bool operator >=(Hwinsta left, Hwinsta right) => left.Value >= right.Value;

    public static explicit operator Hwinsta(void* value) => new Hwinsta(value);

    public static implicit operator void*(Hwinsta value) => value.Value;

    public static explicit operator Hwinsta(Handle value) => new Hwinsta(value);

    public static implicit operator Handle(Hwinsta value) => new Handle(value.Value);

    public static explicit operator Hwinsta(byte value) => new Hwinsta(unchecked((void*)(value)));

    public static explicit operator byte(Hwinsta value) => (byte)(value.Value);

    public static explicit operator Hwinsta(short value) => new Hwinsta(unchecked((void*)(value)));

    public static explicit operator short(Hwinsta value) => (short)(value.Value);

    public static explicit operator Hwinsta(int value) => new Hwinsta(unchecked((void*)(value)));

    public static explicit operator int(Hwinsta value) => (int)(value.Value);

    public static explicit operator Hwinsta(long value) => new Hwinsta(unchecked((void*)(value)));

    public static explicit operator long(Hwinsta value) => (long)(value.Value);

    public static explicit operator Hwinsta(nint value) => new Hwinsta(unchecked((void*)(value)));

    public static implicit operator nint(Hwinsta value) => (nint)(value.Value);

    public static explicit operator Hwinsta(sbyte value) => new Hwinsta(unchecked((void*)(value)));

    public static explicit operator sbyte(Hwinsta value) => (sbyte)(value.Value);

    public static explicit operator Hwinsta(ushort value) => new Hwinsta(unchecked((void*)(value)));

    public static explicit operator ushort(Hwinsta value) => (ushort)(value.Value);

    public static explicit operator Hwinsta(uint value) => new Hwinsta(unchecked((void*)(value)));

    public static explicit operator uint(Hwinsta value) => (uint)(value.Value);

    public static explicit operator Hwinsta(ulong value) => new Hwinsta(unchecked((void*)(value)));

    public static explicit operator ulong(Hwinsta value) => (ulong)(value.Value);

    public static explicit operator Hwinsta(nuint value) => new Hwinsta(unchecked((void*)(value)));

    public static implicit operator nuint(Hwinsta value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hwinsta other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HWINSTA.");
    }

    public int CompareTo(Hwinsta other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hwinsta other) && Equals(other);

    public bool Equals(Hwinsta other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
