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

public readonly unsafe partial struct Hinteractioncontext
    : IComparable,
        IComparable<Hinteractioncontext>,
        IEquatable<Hinteractioncontext>,
        IFormattable
{
    public readonly void* Value;

    public Hinteractioncontext(void* value)
    {
        Value = value;
    }

    public static Hinteractioncontext INVALID_VALUE => new Hinteractioncontext((void*)(-1));
    public static Hinteractioncontext NULL => new Hinteractioncontext(null);

    public static bool operator ==(Hinteractioncontext left, Hinteractioncontext right) =>
        left.Value == right.Value;

    public static bool operator !=(Hinteractioncontext left, Hinteractioncontext right) =>
        left.Value != right.Value;

    public static bool operator <(Hinteractioncontext left, Hinteractioncontext right) =>
        left.Value < right.Value;

    public static bool operator <=(Hinteractioncontext left, Hinteractioncontext right) =>
        left.Value <= right.Value;

    public static bool operator >(Hinteractioncontext left, Hinteractioncontext right) =>
        left.Value > right.Value;

    public static bool operator >=(Hinteractioncontext left, Hinteractioncontext right) =>
        left.Value >= right.Value;

    public static explicit operator Hinteractioncontext(void* value) =>
        new Hinteractioncontext(value);

    public static implicit operator void*(Hinteractioncontext value) => value.Value;

    public static explicit operator Hinteractioncontext(Handle value) =>
        new Hinteractioncontext(value);

    public static implicit operator Handle(Hinteractioncontext value) => new Handle(value.Value);

    public static explicit operator Hinteractioncontext(byte value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static explicit operator byte(Hinteractioncontext value) => (byte)(value.Value);

    public static explicit operator Hinteractioncontext(short value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static explicit operator short(Hinteractioncontext value) => (short)(value.Value);

    public static explicit operator Hinteractioncontext(int value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static explicit operator int(Hinteractioncontext value) => (int)(value.Value);

    public static explicit operator Hinteractioncontext(long value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static explicit operator long(Hinteractioncontext value) => (long)(value.Value);

    public static explicit operator Hinteractioncontext(nint value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static implicit operator nint(Hinteractioncontext value) => (nint)(value.Value);

    public static explicit operator Hinteractioncontext(sbyte value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static explicit operator sbyte(Hinteractioncontext value) => (sbyte)(value.Value);

    public static explicit operator Hinteractioncontext(ushort value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static explicit operator ushort(Hinteractioncontext value) => (ushort)(value.Value);

    public static explicit operator Hinteractioncontext(uint value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static explicit operator uint(Hinteractioncontext value) => (uint)(value.Value);

    public static explicit operator Hinteractioncontext(ulong value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static explicit operator ulong(Hinteractioncontext value) => (ulong)(value.Value);

    public static explicit operator Hinteractioncontext(nuint value) =>
        new Hinteractioncontext(unchecked((void*)(value)));

    public static implicit operator nuint(Hinteractioncontext value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hinteractioncontext other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HINTERACTIONCONTEXT.");
    }

    public int CompareTo(Hinteractioncontext other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hinteractioncontext other) && Equals(other);

    public bool Equals(Hinteractioncontext other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
