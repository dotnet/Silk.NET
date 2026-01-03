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

public readonly unsafe partial struct Hhook
    : IComparable,
        IComparable<Hhook>,
        IEquatable<Hhook>,
        IFormattable
{
    public readonly void* Value;

    public Hhook(void* value)
    {
        Value = value;
    }

    public static Hhook INVALID_VALUE => new Hhook((void*)(-1));
    public static Hhook NULL => new Hhook(null);

    public static bool operator ==(Hhook left, Hhook right) => left.Value == right.Value;

    public static bool operator !=(Hhook left, Hhook right) => left.Value != right.Value;

    public static bool operator <(Hhook left, Hhook right) => left.Value < right.Value;

    public static bool operator <=(Hhook left, Hhook right) => left.Value <= right.Value;

    public static bool operator >(Hhook left, Hhook right) => left.Value > right.Value;

    public static bool operator >=(Hhook left, Hhook right) => left.Value >= right.Value;

    public static explicit operator Hhook(void* value) => new Hhook(value);

    public static implicit operator void*(Hhook value) => value.Value;

    public static explicit operator Hhook(Handle value) => new Hhook(value);

    public static implicit operator Handle(Hhook value) => new Handle(value.Value);

    public static explicit operator Hhook(byte value) => new Hhook(unchecked((void*)(value)));

    public static explicit operator byte(Hhook value) => (byte)(value.Value);

    public static explicit operator Hhook(short value) => new Hhook(unchecked((void*)(value)));

    public static explicit operator short(Hhook value) => (short)(value.Value);

    public static explicit operator Hhook(int value) => new Hhook(unchecked((void*)(value)));

    public static explicit operator int(Hhook value) => (int)(value.Value);

    public static explicit operator Hhook(long value) => new Hhook(unchecked((void*)(value)));

    public static explicit operator long(Hhook value) => (long)(value.Value);

    public static explicit operator Hhook(nint value) => new Hhook(unchecked((void*)(value)));

    public static implicit operator nint(Hhook value) => (nint)(value.Value);

    public static explicit operator Hhook(sbyte value) => new Hhook(unchecked((void*)(value)));

    public static explicit operator sbyte(Hhook value) => (sbyte)(value.Value);

    public static explicit operator Hhook(ushort value) => new Hhook(unchecked((void*)(value)));

    public static explicit operator ushort(Hhook value) => (ushort)(value.Value);

    public static explicit operator Hhook(uint value) => new Hhook(unchecked((void*)(value)));

    public static explicit operator uint(Hhook value) => (uint)(value.Value);

    public static explicit operator Hhook(ulong value) => new Hhook(unchecked((void*)(value)));

    public static explicit operator ulong(Hhook value) => (ulong)(value.Value);

    public static explicit operator Hhook(nuint value) => new Hhook(unchecked((void*)(value)));

    public static implicit operator nuint(Hhook value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hhook other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HHOOK.");
    }

    public int CompareTo(Hhook other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hhook other) && Equals(other);

    public bool Equals(Hhook other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
