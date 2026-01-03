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

public readonly unsafe partial struct Hhandle
    : IComparable,
        IComparable<Hhandle>,
        IEquatable<Hhandle>,
        IFormattable
{
    public readonly void* Value;

    public Hhandle(void* value)
    {
        Value = value;
    }

    public static Hhandle INVALID_VALUE => new Hhandle((void*)(-1));
    public static Hhandle NULL => new Hhandle(null);

    public static bool operator ==(Hhandle left, Hhandle right) => left.Value == right.Value;

    public static bool operator !=(Hhandle left, Hhandle right) => left.Value != right.Value;

    public static bool operator <(Hhandle left, Hhandle right) => left.Value < right.Value;

    public static bool operator <=(Hhandle left, Hhandle right) => left.Value <= right.Value;

    public static bool operator >(Hhandle left, Hhandle right) => left.Value > right.Value;

    public static bool operator >=(Hhandle left, Hhandle right) => left.Value >= right.Value;

    public static explicit operator Hhandle(void* value) => new Hhandle(value);

    public static implicit operator void*(Hhandle value) => value.Value;

    public static explicit operator Hhandle(Handle value) => new Hhandle(value);

    public static implicit operator Handle(Hhandle value) => new Handle(value.Value);

    public static explicit operator Hhandle(byte value) => new Hhandle(unchecked((void*)(value)));

    public static explicit operator byte(Hhandle value) => (byte)(value.Value);

    public static explicit operator Hhandle(short value) => new Hhandle(unchecked((void*)(value)));

    public static explicit operator short(Hhandle value) => (short)(value.Value);

    public static explicit operator Hhandle(int value) => new Hhandle(unchecked((void*)(value)));

    public static explicit operator int(Hhandle value) => (int)(value.Value);

    public static explicit operator Hhandle(long value) => new Hhandle(unchecked((void*)(value)));

    public static explicit operator long(Hhandle value) => (long)(value.Value);

    public static explicit operator Hhandle(nint value) => new Hhandle(unchecked((void*)(value)));

    public static implicit operator nint(Hhandle value) => (nint)(value.Value);

    public static explicit operator Hhandle(sbyte value) => new Hhandle(unchecked((void*)(value)));

    public static explicit operator sbyte(Hhandle value) => (sbyte)(value.Value);

    public static explicit operator Hhandle(ushort value) => new Hhandle(unchecked((void*)(value)));

    public static explicit operator ushort(Hhandle value) => (ushort)(value.Value);

    public static explicit operator Hhandle(uint value) => new Hhandle(unchecked((void*)(value)));

    public static explicit operator uint(Hhandle value) => (uint)(value.Value);

    public static explicit operator Hhandle(ulong value) => new Hhandle(unchecked((void*)(value)));

    public static explicit operator ulong(Hhandle value) => (ulong)(value.Value);

    public static explicit operator Hhandle(nuint value) => new Hhandle(unchecked((void*)(value)));

    public static implicit operator nuint(Hhandle value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hhandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HHANDLE.");
    }

    public int CompareTo(Hhandle other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hhandle other) && Equals(other);

    public bool Equals(Hhandle other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
