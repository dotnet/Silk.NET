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

public readonly unsafe partial struct Hfont
    : IComparable,
        IComparable<Hfont>,
        IEquatable<Hfont>,
        IFormattable
{
    public readonly void* Value;

    public Hfont(void* value)
    {
        Value = value;
    }

    public static Hfont INVALID_VALUE => new Hfont((void*)(-1));
    public static Hfont NULL => new Hfont(null);

    public static bool operator ==(Hfont left, Hfont right) => left.Value == right.Value;

    public static bool operator !=(Hfont left, Hfont right) => left.Value != right.Value;

    public static bool operator <(Hfont left, Hfont right) => left.Value < right.Value;

    public static bool operator <=(Hfont left, Hfont right) => left.Value <= right.Value;

    public static bool operator >(Hfont left, Hfont right) => left.Value > right.Value;

    public static bool operator >=(Hfont left, Hfont right) => left.Value >= right.Value;

    public static explicit operator Hfont(void* value) => new Hfont(value);

    public static implicit operator void*(Hfont value) => value.Value;

    public static explicit operator Hfont(Handle value) => new Hfont(value);

    public static implicit operator Handle(Hfont value) => new Handle(value.Value);

    public static explicit operator Hfont(byte value) => new Hfont(unchecked((void*)(value)));

    public static explicit operator byte(Hfont value) => (byte)(value.Value);

    public static explicit operator Hfont(short value) => new Hfont(unchecked((void*)(value)));

    public static explicit operator short(Hfont value) => (short)(value.Value);

    public static explicit operator Hfont(int value) => new Hfont(unchecked((void*)(value)));

    public static explicit operator int(Hfont value) => (int)(value.Value);

    public static explicit operator Hfont(long value) => new Hfont(unchecked((void*)(value)));

    public static explicit operator long(Hfont value) => (long)(value.Value);

    public static explicit operator Hfont(nint value) => new Hfont(unchecked((void*)(value)));

    public static implicit operator nint(Hfont value) => (nint)(value.Value);

    public static explicit operator Hfont(sbyte value) => new Hfont(unchecked((void*)(value)));

    public static explicit operator sbyte(Hfont value) => (sbyte)(value.Value);

    public static explicit operator Hfont(ushort value) => new Hfont(unchecked((void*)(value)));

    public static explicit operator ushort(Hfont value) => (ushort)(value.Value);

    public static explicit operator Hfont(uint value) => new Hfont(unchecked((void*)(value)));

    public static explicit operator uint(Hfont value) => (uint)(value.Value);

    public static explicit operator Hfont(ulong value) => new Hfont(unchecked((void*)(value)));

    public static explicit operator ulong(Hfont value) => (ulong)(value.Value);

    public static explicit operator Hfont(nuint value) => new Hfont(unchecked((void*)(value)));

    public static implicit operator nuint(Hfont value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hfont other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HFONT.");
    }

    public int CompareTo(Hfont other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hfont other) && Equals(other);

    public bool Equals(Hfont other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
