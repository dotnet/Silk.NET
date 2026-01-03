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

public readonly unsafe partial struct CoDeviceCatalogCookie
    : IComparable,
        IComparable<CoDeviceCatalogCookie>,
        IEquatable<CoDeviceCatalogCookie>,
        IFormattable
{
    public readonly void* Value;

    public CoDeviceCatalogCookie(void* value)
    {
        Value = value;
    }

    public static CoDeviceCatalogCookie INVALID_VALUE => new CoDeviceCatalogCookie((void*)(-1));
    public static CoDeviceCatalogCookie NULL => new CoDeviceCatalogCookie(null);

    public static bool operator ==(CoDeviceCatalogCookie left, CoDeviceCatalogCookie right) =>
        left.Value == right.Value;

    public static bool operator !=(CoDeviceCatalogCookie left, CoDeviceCatalogCookie right) =>
        left.Value != right.Value;

    public static bool operator <(CoDeviceCatalogCookie left, CoDeviceCatalogCookie right) =>
        left.Value < right.Value;

    public static bool operator <=(CoDeviceCatalogCookie left, CoDeviceCatalogCookie right) =>
        left.Value <= right.Value;

    public static bool operator >(CoDeviceCatalogCookie left, CoDeviceCatalogCookie right) =>
        left.Value > right.Value;

    public static bool operator >=(CoDeviceCatalogCookie left, CoDeviceCatalogCookie right) =>
        left.Value >= right.Value;

    public static explicit operator CoDeviceCatalogCookie(void* value) =>
        new CoDeviceCatalogCookie(value);

    public static implicit operator void*(CoDeviceCatalogCookie value) => value.Value;

    public static explicit operator CoDeviceCatalogCookie(Handle value) =>
        new CoDeviceCatalogCookie(value);

    public static implicit operator Handle(CoDeviceCatalogCookie value) => new Handle(value.Value);

    public static explicit operator CoDeviceCatalogCookie(byte value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static explicit operator byte(CoDeviceCatalogCookie value) => (byte)(value.Value);

    public static explicit operator CoDeviceCatalogCookie(short value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static explicit operator short(CoDeviceCatalogCookie value) => (short)(value.Value);

    public static explicit operator CoDeviceCatalogCookie(int value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static explicit operator int(CoDeviceCatalogCookie value) => (int)(value.Value);

    public static explicit operator CoDeviceCatalogCookie(long value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static explicit operator long(CoDeviceCatalogCookie value) => (long)(value.Value);

    public static explicit operator CoDeviceCatalogCookie(nint value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static implicit operator nint(CoDeviceCatalogCookie value) => (nint)(value.Value);

    public static explicit operator CoDeviceCatalogCookie(sbyte value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static explicit operator sbyte(CoDeviceCatalogCookie value) => (sbyte)(value.Value);

    public static explicit operator CoDeviceCatalogCookie(ushort value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static explicit operator ushort(CoDeviceCatalogCookie value) => (ushort)(value.Value);

    public static explicit operator CoDeviceCatalogCookie(uint value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static explicit operator uint(CoDeviceCatalogCookie value) => (uint)(value.Value);

    public static explicit operator CoDeviceCatalogCookie(ulong value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static explicit operator ulong(CoDeviceCatalogCookie value) => (ulong)(value.Value);

    public static explicit operator CoDeviceCatalogCookie(nuint value) =>
        new CoDeviceCatalogCookie(unchecked((void*)(value)));

    public static implicit operator nuint(CoDeviceCatalogCookie value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is CoDeviceCatalogCookie other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of CO_DEVICE_CATALOG_COOKIE.");
    }

    public int CompareTo(CoDeviceCatalogCookie other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is CoDeviceCatalogCookie other) && Equals(other);

    public bool Equals(CoDeviceCatalogCookie other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
