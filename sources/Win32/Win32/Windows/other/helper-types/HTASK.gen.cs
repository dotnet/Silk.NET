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

public readonly unsafe partial struct Htask
    : IComparable,
        IComparable<Htask>,
        IEquatable<Htask>,
        IFormattable
{
    public readonly void* Value;

    public Htask(void* value)
    {
        Value = value;
    }

    public static Htask INVALID_VALUE => new Htask((void*)(-1));
    public static Htask NULL => new Htask(null);

    public static bool operator ==(Htask left, Htask right) => left.Value == right.Value;

    public static bool operator !=(Htask left, Htask right) => left.Value != right.Value;

    public static bool operator <(Htask left, Htask right) => left.Value < right.Value;

    public static bool operator <=(Htask left, Htask right) => left.Value <= right.Value;

    public static bool operator >(Htask left, Htask right) => left.Value > right.Value;

    public static bool operator >=(Htask left, Htask right) => left.Value >= right.Value;

    public static explicit operator Htask(void* value) => new Htask(value);

    public static implicit operator void*(Htask value) => value.Value;

    public static explicit operator Htask(Handle value) => new Htask(value);

    public static implicit operator Handle(Htask value) => new Handle(value.Value);

    public static explicit operator Htask(byte value) => new Htask(unchecked((void*)(value)));

    public static explicit operator byte(Htask value) => (byte)(value.Value);

    public static explicit operator Htask(short value) => new Htask(unchecked((void*)(value)));

    public static explicit operator short(Htask value) => (short)(value.Value);

    public static explicit operator Htask(int value) => new Htask(unchecked((void*)(value)));

    public static explicit operator int(Htask value) => (int)(value.Value);

    public static explicit operator Htask(long value) => new Htask(unchecked((void*)(value)));

    public static explicit operator long(Htask value) => (long)(value.Value);

    public static explicit operator Htask(nint value) => new Htask(unchecked((void*)(value)));

    public static implicit operator nint(Htask value) => (nint)(value.Value);

    public static explicit operator Htask(sbyte value) => new Htask(unchecked((void*)(value)));

    public static explicit operator sbyte(Htask value) => (sbyte)(value.Value);

    public static explicit operator Htask(ushort value) => new Htask(unchecked((void*)(value)));

    public static explicit operator ushort(Htask value) => (ushort)(value.Value);

    public static explicit operator Htask(uint value) => new Htask(unchecked((void*)(value)));

    public static explicit operator uint(Htask value) => (uint)(value.Value);

    public static explicit operator Htask(ulong value) => new Htask(unchecked((void*)(value)));

    public static explicit operator ulong(Htask value) => (ulong)(value.Value);

    public static explicit operator Htask(nuint value) => new Htask(unchecked((void*)(value)));

    public static implicit operator nuint(Htask value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Htask other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HTASK.");
    }

    public int CompareTo(Htask other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Htask other) && Equals(other);

    public bool Equals(Htask other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
