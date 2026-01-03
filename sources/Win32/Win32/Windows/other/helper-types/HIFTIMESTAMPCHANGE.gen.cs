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

public readonly unsafe partial struct Hiftimestampchange
    : IComparable,
        IComparable<Hiftimestampchange>,
        IEquatable<Hiftimestampchange>,
        IFormattable
{
    public readonly void* Value;

    public Hiftimestampchange(void* value)
    {
        Value = value;
    }

    public static Hiftimestampchange INVALID_VALUE => new Hiftimestampchange((void*)(-1));
    public static Hiftimestampchange NULL => new Hiftimestampchange(null);

    public static bool operator ==(Hiftimestampchange left, Hiftimestampchange right) =>
        left.Value == right.Value;

    public static bool operator !=(Hiftimestampchange left, Hiftimestampchange right) =>
        left.Value != right.Value;

    public static bool operator <(Hiftimestampchange left, Hiftimestampchange right) =>
        left.Value < right.Value;

    public static bool operator <=(Hiftimestampchange left, Hiftimestampchange right) =>
        left.Value <= right.Value;

    public static bool operator >(Hiftimestampchange left, Hiftimestampchange right) =>
        left.Value > right.Value;

    public static bool operator >=(Hiftimestampchange left, Hiftimestampchange right) =>
        left.Value >= right.Value;

    public static explicit operator Hiftimestampchange(void* value) =>
        new Hiftimestampchange(value);

    public static implicit operator void*(Hiftimestampchange value) => value.Value;

    public static explicit operator Hiftimestampchange(Handle value) =>
        new Hiftimestampchange(value);

    public static implicit operator Handle(Hiftimestampchange value) => new Handle(value.Value);

    public static explicit operator Hiftimestampchange(byte value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static explicit operator byte(Hiftimestampchange value) => (byte)(value.Value);

    public static explicit operator Hiftimestampchange(short value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static explicit operator short(Hiftimestampchange value) => (short)(value.Value);

    public static explicit operator Hiftimestampchange(int value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static explicit operator int(Hiftimestampchange value) => (int)(value.Value);

    public static explicit operator Hiftimestampchange(long value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static explicit operator long(Hiftimestampchange value) => (long)(value.Value);

    public static explicit operator Hiftimestampchange(nint value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static implicit operator nint(Hiftimestampchange value) => (nint)(value.Value);

    public static explicit operator Hiftimestampchange(sbyte value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static explicit operator sbyte(Hiftimestampchange value) => (sbyte)(value.Value);

    public static explicit operator Hiftimestampchange(ushort value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static explicit operator ushort(Hiftimestampchange value) => (ushort)(value.Value);

    public static explicit operator Hiftimestampchange(uint value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static explicit operator uint(Hiftimestampchange value) => (uint)(value.Value);

    public static explicit operator Hiftimestampchange(ulong value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static explicit operator ulong(Hiftimestampchange value) => (ulong)(value.Value);

    public static explicit operator Hiftimestampchange(nuint value) =>
        new Hiftimestampchange(unchecked((void*)(value)));

    public static implicit operator nuint(Hiftimestampchange value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hiftimestampchange other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HIFTIMESTAMPCHANGE.");
    }

    public int CompareTo(Hiftimestampchange other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hiftimestampchange other) && Equals(other);

    public bool Equals(Hiftimestampchange other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
