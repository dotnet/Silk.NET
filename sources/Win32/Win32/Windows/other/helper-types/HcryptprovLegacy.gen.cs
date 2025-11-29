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

public readonly unsafe partial struct HcryptprovLegacy
    : IComparable,
        IComparable<HcryptprovLegacy>,
        IEquatable<HcryptprovLegacy>,
        IFormattable
{
    public readonly void* Value;

    public HcryptprovLegacy(void* value)
    {
        Value = value;
    }

    public static HcryptprovLegacy INVALID_VALUE => new HcryptprovLegacy((void*)(-1));
    public static HcryptprovLegacy NULL => new HcryptprovLegacy(null);

    public static bool operator ==(HcryptprovLegacy left, HcryptprovLegacy right) =>
        left.Value == right.Value;

    public static bool operator !=(HcryptprovLegacy left, HcryptprovLegacy right) =>
        left.Value != right.Value;

    public static bool operator <(HcryptprovLegacy left, HcryptprovLegacy right) =>
        left.Value < right.Value;

    public static bool operator <=(HcryptprovLegacy left, HcryptprovLegacy right) =>
        left.Value <= right.Value;

    public static bool operator >(HcryptprovLegacy left, HcryptprovLegacy right) =>
        left.Value > right.Value;

    public static bool operator >=(HcryptprovLegacy left, HcryptprovLegacy right) =>
        left.Value >= right.Value;

    public static explicit operator HcryptprovLegacy(void* value) => new HcryptprovLegacy(value);

    public static implicit operator void*(HcryptprovLegacy value) => value.Value;

    public static explicit operator HcryptprovLegacy(Handle value) => new HcryptprovLegacy(value);

    public static implicit operator Handle(HcryptprovLegacy value) => new Handle(value.Value);

    public static explicit operator HcryptprovLegacy(byte value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static explicit operator byte(HcryptprovLegacy value) => (byte)(value.Value);

    public static explicit operator HcryptprovLegacy(short value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static explicit operator short(HcryptprovLegacy value) => (short)(value.Value);

    public static explicit operator HcryptprovLegacy(int value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static explicit operator int(HcryptprovLegacy value) => (int)(value.Value);

    public static explicit operator HcryptprovLegacy(long value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static explicit operator long(HcryptprovLegacy value) => (long)(value.Value);

    public static explicit operator HcryptprovLegacy(nint value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static implicit operator nint(HcryptprovLegacy value) => (nint)(value.Value);

    public static explicit operator HcryptprovLegacy(sbyte value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static explicit operator sbyte(HcryptprovLegacy value) => (sbyte)(value.Value);

    public static explicit operator HcryptprovLegacy(ushort value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static explicit operator ushort(HcryptprovLegacy value) => (ushort)(value.Value);

    public static explicit operator HcryptprovLegacy(uint value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static explicit operator uint(HcryptprovLegacy value) => (uint)(value.Value);

    public static explicit operator HcryptprovLegacy(ulong value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static explicit operator ulong(HcryptprovLegacy value) => (ulong)(value.Value);

    public static explicit operator HcryptprovLegacy(nuint value) =>
        new HcryptprovLegacy(unchecked((void*)(value)));

    public static implicit operator nuint(HcryptprovLegacy value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HcryptprovLegacy other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTPROV_LEGACY.");
    }

    public int CompareTo(HcryptprovLegacy other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HcryptprovLegacy other) && Equals(other);

    public bool Equals(HcryptprovLegacy other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
