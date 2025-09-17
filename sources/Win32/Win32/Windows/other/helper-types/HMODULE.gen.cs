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

public readonly unsafe partial struct HModule
    : IComparable,
        IComparable<HModule>,
        IEquatable<HModule>,
        IFormattable
{
    public readonly void* Value;

    public HModule(void* value)
    {
        Value = value;
    }

    public static HModule INVALID_VALUE => new HModule((void*)(-1));
    public static HModule NULL => new HModule(null);

    public static bool operator ==(HModule left, HModule right) => left.Value == right.Value;

    public static bool operator !=(HModule left, HModule right) => left.Value != right.Value;

    public static bool operator <(HModule left, HModule right) => left.Value < right.Value;

    public static bool operator <=(HModule left, HModule right) => left.Value <= right.Value;

    public static bool operator >(HModule left, HModule right) => left.Value > right.Value;

    public static bool operator >=(HModule left, HModule right) => left.Value >= right.Value;

    public static explicit operator HModule(void* value) => new HModule(value);

    public static implicit operator void*(HModule value) => value.Value;

    public static explicit operator HModule(Handle value) => new HModule(value);

    public static implicit operator Handle(HModule value) => new Handle(value.Value);

    public static explicit operator HModule(byte value) => new HModule(unchecked((void*)(value)));

    public static explicit operator byte(HModule value) => (byte)(value.Value);

    public static explicit operator HModule(short value) => new HModule(unchecked((void*)(value)));

    public static explicit operator short(HModule value) => (short)(value.Value);

    public static explicit operator HModule(int value) => new HModule(unchecked((void*)(value)));

    public static explicit operator int(HModule value) => (int)(value.Value);

    public static explicit operator HModule(long value) => new HModule(unchecked((void*)(value)));

    public static explicit operator long(HModule value) => (long)(value.Value);

    public static explicit operator HModule(nint value) => new HModule(unchecked((void*)(value)));

    public static implicit operator nint(HModule value) => (nint)(value.Value);

    public static explicit operator HModule(sbyte value) => new HModule(unchecked((void*)(value)));

    public static explicit operator sbyte(HModule value) => (sbyte)(value.Value);

    public static explicit operator HModule(ushort value) => new HModule(unchecked((void*)(value)));

    public static explicit operator ushort(HModule value) => (ushort)(value.Value);

    public static explicit operator HModule(uint value) => new HModule(unchecked((void*)(value)));

    public static explicit operator uint(HModule value) => (uint)(value.Value);

    public static explicit operator HModule(ulong value) => new HModule(unchecked((void*)(value)));

    public static explicit operator ulong(HModule value) => (ulong)(value.Value);

    public static explicit operator HModule(nuint value) => new HModule(unchecked((void*)(value)));

    public static implicit operator nuint(HModule value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HModule other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMODULE.");
    }

    public int CompareTo(HModule other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HModule other) && Equals(other);

    public bool Equals(HModule other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
