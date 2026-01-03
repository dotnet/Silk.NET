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

public readonly unsafe partial struct Hcursor
    : IComparable,
        IComparable<Hcursor>,
        IEquatable<Hcursor>,
        IFormattable
{
    public readonly void* Value;

    public Hcursor(void* value)
    {
        Value = value;
    }

    public static Hcursor INVALID_VALUE => new Hcursor((void*)(-1));
    public static Hcursor NULL => new Hcursor(null);

    public static bool operator ==(Hcursor left, Hcursor right) => left.Value == right.Value;

    public static bool operator !=(Hcursor left, Hcursor right) => left.Value != right.Value;

    public static bool operator <(Hcursor left, Hcursor right) => left.Value < right.Value;

    public static bool operator <=(Hcursor left, Hcursor right) => left.Value <= right.Value;

    public static bool operator >(Hcursor left, Hcursor right) => left.Value > right.Value;

    public static bool operator >=(Hcursor left, Hcursor right) => left.Value >= right.Value;

    public static explicit operator Hcursor(void* value) => new Hcursor(value);

    public static implicit operator void*(Hcursor value) => value.Value;

    public static explicit operator Hcursor(Handle value) => new Hcursor(value);

    public static implicit operator Handle(Hcursor value) => new Handle(value.Value);

    public static explicit operator Hcursor(byte value) => new Hcursor(unchecked((void*)(value)));

    public static explicit operator byte(Hcursor value) => (byte)(value.Value);

    public static explicit operator Hcursor(short value) => new Hcursor(unchecked((void*)(value)));

    public static explicit operator short(Hcursor value) => (short)(value.Value);

    public static explicit operator Hcursor(int value) => new Hcursor(unchecked((void*)(value)));

    public static explicit operator int(Hcursor value) => (int)(value.Value);

    public static explicit operator Hcursor(long value) => new Hcursor(unchecked((void*)(value)));

    public static explicit operator long(Hcursor value) => (long)(value.Value);

    public static explicit operator Hcursor(nint value) => new Hcursor(unchecked((void*)(value)));

    public static implicit operator nint(Hcursor value) => (nint)(value.Value);

    public static explicit operator Hcursor(sbyte value) => new Hcursor(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcursor value) => (sbyte)(value.Value);

    public static explicit operator Hcursor(ushort value) => new Hcursor(unchecked((void*)(value)));

    public static explicit operator ushort(Hcursor value) => (ushort)(value.Value);

    public static explicit operator Hcursor(uint value) => new Hcursor(unchecked((void*)(value)));

    public static explicit operator uint(Hcursor value) => (uint)(value.Value);

    public static explicit operator Hcursor(ulong value) => new Hcursor(unchecked((void*)(value)));

    public static explicit operator ulong(Hcursor value) => (ulong)(value.Value);

    public static explicit operator Hcursor(nuint value) => new Hcursor(unchecked((void*)(value)));

    public static implicit operator nuint(Hcursor value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcursor other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCURSOR.");
    }

    public int CompareTo(Hcursor other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcursor other) && Equals(other);

    public bool Equals(Hcursor other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
