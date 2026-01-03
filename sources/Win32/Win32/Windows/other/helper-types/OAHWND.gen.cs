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
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct Oahwnd
    : IComparable,
        IComparable<Oahwnd>,
        IEquatable<Oahwnd>,
        IFormattable
{
    public readonly void* Value;

    public Oahwnd(void* value)
    {
        Value = value;
    }

    public static Oahwnd NULL => new Oahwnd(null);

    public static bool operator ==(Oahwnd left, Oahwnd right) => left.Value == right.Value;

    public static bool operator !=(Oahwnd left, Oahwnd right) => left.Value != right.Value;

    public static bool operator <(Oahwnd left, Oahwnd right) => left.Value < right.Value;

    public static bool operator <=(Oahwnd left, Oahwnd right) => left.Value <= right.Value;

    public static bool operator >(Oahwnd left, Oahwnd right) => left.Value > right.Value;

    public static bool operator >=(Oahwnd left, Oahwnd right) => left.Value >= right.Value;

    public static explicit operator Oahwnd(void* value) => new Oahwnd(value);

    public static implicit operator void*(Oahwnd value) => value.Value;

    public static explicit operator Oahwnd(byte value) => new Oahwnd(unchecked((void*)(value)));

    public static explicit operator byte(Oahwnd value) => (byte)(value.Value);

    public static explicit operator Oahwnd(short value) => new Oahwnd(unchecked((void*)(value)));

    public static explicit operator short(Oahwnd value) => (short)(value.Value);

    public static explicit operator Oahwnd(int value) => new Oahwnd(unchecked((void*)(value)));

    public static explicit operator int(Oahwnd value) => (int)(value.Value);

    public static explicit operator Oahwnd(long value) => new Oahwnd(unchecked((void*)(value)));

    public static explicit operator long(Oahwnd value) => (long)(value.Value);

    public static explicit operator Oahwnd(nint value) => new Oahwnd(unchecked((void*)(value)));

    public static implicit operator nint(Oahwnd value) => (nint)(value.Value);

    public static explicit operator Oahwnd(sbyte value) => new Oahwnd(unchecked((void*)(value)));

    public static explicit operator sbyte(Oahwnd value) => (sbyte)(value.Value);

    public static explicit operator Oahwnd(ushort value) => new Oahwnd(unchecked((void*)(value)));

    public static explicit operator ushort(Oahwnd value) => (ushort)(value.Value);

    public static explicit operator Oahwnd(uint value) => new Oahwnd(unchecked((void*)(value)));

    public static explicit operator uint(Oahwnd value) => (uint)(value.Value);

    public static explicit operator Oahwnd(ulong value) => new Oahwnd(unchecked((void*)(value)));

    public static explicit operator ulong(Oahwnd value) => (ulong)(value.Value);

    public static explicit operator Oahwnd(nuint value) => new Oahwnd(unchecked((void*)(value)));

    public static implicit operator nuint(Oahwnd value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Oahwnd other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of OAHWND.");
    }

    public int CompareTo(Oahwnd other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Oahwnd other) && Equals(other);

    public bool Equals(Oahwnd other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
