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

public readonly unsafe partial struct Hmidiin
    : IComparable,
        IComparable<Hmidiin>,
        IEquatable<Hmidiin>,
        IFormattable
{
    public readonly void* Value;

    public Hmidiin(void* value)
    {
        Value = value;
    }

    public static Hmidiin INVALID_VALUE => new Hmidiin((void*)(-1));
    public static Hmidiin NULL => new Hmidiin(null);

    public static bool operator ==(Hmidiin left, Hmidiin right) => left.Value == right.Value;

    public static bool operator !=(Hmidiin left, Hmidiin right) => left.Value != right.Value;

    public static bool operator <(Hmidiin left, Hmidiin right) => left.Value < right.Value;

    public static bool operator <=(Hmidiin left, Hmidiin right) => left.Value <= right.Value;

    public static bool operator >(Hmidiin left, Hmidiin right) => left.Value > right.Value;

    public static bool operator >=(Hmidiin left, Hmidiin right) => left.Value >= right.Value;

    public static explicit operator Hmidiin(void* value) => new Hmidiin(value);

    public static implicit operator void*(Hmidiin value) => value.Value;

    public static explicit operator Hmidiin(Handle value) => new Hmidiin(value);

    public static implicit operator Handle(Hmidiin value) => new Handle(value.Value);

    public static explicit operator Hmidiin(byte value) => new Hmidiin(unchecked((void*)(value)));

    public static explicit operator byte(Hmidiin value) => (byte)(value.Value);

    public static explicit operator Hmidiin(short value) => new Hmidiin(unchecked((void*)(value)));

    public static explicit operator short(Hmidiin value) => (short)(value.Value);

    public static explicit operator Hmidiin(int value) => new Hmidiin(unchecked((void*)(value)));

    public static explicit operator int(Hmidiin value) => (int)(value.Value);

    public static explicit operator Hmidiin(long value) => new Hmidiin(unchecked((void*)(value)));

    public static explicit operator long(Hmidiin value) => (long)(value.Value);

    public static explicit operator Hmidiin(nint value) => new Hmidiin(unchecked((void*)(value)));

    public static implicit operator nint(Hmidiin value) => (nint)(value.Value);

    public static explicit operator Hmidiin(sbyte value) => new Hmidiin(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmidiin value) => (sbyte)(value.Value);

    public static explicit operator Hmidiin(ushort value) => new Hmidiin(unchecked((void*)(value)));

    public static explicit operator ushort(Hmidiin value) => (ushort)(value.Value);

    public static explicit operator Hmidiin(uint value) => new Hmidiin(unchecked((void*)(value)));

    public static explicit operator uint(Hmidiin value) => (uint)(value.Value);

    public static explicit operator Hmidiin(ulong value) => new Hmidiin(unchecked((void*)(value)));

    public static explicit operator ulong(Hmidiin value) => (ulong)(value.Value);

    public static explicit operator Hmidiin(nuint value) => new Hmidiin(unchecked((void*)(value)));

    public static implicit operator nuint(Hmidiin value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmidiin other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMIDIIN.");
    }

    public int CompareTo(Hmidiin other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmidiin other) && Equals(other);

    public bool Equals(Hmidiin other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
