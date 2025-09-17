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

public readonly unsafe partial struct HcertServerOcspResponse
    : IComparable,
        IComparable<HcertServerOcspResponse>,
        IEquatable<HcertServerOcspResponse>,
        IFormattable
{
    public readonly void* Value;

    public HcertServerOcspResponse(void* value)
    {
        Value = value;
    }

    public static HcertServerOcspResponse INVALID_VALUE => new HcertServerOcspResponse((void*)(-1));
    public static HcertServerOcspResponse NULL => new HcertServerOcspResponse(null);

    public static bool operator ==(HcertServerOcspResponse left, HcertServerOcspResponse right) =>
        left.Value == right.Value;

    public static bool operator !=(HcertServerOcspResponse left, HcertServerOcspResponse right) =>
        left.Value != right.Value;

    public static bool operator <(HcertServerOcspResponse left, HcertServerOcspResponse right) =>
        left.Value < right.Value;

    public static bool operator <=(HcertServerOcspResponse left, HcertServerOcspResponse right) =>
        left.Value <= right.Value;

    public static bool operator >(HcertServerOcspResponse left, HcertServerOcspResponse right) =>
        left.Value > right.Value;

    public static bool operator >=(HcertServerOcspResponse left, HcertServerOcspResponse right) =>
        left.Value >= right.Value;

    public static explicit operator HcertServerOcspResponse(void* value) =>
        new HcertServerOcspResponse(value);

    public static implicit operator void*(HcertServerOcspResponse value) => value.Value;

    public static explicit operator HcertServerOcspResponse(Handle value) =>
        new HcertServerOcspResponse(value);

    public static implicit operator Handle(HcertServerOcspResponse value) =>
        new Handle(value.Value);

    public static explicit operator HcertServerOcspResponse(byte value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static explicit operator byte(HcertServerOcspResponse value) => (byte)(value.Value);

    public static explicit operator HcertServerOcspResponse(short value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static explicit operator short(HcertServerOcspResponse value) => (short)(value.Value);

    public static explicit operator HcertServerOcspResponse(int value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static explicit operator int(HcertServerOcspResponse value) => (int)(value.Value);

    public static explicit operator HcertServerOcspResponse(long value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static explicit operator long(HcertServerOcspResponse value) => (long)(value.Value);

    public static explicit operator HcertServerOcspResponse(nint value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static implicit operator nint(HcertServerOcspResponse value) => (nint)(value.Value);

    public static explicit operator HcertServerOcspResponse(sbyte value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static explicit operator sbyte(HcertServerOcspResponse value) => (sbyte)(value.Value);

    public static explicit operator HcertServerOcspResponse(ushort value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static explicit operator ushort(HcertServerOcspResponse value) => (ushort)(value.Value);

    public static explicit operator HcertServerOcspResponse(uint value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static explicit operator uint(HcertServerOcspResponse value) => (uint)(value.Value);

    public static explicit operator HcertServerOcspResponse(ulong value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static explicit operator ulong(HcertServerOcspResponse value) => (ulong)(value.Value);

    public static explicit operator HcertServerOcspResponse(nuint value) =>
        new HcertServerOcspResponse(unchecked((void*)(value)));

    public static implicit operator nuint(HcertServerOcspResponse value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HcertServerOcspResponse other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCERT_SERVER_OCSP_RESPONSE.");
    }

    public int CompareTo(HcertServerOcspResponse other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is HcertServerOcspResponse other) && Equals(other);

    public bool Equals(HcertServerOcspResponse other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
