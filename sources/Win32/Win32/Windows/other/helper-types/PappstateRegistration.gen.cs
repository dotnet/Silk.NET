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

public readonly unsafe partial struct PappstateRegistration
    : IComparable,
        IComparable<PappstateRegistration>,
        IEquatable<PappstateRegistration>,
        IFormattable
{
    public readonly void* Value;

    public PappstateRegistration(void* value)
    {
        Value = value;
    }

    public static PappstateRegistration NULL => new PappstateRegistration(null);

    public static bool operator ==(PappstateRegistration left, PappstateRegistration right) =>
        left.Value == right.Value;

    public static bool operator !=(PappstateRegistration left, PappstateRegistration right) =>
        left.Value != right.Value;

    public static bool operator <(PappstateRegistration left, PappstateRegistration right) =>
        left.Value < right.Value;

    public static bool operator <=(PappstateRegistration left, PappstateRegistration right) =>
        left.Value <= right.Value;

    public static bool operator >(PappstateRegistration left, PappstateRegistration right) =>
        left.Value > right.Value;

    public static bool operator >=(PappstateRegistration left, PappstateRegistration right) =>
        left.Value >= right.Value;

    public static explicit operator PappstateRegistration(void* value) =>
        new PappstateRegistration(value);

    public static implicit operator void*(PappstateRegistration value) => value.Value;

    public static explicit operator PappstateRegistration(byte value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static explicit operator byte(PappstateRegistration value) => (byte)(value.Value);

    public static explicit operator PappstateRegistration(short value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static explicit operator short(PappstateRegistration value) => (short)(value.Value);

    public static explicit operator PappstateRegistration(int value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static explicit operator int(PappstateRegistration value) => (int)(value.Value);

    public static explicit operator PappstateRegistration(long value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static explicit operator long(PappstateRegistration value) => (long)(value.Value);

    public static explicit operator PappstateRegistration(nint value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static implicit operator nint(PappstateRegistration value) => (nint)(value.Value);

    public static explicit operator PappstateRegistration(sbyte value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static explicit operator sbyte(PappstateRegistration value) => (sbyte)(value.Value);

    public static explicit operator PappstateRegistration(ushort value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static explicit operator ushort(PappstateRegistration value) => (ushort)(value.Value);

    public static explicit operator PappstateRegistration(uint value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static explicit operator uint(PappstateRegistration value) => (uint)(value.Value);

    public static explicit operator PappstateRegistration(ulong value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static explicit operator ulong(PappstateRegistration value) => (ulong)(value.Value);

    public static explicit operator PappstateRegistration(nuint value) =>
        new PappstateRegistration(unchecked((void*)(value)));

    public static implicit operator nuint(PappstateRegistration value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PappstateRegistration other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PAPPSTATE_REGISTRATION.");
    }

    public int CompareTo(PappstateRegistration other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PappstateRegistration other) && Equals(other);

    public bool Equals(PappstateRegistration other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
