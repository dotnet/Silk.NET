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

public readonly unsafe partial struct Pcuserializedpropstorage
    : IComparable,
        IComparable<Pcuserializedpropstorage>,
        IEquatable<Pcuserializedpropstorage>,
        IFormattable
{
    public readonly void* Value;

    public Pcuserializedpropstorage(void* value)
    {
        Value = value;
    }

    public static Pcuserializedpropstorage NULL => new Pcuserializedpropstorage(null);

    public static bool operator ==(Pcuserializedpropstorage left, Pcuserializedpropstorage right) =>
        left.Value == right.Value;

    public static bool operator !=(Pcuserializedpropstorage left, Pcuserializedpropstorage right) =>
        left.Value != right.Value;

    public static bool operator <(Pcuserializedpropstorage left, Pcuserializedpropstorage right) =>
        left.Value < right.Value;

    public static bool operator <=(Pcuserializedpropstorage left, Pcuserializedpropstorage right) =>
        left.Value <= right.Value;

    public static bool operator >(Pcuserializedpropstorage left, Pcuserializedpropstorage right) =>
        left.Value > right.Value;

    public static bool operator >=(Pcuserializedpropstorage left, Pcuserializedpropstorage right) =>
        left.Value >= right.Value;

    public static explicit operator Pcuserializedpropstorage(void* value) =>
        new Pcuserializedpropstorage(value);

    public static implicit operator void*(Pcuserializedpropstorage value) => value.Value;

    public static explicit operator Pcuserializedpropstorage(byte value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static explicit operator byte(Pcuserializedpropstorage value) => (byte)(value.Value);

    public static explicit operator Pcuserializedpropstorage(short value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static explicit operator short(Pcuserializedpropstorage value) => (short)(value.Value);

    public static explicit operator Pcuserializedpropstorage(int value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static explicit operator int(Pcuserializedpropstorage value) => (int)(value.Value);

    public static explicit operator Pcuserializedpropstorage(long value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static explicit operator long(Pcuserializedpropstorage value) => (long)(value.Value);

    public static explicit operator Pcuserializedpropstorage(nint value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static implicit operator nint(Pcuserializedpropstorage value) => (nint)(value.Value);

    public static explicit operator Pcuserializedpropstorage(sbyte value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static explicit operator sbyte(Pcuserializedpropstorage value) => (sbyte)(value.Value);

    public static explicit operator Pcuserializedpropstorage(ushort value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static explicit operator ushort(Pcuserializedpropstorage value) => (ushort)(value.Value);

    public static explicit operator Pcuserializedpropstorage(uint value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static explicit operator uint(Pcuserializedpropstorage value) => (uint)(value.Value);

    public static explicit operator Pcuserializedpropstorage(ulong value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static explicit operator ulong(Pcuserializedpropstorage value) => (ulong)(value.Value);

    public static explicit operator Pcuserializedpropstorage(nuint value) =>
        new Pcuserializedpropstorage(unchecked((void*)(value)));

    public static implicit operator nuint(Pcuserializedpropstorage value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Pcuserializedpropstorage other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PCUSERIALIZEDPROPSTORAGE.");
    }

    public int CompareTo(Pcuserializedpropstorage other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is Pcuserializedpropstorage other) && Equals(other);

    public bool Equals(Pcuserializedpropstorage other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
