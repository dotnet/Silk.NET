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

public readonly unsafe partial struct Spstatehandle
    : IComparable,
        IComparable<Spstatehandle>,
        IEquatable<Spstatehandle>,
        IFormattable
{
    public readonly void* Value;

    public Spstatehandle(void* value)
    {
        Value = value;
    }

    public static Spstatehandle INVALID_VALUE => new Spstatehandle((void*)(-1));
    public static Spstatehandle NULL => new Spstatehandle(null);

    public static bool operator ==(Spstatehandle left, Spstatehandle right) =>
        left.Value == right.Value;

    public static bool operator !=(Spstatehandle left, Spstatehandle right) =>
        left.Value != right.Value;

    public static bool operator <(Spstatehandle left, Spstatehandle right) =>
        left.Value < right.Value;

    public static bool operator <=(Spstatehandle left, Spstatehandle right) =>
        left.Value <= right.Value;

    public static bool operator >(Spstatehandle left, Spstatehandle right) =>
        left.Value > right.Value;

    public static bool operator >=(Spstatehandle left, Spstatehandle right) =>
        left.Value >= right.Value;

    public static explicit operator Spstatehandle(void* value) => new Spstatehandle(value);

    public static implicit operator void*(Spstatehandle value) => value.Value;

    public static explicit operator Spstatehandle(Handle value) => new Spstatehandle(value);

    public static implicit operator Handle(Spstatehandle value) => new Handle(value.Value);

    public static explicit operator Spstatehandle(byte value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static explicit operator byte(Spstatehandle value) => (byte)(value.Value);

    public static explicit operator Spstatehandle(short value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static explicit operator short(Spstatehandle value) => (short)(value.Value);

    public static explicit operator Spstatehandle(int value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static explicit operator int(Spstatehandle value) => (int)(value.Value);

    public static explicit operator Spstatehandle(long value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static explicit operator long(Spstatehandle value) => (long)(value.Value);

    public static explicit operator Spstatehandle(nint value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static implicit operator nint(Spstatehandle value) => (nint)(value.Value);

    public static explicit operator Spstatehandle(sbyte value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static explicit operator sbyte(Spstatehandle value) => (sbyte)(value.Value);

    public static explicit operator Spstatehandle(ushort value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static explicit operator ushort(Spstatehandle value) => (ushort)(value.Value);

    public static explicit operator Spstatehandle(uint value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static explicit operator uint(Spstatehandle value) => (uint)(value.Value);

    public static explicit operator Spstatehandle(ulong value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static explicit operator ulong(Spstatehandle value) => (ulong)(value.Value);

    public static explicit operator Spstatehandle(nuint value) =>
        new Spstatehandle(unchecked((void*)(value)));

    public static implicit operator nuint(Spstatehandle value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Spstatehandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of SPSTATEHANDLE.");
    }

    public int CompareTo(Spstatehandle other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Spstatehandle other) && Equals(other);

    public bool Equals(Spstatehandle other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
