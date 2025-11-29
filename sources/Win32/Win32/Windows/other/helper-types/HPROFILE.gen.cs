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

public readonly unsafe partial struct Hprofile
    : IComparable,
        IComparable<Hprofile>,
        IEquatable<Hprofile>,
        IFormattable
{
    public readonly void* Value;

    public Hprofile(void* value)
    {
        Value = value;
    }

    public static Hprofile INVALID_VALUE => new Hprofile((void*)(-1));
    public static Hprofile NULL => new Hprofile(null);

    public static bool operator ==(Hprofile left, Hprofile right) => left.Value == right.Value;

    public static bool operator !=(Hprofile left, Hprofile right) => left.Value != right.Value;

    public static bool operator <(Hprofile left, Hprofile right) => left.Value < right.Value;

    public static bool operator <=(Hprofile left, Hprofile right) => left.Value <= right.Value;

    public static bool operator >(Hprofile left, Hprofile right) => left.Value > right.Value;

    public static bool operator >=(Hprofile left, Hprofile right) => left.Value >= right.Value;

    public static explicit operator Hprofile(void* value) => new Hprofile(value);

    public static implicit operator void*(Hprofile value) => value.Value;

    public static explicit operator Hprofile(Handle value) => new Hprofile(value);

    public static implicit operator Handle(Hprofile value) => new Handle(value.Value);

    public static explicit operator Hprofile(byte value) => new Hprofile(unchecked((void*)(value)));

    public static explicit operator byte(Hprofile value) => (byte)(value.Value);

    public static explicit operator Hprofile(short value) =>
        new Hprofile(unchecked((void*)(value)));

    public static explicit operator short(Hprofile value) => (short)(value.Value);

    public static explicit operator Hprofile(int value) => new Hprofile(unchecked((void*)(value)));

    public static explicit operator int(Hprofile value) => (int)(value.Value);

    public static explicit operator Hprofile(long value) => new Hprofile(unchecked((void*)(value)));

    public static explicit operator long(Hprofile value) => (long)(value.Value);

    public static explicit operator Hprofile(nint value) => new Hprofile(unchecked((void*)(value)));

    public static implicit operator nint(Hprofile value) => (nint)(value.Value);

    public static explicit operator Hprofile(sbyte value) =>
        new Hprofile(unchecked((void*)(value)));

    public static explicit operator sbyte(Hprofile value) => (sbyte)(value.Value);

    public static explicit operator Hprofile(ushort value) =>
        new Hprofile(unchecked((void*)(value)));

    public static explicit operator ushort(Hprofile value) => (ushort)(value.Value);

    public static explicit operator Hprofile(uint value) => new Hprofile(unchecked((void*)(value)));

    public static explicit operator uint(Hprofile value) => (uint)(value.Value);

    public static explicit operator Hprofile(ulong value) =>
        new Hprofile(unchecked((void*)(value)));

    public static explicit operator ulong(Hprofile value) => (ulong)(value.Value);

    public static explicit operator Hprofile(nuint value) =>
        new Hprofile(unchecked((void*)(value)));

    public static implicit operator nuint(Hprofile value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hprofile other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPROFILE.");
    }

    public int CompareTo(Hprofile other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hprofile other) && Equals(other);

    public bool Equals(Hprofile other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
