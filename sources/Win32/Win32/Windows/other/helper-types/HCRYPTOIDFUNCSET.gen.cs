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

public readonly unsafe partial struct Hcryptoidfuncset
    : IComparable,
        IComparable<Hcryptoidfuncset>,
        IEquatable<Hcryptoidfuncset>,
        IFormattable
{
    public readonly void* Value;

    public Hcryptoidfuncset(void* value)
    {
        Value = value;
    }

    public static Hcryptoidfuncset INVALID_VALUE => new Hcryptoidfuncset((void*)(-1));
    public static Hcryptoidfuncset NULL => new Hcryptoidfuncset(null);

    public static bool operator ==(Hcryptoidfuncset left, Hcryptoidfuncset right) =>
        left.Value == right.Value;

    public static bool operator !=(Hcryptoidfuncset left, Hcryptoidfuncset right) =>
        left.Value != right.Value;

    public static bool operator <(Hcryptoidfuncset left, Hcryptoidfuncset right) =>
        left.Value < right.Value;

    public static bool operator <=(Hcryptoidfuncset left, Hcryptoidfuncset right) =>
        left.Value <= right.Value;

    public static bool operator >(Hcryptoidfuncset left, Hcryptoidfuncset right) =>
        left.Value > right.Value;

    public static bool operator >=(Hcryptoidfuncset left, Hcryptoidfuncset right) =>
        left.Value >= right.Value;

    public static explicit operator Hcryptoidfuncset(void* value) => new Hcryptoidfuncset(value);

    public static implicit operator void*(Hcryptoidfuncset value) => value.Value;

    public static explicit operator Hcryptoidfuncset(Handle value) => new Hcryptoidfuncset(value);

    public static implicit operator Handle(Hcryptoidfuncset value) => new Handle(value.Value);

    public static explicit operator Hcryptoidfuncset(byte value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static explicit operator byte(Hcryptoidfuncset value) => (byte)(value.Value);

    public static explicit operator Hcryptoidfuncset(short value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static explicit operator short(Hcryptoidfuncset value) => (short)(value.Value);

    public static explicit operator Hcryptoidfuncset(int value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static explicit operator int(Hcryptoidfuncset value) => (int)(value.Value);

    public static explicit operator Hcryptoidfuncset(long value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static explicit operator long(Hcryptoidfuncset value) => (long)(value.Value);

    public static explicit operator Hcryptoidfuncset(nint value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static implicit operator nint(Hcryptoidfuncset value) => (nint)(value.Value);

    public static explicit operator Hcryptoidfuncset(sbyte value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcryptoidfuncset value) => (sbyte)(value.Value);

    public static explicit operator Hcryptoidfuncset(ushort value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static explicit operator ushort(Hcryptoidfuncset value) => (ushort)(value.Value);

    public static explicit operator Hcryptoidfuncset(uint value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static explicit operator uint(Hcryptoidfuncset value) => (uint)(value.Value);

    public static explicit operator Hcryptoidfuncset(ulong value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static explicit operator ulong(Hcryptoidfuncset value) => (ulong)(value.Value);

    public static explicit operator Hcryptoidfuncset(nuint value) =>
        new Hcryptoidfuncset(unchecked((void*)(value)));

    public static implicit operator nuint(Hcryptoidfuncset value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcryptoidfuncset other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTOIDFUNCSET.");
    }

    public int CompareTo(Hcryptoidfuncset other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcryptoidfuncset other) && Equals(other);

    public bool Equals(Hcryptoidfuncset other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
