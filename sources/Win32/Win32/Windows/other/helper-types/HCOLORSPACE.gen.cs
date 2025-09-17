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

public readonly unsafe partial struct Hcolorspace
    : IComparable,
        IComparable<Hcolorspace>,
        IEquatable<Hcolorspace>,
        IFormattable
{
    public readonly void* Value;

    public Hcolorspace(void* value)
    {
        Value = value;
    }

    public static Hcolorspace INVALID_VALUE => new Hcolorspace((void*)(-1));
    public static Hcolorspace NULL => new Hcolorspace(null);

    public static bool operator ==(Hcolorspace left, Hcolorspace right) =>
        left.Value == right.Value;

    public static bool operator !=(Hcolorspace left, Hcolorspace right) =>
        left.Value != right.Value;

    public static bool operator <(Hcolorspace left, Hcolorspace right) => left.Value < right.Value;

    public static bool operator <=(Hcolorspace left, Hcolorspace right) =>
        left.Value <= right.Value;

    public static bool operator >(Hcolorspace left, Hcolorspace right) => left.Value > right.Value;

    public static bool operator >=(Hcolorspace left, Hcolorspace right) =>
        left.Value >= right.Value;

    public static explicit operator Hcolorspace(void* value) => new Hcolorspace(value);

    public static implicit operator void*(Hcolorspace value) => value.Value;

    public static explicit operator Hcolorspace(Handle value) => new Hcolorspace(value);

    public static implicit operator Handle(Hcolorspace value) => new Handle(value.Value);

    public static explicit operator Hcolorspace(byte value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static explicit operator byte(Hcolorspace value) => (byte)(value.Value);

    public static explicit operator Hcolorspace(short value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static explicit operator short(Hcolorspace value) => (short)(value.Value);

    public static explicit operator Hcolorspace(int value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static explicit operator int(Hcolorspace value) => (int)(value.Value);

    public static explicit operator Hcolorspace(long value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static explicit operator long(Hcolorspace value) => (long)(value.Value);

    public static explicit operator Hcolorspace(nint value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static implicit operator nint(Hcolorspace value) => (nint)(value.Value);

    public static explicit operator Hcolorspace(sbyte value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcolorspace value) => (sbyte)(value.Value);

    public static explicit operator Hcolorspace(ushort value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static explicit operator ushort(Hcolorspace value) => (ushort)(value.Value);

    public static explicit operator Hcolorspace(uint value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static explicit operator uint(Hcolorspace value) => (uint)(value.Value);

    public static explicit operator Hcolorspace(ulong value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static explicit operator ulong(Hcolorspace value) => (ulong)(value.Value);

    public static explicit operator Hcolorspace(nuint value) =>
        new Hcolorspace(unchecked((void*)(value)));

    public static implicit operator nuint(Hcolorspace value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcolorspace other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCOLORSPACE.");
    }

    public int CompareTo(Hcolorspace other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcolorspace other) && Equals(other);

    public bool Equals(Hcolorspace other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
