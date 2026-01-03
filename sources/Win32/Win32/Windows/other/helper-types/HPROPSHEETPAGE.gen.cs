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

public readonly unsafe partial struct Hpropsheetpage
    : IComparable,
        IComparable<Hpropsheetpage>,
        IEquatable<Hpropsheetpage>,
        IFormattable
{
    public readonly void* Value;

    public Hpropsheetpage(void* value)
    {
        Value = value;
    }

    public static Hpropsheetpage INVALID_VALUE => new Hpropsheetpage((void*)(-1));
    public static Hpropsheetpage NULL => new Hpropsheetpage(null);

    public static bool operator ==(Hpropsheetpage left, Hpropsheetpage right) =>
        left.Value == right.Value;

    public static bool operator !=(Hpropsheetpage left, Hpropsheetpage right) =>
        left.Value != right.Value;

    public static bool operator <(Hpropsheetpage left, Hpropsheetpage right) =>
        left.Value < right.Value;

    public static bool operator <=(Hpropsheetpage left, Hpropsheetpage right) =>
        left.Value <= right.Value;

    public static bool operator >(Hpropsheetpage left, Hpropsheetpage right) =>
        left.Value > right.Value;

    public static bool operator >=(Hpropsheetpage left, Hpropsheetpage right) =>
        left.Value >= right.Value;

    public static explicit operator Hpropsheetpage(void* value) => new Hpropsheetpage(value);

    public static implicit operator void*(Hpropsheetpage value) => value.Value;

    public static explicit operator Hpropsheetpage(Handle value) => new Hpropsheetpage(value);

    public static implicit operator Handle(Hpropsheetpage value) => new Handle(value.Value);

    public static explicit operator Hpropsheetpage(byte value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static explicit operator byte(Hpropsheetpage value) => (byte)(value.Value);

    public static explicit operator Hpropsheetpage(short value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static explicit operator short(Hpropsheetpage value) => (short)(value.Value);

    public static explicit operator Hpropsheetpage(int value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static explicit operator int(Hpropsheetpage value) => (int)(value.Value);

    public static explicit operator Hpropsheetpage(long value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static explicit operator long(Hpropsheetpage value) => (long)(value.Value);

    public static explicit operator Hpropsheetpage(nint value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static implicit operator nint(Hpropsheetpage value) => (nint)(value.Value);

    public static explicit operator Hpropsheetpage(sbyte value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static explicit operator sbyte(Hpropsheetpage value) => (sbyte)(value.Value);

    public static explicit operator Hpropsheetpage(ushort value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static explicit operator ushort(Hpropsheetpage value) => (ushort)(value.Value);

    public static explicit operator Hpropsheetpage(uint value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static explicit operator uint(Hpropsheetpage value) => (uint)(value.Value);

    public static explicit operator Hpropsheetpage(ulong value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static explicit operator ulong(Hpropsheetpage value) => (ulong)(value.Value);

    public static explicit operator Hpropsheetpage(nuint value) =>
        new Hpropsheetpage(unchecked((void*)(value)));

    public static implicit operator nuint(Hpropsheetpage value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hpropsheetpage other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPROPSHEETPAGE.");
    }

    public int CompareTo(Hpropsheetpage other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hpropsheetpage other) && Equals(other);

    public bool Equals(Hpropsheetpage other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
