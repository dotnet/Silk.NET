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

public readonly unsafe partial struct Hinstance
    : IComparable,
        IComparable<Hinstance>,
        IEquatable<Hinstance>,
        IFormattable
{
    public readonly void* Value;

    public Hinstance(void* value)
    {
        Value = value;
    }

    public static Hinstance INVALID_VALUE => new Hinstance((void*)(-1));
    public static Hinstance NULL => new Hinstance(null);

    public static bool operator ==(Hinstance left, Hinstance right) => left.Value == right.Value;

    public static bool operator !=(Hinstance left, Hinstance right) => left.Value != right.Value;

    public static bool operator <(Hinstance left, Hinstance right) => left.Value < right.Value;

    public static bool operator <=(Hinstance left, Hinstance right) => left.Value <= right.Value;

    public static bool operator >(Hinstance left, Hinstance right) => left.Value > right.Value;

    public static bool operator >=(Hinstance left, Hinstance right) => left.Value >= right.Value;

    public static explicit operator Hinstance(void* value) => new Hinstance(value);

    public static implicit operator void*(Hinstance value) => value.Value;

    public static explicit operator Hinstance(Handle value) => new Hinstance(value);

    public static implicit operator Handle(Hinstance value) => new Handle(value.Value);

    public static explicit operator Hinstance(byte value) =>
        new Hinstance(unchecked((void*)(value)));

    public static explicit operator byte(Hinstance value) => (byte)(value.Value);

    public static explicit operator Hinstance(short value) =>
        new Hinstance(unchecked((void*)(value)));

    public static explicit operator short(Hinstance value) => (short)(value.Value);

    public static explicit operator Hinstance(int value) =>
        new Hinstance(unchecked((void*)(value)));

    public static explicit operator int(Hinstance value) => (int)(value.Value);

    public static explicit operator Hinstance(long value) =>
        new Hinstance(unchecked((void*)(value)));

    public static explicit operator long(Hinstance value) => (long)(value.Value);

    public static explicit operator Hinstance(nint value) =>
        new Hinstance(unchecked((void*)(value)));

    public static implicit operator nint(Hinstance value) => (nint)(value.Value);

    public static explicit operator Hinstance(sbyte value) =>
        new Hinstance(unchecked((void*)(value)));

    public static explicit operator sbyte(Hinstance value) => (sbyte)(value.Value);

    public static explicit operator Hinstance(ushort value) =>
        new Hinstance(unchecked((void*)(value)));

    public static explicit operator ushort(Hinstance value) => (ushort)(value.Value);

    public static explicit operator Hinstance(uint value) =>
        new Hinstance(unchecked((void*)(value)));

    public static explicit operator uint(Hinstance value) => (uint)(value.Value);

    public static explicit operator Hinstance(ulong value) =>
        new Hinstance(unchecked((void*)(value)));

    public static explicit operator ulong(Hinstance value) => (ulong)(value.Value);

    public static explicit operator Hinstance(nuint value) =>
        new Hinstance(unchecked((void*)(value)));

    public static implicit operator nuint(Hinstance value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hinstance other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HINSTANCE.");
    }

    public int CompareTo(Hinstance other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hinstance other) && Equals(other);

    public bool Equals(Hinstance other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
