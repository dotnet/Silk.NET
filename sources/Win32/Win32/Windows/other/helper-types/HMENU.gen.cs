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

public readonly unsafe partial struct Hmenu
    : IComparable,
        IComparable<Hmenu>,
        IEquatable<Hmenu>,
        IFormattable
{
    public readonly void* Value;

    public Hmenu(void* value)
    {
        Value = value;
    }

    public static Hmenu INVALID_VALUE => new Hmenu((void*)(-1));
    public static Hmenu NULL => new Hmenu(null);

    public static bool operator ==(Hmenu left, Hmenu right) => left.Value == right.Value;

    public static bool operator !=(Hmenu left, Hmenu right) => left.Value != right.Value;

    public static bool operator <(Hmenu left, Hmenu right) => left.Value < right.Value;

    public static bool operator <=(Hmenu left, Hmenu right) => left.Value <= right.Value;

    public static bool operator >(Hmenu left, Hmenu right) => left.Value > right.Value;

    public static bool operator >=(Hmenu left, Hmenu right) => left.Value >= right.Value;

    public static explicit operator Hmenu(void* value) => new Hmenu(value);

    public static implicit operator void*(Hmenu value) => value.Value;

    public static explicit operator Hmenu(Handle value) => new Hmenu(value);

    public static implicit operator Handle(Hmenu value) => new Handle(value.Value);

    public static explicit operator Hmenu(byte value) => new Hmenu(unchecked((void*)(value)));

    public static explicit operator byte(Hmenu value) => (byte)(value.Value);

    public static explicit operator Hmenu(short value) => new Hmenu(unchecked((void*)(value)));

    public static explicit operator short(Hmenu value) => (short)(value.Value);

    public static explicit operator Hmenu(int value) => new Hmenu(unchecked((void*)(value)));

    public static explicit operator int(Hmenu value) => (int)(value.Value);

    public static explicit operator Hmenu(long value) => new Hmenu(unchecked((void*)(value)));

    public static explicit operator long(Hmenu value) => (long)(value.Value);

    public static explicit operator Hmenu(nint value) => new Hmenu(unchecked((void*)(value)));

    public static implicit operator nint(Hmenu value) => (nint)(value.Value);

    public static explicit operator Hmenu(sbyte value) => new Hmenu(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmenu value) => (sbyte)(value.Value);

    public static explicit operator Hmenu(ushort value) => new Hmenu(unchecked((void*)(value)));

    public static explicit operator ushort(Hmenu value) => (ushort)(value.Value);

    public static explicit operator Hmenu(uint value) => new Hmenu(unchecked((void*)(value)));

    public static explicit operator uint(Hmenu value) => (uint)(value.Value);

    public static explicit operator Hmenu(ulong value) => new Hmenu(unchecked((void*)(value)));

    public static explicit operator ulong(Hmenu value) => (ulong)(value.Value);

    public static explicit operator Hmenu(nuint value) => new Hmenu(unchecked((void*)(value)));

    public static implicit operator nuint(Hmenu value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmenu other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMENU.");
    }

    public int CompareTo(Hmenu other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmenu other) && Equals(other);

    public bool Equals(Hmenu other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
