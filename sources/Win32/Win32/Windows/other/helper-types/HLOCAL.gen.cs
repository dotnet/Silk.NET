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

public readonly unsafe partial struct Hlocal
    : IComparable,
        IComparable<Hlocal>,
        IEquatable<Hlocal>,
        IFormattable
{
    public readonly void* Value;

    public Hlocal(void* value)
    {
        Value = value;
    }

    public static Hlocal INVALID_VALUE => new Hlocal((void*)(-1));
    public static Hlocal NULL => new Hlocal(null);

    public static bool operator ==(Hlocal left, Hlocal right) => left.Value == right.Value;

    public static bool operator !=(Hlocal left, Hlocal right) => left.Value != right.Value;

    public static bool operator <(Hlocal left, Hlocal right) => left.Value < right.Value;

    public static bool operator <=(Hlocal left, Hlocal right) => left.Value <= right.Value;

    public static bool operator >(Hlocal left, Hlocal right) => left.Value > right.Value;

    public static bool operator >=(Hlocal left, Hlocal right) => left.Value >= right.Value;

    public static explicit operator Hlocal(void* value) => new Hlocal(value);

    public static implicit operator void*(Hlocal value) => value.Value;

    public static explicit operator Hlocal(Handle value) => new Hlocal(value);

    public static implicit operator Handle(Hlocal value) => new Handle(value.Value);

    public static explicit operator Hlocal(byte value) => new Hlocal(unchecked((void*)(value)));

    public static explicit operator byte(Hlocal value) => (byte)(value.Value);

    public static explicit operator Hlocal(short value) => new Hlocal(unchecked((void*)(value)));

    public static explicit operator short(Hlocal value) => (short)(value.Value);

    public static explicit operator Hlocal(int value) => new Hlocal(unchecked((void*)(value)));

    public static explicit operator int(Hlocal value) => (int)(value.Value);

    public static explicit operator Hlocal(long value) => new Hlocal(unchecked((void*)(value)));

    public static explicit operator long(Hlocal value) => (long)(value.Value);

    public static explicit operator Hlocal(nint value) => new Hlocal(unchecked((void*)(value)));

    public static implicit operator nint(Hlocal value) => (nint)(value.Value);

    public static explicit operator Hlocal(sbyte value) => new Hlocal(unchecked((void*)(value)));

    public static explicit operator sbyte(Hlocal value) => (sbyte)(value.Value);

    public static explicit operator Hlocal(ushort value) => new Hlocal(unchecked((void*)(value)));

    public static explicit operator ushort(Hlocal value) => (ushort)(value.Value);

    public static explicit operator Hlocal(uint value) => new Hlocal(unchecked((void*)(value)));

    public static explicit operator uint(Hlocal value) => (uint)(value.Value);

    public static explicit operator Hlocal(ulong value) => new Hlocal(unchecked((void*)(value)));

    public static explicit operator ulong(Hlocal value) => (ulong)(value.Value);

    public static explicit operator Hlocal(nuint value) => new Hlocal(unchecked((void*)(value)));

    public static implicit operator nuint(Hlocal value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hlocal other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HLOCAL.");
    }

    public int CompareTo(Hlocal other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hlocal other) && Equals(other);

    public bool Equals(Hlocal other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
