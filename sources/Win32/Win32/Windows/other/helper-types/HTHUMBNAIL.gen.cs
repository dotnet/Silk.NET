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

public readonly unsafe partial struct Hthumbnail
    : IComparable,
        IComparable<Hthumbnail>,
        IEquatable<Hthumbnail>,
        IFormattable
{
    public readonly void* Value;

    public Hthumbnail(void* value)
    {
        Value = value;
    }

    public static Hthumbnail INVALID_VALUE => new Hthumbnail((void*)(-1));
    public static Hthumbnail NULL => new Hthumbnail(null);

    public static bool operator ==(Hthumbnail left, Hthumbnail right) => left.Value == right.Value;

    public static bool operator !=(Hthumbnail left, Hthumbnail right) => left.Value != right.Value;

    public static bool operator <(Hthumbnail left, Hthumbnail right) => left.Value < right.Value;

    public static bool operator <=(Hthumbnail left, Hthumbnail right) => left.Value <= right.Value;

    public static bool operator >(Hthumbnail left, Hthumbnail right) => left.Value > right.Value;

    public static bool operator >=(Hthumbnail left, Hthumbnail right) => left.Value >= right.Value;

    public static explicit operator Hthumbnail(void* value) => new Hthumbnail(value);

    public static implicit operator void*(Hthumbnail value) => value.Value;

    public static explicit operator Hthumbnail(Handle value) => new Hthumbnail(value);

    public static implicit operator Handle(Hthumbnail value) => new Handle(value.Value);

    public static explicit operator Hthumbnail(byte value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static explicit operator byte(Hthumbnail value) => (byte)(value.Value);

    public static explicit operator Hthumbnail(short value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static explicit operator short(Hthumbnail value) => (short)(value.Value);

    public static explicit operator Hthumbnail(int value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static explicit operator int(Hthumbnail value) => (int)(value.Value);

    public static explicit operator Hthumbnail(long value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static explicit operator long(Hthumbnail value) => (long)(value.Value);

    public static explicit operator Hthumbnail(nint value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static implicit operator nint(Hthumbnail value) => (nint)(value.Value);

    public static explicit operator Hthumbnail(sbyte value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static explicit operator sbyte(Hthumbnail value) => (sbyte)(value.Value);

    public static explicit operator Hthumbnail(ushort value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static explicit operator ushort(Hthumbnail value) => (ushort)(value.Value);

    public static explicit operator Hthumbnail(uint value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static explicit operator uint(Hthumbnail value) => (uint)(value.Value);

    public static explicit operator Hthumbnail(ulong value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static explicit operator ulong(Hthumbnail value) => (ulong)(value.Value);

    public static explicit operator Hthumbnail(nuint value) =>
        new Hthumbnail(unchecked((void*)(value)));

    public static implicit operator nuint(Hthumbnail value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hthumbnail other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HTHUMBNAIL.");
    }

    public int CompareTo(Hthumbnail other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hthumbnail other) && Equals(other);

    public bool Equals(Hthumbnail other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
