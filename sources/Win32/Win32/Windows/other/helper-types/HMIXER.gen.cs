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

public readonly unsafe partial struct Hmixer
    : IComparable,
        IComparable<Hmixer>,
        IEquatable<Hmixer>,
        IFormattable
{
    public readonly void* Value;

    public Hmixer(void* value)
    {
        Value = value;
    }

    public static Hmixer INVALID_VALUE => new Hmixer((void*)(-1));
    public static Hmixer NULL => new Hmixer(null);

    public static bool operator ==(Hmixer left, Hmixer right) => left.Value == right.Value;

    public static bool operator !=(Hmixer left, Hmixer right) => left.Value != right.Value;

    public static bool operator <(Hmixer left, Hmixer right) => left.Value < right.Value;

    public static bool operator <=(Hmixer left, Hmixer right) => left.Value <= right.Value;

    public static bool operator >(Hmixer left, Hmixer right) => left.Value > right.Value;

    public static bool operator >=(Hmixer left, Hmixer right) => left.Value >= right.Value;

    public static explicit operator Hmixer(void* value) => new Hmixer(value);

    public static implicit operator void*(Hmixer value) => value.Value;

    public static explicit operator Hmixer(Handle value) => new Hmixer(value);

    public static implicit operator Handle(Hmixer value) => new Handle(value.Value);

    public static explicit operator Hmixer(byte value) => new Hmixer(unchecked((void*)(value)));

    public static explicit operator byte(Hmixer value) => (byte)(value.Value);

    public static explicit operator Hmixer(short value) => new Hmixer(unchecked((void*)(value)));

    public static explicit operator short(Hmixer value) => (short)(value.Value);

    public static explicit operator Hmixer(int value) => new Hmixer(unchecked((void*)(value)));

    public static explicit operator int(Hmixer value) => (int)(value.Value);

    public static explicit operator Hmixer(long value) => new Hmixer(unchecked((void*)(value)));

    public static explicit operator long(Hmixer value) => (long)(value.Value);

    public static explicit operator Hmixer(nint value) => new Hmixer(unchecked((void*)(value)));

    public static implicit operator nint(Hmixer value) => (nint)(value.Value);

    public static explicit operator Hmixer(sbyte value) => new Hmixer(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmixer value) => (sbyte)(value.Value);

    public static explicit operator Hmixer(ushort value) => new Hmixer(unchecked((void*)(value)));

    public static explicit operator ushort(Hmixer value) => (ushort)(value.Value);

    public static explicit operator Hmixer(uint value) => new Hmixer(unchecked((void*)(value)));

    public static explicit operator uint(Hmixer value) => (uint)(value.Value);

    public static explicit operator Hmixer(ulong value) => new Hmixer(unchecked((void*)(value)));

    public static explicit operator ulong(Hmixer value) => (ulong)(value.Value);

    public static explicit operator Hmixer(nuint value) => new Hmixer(unchecked((void*)(value)));

    public static implicit operator nuint(Hmixer value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmixer other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMIXER.");
    }

    public int CompareTo(Hmixer other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmixer other) && Equals(other);

    public bool Equals(Hmixer other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
