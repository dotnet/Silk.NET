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

public readonly unsafe partial struct Hbitmap
    : IComparable,
        IComparable<Hbitmap>,
        IEquatable<Hbitmap>,
        IFormattable
{
    public readonly void* Value;

    public Hbitmap(void* value)
    {
        Value = value;
    }

    public static Hbitmap INVALID_VALUE => new Hbitmap((void*)(-1));
    public static Hbitmap NULL => new Hbitmap(null);

    public static bool operator ==(Hbitmap left, Hbitmap right) => left.Value == right.Value;

    public static bool operator !=(Hbitmap left, Hbitmap right) => left.Value != right.Value;

    public static bool operator <(Hbitmap left, Hbitmap right) => left.Value < right.Value;

    public static bool operator <=(Hbitmap left, Hbitmap right) => left.Value <= right.Value;

    public static bool operator >(Hbitmap left, Hbitmap right) => left.Value > right.Value;

    public static bool operator >=(Hbitmap left, Hbitmap right) => left.Value >= right.Value;

    public static explicit operator Hbitmap(void* value) => new Hbitmap(value);

    public static implicit operator void*(Hbitmap value) => value.Value;

    public static explicit operator Hbitmap(Handle value) => new Hbitmap(value);

    public static implicit operator Handle(Hbitmap value) => new Handle(value.Value);

    public static explicit operator Hbitmap(byte value) => new Hbitmap(unchecked((void*)(value)));

    public static explicit operator byte(Hbitmap value) => (byte)(value.Value);

    public static explicit operator Hbitmap(short value) => new Hbitmap(unchecked((void*)(value)));

    public static explicit operator short(Hbitmap value) => (short)(value.Value);

    public static explicit operator Hbitmap(int value) => new Hbitmap(unchecked((void*)(value)));

    public static explicit operator int(Hbitmap value) => (int)(value.Value);

    public static explicit operator Hbitmap(long value) => new Hbitmap(unchecked((void*)(value)));

    public static explicit operator long(Hbitmap value) => (long)(value.Value);

    public static explicit operator Hbitmap(nint value) => new Hbitmap(unchecked((void*)(value)));

    public static implicit operator nint(Hbitmap value) => (nint)(value.Value);

    public static explicit operator Hbitmap(sbyte value) => new Hbitmap(unchecked((void*)(value)));

    public static explicit operator sbyte(Hbitmap value) => (sbyte)(value.Value);

    public static explicit operator Hbitmap(ushort value) => new Hbitmap(unchecked((void*)(value)));

    public static explicit operator ushort(Hbitmap value) => (ushort)(value.Value);

    public static explicit operator Hbitmap(uint value) => new Hbitmap(unchecked((void*)(value)));

    public static explicit operator uint(Hbitmap value) => (uint)(value.Value);

    public static explicit operator Hbitmap(ulong value) => new Hbitmap(unchecked((void*)(value)));

    public static explicit operator ulong(Hbitmap value) => (ulong)(value.Value);

    public static explicit operator Hbitmap(nuint value) => new Hbitmap(unchecked((void*)(value)));

    public static implicit operator nuint(Hbitmap value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hbitmap other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HBITMAP.");
    }

    public int CompareTo(Hbitmap other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hbitmap other) && Equals(other);

    public bool Equals(Hbitmap other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
