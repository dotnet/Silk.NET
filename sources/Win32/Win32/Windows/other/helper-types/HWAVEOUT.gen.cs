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

public readonly unsafe partial struct Hwaveout
    : IComparable,
        IComparable<Hwaveout>,
        IEquatable<Hwaveout>,
        IFormattable
{
    public readonly void* Value;

    public Hwaveout(void* value)
    {
        Value = value;
    }

    public static Hwaveout INVALID_VALUE => new Hwaveout((void*)(-1));
    public static Hwaveout NULL => new Hwaveout(null);

    public static bool operator ==(Hwaveout left, Hwaveout right) => left.Value == right.Value;

    public static bool operator !=(Hwaveout left, Hwaveout right) => left.Value != right.Value;

    public static bool operator <(Hwaveout left, Hwaveout right) => left.Value < right.Value;

    public static bool operator <=(Hwaveout left, Hwaveout right) => left.Value <= right.Value;

    public static bool operator >(Hwaveout left, Hwaveout right) => left.Value > right.Value;

    public static bool operator >=(Hwaveout left, Hwaveout right) => left.Value >= right.Value;

    public static explicit operator Hwaveout(void* value) => new Hwaveout(value);

    public static implicit operator void*(Hwaveout value) => value.Value;

    public static explicit operator Hwaveout(Handle value) => new Hwaveout(value);

    public static implicit operator Handle(Hwaveout value) => new Handle(value.Value);

    public static explicit operator Hwaveout(byte value) => new Hwaveout(unchecked((void*)(value)));

    public static explicit operator byte(Hwaveout value) => (byte)(value.Value);

    public static explicit operator Hwaveout(short value) =>
        new Hwaveout(unchecked((void*)(value)));

    public static explicit operator short(Hwaveout value) => (short)(value.Value);

    public static explicit operator Hwaveout(int value) => new Hwaveout(unchecked((void*)(value)));

    public static explicit operator int(Hwaveout value) => (int)(value.Value);

    public static explicit operator Hwaveout(long value) => new Hwaveout(unchecked((void*)(value)));

    public static explicit operator long(Hwaveout value) => (long)(value.Value);

    public static explicit operator Hwaveout(nint value) => new Hwaveout(unchecked((void*)(value)));

    public static implicit operator nint(Hwaveout value) => (nint)(value.Value);

    public static explicit operator Hwaveout(sbyte value) =>
        new Hwaveout(unchecked((void*)(value)));

    public static explicit operator sbyte(Hwaveout value) => (sbyte)(value.Value);

    public static explicit operator Hwaveout(ushort value) =>
        new Hwaveout(unchecked((void*)(value)));

    public static explicit operator ushort(Hwaveout value) => (ushort)(value.Value);

    public static explicit operator Hwaveout(uint value) => new Hwaveout(unchecked((void*)(value)));

    public static explicit operator uint(Hwaveout value) => (uint)(value.Value);

    public static explicit operator Hwaveout(ulong value) =>
        new Hwaveout(unchecked((void*)(value)));

    public static explicit operator ulong(Hwaveout value) => (ulong)(value.Value);

    public static explicit operator Hwaveout(nuint value) =>
        new Hwaveout(unchecked((void*)(value)));

    public static implicit operator nuint(Hwaveout value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hwaveout other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HWAVEOUT.");
    }

    public int CompareTo(Hwaveout other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hwaveout other) && Equals(other);

    public bool Equals(Hwaveout other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
