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

public readonly unsafe partial struct Huskey
    : IComparable,
        IComparable<Huskey>,
        IEquatable<Huskey>,
        IFormattable
{
    public readonly void* Value;

    public Huskey(void* value)
    {
        Value = value;
    }

    public static Huskey INVALID_VALUE => new Huskey((void*)(-1));
    public static Huskey NULL => new Huskey(null);

    public static bool operator ==(Huskey left, Huskey right) => left.Value == right.Value;

    public static bool operator !=(Huskey left, Huskey right) => left.Value != right.Value;

    public static bool operator <(Huskey left, Huskey right) => left.Value < right.Value;

    public static bool operator <=(Huskey left, Huskey right) => left.Value <= right.Value;

    public static bool operator >(Huskey left, Huskey right) => left.Value > right.Value;

    public static bool operator >=(Huskey left, Huskey right) => left.Value >= right.Value;

    public static explicit operator Huskey(void* value) => new Huskey(value);

    public static implicit operator void*(Huskey value) => value.Value;

    public static explicit operator Huskey(Handle value) => new Huskey(value);

    public static implicit operator Handle(Huskey value) => new Handle(value.Value);

    public static explicit operator Huskey(byte value) => new Huskey(unchecked((void*)(value)));

    public static explicit operator byte(Huskey value) => (byte)(value.Value);

    public static explicit operator Huskey(short value) => new Huskey(unchecked((void*)(value)));

    public static explicit operator short(Huskey value) => (short)(value.Value);

    public static explicit operator Huskey(int value) => new Huskey(unchecked((void*)(value)));

    public static explicit operator int(Huskey value) => (int)(value.Value);

    public static explicit operator Huskey(long value) => new Huskey(unchecked((void*)(value)));

    public static explicit operator long(Huskey value) => (long)(value.Value);

    public static explicit operator Huskey(nint value) => new Huskey(unchecked((void*)(value)));

    public static implicit operator nint(Huskey value) => (nint)(value.Value);

    public static explicit operator Huskey(sbyte value) => new Huskey(unchecked((void*)(value)));

    public static explicit operator sbyte(Huskey value) => (sbyte)(value.Value);

    public static explicit operator Huskey(ushort value) => new Huskey(unchecked((void*)(value)));

    public static explicit operator ushort(Huskey value) => (ushort)(value.Value);

    public static explicit operator Huskey(uint value) => new Huskey(unchecked((void*)(value)));

    public static explicit operator uint(Huskey value) => (uint)(value.Value);

    public static explicit operator Huskey(ulong value) => new Huskey(unchecked((void*)(value)));

    public static explicit operator ulong(Huskey value) => (ulong)(value.Value);

    public static explicit operator Huskey(nuint value) => new Huskey(unchecked((void*)(value)));

    public static implicit operator nuint(Huskey value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Huskey other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HUSKEY.");
    }

    public int CompareTo(Huskey other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Huskey other) && Equals(other);

    public bool Equals(Huskey other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
