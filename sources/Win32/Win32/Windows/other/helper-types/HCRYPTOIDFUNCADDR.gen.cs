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

public readonly unsafe partial struct Hcryptoidfuncaddr
    : IComparable,
        IComparable<Hcryptoidfuncaddr>,
        IEquatable<Hcryptoidfuncaddr>,
        IFormattable
{
    public readonly void* Value;

    public Hcryptoidfuncaddr(void* value)
    {
        Value = value;
    }

    public static Hcryptoidfuncaddr INVALID_VALUE => new Hcryptoidfuncaddr((void*)(-1));
    public static Hcryptoidfuncaddr NULL => new Hcryptoidfuncaddr(null);

    public static bool operator ==(Hcryptoidfuncaddr left, Hcryptoidfuncaddr right) =>
        left.Value == right.Value;

    public static bool operator !=(Hcryptoidfuncaddr left, Hcryptoidfuncaddr right) =>
        left.Value != right.Value;

    public static bool operator <(Hcryptoidfuncaddr left, Hcryptoidfuncaddr right) =>
        left.Value < right.Value;

    public static bool operator <=(Hcryptoidfuncaddr left, Hcryptoidfuncaddr right) =>
        left.Value <= right.Value;

    public static bool operator >(Hcryptoidfuncaddr left, Hcryptoidfuncaddr right) =>
        left.Value > right.Value;

    public static bool operator >=(Hcryptoidfuncaddr left, Hcryptoidfuncaddr right) =>
        left.Value >= right.Value;

    public static explicit operator Hcryptoidfuncaddr(void* value) => new Hcryptoidfuncaddr(value);

    public static implicit operator void*(Hcryptoidfuncaddr value) => value.Value;

    public static explicit operator Hcryptoidfuncaddr(Handle value) => new Hcryptoidfuncaddr(value);

    public static implicit operator Handle(Hcryptoidfuncaddr value) => new Handle(value.Value);

    public static explicit operator Hcryptoidfuncaddr(byte value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static explicit operator byte(Hcryptoidfuncaddr value) => (byte)(value.Value);

    public static explicit operator Hcryptoidfuncaddr(short value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static explicit operator short(Hcryptoidfuncaddr value) => (short)(value.Value);

    public static explicit operator Hcryptoidfuncaddr(int value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static explicit operator int(Hcryptoidfuncaddr value) => (int)(value.Value);

    public static explicit operator Hcryptoidfuncaddr(long value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static explicit operator long(Hcryptoidfuncaddr value) => (long)(value.Value);

    public static explicit operator Hcryptoidfuncaddr(nint value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static implicit operator nint(Hcryptoidfuncaddr value) => (nint)(value.Value);

    public static explicit operator Hcryptoidfuncaddr(sbyte value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcryptoidfuncaddr value) => (sbyte)(value.Value);

    public static explicit operator Hcryptoidfuncaddr(ushort value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static explicit operator ushort(Hcryptoidfuncaddr value) => (ushort)(value.Value);

    public static explicit operator Hcryptoidfuncaddr(uint value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static explicit operator uint(Hcryptoidfuncaddr value) => (uint)(value.Value);

    public static explicit operator Hcryptoidfuncaddr(ulong value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static explicit operator ulong(Hcryptoidfuncaddr value) => (ulong)(value.Value);

    public static explicit operator Hcryptoidfuncaddr(nuint value) =>
        new Hcryptoidfuncaddr(unchecked((void*)(value)));

    public static implicit operator nuint(Hcryptoidfuncaddr value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcryptoidfuncaddr other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTOIDFUNCADDR.");
    }

    public int CompareTo(Hcryptoidfuncaddr other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcryptoidfuncaddr other) && Equals(other);

    public bool Equals(Hcryptoidfuncaddr other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
