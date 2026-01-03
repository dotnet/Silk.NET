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

public readonly unsafe partial struct Hpowernotify
    : IComparable,
        IComparable<Hpowernotify>,
        IEquatable<Hpowernotify>,
        IFormattable
{
    public readonly void* Value;

    public Hpowernotify(void* value)
    {
        Value = value;
    }

    public static Hpowernotify INVALID_VALUE => new Hpowernotify((void*)(-1));
    public static Hpowernotify NULL => new Hpowernotify(null);

    public static bool operator ==(Hpowernotify left, Hpowernotify right) =>
        left.Value == right.Value;

    public static bool operator !=(Hpowernotify left, Hpowernotify right) =>
        left.Value != right.Value;

    public static bool operator <(Hpowernotify left, Hpowernotify right) =>
        left.Value < right.Value;

    public static bool operator <=(Hpowernotify left, Hpowernotify right) =>
        left.Value <= right.Value;

    public static bool operator >(Hpowernotify left, Hpowernotify right) =>
        left.Value > right.Value;

    public static bool operator >=(Hpowernotify left, Hpowernotify right) =>
        left.Value >= right.Value;

    public static explicit operator Hpowernotify(void* value) => new Hpowernotify(value);

    public static implicit operator void*(Hpowernotify value) => value.Value;

    public static explicit operator Hpowernotify(Handle value) => new Hpowernotify(value);

    public static implicit operator Handle(Hpowernotify value) => new Handle(value.Value);

    public static explicit operator Hpowernotify(byte value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static explicit operator byte(Hpowernotify value) => (byte)(value.Value);

    public static explicit operator Hpowernotify(short value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static explicit operator short(Hpowernotify value) => (short)(value.Value);

    public static explicit operator Hpowernotify(int value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static explicit operator int(Hpowernotify value) => (int)(value.Value);

    public static explicit operator Hpowernotify(long value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static explicit operator long(Hpowernotify value) => (long)(value.Value);

    public static explicit operator Hpowernotify(nint value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static implicit operator nint(Hpowernotify value) => (nint)(value.Value);

    public static explicit operator Hpowernotify(sbyte value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static explicit operator sbyte(Hpowernotify value) => (sbyte)(value.Value);

    public static explicit operator Hpowernotify(ushort value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static explicit operator ushort(Hpowernotify value) => (ushort)(value.Value);

    public static explicit operator Hpowernotify(uint value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static explicit operator uint(Hpowernotify value) => (uint)(value.Value);

    public static explicit operator Hpowernotify(ulong value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static explicit operator ulong(Hpowernotify value) => (ulong)(value.Value);

    public static explicit operator Hpowernotify(nuint value) =>
        new Hpowernotify(unchecked((void*)(value)));

    public static implicit operator nuint(Hpowernotify value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hpowernotify other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPOWERNOTIFY.");
    }

    public int CompareTo(Hpowernotify other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hpowernotify other) && Equals(other);

    public bool Equals(Hpowernotify other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
