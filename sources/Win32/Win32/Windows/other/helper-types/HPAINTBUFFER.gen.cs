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

public readonly unsafe partial struct Hpaintbuffer
    : IComparable,
        IComparable<Hpaintbuffer>,
        IEquatable<Hpaintbuffer>,
        IFormattable
{
    public readonly void* Value;

    public Hpaintbuffer(void* value)
    {
        Value = value;
    }

    public static Hpaintbuffer INVALID_VALUE => new Hpaintbuffer((void*)(-1));
    public static Hpaintbuffer NULL => new Hpaintbuffer(null);

    public static bool operator ==(Hpaintbuffer left, Hpaintbuffer right) =>
        left.Value == right.Value;

    public static bool operator !=(Hpaintbuffer left, Hpaintbuffer right) =>
        left.Value != right.Value;

    public static bool operator <(Hpaintbuffer left, Hpaintbuffer right) =>
        left.Value < right.Value;

    public static bool operator <=(Hpaintbuffer left, Hpaintbuffer right) =>
        left.Value <= right.Value;

    public static bool operator >(Hpaintbuffer left, Hpaintbuffer right) =>
        left.Value > right.Value;

    public static bool operator >=(Hpaintbuffer left, Hpaintbuffer right) =>
        left.Value >= right.Value;

    public static explicit operator Hpaintbuffer(void* value) => new Hpaintbuffer(value);

    public static implicit operator void*(Hpaintbuffer value) => value.Value;

    public static explicit operator Hpaintbuffer(Handle value) => new Hpaintbuffer(value);

    public static implicit operator Handle(Hpaintbuffer value) => new Handle(value.Value);

    public static explicit operator Hpaintbuffer(byte value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static explicit operator byte(Hpaintbuffer value) => (byte)(value.Value);

    public static explicit operator Hpaintbuffer(short value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static explicit operator short(Hpaintbuffer value) => (short)(value.Value);

    public static explicit operator Hpaintbuffer(int value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static explicit operator int(Hpaintbuffer value) => (int)(value.Value);

    public static explicit operator Hpaintbuffer(long value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static explicit operator long(Hpaintbuffer value) => (long)(value.Value);

    public static explicit operator Hpaintbuffer(nint value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static implicit operator nint(Hpaintbuffer value) => (nint)(value.Value);

    public static explicit operator Hpaintbuffer(sbyte value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static explicit operator sbyte(Hpaintbuffer value) => (sbyte)(value.Value);

    public static explicit operator Hpaintbuffer(ushort value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static explicit operator ushort(Hpaintbuffer value) => (ushort)(value.Value);

    public static explicit operator Hpaintbuffer(uint value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static explicit operator uint(Hpaintbuffer value) => (uint)(value.Value);

    public static explicit operator Hpaintbuffer(ulong value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static explicit operator ulong(Hpaintbuffer value) => (ulong)(value.Value);

    public static explicit operator Hpaintbuffer(nuint value) =>
        new Hpaintbuffer(unchecked((void*)(value)));

    public static implicit operator nuint(Hpaintbuffer value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hpaintbuffer other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPAINTBUFFER.");
    }

    public int CompareTo(Hpaintbuffer other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hpaintbuffer other) && Equals(other);

    public bool Equals(Hpaintbuffer other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
