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

public readonly unsafe partial struct Hpsxa
    : IComparable,
        IComparable<Hpsxa>,
        IEquatable<Hpsxa>,
        IFormattable
{
    public readonly void* Value;

    public Hpsxa(void* value)
    {
        Value = value;
    }

    public static Hpsxa INVALID_VALUE => new Hpsxa((void*)(-1));
    public static Hpsxa NULL => new Hpsxa(null);

    public static bool operator ==(Hpsxa left, Hpsxa right) => left.Value == right.Value;

    public static bool operator !=(Hpsxa left, Hpsxa right) => left.Value != right.Value;

    public static bool operator <(Hpsxa left, Hpsxa right) => left.Value < right.Value;

    public static bool operator <=(Hpsxa left, Hpsxa right) => left.Value <= right.Value;

    public static bool operator >(Hpsxa left, Hpsxa right) => left.Value > right.Value;

    public static bool operator >=(Hpsxa left, Hpsxa right) => left.Value >= right.Value;

    public static explicit operator Hpsxa(void* value) => new Hpsxa(value);

    public static implicit operator void*(Hpsxa value) => value.Value;

    public static explicit operator Hpsxa(Handle value) => new Hpsxa(value);

    public static implicit operator Handle(Hpsxa value) => new Handle(value.Value);

    public static explicit operator Hpsxa(byte value) => new Hpsxa(unchecked((void*)(value)));

    public static explicit operator byte(Hpsxa value) => (byte)(value.Value);

    public static explicit operator Hpsxa(short value) => new Hpsxa(unchecked((void*)(value)));

    public static explicit operator short(Hpsxa value) => (short)(value.Value);

    public static explicit operator Hpsxa(int value) => new Hpsxa(unchecked((void*)(value)));

    public static explicit operator int(Hpsxa value) => (int)(value.Value);

    public static explicit operator Hpsxa(long value) => new Hpsxa(unchecked((void*)(value)));

    public static explicit operator long(Hpsxa value) => (long)(value.Value);

    public static explicit operator Hpsxa(nint value) => new Hpsxa(unchecked((void*)(value)));

    public static implicit operator nint(Hpsxa value) => (nint)(value.Value);

    public static explicit operator Hpsxa(sbyte value) => new Hpsxa(unchecked((void*)(value)));

    public static explicit operator sbyte(Hpsxa value) => (sbyte)(value.Value);

    public static explicit operator Hpsxa(ushort value) => new Hpsxa(unchecked((void*)(value)));

    public static explicit operator ushort(Hpsxa value) => (ushort)(value.Value);

    public static explicit operator Hpsxa(uint value) => new Hpsxa(unchecked((void*)(value)));

    public static explicit operator uint(Hpsxa value) => (uint)(value.Value);

    public static explicit operator Hpsxa(ulong value) => new Hpsxa(unchecked((void*)(value)));

    public static explicit operator ulong(Hpsxa value) => (ulong)(value.Value);

    public static explicit operator Hpsxa(nuint value) => new Hpsxa(unchecked((void*)(value)));

    public static implicit operator nuint(Hpsxa value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hpsxa other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPSXA.");
    }

    public int CompareTo(Hpsxa other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hpsxa other) && Equals(other);

    public bool Equals(Hpsxa other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
