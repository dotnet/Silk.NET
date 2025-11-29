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

public readonly unsafe partial struct Hdrop
    : IComparable,
        IComparable<Hdrop>,
        IEquatable<Hdrop>,
        IFormattable
{
    public readonly void* Value;

    public Hdrop(void* value)
    {
        Value = value;
    }

    public static Hdrop INVALID_VALUE => new Hdrop((void*)(-1));
    public static Hdrop NULL => new Hdrop(null);

    public static bool operator ==(Hdrop left, Hdrop right) => left.Value == right.Value;

    public static bool operator !=(Hdrop left, Hdrop right) => left.Value != right.Value;

    public static bool operator <(Hdrop left, Hdrop right) => left.Value < right.Value;

    public static bool operator <=(Hdrop left, Hdrop right) => left.Value <= right.Value;

    public static bool operator >(Hdrop left, Hdrop right) => left.Value > right.Value;

    public static bool operator >=(Hdrop left, Hdrop right) => left.Value >= right.Value;

    public static explicit operator Hdrop(void* value) => new Hdrop(value);

    public static implicit operator void*(Hdrop value) => value.Value;

    public static explicit operator Hdrop(Handle value) => new Hdrop(value);

    public static implicit operator Handle(Hdrop value) => new Handle(value.Value);

    public static explicit operator Hdrop(byte value) => new Hdrop(unchecked((void*)(value)));

    public static explicit operator byte(Hdrop value) => (byte)(value.Value);

    public static explicit operator Hdrop(short value) => new Hdrop(unchecked((void*)(value)));

    public static explicit operator short(Hdrop value) => (short)(value.Value);

    public static explicit operator Hdrop(int value) => new Hdrop(unchecked((void*)(value)));

    public static explicit operator int(Hdrop value) => (int)(value.Value);

    public static explicit operator Hdrop(long value) => new Hdrop(unchecked((void*)(value)));

    public static explicit operator long(Hdrop value) => (long)(value.Value);

    public static explicit operator Hdrop(nint value) => new Hdrop(unchecked((void*)(value)));

    public static implicit operator nint(Hdrop value) => (nint)(value.Value);

    public static explicit operator Hdrop(sbyte value) => new Hdrop(unchecked((void*)(value)));

    public static explicit operator sbyte(Hdrop value) => (sbyte)(value.Value);

    public static explicit operator Hdrop(ushort value) => new Hdrop(unchecked((void*)(value)));

    public static explicit operator ushort(Hdrop value) => (ushort)(value.Value);

    public static explicit operator Hdrop(uint value) => new Hdrop(unchecked((void*)(value)));

    public static explicit operator uint(Hdrop value) => (uint)(value.Value);

    public static explicit operator Hdrop(ulong value) => new Hdrop(unchecked((void*)(value)));

    public static explicit operator ulong(Hdrop value) => (ulong)(value.Value);

    public static explicit operator Hdrop(nuint value) => new Hdrop(unchecked((void*)(value)));

    public static implicit operator nuint(Hdrop value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hdrop other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDROP.");
    }

    public int CompareTo(Hdrop other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hdrop other) && Equals(other);

    public bool Equals(Hdrop other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
