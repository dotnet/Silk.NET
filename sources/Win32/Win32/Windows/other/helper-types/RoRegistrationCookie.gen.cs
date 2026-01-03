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

public readonly unsafe partial struct RoRegistrationCookie
    : IComparable,
        IComparable<RoRegistrationCookie>,
        IEquatable<RoRegistrationCookie>,
        IFormattable
{
    public readonly void* Value;

    public RoRegistrationCookie(void* value)
    {
        Value = value;
    }

    public static RoRegistrationCookie NULL => new RoRegistrationCookie(null);

    public static bool operator ==(RoRegistrationCookie left, RoRegistrationCookie right) =>
        left.Value == right.Value;

    public static bool operator !=(RoRegistrationCookie left, RoRegistrationCookie right) =>
        left.Value != right.Value;

    public static bool operator <(RoRegistrationCookie left, RoRegistrationCookie right) =>
        left.Value < right.Value;

    public static bool operator <=(RoRegistrationCookie left, RoRegistrationCookie right) =>
        left.Value <= right.Value;

    public static bool operator >(RoRegistrationCookie left, RoRegistrationCookie right) =>
        left.Value > right.Value;

    public static bool operator >=(RoRegistrationCookie left, RoRegistrationCookie right) =>
        left.Value >= right.Value;

    public static explicit operator RoRegistrationCookie(void* value) =>
        new RoRegistrationCookie(value);

    public static implicit operator void*(RoRegistrationCookie value) => value.Value;

    public static explicit operator RoRegistrationCookie(byte value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator byte(RoRegistrationCookie value) => (byte)(value.Value);

    public static explicit operator RoRegistrationCookie(short value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator short(RoRegistrationCookie value) => (short)(value.Value);

    public static explicit operator RoRegistrationCookie(int value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator int(RoRegistrationCookie value) => (int)(value.Value);

    public static explicit operator RoRegistrationCookie(long value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator long(RoRegistrationCookie value) => (long)(value.Value);

    public static explicit operator RoRegistrationCookie(nint value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static implicit operator nint(RoRegistrationCookie value) => (nint)(value.Value);

    public static explicit operator RoRegistrationCookie(sbyte value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator sbyte(RoRegistrationCookie value) => (sbyte)(value.Value);

    public static explicit operator RoRegistrationCookie(ushort value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator ushort(RoRegistrationCookie value) => (ushort)(value.Value);

    public static explicit operator RoRegistrationCookie(uint value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator uint(RoRegistrationCookie value) => (uint)(value.Value);

    public static explicit operator RoRegistrationCookie(ulong value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator ulong(RoRegistrationCookie value) => (ulong)(value.Value);

    public static explicit operator RoRegistrationCookie(nuint value) =>
        new RoRegistrationCookie(unchecked((void*)(value)));

    public static implicit operator nuint(RoRegistrationCookie value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is RoRegistrationCookie other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of RO_REGISTRATION_COOKIE.");
    }

    public int CompareTo(RoRegistrationCookie other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is RoRegistrationCookie other) && Equals(other);

    public bool Equals(RoRegistrationCookie other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
