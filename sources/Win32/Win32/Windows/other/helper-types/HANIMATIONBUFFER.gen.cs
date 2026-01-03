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

public readonly unsafe partial struct Hanimationbuffer
    : IComparable,
        IComparable<Hanimationbuffer>,
        IEquatable<Hanimationbuffer>,
        IFormattable
{
    public readonly void* Value;

    public Hanimationbuffer(void* value)
    {
        Value = value;
    }

    public static Hanimationbuffer INVALID_VALUE => new Hanimationbuffer((void*)(-1));
    public static Hanimationbuffer NULL => new Hanimationbuffer(null);

    public static bool operator ==(Hanimationbuffer left, Hanimationbuffer right) =>
        left.Value == right.Value;

    public static bool operator !=(Hanimationbuffer left, Hanimationbuffer right) =>
        left.Value != right.Value;

    public static bool operator <(Hanimationbuffer left, Hanimationbuffer right) =>
        left.Value < right.Value;

    public static bool operator <=(Hanimationbuffer left, Hanimationbuffer right) =>
        left.Value <= right.Value;

    public static bool operator >(Hanimationbuffer left, Hanimationbuffer right) =>
        left.Value > right.Value;

    public static bool operator >=(Hanimationbuffer left, Hanimationbuffer right) =>
        left.Value >= right.Value;

    public static explicit operator Hanimationbuffer(void* value) => new Hanimationbuffer(value);

    public static implicit operator void*(Hanimationbuffer value) => value.Value;

    public static explicit operator Hanimationbuffer(Handle value) => new Hanimationbuffer(value);

    public static implicit operator Handle(Hanimationbuffer value) => new Handle(value.Value);

    public static explicit operator Hanimationbuffer(byte value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static explicit operator byte(Hanimationbuffer value) => (byte)(value.Value);

    public static explicit operator Hanimationbuffer(short value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static explicit operator short(Hanimationbuffer value) => (short)(value.Value);

    public static explicit operator Hanimationbuffer(int value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static explicit operator int(Hanimationbuffer value) => (int)(value.Value);

    public static explicit operator Hanimationbuffer(long value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static explicit operator long(Hanimationbuffer value) => (long)(value.Value);

    public static explicit operator Hanimationbuffer(nint value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static implicit operator nint(Hanimationbuffer value) => (nint)(value.Value);

    public static explicit operator Hanimationbuffer(sbyte value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static explicit operator sbyte(Hanimationbuffer value) => (sbyte)(value.Value);

    public static explicit operator Hanimationbuffer(ushort value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static explicit operator ushort(Hanimationbuffer value) => (ushort)(value.Value);

    public static explicit operator Hanimationbuffer(uint value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static explicit operator uint(Hanimationbuffer value) => (uint)(value.Value);

    public static explicit operator Hanimationbuffer(ulong value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static explicit operator ulong(Hanimationbuffer value) => (ulong)(value.Value);

    public static explicit operator Hanimationbuffer(nuint value) =>
        new Hanimationbuffer(unchecked((void*)(value)));

    public static implicit operator nuint(Hanimationbuffer value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hanimationbuffer other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HANIMATIONBUFFER.");
    }

    public int CompareTo(Hanimationbuffer other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hanimationbuffer other) && Equals(other);

    public bool Equals(Hanimationbuffer other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
