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

public readonly unsafe partial struct Hcrypthash
    : IComparable,
        IComparable<Hcrypthash>,
        IEquatable<Hcrypthash>,
        IFormattable
{
    public readonly void* Value;

    public Hcrypthash(void* value)
    {
        Value = value;
    }

    public static Hcrypthash INVALID_VALUE => new Hcrypthash((void*)(-1));
    public static Hcrypthash NULL => new Hcrypthash(null);

    public static bool operator ==(Hcrypthash left, Hcrypthash right) => left.Value == right.Value;

    public static bool operator !=(Hcrypthash left, Hcrypthash right) => left.Value != right.Value;

    public static bool operator <(Hcrypthash left, Hcrypthash right) => left.Value < right.Value;

    public static bool operator <=(Hcrypthash left, Hcrypthash right) => left.Value <= right.Value;

    public static bool operator >(Hcrypthash left, Hcrypthash right) => left.Value > right.Value;

    public static bool operator >=(Hcrypthash left, Hcrypthash right) => left.Value >= right.Value;

    public static explicit operator Hcrypthash(void* value) => new Hcrypthash(value);

    public static implicit operator void*(Hcrypthash value) => value.Value;

    public static explicit operator Hcrypthash(Handle value) => new Hcrypthash(value);

    public static implicit operator Handle(Hcrypthash value) => new Handle(value.Value);

    public static explicit operator Hcrypthash(byte value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static explicit operator byte(Hcrypthash value) => (byte)(value.Value);

    public static explicit operator Hcrypthash(short value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static explicit operator short(Hcrypthash value) => (short)(value.Value);

    public static explicit operator Hcrypthash(int value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static explicit operator int(Hcrypthash value) => (int)(value.Value);

    public static explicit operator Hcrypthash(long value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static explicit operator long(Hcrypthash value) => (long)(value.Value);

    public static explicit operator Hcrypthash(nint value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static implicit operator nint(Hcrypthash value) => (nint)(value.Value);

    public static explicit operator Hcrypthash(sbyte value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcrypthash value) => (sbyte)(value.Value);

    public static explicit operator Hcrypthash(ushort value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static explicit operator ushort(Hcrypthash value) => (ushort)(value.Value);

    public static explicit operator Hcrypthash(uint value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static explicit operator uint(Hcrypthash value) => (uint)(value.Value);

    public static explicit operator Hcrypthash(ulong value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static explicit operator ulong(Hcrypthash value) => (ulong)(value.Value);

    public static explicit operator Hcrypthash(nuint value) =>
        new Hcrypthash(unchecked((void*)(value)));

    public static implicit operator nuint(Hcrypthash value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcrypthash other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTHASH.");
    }

    public int CompareTo(Hcrypthash other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcrypthash other) && Equals(other);

    public bool Equals(Hcrypthash other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
