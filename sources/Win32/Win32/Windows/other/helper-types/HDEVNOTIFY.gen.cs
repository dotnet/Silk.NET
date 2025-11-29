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

public readonly unsafe partial struct Hdevnotify
    : IComparable,
        IComparable<Hdevnotify>,
        IEquatable<Hdevnotify>,
        IFormattable
{
    public readonly void* Value;

    public Hdevnotify(void* value)
    {
        Value = value;
    }

    public static Hdevnotify INVALID_VALUE => new Hdevnotify((void*)(-1));
    public static Hdevnotify NULL => new Hdevnotify(null);

    public static bool operator ==(Hdevnotify left, Hdevnotify right) => left.Value == right.Value;

    public static bool operator !=(Hdevnotify left, Hdevnotify right) => left.Value != right.Value;

    public static bool operator <(Hdevnotify left, Hdevnotify right) => left.Value < right.Value;

    public static bool operator <=(Hdevnotify left, Hdevnotify right) => left.Value <= right.Value;

    public static bool operator >(Hdevnotify left, Hdevnotify right) => left.Value > right.Value;

    public static bool operator >=(Hdevnotify left, Hdevnotify right) => left.Value >= right.Value;

    public static explicit operator Hdevnotify(void* value) => new Hdevnotify(value);

    public static implicit operator void*(Hdevnotify value) => value.Value;

    public static explicit operator Hdevnotify(Handle value) => new Hdevnotify(value);

    public static implicit operator Handle(Hdevnotify value) => new Handle(value.Value);

    public static explicit operator Hdevnotify(byte value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static explicit operator byte(Hdevnotify value) => (byte)(value.Value);

    public static explicit operator Hdevnotify(short value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static explicit operator short(Hdevnotify value) => (short)(value.Value);

    public static explicit operator Hdevnotify(int value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static explicit operator int(Hdevnotify value) => (int)(value.Value);

    public static explicit operator Hdevnotify(long value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static explicit operator long(Hdevnotify value) => (long)(value.Value);

    public static explicit operator Hdevnotify(nint value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static implicit operator nint(Hdevnotify value) => (nint)(value.Value);

    public static explicit operator Hdevnotify(sbyte value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static explicit operator sbyte(Hdevnotify value) => (sbyte)(value.Value);

    public static explicit operator Hdevnotify(ushort value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static explicit operator ushort(Hdevnotify value) => (ushort)(value.Value);

    public static explicit operator Hdevnotify(uint value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static explicit operator uint(Hdevnotify value) => (uint)(value.Value);

    public static explicit operator Hdevnotify(ulong value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static explicit operator ulong(Hdevnotify value) => (ulong)(value.Value);

    public static explicit operator Hdevnotify(nuint value) =>
        new Hdevnotify(unchecked((void*)(value)));

    public static implicit operator nuint(Hdevnotify value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hdevnotify other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HDEVNOTIFY.");
    }

    public int CompareTo(Hdevnotify other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hdevnotify other) && Equals(other);

    public bool Equals(Hdevnotify other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
