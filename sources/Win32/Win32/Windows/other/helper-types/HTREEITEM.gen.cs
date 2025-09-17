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

public readonly unsafe partial struct Htreeitem
    : IComparable,
        IComparable<Htreeitem>,
        IEquatable<Htreeitem>,
        IFormattable
{
    public readonly void* Value;

    public Htreeitem(void* value)
    {
        Value = value;
    }

    public static Htreeitem INVALID_VALUE => new Htreeitem((void*)(-1));
    public static Htreeitem NULL => new Htreeitem(null);

    public static bool operator ==(Htreeitem left, Htreeitem right) => left.Value == right.Value;

    public static bool operator !=(Htreeitem left, Htreeitem right) => left.Value != right.Value;

    public static bool operator <(Htreeitem left, Htreeitem right) => left.Value < right.Value;

    public static bool operator <=(Htreeitem left, Htreeitem right) => left.Value <= right.Value;

    public static bool operator >(Htreeitem left, Htreeitem right) => left.Value > right.Value;

    public static bool operator >=(Htreeitem left, Htreeitem right) => left.Value >= right.Value;

    public static explicit operator Htreeitem(void* value) => new Htreeitem(value);

    public static implicit operator void*(Htreeitem value) => value.Value;

    public static explicit operator Htreeitem(Handle value) => new Htreeitem(value);

    public static implicit operator Handle(Htreeitem value) => new Handle(value.Value);

    public static explicit operator Htreeitem(byte value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static explicit operator byte(Htreeitem value) => (byte)(value.Value);

    public static explicit operator Htreeitem(short value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static explicit operator short(Htreeitem value) => (short)(value.Value);

    public static explicit operator Htreeitem(int value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static explicit operator int(Htreeitem value) => (int)(value.Value);

    public static explicit operator Htreeitem(long value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static explicit operator long(Htreeitem value) => (long)(value.Value);

    public static explicit operator Htreeitem(nint value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static implicit operator nint(Htreeitem value) => (nint)(value.Value);

    public static explicit operator Htreeitem(sbyte value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static explicit operator sbyte(Htreeitem value) => (sbyte)(value.Value);

    public static explicit operator Htreeitem(ushort value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static explicit operator ushort(Htreeitem value) => (ushort)(value.Value);

    public static explicit operator Htreeitem(uint value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static explicit operator uint(Htreeitem value) => (uint)(value.Value);

    public static explicit operator Htreeitem(ulong value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static explicit operator ulong(Htreeitem value) => (ulong)(value.Value);

    public static explicit operator Htreeitem(nuint value) =>
        new Htreeitem(unchecked((void*)(value)));

    public static implicit operator nuint(Htreeitem value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Htreeitem other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HTREEITEM.");
    }

    public int CompareTo(Htreeitem other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Htreeitem other) && Equals(other);

    public bool Equals(Htreeitem other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
