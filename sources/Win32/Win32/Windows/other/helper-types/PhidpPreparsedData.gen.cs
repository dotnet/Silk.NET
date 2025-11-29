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

public readonly unsafe partial struct PhidpPreparsedData
    : IComparable,
        IComparable<PhidpPreparsedData>,
        IEquatable<PhidpPreparsedData>,
        IFormattable
{
    public readonly void* Value;

    public PhidpPreparsedData(void* value)
    {
        Value = value;
    }

    public static PhidpPreparsedData NULL => new PhidpPreparsedData(null);

    public static bool operator ==(PhidpPreparsedData left, PhidpPreparsedData right) =>
        left.Value == right.Value;

    public static bool operator !=(PhidpPreparsedData left, PhidpPreparsedData right) =>
        left.Value != right.Value;

    public static bool operator <(PhidpPreparsedData left, PhidpPreparsedData right) =>
        left.Value < right.Value;

    public static bool operator <=(PhidpPreparsedData left, PhidpPreparsedData right) =>
        left.Value <= right.Value;

    public static bool operator >(PhidpPreparsedData left, PhidpPreparsedData right) =>
        left.Value > right.Value;

    public static bool operator >=(PhidpPreparsedData left, PhidpPreparsedData right) =>
        left.Value >= right.Value;

    public static explicit operator PhidpPreparsedData(void* value) =>
        new PhidpPreparsedData(value);

    public static implicit operator void*(PhidpPreparsedData value) => value.Value;

    public static explicit operator PhidpPreparsedData(byte value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static explicit operator byte(PhidpPreparsedData value) => (byte)(value.Value);

    public static explicit operator PhidpPreparsedData(short value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static explicit operator short(PhidpPreparsedData value) => (short)(value.Value);

    public static explicit operator PhidpPreparsedData(int value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static explicit operator int(PhidpPreparsedData value) => (int)(value.Value);

    public static explicit operator PhidpPreparsedData(long value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static explicit operator long(PhidpPreparsedData value) => (long)(value.Value);

    public static explicit operator PhidpPreparsedData(nint value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static implicit operator nint(PhidpPreparsedData value) => (nint)(value.Value);

    public static explicit operator PhidpPreparsedData(sbyte value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static explicit operator sbyte(PhidpPreparsedData value) => (sbyte)(value.Value);

    public static explicit operator PhidpPreparsedData(ushort value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static explicit operator ushort(PhidpPreparsedData value) => (ushort)(value.Value);

    public static explicit operator PhidpPreparsedData(uint value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static explicit operator uint(PhidpPreparsedData value) => (uint)(value.Value);

    public static explicit operator PhidpPreparsedData(ulong value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static explicit operator ulong(PhidpPreparsedData value) => (ulong)(value.Value);

    public static explicit operator PhidpPreparsedData(nuint value) =>
        new PhidpPreparsedData(unchecked((void*)(value)));

    public static implicit operator nuint(PhidpPreparsedData value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PhidpPreparsedData other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PHIDP_PREPARSED_DATA.");
    }

    public int CompareTo(PhidpPreparsedData other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PhidpPreparsedData other) && Equals(other);

    public bool Equals(PhidpPreparsedData other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
