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

public readonly unsafe partial struct LpprocThreadAttributeList
    : IComparable,
        IComparable<LpprocThreadAttributeList>,
        IEquatable<LpprocThreadAttributeList>,
        IFormattable
{
    public readonly void* Value;

    public LpprocThreadAttributeList(void* value)
    {
        Value = value;
    }

    public static LpprocThreadAttributeList NULL => new LpprocThreadAttributeList(null);

    public static bool operator ==(
        LpprocThreadAttributeList left,
        LpprocThreadAttributeList right
    ) => left.Value == right.Value;

    public static bool operator !=(
        LpprocThreadAttributeList left,
        LpprocThreadAttributeList right
    ) => left.Value != right.Value;

    public static bool operator <(
        LpprocThreadAttributeList left,
        LpprocThreadAttributeList right
    ) => left.Value < right.Value;

    public static bool operator <=(
        LpprocThreadAttributeList left,
        LpprocThreadAttributeList right
    ) => left.Value <= right.Value;

    public static bool operator >(
        LpprocThreadAttributeList left,
        LpprocThreadAttributeList right
    ) => left.Value > right.Value;

    public static bool operator >=(
        LpprocThreadAttributeList left,
        LpprocThreadAttributeList right
    ) => left.Value >= right.Value;

    public static explicit operator LpprocThreadAttributeList(void* value) =>
        new LpprocThreadAttributeList(value);

    public static implicit operator void*(LpprocThreadAttributeList value) => value.Value;

    public static explicit operator LpprocThreadAttributeList(byte value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static explicit operator byte(LpprocThreadAttributeList value) => (byte)(value.Value);

    public static explicit operator LpprocThreadAttributeList(short value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static explicit operator short(LpprocThreadAttributeList value) => (short)(value.Value);

    public static explicit operator LpprocThreadAttributeList(int value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static explicit operator int(LpprocThreadAttributeList value) => (int)(value.Value);

    public static explicit operator LpprocThreadAttributeList(long value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static explicit operator long(LpprocThreadAttributeList value) => (long)(value.Value);

    public static explicit operator LpprocThreadAttributeList(nint value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static implicit operator nint(LpprocThreadAttributeList value) => (nint)(value.Value);

    public static explicit operator LpprocThreadAttributeList(sbyte value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static explicit operator sbyte(LpprocThreadAttributeList value) => (sbyte)(value.Value);

    public static explicit operator LpprocThreadAttributeList(ushort value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static explicit operator ushort(LpprocThreadAttributeList value) =>
        (ushort)(value.Value);

    public static explicit operator LpprocThreadAttributeList(uint value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static explicit operator uint(LpprocThreadAttributeList value) => (uint)(value.Value);

    public static explicit operator LpprocThreadAttributeList(ulong value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static explicit operator ulong(LpprocThreadAttributeList value) => (ulong)(value.Value);

    public static explicit operator LpprocThreadAttributeList(nuint value) =>
        new LpprocThreadAttributeList(unchecked((void*)(value)));

    public static implicit operator nuint(LpprocThreadAttributeList value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is LpprocThreadAttributeList other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException(
                "obj is not an instance of LPPROC_THREAD_ATTRIBUTE_LIST."
            );
    }

    public int CompareTo(LpprocThreadAttributeList other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is LpprocThreadAttributeList other) && Equals(other);

    public bool Equals(LpprocThreadAttributeList other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
