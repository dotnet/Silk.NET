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

public readonly unsafe partial struct Hmidiout
    : IComparable,
        IComparable<Hmidiout>,
        IEquatable<Hmidiout>,
        IFormattable
{
    public readonly void* Value;

    public Hmidiout(void* value)
    {
        Value = value;
    }

    public static Hmidiout INVALID_VALUE => new Hmidiout((void*)(-1));
    public static Hmidiout NULL => new Hmidiout(null);

    public static bool operator ==(Hmidiout left, Hmidiout right) => left.Value == right.Value;

    public static bool operator !=(Hmidiout left, Hmidiout right) => left.Value != right.Value;

    public static bool operator <(Hmidiout left, Hmidiout right) => left.Value < right.Value;

    public static bool operator <=(Hmidiout left, Hmidiout right) => left.Value <= right.Value;

    public static bool operator >(Hmidiout left, Hmidiout right) => left.Value > right.Value;

    public static bool operator >=(Hmidiout left, Hmidiout right) => left.Value >= right.Value;

    public static explicit operator Hmidiout(void* value) => new Hmidiout(value);

    public static implicit operator void*(Hmidiout value) => value.Value;

    public static explicit operator Hmidiout(Handle value) => new Hmidiout(value);

    public static implicit operator Handle(Hmidiout value) => new Handle(value.Value);

    public static explicit operator Hmidiout(byte value) => new Hmidiout(unchecked((void*)(value)));

    public static explicit operator byte(Hmidiout value) => (byte)(value.Value);

    public static explicit operator Hmidiout(short value) =>
        new Hmidiout(unchecked((void*)(value)));

    public static explicit operator short(Hmidiout value) => (short)(value.Value);

    public static explicit operator Hmidiout(int value) => new Hmidiout(unchecked((void*)(value)));

    public static explicit operator int(Hmidiout value) => (int)(value.Value);

    public static explicit operator Hmidiout(long value) => new Hmidiout(unchecked((void*)(value)));

    public static explicit operator long(Hmidiout value) => (long)(value.Value);

    public static explicit operator Hmidiout(nint value) => new Hmidiout(unchecked((void*)(value)));

    public static implicit operator nint(Hmidiout value) => (nint)(value.Value);

    public static explicit operator Hmidiout(sbyte value) =>
        new Hmidiout(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmidiout value) => (sbyte)(value.Value);

    public static explicit operator Hmidiout(ushort value) =>
        new Hmidiout(unchecked((void*)(value)));

    public static explicit operator ushort(Hmidiout value) => (ushort)(value.Value);

    public static explicit operator Hmidiout(uint value) => new Hmidiout(unchecked((void*)(value)));

    public static explicit operator uint(Hmidiout value) => (uint)(value.Value);

    public static explicit operator Hmidiout(ulong value) =>
        new Hmidiout(unchecked((void*)(value)));

    public static explicit operator ulong(Hmidiout value) => (ulong)(value.Value);

    public static explicit operator Hmidiout(nuint value) =>
        new Hmidiout(unchecked((void*)(value)));

    public static implicit operator nuint(Hmidiout value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmidiout other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMIDIOUT.");
    }

    public int CompareTo(Hmidiout other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmidiout other) && Equals(other);

    public bool Equals(Hmidiout other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
