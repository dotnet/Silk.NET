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

public readonly unsafe partial struct PappconstrainRegistration
    : IComparable,
        IComparable<PappconstrainRegistration>,
        IEquatable<PappconstrainRegistration>,
        IFormattable
{
    public readonly void* Value;

    public PappconstrainRegistration(void* value)
    {
        Value = value;
    }

    public static PappconstrainRegistration NULL => new PappconstrainRegistration(null);

    public static bool operator ==(
        PappconstrainRegistration left,
        PappconstrainRegistration right
    ) => left.Value == right.Value;

    public static bool operator !=(
        PappconstrainRegistration left,
        PappconstrainRegistration right
    ) => left.Value != right.Value;

    public static bool operator <(
        PappconstrainRegistration left,
        PappconstrainRegistration right
    ) => left.Value < right.Value;

    public static bool operator <=(
        PappconstrainRegistration left,
        PappconstrainRegistration right
    ) => left.Value <= right.Value;

    public static bool operator >(
        PappconstrainRegistration left,
        PappconstrainRegistration right
    ) => left.Value > right.Value;

    public static bool operator >=(
        PappconstrainRegistration left,
        PappconstrainRegistration right
    ) => left.Value >= right.Value;

    public static explicit operator PappconstrainRegistration(void* value) =>
        new PappconstrainRegistration(value);

    public static implicit operator void*(PappconstrainRegistration value) => value.Value;

    public static explicit operator PappconstrainRegistration(byte value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static explicit operator byte(PappconstrainRegistration value) => (byte)(value.Value);

    public static explicit operator PappconstrainRegistration(short value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static explicit operator short(PappconstrainRegistration value) => (short)(value.Value);

    public static explicit operator PappconstrainRegistration(int value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static explicit operator int(PappconstrainRegistration value) => (int)(value.Value);

    public static explicit operator PappconstrainRegistration(long value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static explicit operator long(PappconstrainRegistration value) => (long)(value.Value);

    public static explicit operator PappconstrainRegistration(nint value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static implicit operator nint(PappconstrainRegistration value) => (nint)(value.Value);

    public static explicit operator PappconstrainRegistration(sbyte value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static explicit operator sbyte(PappconstrainRegistration value) => (sbyte)(value.Value);

    public static explicit operator PappconstrainRegistration(ushort value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static explicit operator ushort(PappconstrainRegistration value) =>
        (ushort)(value.Value);

    public static explicit operator PappconstrainRegistration(uint value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static explicit operator uint(PappconstrainRegistration value) => (uint)(value.Value);

    public static explicit operator PappconstrainRegistration(ulong value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static explicit operator ulong(PappconstrainRegistration value) => (ulong)(value.Value);

    public static explicit operator PappconstrainRegistration(nuint value) =>
        new PappconstrainRegistration(unchecked((void*)(value)));

    public static implicit operator nuint(PappconstrainRegistration value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PappconstrainRegistration other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PAPPCONSTRAIN_REGISTRATION.");
    }

    public int CompareTo(PappconstrainRegistration other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PappconstrainRegistration other) && Equals(other);

    public bool Equals(PappconstrainRegistration other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
