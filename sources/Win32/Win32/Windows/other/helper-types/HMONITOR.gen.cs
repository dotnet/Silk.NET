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
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct Hmonitor
    : IComparable,
        IComparable<Hmonitor>,
        IEquatable<Hmonitor>,
        IFormattable
{
    public readonly void* Value;

    public Hmonitor(void* value)
    {
        Value = value;
    }

    public static Hmonitor INVALID_VALUE => new Hmonitor((void*)(-1));
    public static Hmonitor NULL => new Hmonitor(null);

    public static bool operator ==(Hmonitor left, Hmonitor right) => left.Value == right.Value;

    public static bool operator !=(Hmonitor left, Hmonitor right) => left.Value != right.Value;

    public static bool operator <(Hmonitor left, Hmonitor right) => left.Value < right.Value;

    public static bool operator <=(Hmonitor left, Hmonitor right) => left.Value <= right.Value;

    public static bool operator >(Hmonitor left, Hmonitor right) => left.Value > right.Value;

    public static bool operator >=(Hmonitor left, Hmonitor right) => left.Value >= right.Value;

    public static explicit operator Hmonitor(void* value) => new Hmonitor(value);

    public static implicit operator void*(Hmonitor value) => value.Value;

    public static explicit operator Hmonitor(Handle value) => new Hmonitor(value);

    public static implicit operator Handle(Hmonitor value) => new Handle(value.Value);

    public static explicit operator Hmonitor(byte value) => new Hmonitor(unchecked((void*)(value)));

    public static explicit operator byte(Hmonitor value) => (byte)(value.Value);

    public static explicit operator Hmonitor(short value) =>
        new Hmonitor(unchecked((void*)(value)));

    public static explicit operator short(Hmonitor value) => (short)(value.Value);

    public static explicit operator Hmonitor(int value) => new Hmonitor(unchecked((void*)(value)));

    public static explicit operator int(Hmonitor value) => (int)(value.Value);

    public static explicit operator Hmonitor(long value) => new Hmonitor(unchecked((void*)(value)));

    public static explicit operator long(Hmonitor value) => (long)(value.Value);

    public static explicit operator Hmonitor(nint value) => new Hmonitor(unchecked((void*)(value)));

    public static implicit operator nint(Hmonitor value) => (nint)(value.Value);

    public static explicit operator Hmonitor(sbyte value) =>
        new Hmonitor(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmonitor value) => (sbyte)(value.Value);

    public static explicit operator Hmonitor(ushort value) =>
        new Hmonitor(unchecked((void*)(value)));

    public static explicit operator ushort(Hmonitor value) => (ushort)(value.Value);

    public static explicit operator Hmonitor(uint value) => new Hmonitor(unchecked((void*)(value)));

    public static explicit operator uint(Hmonitor value) => (uint)(value.Value);

    public static explicit operator Hmonitor(ulong value) =>
        new Hmonitor(unchecked((void*)(value)));

    public static explicit operator ulong(Hmonitor value) => (ulong)(value.Value);

    public static explicit operator Hmonitor(nuint value) =>
        new Hmonitor(unchecked((void*)(value)));

    public static implicit operator nuint(Hmonitor value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmonitor other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMONITOR.");
    }

    public int CompareTo(Hmonitor other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmonitor other) && Equals(other);

    public bool Equals(Hmonitor other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
