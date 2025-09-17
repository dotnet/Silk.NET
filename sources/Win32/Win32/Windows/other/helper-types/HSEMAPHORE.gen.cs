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

public readonly unsafe partial struct Hsemaphore
    : IComparable,
        IComparable<Hsemaphore>,
        IEquatable<Hsemaphore>,
        IFormattable
{
    public readonly void* Value;

    public Hsemaphore(void* value)
    {
        Value = value;
    }

    public static Hsemaphore INVALID_VALUE => new Hsemaphore((void*)(-1));
    public static Hsemaphore NULL => new Hsemaphore(null);

    public static bool operator ==(Hsemaphore left, Hsemaphore right) => left.Value == right.Value;

    public static bool operator !=(Hsemaphore left, Hsemaphore right) => left.Value != right.Value;

    public static bool operator <(Hsemaphore left, Hsemaphore right) => left.Value < right.Value;

    public static bool operator <=(Hsemaphore left, Hsemaphore right) => left.Value <= right.Value;

    public static bool operator >(Hsemaphore left, Hsemaphore right) => left.Value > right.Value;

    public static bool operator >=(Hsemaphore left, Hsemaphore right) => left.Value >= right.Value;

    public static explicit operator Hsemaphore(void* value) => new Hsemaphore(value);

    public static implicit operator void*(Hsemaphore value) => value.Value;

    public static explicit operator Hsemaphore(Handle value) => new Hsemaphore(value);

    public static implicit operator Handle(Hsemaphore value) => new Handle(value.Value);

    public static explicit operator Hsemaphore(byte value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static explicit operator byte(Hsemaphore value) => (byte)(value.Value);

    public static explicit operator Hsemaphore(short value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static explicit operator short(Hsemaphore value) => (short)(value.Value);

    public static explicit operator Hsemaphore(int value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static explicit operator int(Hsemaphore value) => (int)(value.Value);

    public static explicit operator Hsemaphore(long value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static explicit operator long(Hsemaphore value) => (long)(value.Value);

    public static explicit operator Hsemaphore(nint value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static implicit operator nint(Hsemaphore value) => (nint)(value.Value);

    public static explicit operator Hsemaphore(sbyte value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static explicit operator sbyte(Hsemaphore value) => (sbyte)(value.Value);

    public static explicit operator Hsemaphore(ushort value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static explicit operator ushort(Hsemaphore value) => (ushort)(value.Value);

    public static explicit operator Hsemaphore(uint value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static explicit operator uint(Hsemaphore value) => (uint)(value.Value);

    public static explicit operator Hsemaphore(ulong value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static explicit operator ulong(Hsemaphore value) => (ulong)(value.Value);

    public static explicit operator Hsemaphore(nuint value) =>
        new Hsemaphore(unchecked((void*)(value)));

    public static implicit operator nuint(Hsemaphore value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hsemaphore other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSEMAPHORE.");
    }

    public int CompareTo(Hsemaphore other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hsemaphore other) && Equals(other);

    public bool Equals(Hsemaphore other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
