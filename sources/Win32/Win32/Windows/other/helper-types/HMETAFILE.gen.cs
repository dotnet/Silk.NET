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

public readonly unsafe partial struct Hmetafile
    : IComparable,
        IComparable<Hmetafile>,
        IEquatable<Hmetafile>,
        IFormattable
{
    public readonly void* Value;

    public Hmetafile(void* value)
    {
        Value = value;
    }

    public static Hmetafile INVALID_VALUE => new Hmetafile((void*)(-1));
    public static Hmetafile NULL => new Hmetafile(null);

    public static bool operator ==(Hmetafile left, Hmetafile right) => left.Value == right.Value;

    public static bool operator !=(Hmetafile left, Hmetafile right) => left.Value != right.Value;

    public static bool operator <(Hmetafile left, Hmetafile right) => left.Value < right.Value;

    public static bool operator <=(Hmetafile left, Hmetafile right) => left.Value <= right.Value;

    public static bool operator >(Hmetafile left, Hmetafile right) => left.Value > right.Value;

    public static bool operator >=(Hmetafile left, Hmetafile right) => left.Value >= right.Value;

    public static explicit operator Hmetafile(void* value) => new Hmetafile(value);

    public static implicit operator void*(Hmetafile value) => value.Value;

    public static explicit operator Hmetafile(Handle value) => new Hmetafile(value);

    public static implicit operator Handle(Hmetafile value) => new Handle(value.Value);

    public static explicit operator Hmetafile(byte value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static explicit operator byte(Hmetafile value) => (byte)(value.Value);

    public static explicit operator Hmetafile(short value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static explicit operator short(Hmetafile value) => (short)(value.Value);

    public static explicit operator Hmetafile(int value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static explicit operator int(Hmetafile value) => (int)(value.Value);

    public static explicit operator Hmetafile(long value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static explicit operator long(Hmetafile value) => (long)(value.Value);

    public static explicit operator Hmetafile(nint value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static implicit operator nint(Hmetafile value) => (nint)(value.Value);

    public static explicit operator Hmetafile(sbyte value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmetafile value) => (sbyte)(value.Value);

    public static explicit operator Hmetafile(ushort value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static explicit operator ushort(Hmetafile value) => (ushort)(value.Value);

    public static explicit operator Hmetafile(uint value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static explicit operator uint(Hmetafile value) => (uint)(value.Value);

    public static explicit operator Hmetafile(ulong value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static explicit operator ulong(Hmetafile value) => (ulong)(value.Value);

    public static explicit operator Hmetafile(nuint value) =>
        new Hmetafile(unchecked((void*)(value)));

    public static implicit operator nuint(Hmetafile value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmetafile other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMETAFILE.");
    }

    public int CompareTo(Hmetafile other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmetafile other) && Equals(other);

    public bool Equals(Hmetafile other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
