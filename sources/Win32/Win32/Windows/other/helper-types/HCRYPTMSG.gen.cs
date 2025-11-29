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

public readonly unsafe partial struct Hcryptmsg
    : IComparable,
        IComparable<Hcryptmsg>,
        IEquatable<Hcryptmsg>,
        IFormattable
{
    public readonly void* Value;

    public Hcryptmsg(void* value)
    {
        Value = value;
    }

    public static Hcryptmsg INVALID_VALUE => new Hcryptmsg((void*)(-1));
    public static Hcryptmsg NULL => new Hcryptmsg(null);

    public static bool operator ==(Hcryptmsg left, Hcryptmsg right) => left.Value == right.Value;

    public static bool operator !=(Hcryptmsg left, Hcryptmsg right) => left.Value != right.Value;

    public static bool operator <(Hcryptmsg left, Hcryptmsg right) => left.Value < right.Value;

    public static bool operator <=(Hcryptmsg left, Hcryptmsg right) => left.Value <= right.Value;

    public static bool operator >(Hcryptmsg left, Hcryptmsg right) => left.Value > right.Value;

    public static bool operator >=(Hcryptmsg left, Hcryptmsg right) => left.Value >= right.Value;

    public static explicit operator Hcryptmsg(void* value) => new Hcryptmsg(value);

    public static implicit operator void*(Hcryptmsg value) => value.Value;

    public static explicit operator Hcryptmsg(Handle value) => new Hcryptmsg(value);

    public static implicit operator Handle(Hcryptmsg value) => new Handle(value.Value);

    public static explicit operator Hcryptmsg(byte value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static explicit operator byte(Hcryptmsg value) => (byte)(value.Value);

    public static explicit operator Hcryptmsg(short value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static explicit operator short(Hcryptmsg value) => (short)(value.Value);

    public static explicit operator Hcryptmsg(int value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static explicit operator int(Hcryptmsg value) => (int)(value.Value);

    public static explicit operator Hcryptmsg(long value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static explicit operator long(Hcryptmsg value) => (long)(value.Value);

    public static explicit operator Hcryptmsg(nint value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static implicit operator nint(Hcryptmsg value) => (nint)(value.Value);

    public static explicit operator Hcryptmsg(sbyte value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcryptmsg value) => (sbyte)(value.Value);

    public static explicit operator Hcryptmsg(ushort value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static explicit operator ushort(Hcryptmsg value) => (ushort)(value.Value);

    public static explicit operator Hcryptmsg(uint value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static explicit operator uint(Hcryptmsg value) => (uint)(value.Value);

    public static explicit operator Hcryptmsg(ulong value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static explicit operator ulong(Hcryptmsg value) => (ulong)(value.Value);

    public static explicit operator Hcryptmsg(nuint value) =>
        new Hcryptmsg(unchecked((void*)(value)));

    public static implicit operator nuint(Hcryptmsg value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcryptmsg other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTMSG.");
    }

    public int CompareTo(Hcryptmsg other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcryptmsg other) && Equals(other);

    public bool Equals(Hcryptmsg other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
