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

public readonly unsafe partial struct CoMtaUsageCookie
    : IComparable,
        IComparable<CoMtaUsageCookie>,
        IEquatable<CoMtaUsageCookie>,
        IFormattable
{
    public readonly void* Value;

    public CoMtaUsageCookie(void* value)
    {
        Value = value;
    }

    public static CoMtaUsageCookie INVALID_VALUE => new CoMtaUsageCookie((void*)(-1));
    public static CoMtaUsageCookie NULL => new CoMtaUsageCookie(null);

    public static bool operator ==(CoMtaUsageCookie left, CoMtaUsageCookie right) =>
        left.Value == right.Value;

    public static bool operator !=(CoMtaUsageCookie left, CoMtaUsageCookie right) =>
        left.Value != right.Value;

    public static bool operator <(CoMtaUsageCookie left, CoMtaUsageCookie right) =>
        left.Value < right.Value;

    public static bool operator <=(CoMtaUsageCookie left, CoMtaUsageCookie right) =>
        left.Value <= right.Value;

    public static bool operator >(CoMtaUsageCookie left, CoMtaUsageCookie right) =>
        left.Value > right.Value;

    public static bool operator >=(CoMtaUsageCookie left, CoMtaUsageCookie right) =>
        left.Value >= right.Value;

    public static explicit operator CoMtaUsageCookie(void* value) => new CoMtaUsageCookie(value);

    public static implicit operator void*(CoMtaUsageCookie value) => value.Value;

    public static explicit operator CoMtaUsageCookie(Handle value) => new CoMtaUsageCookie(value);

    public static implicit operator Handle(CoMtaUsageCookie value) => new Handle(value.Value);

    public static explicit operator CoMtaUsageCookie(byte value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static explicit operator byte(CoMtaUsageCookie value) => (byte)(value.Value);

    public static explicit operator CoMtaUsageCookie(short value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static explicit operator short(CoMtaUsageCookie value) => (short)(value.Value);

    public static explicit operator CoMtaUsageCookie(int value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static explicit operator int(CoMtaUsageCookie value) => (int)(value.Value);

    public static explicit operator CoMtaUsageCookie(long value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static explicit operator long(CoMtaUsageCookie value) => (long)(value.Value);

    public static explicit operator CoMtaUsageCookie(nint value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static implicit operator nint(CoMtaUsageCookie value) => (nint)(value.Value);

    public static explicit operator CoMtaUsageCookie(sbyte value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static explicit operator sbyte(CoMtaUsageCookie value) => (sbyte)(value.Value);

    public static explicit operator CoMtaUsageCookie(ushort value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static explicit operator ushort(CoMtaUsageCookie value) => (ushort)(value.Value);

    public static explicit operator CoMtaUsageCookie(uint value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static explicit operator uint(CoMtaUsageCookie value) => (uint)(value.Value);

    public static explicit operator CoMtaUsageCookie(ulong value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static explicit operator ulong(CoMtaUsageCookie value) => (ulong)(value.Value);

    public static explicit operator CoMtaUsageCookie(nuint value) =>
        new CoMtaUsageCookie(unchecked((void*)(value)));

    public static implicit operator nuint(CoMtaUsageCookie value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is CoMtaUsageCookie other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of CO_MTA_USAGE_COOKIE.");
    }

    public int CompareTo(CoMtaUsageCookie other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is CoMtaUsageCookie other) && Equals(other);

    public bool Equals(CoMtaUsageCookie other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
