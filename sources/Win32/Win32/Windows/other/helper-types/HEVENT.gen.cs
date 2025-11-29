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

public readonly unsafe partial struct Hevent
    : IComparable,
        IComparable<Hevent>,
        IEquatable<Hevent>,
        IFormattable
{
    public readonly void* Value;

    public Hevent(void* value)
    {
        Value = value;
    }

    public static Hevent INVALID_VALUE => new Hevent((void*)(-1));
    public static Hevent NULL => new Hevent(null);

    public static bool operator ==(Hevent left, Hevent right) => left.Value == right.Value;

    public static bool operator !=(Hevent left, Hevent right) => left.Value != right.Value;

    public static bool operator <(Hevent left, Hevent right) => left.Value < right.Value;

    public static bool operator <=(Hevent left, Hevent right) => left.Value <= right.Value;

    public static bool operator >(Hevent left, Hevent right) => left.Value > right.Value;

    public static bool operator >=(Hevent left, Hevent right) => left.Value >= right.Value;

    public static explicit operator Hevent(void* value) => new Hevent(value);

    public static implicit operator void*(Hevent value) => value.Value;

    public static explicit operator Hevent(Handle value) => new Hevent(value);

    public static implicit operator Handle(Hevent value) => new Handle(value.Value);

    public static explicit operator Hevent(byte value) => new Hevent(unchecked((void*)(value)));

    public static explicit operator byte(Hevent value) => (byte)(value.Value);

    public static explicit operator Hevent(short value) => new Hevent(unchecked((void*)(value)));

    public static explicit operator short(Hevent value) => (short)(value.Value);

    public static explicit operator Hevent(int value) => new Hevent(unchecked((void*)(value)));

    public static explicit operator int(Hevent value) => (int)(value.Value);

    public static explicit operator Hevent(long value) => new Hevent(unchecked((void*)(value)));

    public static explicit operator long(Hevent value) => (long)(value.Value);

    public static explicit operator Hevent(nint value) => new Hevent(unchecked((void*)(value)));

    public static implicit operator nint(Hevent value) => (nint)(value.Value);

    public static explicit operator Hevent(sbyte value) => new Hevent(unchecked((void*)(value)));

    public static explicit operator sbyte(Hevent value) => (sbyte)(value.Value);

    public static explicit operator Hevent(ushort value) => new Hevent(unchecked((void*)(value)));

    public static explicit operator ushort(Hevent value) => (ushort)(value.Value);

    public static explicit operator Hevent(uint value) => new Hevent(unchecked((void*)(value)));

    public static explicit operator uint(Hevent value) => (uint)(value.Value);

    public static explicit operator Hevent(ulong value) => new Hevent(unchecked((void*)(value)));

    public static explicit operator ulong(Hevent value) => (ulong)(value.Value);

    public static explicit operator Hevent(nuint value) => new Hevent(unchecked((void*)(value)));

    public static implicit operator nuint(Hevent value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hevent other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HEVENT.");
    }

    public int CompareTo(Hevent other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hevent other) && Equals(other);

    public bool Equals(Hevent other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
