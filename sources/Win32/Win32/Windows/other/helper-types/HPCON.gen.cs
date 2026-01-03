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

public readonly unsafe partial struct Hpcon
    : IComparable,
        IComparable<Hpcon>,
        IEquatable<Hpcon>,
        IFormattable
{
    public readonly void* Value;

    public Hpcon(void* value)
    {
        Value = value;
    }

    public static Hpcon INVALID_VALUE => new Hpcon((void*)(-1));
    public static Hpcon NULL => new Hpcon(null);

    public static bool operator ==(Hpcon left, Hpcon right) => left.Value == right.Value;

    public static bool operator !=(Hpcon left, Hpcon right) => left.Value != right.Value;

    public static bool operator <(Hpcon left, Hpcon right) => left.Value < right.Value;

    public static bool operator <=(Hpcon left, Hpcon right) => left.Value <= right.Value;

    public static bool operator >(Hpcon left, Hpcon right) => left.Value > right.Value;

    public static bool operator >=(Hpcon left, Hpcon right) => left.Value >= right.Value;

    public static explicit operator Hpcon(void* value) => new Hpcon(value);

    public static implicit operator void*(Hpcon value) => value.Value;

    public static explicit operator Hpcon(Handle value) => new Hpcon(value);

    public static implicit operator Handle(Hpcon value) => new Handle(value.Value);

    public static explicit operator Hpcon(byte value) => new Hpcon(unchecked((void*)(value)));

    public static explicit operator byte(Hpcon value) => (byte)(value.Value);

    public static explicit operator Hpcon(short value) => new Hpcon(unchecked((void*)(value)));

    public static explicit operator short(Hpcon value) => (short)(value.Value);

    public static explicit operator Hpcon(int value) => new Hpcon(unchecked((void*)(value)));

    public static explicit operator int(Hpcon value) => (int)(value.Value);

    public static explicit operator Hpcon(long value) => new Hpcon(unchecked((void*)(value)));

    public static explicit operator long(Hpcon value) => (long)(value.Value);

    public static explicit operator Hpcon(nint value) => new Hpcon(unchecked((void*)(value)));

    public static implicit operator nint(Hpcon value) => (nint)(value.Value);

    public static explicit operator Hpcon(sbyte value) => new Hpcon(unchecked((void*)(value)));

    public static explicit operator sbyte(Hpcon value) => (sbyte)(value.Value);

    public static explicit operator Hpcon(ushort value) => new Hpcon(unchecked((void*)(value)));

    public static explicit operator ushort(Hpcon value) => (ushort)(value.Value);

    public static explicit operator Hpcon(uint value) => new Hpcon(unchecked((void*)(value)));

    public static explicit operator uint(Hpcon value) => (uint)(value.Value);

    public static explicit operator Hpcon(ulong value) => new Hpcon(unchecked((void*)(value)));

    public static explicit operator ulong(Hpcon value) => (ulong)(value.Value);

    public static explicit operator Hpcon(nuint value) => new Hpcon(unchecked((void*)(value)));

    public static implicit operator nuint(Hpcon value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hpcon other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPCON.");
    }

    public int CompareTo(Hpcon other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hpcon other) && Equals(other);

    public bool Equals(Hpcon other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
