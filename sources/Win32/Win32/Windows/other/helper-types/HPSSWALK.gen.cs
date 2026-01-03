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

public readonly unsafe partial struct Hpsswalk
    : IComparable,
        IComparable<Hpsswalk>,
        IEquatable<Hpsswalk>,
        IFormattable
{
    public readonly void* Value;

    public Hpsswalk(void* value)
    {
        Value = value;
    }

    public static Hpsswalk INVALID_VALUE => new Hpsswalk((void*)(-1));
    public static Hpsswalk NULL => new Hpsswalk(null);

    public static bool operator ==(Hpsswalk left, Hpsswalk right) => left.Value == right.Value;

    public static bool operator !=(Hpsswalk left, Hpsswalk right) => left.Value != right.Value;

    public static bool operator <(Hpsswalk left, Hpsswalk right) => left.Value < right.Value;

    public static bool operator <=(Hpsswalk left, Hpsswalk right) => left.Value <= right.Value;

    public static bool operator >(Hpsswalk left, Hpsswalk right) => left.Value > right.Value;

    public static bool operator >=(Hpsswalk left, Hpsswalk right) => left.Value >= right.Value;

    public static explicit operator Hpsswalk(void* value) => new Hpsswalk(value);

    public static implicit operator void*(Hpsswalk value) => value.Value;

    public static explicit operator Hpsswalk(Handle value) => new Hpsswalk(value);

    public static implicit operator Handle(Hpsswalk value) => new Handle(value.Value);

    public static explicit operator Hpsswalk(byte value) => new Hpsswalk(unchecked((void*)(value)));

    public static explicit operator byte(Hpsswalk value) => (byte)(value.Value);

    public static explicit operator Hpsswalk(short value) =>
        new Hpsswalk(unchecked((void*)(value)));

    public static explicit operator short(Hpsswalk value) => (short)(value.Value);

    public static explicit operator Hpsswalk(int value) => new Hpsswalk(unchecked((void*)(value)));

    public static explicit operator int(Hpsswalk value) => (int)(value.Value);

    public static explicit operator Hpsswalk(long value) => new Hpsswalk(unchecked((void*)(value)));

    public static explicit operator long(Hpsswalk value) => (long)(value.Value);

    public static explicit operator Hpsswalk(nint value) => new Hpsswalk(unchecked((void*)(value)));

    public static implicit operator nint(Hpsswalk value) => (nint)(value.Value);

    public static explicit operator Hpsswalk(sbyte value) =>
        new Hpsswalk(unchecked((void*)(value)));

    public static explicit operator sbyte(Hpsswalk value) => (sbyte)(value.Value);

    public static explicit operator Hpsswalk(ushort value) =>
        new Hpsswalk(unchecked((void*)(value)));

    public static explicit operator ushort(Hpsswalk value) => (ushort)(value.Value);

    public static explicit operator Hpsswalk(uint value) => new Hpsswalk(unchecked((void*)(value)));

    public static explicit operator uint(Hpsswalk value) => (uint)(value.Value);

    public static explicit operator Hpsswalk(ulong value) =>
        new Hpsswalk(unchecked((void*)(value)));

    public static explicit operator ulong(Hpsswalk value) => (ulong)(value.Value);

    public static explicit operator Hpsswalk(nuint value) =>
        new Hpsswalk(unchecked((void*)(value)));

    public static implicit operator nuint(Hpsswalk value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hpsswalk other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPSSWALK.");
    }

    public int CompareTo(Hpsswalk other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hpsswalk other) && Equals(other);

    public bool Equals(Hpsswalk other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
