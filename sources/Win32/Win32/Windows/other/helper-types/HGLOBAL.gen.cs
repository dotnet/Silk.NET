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

public readonly unsafe partial struct Hglobal
    : IComparable,
        IComparable<Hglobal>,
        IEquatable<Hglobal>,
        IFormattable
{
    public readonly void* Value;

    public Hglobal(void* value)
    {
        Value = value;
    }

    public static Hglobal INVALID_VALUE => new Hglobal((void*)(-1));
    public static Hglobal NULL => new Hglobal(null);

    public static bool operator ==(Hglobal left, Hglobal right) => left.Value == right.Value;

    public static bool operator !=(Hglobal left, Hglobal right) => left.Value != right.Value;

    public static bool operator <(Hglobal left, Hglobal right) => left.Value < right.Value;

    public static bool operator <=(Hglobal left, Hglobal right) => left.Value <= right.Value;

    public static bool operator >(Hglobal left, Hglobal right) => left.Value > right.Value;

    public static bool operator >=(Hglobal left, Hglobal right) => left.Value >= right.Value;

    public static explicit operator Hglobal(void* value) => new Hglobal(value);

    public static implicit operator void*(Hglobal value) => value.Value;

    public static explicit operator Hglobal(Handle value) => new Hglobal(value);

    public static implicit operator Handle(Hglobal value) => new Handle(value.Value);

    public static explicit operator Hglobal(byte value) => new Hglobal(unchecked((void*)(value)));

    public static explicit operator byte(Hglobal value) => (byte)(value.Value);

    public static explicit operator Hglobal(short value) => new Hglobal(unchecked((void*)(value)));

    public static explicit operator short(Hglobal value) => (short)(value.Value);

    public static explicit operator Hglobal(int value) => new Hglobal(unchecked((void*)(value)));

    public static explicit operator int(Hglobal value) => (int)(value.Value);

    public static explicit operator Hglobal(long value) => new Hglobal(unchecked((void*)(value)));

    public static explicit operator long(Hglobal value) => (long)(value.Value);

    public static explicit operator Hglobal(nint value) => new Hglobal(unchecked((void*)(value)));

    public static implicit operator nint(Hglobal value) => (nint)(value.Value);

    public static explicit operator Hglobal(sbyte value) => new Hglobal(unchecked((void*)(value)));

    public static explicit operator sbyte(Hglobal value) => (sbyte)(value.Value);

    public static explicit operator Hglobal(ushort value) => new Hglobal(unchecked((void*)(value)));

    public static explicit operator ushort(Hglobal value) => (ushort)(value.Value);

    public static explicit operator Hglobal(uint value) => new Hglobal(unchecked((void*)(value)));

    public static explicit operator uint(Hglobal value) => (uint)(value.Value);

    public static explicit operator Hglobal(ulong value) => new Hglobal(unchecked((void*)(value)));

    public static explicit operator ulong(Hglobal value) => (ulong)(value.Value);

    public static explicit operator Hglobal(nuint value) => new Hglobal(unchecked((void*)(value)));

    public static implicit operator nuint(Hglobal value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hglobal other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HGLOBAL.");
    }

    public int CompareTo(Hglobal other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hglobal other) && Equals(other);

    public bool Equals(Hglobal other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
