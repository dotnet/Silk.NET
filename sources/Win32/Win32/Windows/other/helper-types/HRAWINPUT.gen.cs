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
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct Hrawinput
    : IComparable,
        IComparable<Hrawinput>,
        IEquatable<Hrawinput>,
        IFormattable
{
    public readonly void* Value;

    public Hrawinput(void* value)
    {
        Value = value;
    }

    public static Hrawinput INVALID_VALUE => new Hrawinput((void*)(-1));
    public static Hrawinput NULL => new Hrawinput(null);

    public static bool operator ==(Hrawinput left, Hrawinput right) => left.Value == right.Value;

    public static bool operator !=(Hrawinput left, Hrawinput right) => left.Value != right.Value;

    public static bool operator <(Hrawinput left, Hrawinput right) => left.Value < right.Value;

    public static bool operator <=(Hrawinput left, Hrawinput right) => left.Value <= right.Value;

    public static bool operator >(Hrawinput left, Hrawinput right) => left.Value > right.Value;

    public static bool operator >=(Hrawinput left, Hrawinput right) => left.Value >= right.Value;

    public static explicit operator Hrawinput(void* value) => new Hrawinput(value);

    public static implicit operator void*(Hrawinput value) => value.Value;

    public static explicit operator Hrawinput(Handle value) => new Hrawinput(value);

    public static implicit operator Handle(Hrawinput value) => new Handle(value.Value);

    public static explicit operator Hrawinput(byte value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static explicit operator byte(Hrawinput value) => (byte)(value.Value);

    public static explicit operator Hrawinput(short value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static explicit operator short(Hrawinput value) => (short)(value.Value);

    public static explicit operator Hrawinput(int value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static explicit operator int(Hrawinput value) => (int)(value.Value);

    public static explicit operator Hrawinput(long value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static explicit operator long(Hrawinput value) => (long)(value.Value);

    public static explicit operator Hrawinput(nint value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static implicit operator nint(Hrawinput value) => (nint)(value.Value);

    public static explicit operator Hrawinput(sbyte value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static explicit operator sbyte(Hrawinput value) => (sbyte)(value.Value);

    public static explicit operator Hrawinput(ushort value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static explicit operator ushort(Hrawinput value) => (ushort)(value.Value);

    public static explicit operator Hrawinput(uint value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static explicit operator uint(Hrawinput value) => (uint)(value.Value);

    public static explicit operator Hrawinput(ulong value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static explicit operator ulong(Hrawinput value) => (ulong)(value.Value);

    public static explicit operator Hrawinput(nuint value) =>
        new Hrawinput(unchecked((void*)(value)));

    public static implicit operator nuint(Hrawinput value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hrawinput other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HRAWINPUT.");
    }

    public int CompareTo(Hrawinput other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hrawinput other) && Equals(other);

    public bool Equals(Hrawinput other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
