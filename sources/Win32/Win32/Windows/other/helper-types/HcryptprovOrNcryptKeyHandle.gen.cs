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

public readonly unsafe partial struct HcryptprovOrNcryptKeyHandle
    : IComparable,
        IComparable<HcryptprovOrNcryptKeyHandle>,
        IEquatable<HcryptprovOrNcryptKeyHandle>,
        IFormattable
{
    public readonly void* Value;

    public HcryptprovOrNcryptKeyHandle(void* value)
    {
        Value = value;
    }

    public static HcryptprovOrNcryptKeyHandle INVALID_VALUE =>
        new HcryptprovOrNcryptKeyHandle((void*)(-1));
    public static HcryptprovOrNcryptKeyHandle NULL => new HcryptprovOrNcryptKeyHandle(null);

    public static bool operator ==(
        HcryptprovOrNcryptKeyHandle left,
        HcryptprovOrNcryptKeyHandle right
    ) => left.Value == right.Value;

    public static bool operator !=(
        HcryptprovOrNcryptKeyHandle left,
        HcryptprovOrNcryptKeyHandle right
    ) => left.Value != right.Value;

    public static bool operator <(
        HcryptprovOrNcryptKeyHandle left,
        HcryptprovOrNcryptKeyHandle right
    ) => left.Value < right.Value;

    public static bool operator <=(
        HcryptprovOrNcryptKeyHandle left,
        HcryptprovOrNcryptKeyHandle right
    ) => left.Value <= right.Value;

    public static bool operator >(
        HcryptprovOrNcryptKeyHandle left,
        HcryptprovOrNcryptKeyHandle right
    ) => left.Value > right.Value;

    public static bool operator >=(
        HcryptprovOrNcryptKeyHandle left,
        HcryptprovOrNcryptKeyHandle right
    ) => left.Value >= right.Value;

    public static explicit operator HcryptprovOrNcryptKeyHandle(void* value) =>
        new HcryptprovOrNcryptKeyHandle(value);

    public static implicit operator void*(HcryptprovOrNcryptKeyHandle value) => value.Value;

    public static explicit operator HcryptprovOrNcryptKeyHandle(Handle value) =>
        new HcryptprovOrNcryptKeyHandle(value);

    public static implicit operator Handle(HcryptprovOrNcryptKeyHandle value) =>
        new Handle(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(byte value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static explicit operator byte(HcryptprovOrNcryptKeyHandle value) => (byte)(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(short value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static explicit operator short(HcryptprovOrNcryptKeyHandle value) =>
        (short)(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(int value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static explicit operator int(HcryptprovOrNcryptKeyHandle value) => (int)(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(long value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static explicit operator long(HcryptprovOrNcryptKeyHandle value) => (long)(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(nint value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static implicit operator nint(HcryptprovOrNcryptKeyHandle value) => (nint)(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(sbyte value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static explicit operator sbyte(HcryptprovOrNcryptKeyHandle value) =>
        (sbyte)(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(ushort value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static explicit operator ushort(HcryptprovOrNcryptKeyHandle value) =>
        (ushort)(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(uint value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static explicit operator uint(HcryptprovOrNcryptKeyHandle value) => (uint)(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(ulong value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static explicit operator ulong(HcryptprovOrNcryptKeyHandle value) =>
        (ulong)(value.Value);

    public static explicit operator HcryptprovOrNcryptKeyHandle(nuint value) =>
        new HcryptprovOrNcryptKeyHandle(unchecked((void*)(value)));

    public static implicit operator nuint(HcryptprovOrNcryptKeyHandle value) =>
        (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HcryptprovOrNcryptKeyHandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException(
                "obj is not an instance of HCRYPTPROV_OR_NCRYPT_KEY_HANDLE."
            );
    }

    public int CompareTo(HcryptprovOrNcryptKeyHandle other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is HcryptprovOrNcryptKeyHandle other) && Equals(other);

    public bool Equals(HcryptprovOrNcryptKeyHandle other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
