// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HDC
    : IComparable,
        IComparable<HDC>,
        IEquatable<HDC>,
        IFormattable
{
    public readonly void* Value;

    public HDC(void* value)
    {
        Value = value;
    }

    public static HDC INVALID_VALUE => new HDC((void*)(-1));
    public static HDC NULL => new HDC(null);

    public static bool operator ==(HDC left, HDC right) => left.Value == right.Value;

    public static bool operator !=(HDC left, HDC right) => left.Value != right.Value;

    public static bool operator <(HDC left, HDC right) => left.Value < right.Value;

    public static bool operator <=(HDC left, HDC right) => left.Value <= right.Value;

    public static bool operator >(HDC left, HDC right) => left.Value > right.Value;

    public static bool operator >=(HDC left, HDC right) => left.Value >= right.Value;

    public static explicit operator HDC(void* value) => new HDC(value);

    public static implicit operator void*(HDC value) => value.Value;

    public static explicit operator HDC(Handle value) => new HDC(value);

    public static implicit operator Handle(HDC value) => new Handle(value.Value);

    public static explicit operator HDC(byte value) => new HDC(unchecked((void*)(value)));

    public static explicit operator byte(HDC value) => (byte)(value.Value);

    public static explicit operator HDC(short value) => new HDC(unchecked((void*)(value)));

    public static explicit operator short(HDC value) => (short)(value.Value);

    public static explicit operator HDC(int value) => new HDC(unchecked((void*)(value)));

    public static explicit operator int(HDC value) => (int)(value.Value);

    public static explicit operator HDC(long value) => new HDC(unchecked((void*)(value)));

    public static explicit operator long(HDC value) => (long)(value.Value);

    public static explicit operator HDC(nint value) => new HDC(unchecked((void*)(value)));

    public static implicit operator nint(HDC value) => (nint)(value.Value);

    public static explicit operator HDC(sbyte value) => new HDC(unchecked((void*)(value)));

    public static explicit operator sbyte(HDC value) => (sbyte)(value.Value);

    public static explicit operator HDC(ushort value) => new HDC(unchecked((void*)(value)));

    public static explicit operator ushort(HDC value) => (ushort)(value.Value);

    public static explicit operator HDC(uint value) => new HDC(unchecked((void*)(value)));

    public static explicit operator uint(HDC value) => (uint)(value.Value);

    public static explicit operator HDC(ulong value) => new HDC(unchecked((void*)(value)));

    public static explicit operator ulong(HDC value) => (ulong)(value.Value);

    public static explicit operator HDC(nuint value) => new HDC(unchecked((void*)(value)));

    public static implicit operator nuint(HDC value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HDC other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDC.");
    }

    public int CompareTo(HDC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HDC other) && Equals(other);

    public bool Equals(HDC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
