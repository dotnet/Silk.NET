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

public readonly unsafe partial struct Hcertstore
    : IComparable,
        IComparable<Hcertstore>,
        IEquatable<Hcertstore>,
        IFormattable
{
    public readonly void* Value;

    public Hcertstore(void* value)
    {
        Value = value;
    }

    public static Hcertstore INVALID_VALUE => new Hcertstore((void*)(-1));
    public static Hcertstore NULL => new Hcertstore(null);

    public static bool operator ==(Hcertstore left, Hcertstore right) => left.Value == right.Value;

    public static bool operator !=(Hcertstore left, Hcertstore right) => left.Value != right.Value;

    public static bool operator <(Hcertstore left, Hcertstore right) => left.Value < right.Value;

    public static bool operator <=(Hcertstore left, Hcertstore right) => left.Value <= right.Value;

    public static bool operator >(Hcertstore left, Hcertstore right) => left.Value > right.Value;

    public static bool operator >=(Hcertstore left, Hcertstore right) => left.Value >= right.Value;

    public static explicit operator Hcertstore(void* value) => new Hcertstore(value);

    public static implicit operator void*(Hcertstore value) => value.Value;

    public static explicit operator Hcertstore(Handle value) => new Hcertstore(value);

    public static implicit operator Handle(Hcertstore value) => new Handle(value.Value);

    public static explicit operator Hcertstore(byte value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static explicit operator byte(Hcertstore value) => (byte)(value.Value);

    public static explicit operator Hcertstore(short value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static explicit operator short(Hcertstore value) => (short)(value.Value);

    public static explicit operator Hcertstore(int value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static explicit operator int(Hcertstore value) => (int)(value.Value);

    public static explicit operator Hcertstore(long value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static explicit operator long(Hcertstore value) => (long)(value.Value);

    public static explicit operator Hcertstore(nint value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static implicit operator nint(Hcertstore value) => (nint)(value.Value);

    public static explicit operator Hcertstore(sbyte value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcertstore value) => (sbyte)(value.Value);

    public static explicit operator Hcertstore(ushort value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static explicit operator ushort(Hcertstore value) => (ushort)(value.Value);

    public static explicit operator Hcertstore(uint value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static explicit operator uint(Hcertstore value) => (uint)(value.Value);

    public static explicit operator Hcertstore(ulong value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static explicit operator ulong(Hcertstore value) => (ulong)(value.Value);

    public static explicit operator Hcertstore(nuint value) =>
        new Hcertstore(unchecked((void*)(value)));

    public static implicit operator nuint(Hcertstore value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcertstore other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCERTSTORE.");
    }

    public int CompareTo(Hcertstore other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcertstore other) && Equals(other);

    public bool Equals(Hcertstore other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
