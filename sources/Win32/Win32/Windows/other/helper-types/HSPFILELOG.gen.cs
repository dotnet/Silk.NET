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

public readonly unsafe partial struct Hspfilelog
    : IComparable,
        IComparable<Hspfilelog>,
        IEquatable<Hspfilelog>,
        IFormattable
{
    public readonly void* Value;

    public Hspfilelog(void* value)
    {
        Value = value;
    }

    public static Hspfilelog INVALID_VALUE => new Hspfilelog((void*)(-1));
    public static Hspfilelog NULL => new Hspfilelog(null);

    public static bool operator ==(Hspfilelog left, Hspfilelog right) => left.Value == right.Value;

    public static bool operator !=(Hspfilelog left, Hspfilelog right) => left.Value != right.Value;

    public static bool operator <(Hspfilelog left, Hspfilelog right) => left.Value < right.Value;

    public static bool operator <=(Hspfilelog left, Hspfilelog right) => left.Value <= right.Value;

    public static bool operator >(Hspfilelog left, Hspfilelog right) => left.Value > right.Value;

    public static bool operator >=(Hspfilelog left, Hspfilelog right) => left.Value >= right.Value;

    public static explicit operator Hspfilelog(void* value) => new Hspfilelog(value);

    public static implicit operator void*(Hspfilelog value) => value.Value;

    public static explicit operator Hspfilelog(Handle value) => new Hspfilelog(value);

    public static implicit operator Handle(Hspfilelog value) => new Handle(value.Value);

    public static explicit operator Hspfilelog(byte value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static explicit operator byte(Hspfilelog value) => (byte)(value.Value);

    public static explicit operator Hspfilelog(short value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static explicit operator short(Hspfilelog value) => (short)(value.Value);

    public static explicit operator Hspfilelog(int value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static explicit operator int(Hspfilelog value) => (int)(value.Value);

    public static explicit operator Hspfilelog(long value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static explicit operator long(Hspfilelog value) => (long)(value.Value);

    public static explicit operator Hspfilelog(nint value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static implicit operator nint(Hspfilelog value) => (nint)(value.Value);

    public static explicit operator Hspfilelog(sbyte value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static explicit operator sbyte(Hspfilelog value) => (sbyte)(value.Value);

    public static explicit operator Hspfilelog(ushort value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static explicit operator ushort(Hspfilelog value) => (ushort)(value.Value);

    public static explicit operator Hspfilelog(uint value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static explicit operator uint(Hspfilelog value) => (uint)(value.Value);

    public static explicit operator Hspfilelog(ulong value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static explicit operator ulong(Hspfilelog value) => (ulong)(value.Value);

    public static explicit operator Hspfilelog(nuint value) =>
        new Hspfilelog(unchecked((void*)(value)));

    public static implicit operator nuint(Hspfilelog value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hspfilelog other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSPFILELOG.");
    }

    public int CompareTo(Hspfilelog other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hspfilelog other) && Equals(other);

    public bool Equals(Hspfilelog other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
