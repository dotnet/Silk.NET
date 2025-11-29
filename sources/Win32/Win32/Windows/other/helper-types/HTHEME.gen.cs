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

public readonly unsafe partial struct Htheme
    : IComparable,
        IComparable<Htheme>,
        IEquatable<Htheme>,
        IFormattable
{
    public readonly void* Value;

    public Htheme(void* value)
    {
        Value = value;
    }

    public static Htheme INVALID_VALUE => new Htheme((void*)(-1));
    public static Htheme NULL => new Htheme(null);

    public static bool operator ==(Htheme left, Htheme right) => left.Value == right.Value;

    public static bool operator !=(Htheme left, Htheme right) => left.Value != right.Value;

    public static bool operator <(Htheme left, Htheme right) => left.Value < right.Value;

    public static bool operator <=(Htheme left, Htheme right) => left.Value <= right.Value;

    public static bool operator >(Htheme left, Htheme right) => left.Value > right.Value;

    public static bool operator >=(Htheme left, Htheme right) => left.Value >= right.Value;

    public static explicit operator Htheme(void* value) => new Htheme(value);

    public static implicit operator void*(Htheme value) => value.Value;

    public static explicit operator Htheme(Handle value) => new Htheme(value);

    public static implicit operator Handle(Htheme value) => new Handle(value.Value);

    public static explicit operator Htheme(byte value) => new Htheme(unchecked((void*)(value)));

    public static explicit operator byte(Htheme value) => (byte)(value.Value);

    public static explicit operator Htheme(short value) => new Htheme(unchecked((void*)(value)));

    public static explicit operator short(Htheme value) => (short)(value.Value);

    public static explicit operator Htheme(int value) => new Htheme(unchecked((void*)(value)));

    public static explicit operator int(Htheme value) => (int)(value.Value);

    public static explicit operator Htheme(long value) => new Htheme(unchecked((void*)(value)));

    public static explicit operator long(Htheme value) => (long)(value.Value);

    public static explicit operator Htheme(nint value) => new Htheme(unchecked((void*)(value)));

    public static implicit operator nint(Htheme value) => (nint)(value.Value);

    public static explicit operator Htheme(sbyte value) => new Htheme(unchecked((void*)(value)));

    public static explicit operator sbyte(Htheme value) => (sbyte)(value.Value);

    public static explicit operator Htheme(ushort value) => new Htheme(unchecked((void*)(value)));

    public static explicit operator ushort(Htheme value) => (ushort)(value.Value);

    public static explicit operator Htheme(uint value) => new Htheme(unchecked((void*)(value)));

    public static explicit operator uint(Htheme value) => (uint)(value.Value);

    public static explicit operator Htheme(ulong value) => new Htheme(unchecked((void*)(value)));

    public static explicit operator ulong(Htheme value) => (ulong)(value.Value);

    public static explicit operator Htheme(nuint value) => new Htheme(unchecked((void*)(value)));

    public static implicit operator nuint(Htheme value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Htheme other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HTHEME.");
    }

    public int CompareTo(Htheme other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Htheme other) && Equals(other);

    public bool Equals(Htheme other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
