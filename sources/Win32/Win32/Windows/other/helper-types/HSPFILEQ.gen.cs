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

public readonly unsafe partial struct Hspfileq
    : IComparable,
        IComparable<Hspfileq>,
        IEquatable<Hspfileq>,
        IFormattable
{
    public readonly void* Value;

    public Hspfileq(void* value)
    {
        Value = value;
    }

    public static Hspfileq INVALID_VALUE => new Hspfileq((void*)(-1));
    public static Hspfileq NULL => new Hspfileq(null);

    public static bool operator ==(Hspfileq left, Hspfileq right) => left.Value == right.Value;

    public static bool operator !=(Hspfileq left, Hspfileq right) => left.Value != right.Value;

    public static bool operator <(Hspfileq left, Hspfileq right) => left.Value < right.Value;

    public static bool operator <=(Hspfileq left, Hspfileq right) => left.Value <= right.Value;

    public static bool operator >(Hspfileq left, Hspfileq right) => left.Value > right.Value;

    public static bool operator >=(Hspfileq left, Hspfileq right) => left.Value >= right.Value;

    public static explicit operator Hspfileq(void* value) => new Hspfileq(value);

    public static implicit operator void*(Hspfileq value) => value.Value;

    public static explicit operator Hspfileq(Handle value) => new Hspfileq(value);

    public static implicit operator Handle(Hspfileq value) => new Handle(value.Value);

    public static explicit operator Hspfileq(byte value) => new Hspfileq(unchecked((void*)(value)));

    public static explicit operator byte(Hspfileq value) => (byte)(value.Value);

    public static explicit operator Hspfileq(short value) =>
        new Hspfileq(unchecked((void*)(value)));

    public static explicit operator short(Hspfileq value) => (short)(value.Value);

    public static explicit operator Hspfileq(int value) => new Hspfileq(unchecked((void*)(value)));

    public static explicit operator int(Hspfileq value) => (int)(value.Value);

    public static explicit operator Hspfileq(long value) => new Hspfileq(unchecked((void*)(value)));

    public static explicit operator long(Hspfileq value) => (long)(value.Value);

    public static explicit operator Hspfileq(nint value) => new Hspfileq(unchecked((void*)(value)));

    public static implicit operator nint(Hspfileq value) => (nint)(value.Value);

    public static explicit operator Hspfileq(sbyte value) =>
        new Hspfileq(unchecked((void*)(value)));

    public static explicit operator sbyte(Hspfileq value) => (sbyte)(value.Value);

    public static explicit operator Hspfileq(ushort value) =>
        new Hspfileq(unchecked((void*)(value)));

    public static explicit operator ushort(Hspfileq value) => (ushort)(value.Value);

    public static explicit operator Hspfileq(uint value) => new Hspfileq(unchecked((void*)(value)));

    public static explicit operator uint(Hspfileq value) => (uint)(value.Value);

    public static explicit operator Hspfileq(ulong value) =>
        new Hspfileq(unchecked((void*)(value)));

    public static explicit operator ulong(Hspfileq value) => (ulong)(value.Value);

    public static explicit operator Hspfileq(nuint value) =>
        new Hspfileq(unchecked((void*)(value)));

    public static implicit operator nuint(Hspfileq value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hspfileq other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSPFILEQ.");
    }

    public int CompareTo(Hspfileq other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hspfileq other) && Equals(other);

    public bool Equals(Hspfileq other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
