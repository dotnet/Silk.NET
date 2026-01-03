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

public readonly unsafe partial struct Hmidi
    : IComparable,
        IComparable<Hmidi>,
        IEquatable<Hmidi>,
        IFormattable
{
    public readonly void* Value;

    public Hmidi(void* value)
    {
        Value = value;
    }

    public static Hmidi INVALID_VALUE => new Hmidi((void*)(-1));
    public static Hmidi NULL => new Hmidi(null);

    public static bool operator ==(Hmidi left, Hmidi right) => left.Value == right.Value;

    public static bool operator !=(Hmidi left, Hmidi right) => left.Value != right.Value;

    public static bool operator <(Hmidi left, Hmidi right) => left.Value < right.Value;

    public static bool operator <=(Hmidi left, Hmidi right) => left.Value <= right.Value;

    public static bool operator >(Hmidi left, Hmidi right) => left.Value > right.Value;

    public static bool operator >=(Hmidi left, Hmidi right) => left.Value >= right.Value;

    public static explicit operator Hmidi(void* value) => new Hmidi(value);

    public static implicit operator void*(Hmidi value) => value.Value;

    public static explicit operator Hmidi(Handle value) => new Hmidi(value);

    public static implicit operator Handle(Hmidi value) => new Handle(value.Value);

    public static explicit operator Hmidi(byte value) => new Hmidi(unchecked((void*)(value)));

    public static explicit operator byte(Hmidi value) => (byte)(value.Value);

    public static explicit operator Hmidi(short value) => new Hmidi(unchecked((void*)(value)));

    public static explicit operator short(Hmidi value) => (short)(value.Value);

    public static explicit operator Hmidi(int value) => new Hmidi(unchecked((void*)(value)));

    public static explicit operator int(Hmidi value) => (int)(value.Value);

    public static explicit operator Hmidi(long value) => new Hmidi(unchecked((void*)(value)));

    public static explicit operator long(Hmidi value) => (long)(value.Value);

    public static explicit operator Hmidi(nint value) => new Hmidi(unchecked((void*)(value)));

    public static implicit operator nint(Hmidi value) => (nint)(value.Value);

    public static explicit operator Hmidi(sbyte value) => new Hmidi(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmidi value) => (sbyte)(value.Value);

    public static explicit operator Hmidi(ushort value) => new Hmidi(unchecked((void*)(value)));

    public static explicit operator ushort(Hmidi value) => (ushort)(value.Value);

    public static explicit operator Hmidi(uint value) => new Hmidi(unchecked((void*)(value)));

    public static explicit operator uint(Hmidi value) => (uint)(value.Value);

    public static explicit operator Hmidi(ulong value) => new Hmidi(unchecked((void*)(value)));

    public static explicit operator ulong(Hmidi value) => (ulong)(value.Value);

    public static explicit operator Hmidi(nuint value) => new Hmidi(unchecked((void*)(value)));

    public static implicit operator nuint(Hmidi value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmidi other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMIDI.");
    }

    public int CompareTo(Hmidi other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmidi other) && Equals(other);

    public bool Equals(Hmidi other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
