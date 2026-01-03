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

public readonly unsafe partial struct ApartmentShutdownRegistrationCookie
    : IComparable,
        IComparable<ApartmentShutdownRegistrationCookie>,
        IEquatable<ApartmentShutdownRegistrationCookie>,
        IFormattable
{
    public readonly void* Value;

    public ApartmentShutdownRegistrationCookie(void* value)
    {
        Value = value;
    }

    public static ApartmentShutdownRegistrationCookie INVALID_VALUE =>
        new ApartmentShutdownRegistrationCookie((void*)(-1));
    public static ApartmentShutdownRegistrationCookie NULL =>
        new ApartmentShutdownRegistrationCookie(null);

    public static bool operator ==(
        ApartmentShutdownRegistrationCookie left,
        ApartmentShutdownRegistrationCookie right
    ) => left.Value == right.Value;

    public static bool operator !=(
        ApartmentShutdownRegistrationCookie left,
        ApartmentShutdownRegistrationCookie right
    ) => left.Value != right.Value;

    public static bool operator <(
        ApartmentShutdownRegistrationCookie left,
        ApartmentShutdownRegistrationCookie right
    ) => left.Value < right.Value;

    public static bool operator <=(
        ApartmentShutdownRegistrationCookie left,
        ApartmentShutdownRegistrationCookie right
    ) => left.Value <= right.Value;

    public static bool operator >(
        ApartmentShutdownRegistrationCookie left,
        ApartmentShutdownRegistrationCookie right
    ) => left.Value > right.Value;

    public static bool operator >=(
        ApartmentShutdownRegistrationCookie left,
        ApartmentShutdownRegistrationCookie right
    ) => left.Value >= right.Value;

    public static explicit operator ApartmentShutdownRegistrationCookie(void* value) =>
        new ApartmentShutdownRegistrationCookie(value);

    public static implicit operator void*(ApartmentShutdownRegistrationCookie value) => value.Value;

    public static explicit operator ApartmentShutdownRegistrationCookie(Handle value) =>
        new ApartmentShutdownRegistrationCookie(value);

    public static implicit operator Handle(ApartmentShutdownRegistrationCookie value) =>
        new Handle(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(byte value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator byte(ApartmentShutdownRegistrationCookie value) =>
        (byte)(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(short value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator short(ApartmentShutdownRegistrationCookie value) =>
        (short)(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(int value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator int(ApartmentShutdownRegistrationCookie value) =>
        (int)(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(long value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator long(ApartmentShutdownRegistrationCookie value) =>
        (long)(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(nint value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static implicit operator nint(ApartmentShutdownRegistrationCookie value) =>
        (nint)(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(sbyte value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator sbyte(ApartmentShutdownRegistrationCookie value) =>
        (sbyte)(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(ushort value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator ushort(ApartmentShutdownRegistrationCookie value) =>
        (ushort)(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(uint value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator uint(ApartmentShutdownRegistrationCookie value) =>
        (uint)(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(ulong value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static explicit operator ulong(ApartmentShutdownRegistrationCookie value) =>
        (ulong)(value.Value);

    public static explicit operator ApartmentShutdownRegistrationCookie(nuint value) =>
        new ApartmentShutdownRegistrationCookie(unchecked((void*)(value)));

    public static implicit operator nuint(ApartmentShutdownRegistrationCookie value) =>
        (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is ApartmentShutdownRegistrationCookie other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException(
                "obj is not an instance of APARTMENT_SHUTDOWN_REGISTRATION_COOKIE."
            );
    }

    public int CompareTo(ApartmentShutdownRegistrationCookie other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is ApartmentShutdownRegistrationCookie other) && Equals(other);

    public bool Equals(ApartmentShutdownRegistrationCookie other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
