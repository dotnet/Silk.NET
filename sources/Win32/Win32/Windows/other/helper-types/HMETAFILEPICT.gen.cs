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

public readonly unsafe partial struct Hmetafilepict
    : IComparable,
        IComparable<Hmetafilepict>,
        IEquatable<Hmetafilepict>,
        IFormattable
{
    public readonly void* Value;

    public Hmetafilepict(void* value)
    {
        Value = value;
    }

    public static Hmetafilepict INVALID_VALUE => new Hmetafilepict((void*)(-1));
    public static Hmetafilepict NULL => new Hmetafilepict(null);

    public static bool operator ==(Hmetafilepict left, Hmetafilepict right) =>
        left.Value == right.Value;

    public static bool operator !=(Hmetafilepict left, Hmetafilepict right) =>
        left.Value != right.Value;

    public static bool operator <(Hmetafilepict left, Hmetafilepict right) =>
        left.Value < right.Value;

    public static bool operator <=(Hmetafilepict left, Hmetafilepict right) =>
        left.Value <= right.Value;

    public static bool operator >(Hmetafilepict left, Hmetafilepict right) =>
        left.Value > right.Value;

    public static bool operator >=(Hmetafilepict left, Hmetafilepict right) =>
        left.Value >= right.Value;

    public static explicit operator Hmetafilepict(void* value) => new Hmetafilepict(value);

    public static implicit operator void*(Hmetafilepict value) => value.Value;

    public static explicit operator Hmetafilepict(Handle value) => new Hmetafilepict(value);

    public static implicit operator Handle(Hmetafilepict value) => new Handle(value.Value);

    public static explicit operator Hmetafilepict(byte value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static explicit operator byte(Hmetafilepict value) => (byte)(value.Value);

    public static explicit operator Hmetafilepict(short value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static explicit operator short(Hmetafilepict value) => (short)(value.Value);

    public static explicit operator Hmetafilepict(int value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static explicit operator int(Hmetafilepict value) => (int)(value.Value);

    public static explicit operator Hmetafilepict(long value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static explicit operator long(Hmetafilepict value) => (long)(value.Value);

    public static explicit operator Hmetafilepict(nint value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static implicit operator nint(Hmetafilepict value) => (nint)(value.Value);

    public static explicit operator Hmetafilepict(sbyte value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmetafilepict value) => (sbyte)(value.Value);

    public static explicit operator Hmetafilepict(ushort value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static explicit operator ushort(Hmetafilepict value) => (ushort)(value.Value);

    public static explicit operator Hmetafilepict(uint value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static explicit operator uint(Hmetafilepict value) => (uint)(value.Value);

    public static explicit operator Hmetafilepict(ulong value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static explicit operator ulong(Hmetafilepict value) => (ulong)(value.Value);

    public static explicit operator Hmetafilepict(nuint value) =>
        new Hmetafilepict(unchecked((void*)(value)));

    public static implicit operator nuint(Hmetafilepict value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmetafilepict other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMETAFILEPICT.");
    }

    public int CompareTo(Hmetafilepict other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmetafilepict other) && Equals(other);

    public bool Equals(Hmetafilepict other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
