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

public readonly unsafe partial struct Hmixerobj
    : IComparable,
        IComparable<Hmixerobj>,
        IEquatable<Hmixerobj>,
        IFormattable
{
    public readonly void* Value;

    public Hmixerobj(void* value)
    {
        Value = value;
    }

    public static Hmixerobj INVALID_VALUE => new Hmixerobj((void*)(-1));
    public static Hmixerobj NULL => new Hmixerobj(null);

    public static bool operator ==(Hmixerobj left, Hmixerobj right) => left.Value == right.Value;

    public static bool operator !=(Hmixerobj left, Hmixerobj right) => left.Value != right.Value;

    public static bool operator <(Hmixerobj left, Hmixerobj right) => left.Value < right.Value;

    public static bool operator <=(Hmixerobj left, Hmixerobj right) => left.Value <= right.Value;

    public static bool operator >(Hmixerobj left, Hmixerobj right) => left.Value > right.Value;

    public static bool operator >=(Hmixerobj left, Hmixerobj right) => left.Value >= right.Value;

    public static explicit operator Hmixerobj(void* value) => new Hmixerobj(value);

    public static implicit operator void*(Hmixerobj value) => value.Value;

    public static explicit operator Hmixerobj(Handle value) => new Hmixerobj(value);

    public static implicit operator Handle(Hmixerobj value) => new Handle(value.Value);

    public static explicit operator Hmixerobj(byte value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static explicit operator byte(Hmixerobj value) => (byte)(value.Value);

    public static explicit operator Hmixerobj(short value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static explicit operator short(Hmixerobj value) => (short)(value.Value);

    public static explicit operator Hmixerobj(int value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static explicit operator int(Hmixerobj value) => (int)(value.Value);

    public static explicit operator Hmixerobj(long value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static explicit operator long(Hmixerobj value) => (long)(value.Value);

    public static explicit operator Hmixerobj(nint value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static implicit operator nint(Hmixerobj value) => (nint)(value.Value);

    public static explicit operator Hmixerobj(sbyte value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static explicit operator sbyte(Hmixerobj value) => (sbyte)(value.Value);

    public static explicit operator Hmixerobj(ushort value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static explicit operator ushort(Hmixerobj value) => (ushort)(value.Value);

    public static explicit operator Hmixerobj(uint value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static explicit operator uint(Hmixerobj value) => (uint)(value.Value);

    public static explicit operator Hmixerobj(ulong value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static explicit operator ulong(Hmixerobj value) => (ulong)(value.Value);

    public static explicit operator Hmixerobj(nuint value) =>
        new Hmixerobj(unchecked((void*)(value)));

    public static implicit operator nuint(Hmixerobj value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hmixerobj other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMIXEROBJ.");
    }

    public int CompareTo(Hmixerobj other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hmixerobj other) && Equals(other);

    public bool Equals(Hmixerobj other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
