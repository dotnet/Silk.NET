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

public readonly unsafe partial struct Hicon
    : IComparable,
        IComparable<Hicon>,
        IEquatable<Hicon>,
        IFormattable
{
    public readonly void* Value;

    public Hicon(void* value)
    {
        Value = value;
    }

    public static Hicon INVALID_VALUE => new Hicon((void*)(-1));
    public static Hicon NULL => new Hicon(null);

    public static bool operator ==(Hicon left, Hicon right) => left.Value == right.Value;

    public static bool operator !=(Hicon left, Hicon right) => left.Value != right.Value;

    public static bool operator <(Hicon left, Hicon right) => left.Value < right.Value;

    public static bool operator <=(Hicon left, Hicon right) => left.Value <= right.Value;

    public static bool operator >(Hicon left, Hicon right) => left.Value > right.Value;

    public static bool operator >=(Hicon left, Hicon right) => left.Value >= right.Value;

    public static explicit operator Hicon(void* value) => new Hicon(value);

    public static implicit operator void*(Hicon value) => value.Value;

    public static explicit operator Hicon(Handle value) => new Hicon(value);

    public static implicit operator Handle(Hicon value) => new Handle(value.Value);

    public static explicit operator Hicon(byte value) => new Hicon(unchecked((void*)(value)));

    public static explicit operator byte(Hicon value) => (byte)(value.Value);

    public static explicit operator Hicon(short value) => new Hicon(unchecked((void*)(value)));

    public static explicit operator short(Hicon value) => (short)(value.Value);

    public static explicit operator Hicon(int value) => new Hicon(unchecked((void*)(value)));

    public static explicit operator int(Hicon value) => (int)(value.Value);

    public static explicit operator Hicon(long value) => new Hicon(unchecked((void*)(value)));

    public static explicit operator long(Hicon value) => (long)(value.Value);

    public static explicit operator Hicon(nint value) => new Hicon(unchecked((void*)(value)));

    public static implicit operator nint(Hicon value) => (nint)(value.Value);

    public static explicit operator Hicon(sbyte value) => new Hicon(unchecked((void*)(value)));

    public static explicit operator sbyte(Hicon value) => (sbyte)(value.Value);

    public static explicit operator Hicon(ushort value) => new Hicon(unchecked((void*)(value)));

    public static explicit operator ushort(Hicon value) => (ushort)(value.Value);

    public static explicit operator Hicon(uint value) => new Hicon(unchecked((void*)(value)));

    public static explicit operator uint(Hicon value) => (uint)(value.Value);

    public static explicit operator Hicon(ulong value) => new Hicon(unchecked((void*)(value)));

    public static explicit operator ulong(Hicon value) => (ulong)(value.Value);

    public static explicit operator Hicon(nuint value) => new Hicon(unchecked((void*)(value)));

    public static implicit operator nuint(Hicon value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hicon other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HICON.");
    }

    public int CompareTo(Hicon other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hicon other) && Equals(other);

    public bool Equals(Hicon other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
