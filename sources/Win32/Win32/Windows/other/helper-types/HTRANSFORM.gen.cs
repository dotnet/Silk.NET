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

public readonly unsafe partial struct Htransform
    : IComparable,
        IComparable<Htransform>,
        IEquatable<Htransform>,
        IFormattable
{
    public readonly void* Value;

    public Htransform(void* value)
    {
        Value = value;
    }

    public static Htransform INVALID_VALUE => new Htransform((void*)(-1));
    public static Htransform NULL => new Htransform(null);

    public static bool operator ==(Htransform left, Htransform right) => left.Value == right.Value;

    public static bool operator !=(Htransform left, Htransform right) => left.Value != right.Value;

    public static bool operator <(Htransform left, Htransform right) => left.Value < right.Value;

    public static bool operator <=(Htransform left, Htransform right) => left.Value <= right.Value;

    public static bool operator >(Htransform left, Htransform right) => left.Value > right.Value;

    public static bool operator >=(Htransform left, Htransform right) => left.Value >= right.Value;

    public static explicit operator Htransform(void* value) => new Htransform(value);

    public static implicit operator void*(Htransform value) => value.Value;

    public static explicit operator Htransform(Handle value) => new Htransform(value);

    public static implicit operator Handle(Htransform value) => new Handle(value.Value);

    public static explicit operator Htransform(byte value) =>
        new Htransform(unchecked((void*)(value)));

    public static explicit operator byte(Htransform value) => (byte)(value.Value);

    public static explicit operator Htransform(short value) =>
        new Htransform(unchecked((void*)(value)));

    public static explicit operator short(Htransform value) => (short)(value.Value);

    public static explicit operator Htransform(int value) =>
        new Htransform(unchecked((void*)(value)));

    public static explicit operator int(Htransform value) => (int)(value.Value);

    public static explicit operator Htransform(long value) =>
        new Htransform(unchecked((void*)(value)));

    public static explicit operator long(Htransform value) => (long)(value.Value);

    public static explicit operator Htransform(nint value) =>
        new Htransform(unchecked((void*)(value)));

    public static implicit operator nint(Htransform value) => (nint)(value.Value);

    public static explicit operator Htransform(sbyte value) =>
        new Htransform(unchecked((void*)(value)));

    public static explicit operator sbyte(Htransform value) => (sbyte)(value.Value);

    public static explicit operator Htransform(ushort value) =>
        new Htransform(unchecked((void*)(value)));

    public static explicit operator ushort(Htransform value) => (ushort)(value.Value);

    public static explicit operator Htransform(uint value) =>
        new Htransform(unchecked((void*)(value)));

    public static explicit operator uint(Htransform value) => (uint)(value.Value);

    public static explicit operator Htransform(ulong value) =>
        new Htransform(unchecked((void*)(value)));

    public static explicit operator ulong(Htransform value) => (ulong)(value.Value);

    public static explicit operator Htransform(nuint value) =>
        new Htransform(unchecked((void*)(value)));

    public static implicit operator nuint(Htransform value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Htransform other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HTRANSFORM.");
    }

    public int CompareTo(Htransform other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Htransform other) && Equals(other);

    public bool Equals(Htransform other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
