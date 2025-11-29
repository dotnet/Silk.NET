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

public readonly unsafe partial struct Hcryptkey
    : IComparable,
        IComparable<Hcryptkey>,
        IEquatable<Hcryptkey>,
        IFormattable
{
    public readonly void* Value;

    public Hcryptkey(void* value)
    {
        Value = value;
    }

    public static Hcryptkey INVALID_VALUE => new Hcryptkey((void*)(-1));
    public static Hcryptkey NULL => new Hcryptkey(null);

    public static bool operator ==(Hcryptkey left, Hcryptkey right) => left.Value == right.Value;

    public static bool operator !=(Hcryptkey left, Hcryptkey right) => left.Value != right.Value;

    public static bool operator <(Hcryptkey left, Hcryptkey right) => left.Value < right.Value;

    public static bool operator <=(Hcryptkey left, Hcryptkey right) => left.Value <= right.Value;

    public static bool operator >(Hcryptkey left, Hcryptkey right) => left.Value > right.Value;

    public static bool operator >=(Hcryptkey left, Hcryptkey right) => left.Value >= right.Value;

    public static explicit operator Hcryptkey(void* value) => new Hcryptkey(value);

    public static implicit operator void*(Hcryptkey value) => value.Value;

    public static explicit operator Hcryptkey(Handle value) => new Hcryptkey(value);

    public static implicit operator Handle(Hcryptkey value) => new Handle(value.Value);

    public static explicit operator Hcryptkey(byte value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static explicit operator byte(Hcryptkey value) => (byte)(value.Value);

    public static explicit operator Hcryptkey(short value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static explicit operator short(Hcryptkey value) => (short)(value.Value);

    public static explicit operator Hcryptkey(int value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static explicit operator int(Hcryptkey value) => (int)(value.Value);

    public static explicit operator Hcryptkey(long value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static explicit operator long(Hcryptkey value) => (long)(value.Value);

    public static explicit operator Hcryptkey(nint value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static implicit operator nint(Hcryptkey value) => (nint)(value.Value);

    public static explicit operator Hcryptkey(sbyte value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcryptkey value) => (sbyte)(value.Value);

    public static explicit operator Hcryptkey(ushort value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static explicit operator ushort(Hcryptkey value) => (ushort)(value.Value);

    public static explicit operator Hcryptkey(uint value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static explicit operator uint(Hcryptkey value) => (uint)(value.Value);

    public static explicit operator Hcryptkey(ulong value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static explicit operator ulong(Hcryptkey value) => (ulong)(value.Value);

    public static explicit operator Hcryptkey(nuint value) =>
        new Hcryptkey(unchecked((void*)(value)));

    public static implicit operator nuint(Hcryptkey value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcryptkey other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTKEY.");
    }

    public int CompareTo(Hcryptkey other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcryptkey other) && Equals(other);

    public bool Equals(Hcryptkey other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
